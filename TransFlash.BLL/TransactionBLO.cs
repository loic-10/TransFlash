using TransFlash.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransFlash.BO;
using static TransFlash.BO.Statut;
using TransFlash.Ressources.Properties;

namespace TransFlash.BLL
{
    public class TransactionBLO
    {
        private IDAL<Transaction> transactionBLO = null;

        public TransactionBLO()
        {
            transactionBLO = new RepositoireDAOFile<Transaction>();
        }

        public void InitierTransaction(TypeCompte typeCompte, TypeTransaction typeTransaction, Epargne epargne, CompteClient compteClientEmetteur, 
            CompteClient compteClientDestinataire, Employe employe, double montant, int nombreJourAttente)
        {
            transactionBLO.Add(new Transaction(CodeTransaction(typeTransaction), typeCompte, typeTransaction, epargne, DateTime.Now, compteClientEmetteur, 
                                                                    compteClientDestinataire, employe, new Employe("/"), 
                                                                    montant, StatutTransaction.En_cours_de_validité, nombreJourAttente));

            if (typeTransaction == TypeTransaction.Dépot)
                new OperationBLO().AjouterOperation(TypeOperation.Dépot, employe, compteClientEmetteur.Client, compteClientEmetteur, montant,
                    $"Nouveau depot initie ({CodeTransaction(typeTransaction)})");

            else if (typeTransaction == TypeTransaction.Retrait)
                new OperationBLO().AjouterOperation(TypeOperation.Retrait, employe, compteClientEmetteur.Client, compteClientEmetteur, montant,
                    $"Nouveau retrait initie ({CodeTransaction(typeTransaction)})");

            else
                new OperationBLO().AjouterOperation(TypeOperation.Transfert_inter_compte, employe, compteClientEmetteur.Client, compteClientEmetteur, montant,
                    $"Nouvelle transaction initie ({CodeTransaction(typeTransaction)})");

            new IdentifiantBLO().AddIdTransaction();
        }

        public void ValiderTransactionCompteCourant(Transaction transaction, Employe employe)
        {

            int index = transactionBLO.IndexOf(transaction);

            transaction.StatutTransaction = StatutTransaction.Validé;
            transaction.EmployeValideur = employe;
            transactionBLO[index] = transaction;

            if (transaction.TypeTransaction == TypeTransaction.Dépot)
            {
                new CompteClientBLO().CrediterCompteClient(transaction.CompteClientEmetteur, transaction.Montant, employe);
                new OperationBLO().AjouterOperation(TypeOperation.Dépot, employe, transaction.CompteClientEmetteur.Client, transaction.CompteClientEmetteur, 
                    transaction.Montant, $"Validation du depot ({transaction.CodeTransaction})");
            }
            else if (transaction.TypeTransaction == TypeTransaction.Retrait)
            {
                new CompteClientBLO().DebiterCompteClient(transaction.CompteClientEmetteur, transaction.Montant, employe, true, true);
                new OperationBLO().AjouterOperation(TypeOperation.Retrait, employe, transaction.CompteClientEmetteur.Client, transaction.CompteClientEmetteur, 
                    transaction.Montant, $"Validation du retrait ({transaction.CodeTransaction})");
            }
            else
            {
                new CompteClientBLO().CrediterUnAutreCompte(transaction.CompteClientEmetteur, transaction.CompteClientDestinataire, transaction.Montant, employe, false, true);
                new OperationBLO().AjouterOperation(TypeOperation.Transfert_inter_compte, employe, transaction.CompteClientEmetteur.Client, 
                    transaction.CompteClientEmetteur, transaction.Montant, $"Validation de la transaction inter-compte ({transaction.CodeTransaction})");
            }

            if (transaction.CompteClientEmetteur.StatutCompte == StatutCompte.En_attente_de_validité)
                new CompteClientBLO().ActiverCompteClient(transaction.CompteClientEmetteur,
                    new ParametreGeneralBLO().TousParametreGenerals[0].MontantDeCreationCompte, employe);
        }

        public void ValiderTransactionCompteEpargne(Transaction transaction, Employe employe)
        {
            Transaction oldTransaction = transaction;

            int index = transactionBLO.IndexOf(transaction);

            transaction.StatutTransaction = StatutTransaction.Validé;
            transaction.EmployeValideur = employe;
            transactionBLO[index] = transaction;

            if (transaction.TypeTransaction == TypeTransaction.Dépot)
            {
                new CompteClientBLO().CrediterCompteClient(transaction.CompteClientEmetteur, transaction.Montant, employe);
                new EpargneBLO().AugmenterMontantEpargner(transaction.Epargne, transaction.Montant, employe);
            }

            else if (transaction.TypeTransaction == TypeTransaction.Retrait && (oldTransaction.StatutTransaction == StatutTransaction.Avisé ||
                oldTransaction.StatutTransaction == StatutTransaction.En_cours_de_validité) && VerifierSiAvis(transaction))
            {
                new CompteClientBLO().DebiterCompteClient(transaction.CompteClientEmetteur, transaction.Montant, employe, false, false);
                new EpargneBLO().ReduireMontantEpargner(transaction.Epargne, transaction.Montant, employe);
            }

            else if (transaction.TypeTransaction == TypeTransaction.Retrait && (oldTransaction.StatutTransaction == StatutTransaction.Avisé ||
                oldTransaction.StatutTransaction == StatutTransaction.En_cours_de_validité) && !VerifierSiAvis(transaction))
            {
                double montant = transaction.Montant + FraisPourSansAvis(transaction);
                new CompteClientBLO().DebiterCompteClient(transaction.CompteClientEmetteur, montant, employe, false, false);
                new EpargneBLO().ReduireMontantEpargner(transaction.Epargne, montant, employe);
            }

            else
            {
                new CompteClientBLO().CrediterUnAutreCompte(transaction.CompteClientEmetteur, transaction.CompteClientDestinataire, 
                    transaction.Montant, employe, false, true);
            }

            if (transaction.CompteClientEmetteur.StatutCompte == StatutCompte.En_attente_de_validité)
                new CompteClientBLO().ActiverCompteClient(transaction.CompteClientEmetteur,
                    new ParametreGeneralBLO().TousParametreGenerals[0].MontantDeCreationCompte, employe);
        }

        public double FraisPourSansAvis(Transaction transaction) => (new ParametreGeneralBLO().TousParametreGenerals[0].PourcentageRetraitEpargneSansAvis * transaction.Montant) / 100;

        public void AviserTransaction(Transaction transaction, Employe employe)
        {
            int index = transactionBLO.IndexOf(transaction);

            transaction.StatutTransaction = StatutTransaction.Avisé;
            transaction.EmployeValideur = employe;
            transactionBLO[index] = transaction;
            new OperationBLO().AjouterOperation(TypeOperation.Avis_de_retrait, employe, transaction.CompteClientEmetteur.Client, transaction.CompteClientEmetteur,
                transaction.Montant, $"Avisement de la transaction ({transaction.CodeTransaction})");
        }

        public bool VerifierSiAvis(Transaction transaction) => (DateTime.Compare(transaction.DateTransaction.AddDays(transaction.NombreJourAttente),
            DateTime.Now) <= 0);

        public void AnnulerTransaction(Transaction transaction, Employe employe)
        {

            int index = transactionBLO.IndexOf(transaction);

            transaction.StatutTransaction = StatutTransaction.Annulé;
            transaction.EmployeValideur = employe;
            transactionBLO[index] = transaction;
            new OperationBLO().AjouterOperation(TypeOperation.Annulation, employe, transaction.CompteClientEmetteur.Client, transaction.CompteClientEmetteur,
                transaction.Montant, $"Annulation de la transaction ({transaction.CodeTransaction})");
        }

        public void SupprimerTransaction(Transaction transaction, Employe employe)
        {

            transactionBLO.Remove(transaction);
            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employe, transaction.CompteClientEmetteur.Client, transaction.CompteClientEmetteur, 
                transaction.Montant, $"Suppression de la transaction ({transaction.CodeTransaction})");
        }

        public string CodeTransaction(TypeTransaction typeTransaction) => 
            ((typeTransaction == TypeTransaction.Transfert_inter_compte) ? "tra-" : (typeTransaction == TypeTransaction.Dépot) ? "dep-" : "ret-" ) +
            new IdentifiantBLO().IdTransaction.ToString().PadLeft(8, '0');

        public Transaction RechercherUneTransaction(string codeTransaction) => transactionBLO.Find(x =>
            x.CodeTransaction == codeTransaction).FirstOrDefault();

        public IEnumerable<Transaction> RechercherTransactionsCompte(CompteClient compteClient) => transactionBLO.Find(x =>
            x.CompteClientEmetteur == compteClient);

        public IEnumerable<Transaction> RechercherDepotSurCompte(CompteClient compteClient) => transactionBLO.Find(x =>
            x.CompteClientEmetteur == compteClient &&
            x.TypeTransaction == TypeTransaction.Dépot &&
            x.StatutTransaction == StatutTransaction.En_cours_de_validité);

        public IEnumerable<Transaction> RechercherLesTransactions(string valeur, bool checkCode, bool checkTypeCompte, 
            bool checkCompteEmetteur, bool checkTypeTransaction, bool checkEpargne, bool checkDateTransaction, 
            bool checkEmployeEmetteur, bool checkEmployeValideur, bool checkCompteDestinataire, bool checkMontant, 
            bool checkStatutTransaction, bool checkNombreJour) =>  transactionBLO.Find(x => 
            (x.CodeTransaction.ToString().ToLower().Contains(valeur.ToLower()) && checkCode) ||
            (x.TypeCompte.ToString().ToLower().Contains(valeur.ToLower()) && checkTypeCompte) ||
            (x.CompteClientEmetteur.ToString().ToLower().Contains(valeur.ToLower()) && checkCompteEmetteur) ||
            (x.TypeTransaction.ToString().ToLower().Contains(valeur.ToLower()) && checkTypeTransaction) ||
            (x.Epargne.ToString().ToLower().Contains(valeur.ToLower()) && checkEpargne) ||
            (x.DateTransaction.ToString().ToLower().Contains(valeur.ToLower()) && checkDateTransaction) ||
            (x.EmployeEmetteur.ToString().ToLower().Contains(valeur.ToLower()) && checkEmployeEmetteur) ||
            (x.EmployeValideur.ToString().ToLower().Contains(valeur.ToLower()) && checkEmployeValideur) ||
            (x.CompteClientDestinataire.ToString().ToLower().Contains(valeur.ToLower()) && checkCompteDestinataire) ||
            (x.Montant.ToString().ToLower().Contains(valeur.ToLower()) && checkMontant) ||
            (x.StatutTransaction.ToString().ToLower().Contains(valeur.ToLower()) && checkStatutTransaction) ||
            (x.NombreJourAttente.ToString().ToLower().Contains(valeur.ToLower()) && checkNombreJour));

        public List<Transaction> ToutesTransactions => transactionBLO.AllItems;

    }
}
