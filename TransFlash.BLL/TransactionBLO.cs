using Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransFlash.BO;
using static TransFlash.BO.Statut;

namespace TransFlash.BLL
{
    public class TransactionBLO
    {
        private IDAL<Transaction> transactionBLO = null;

        private CompteClientBLO compteClientBLO = null;

        private FondBLO fondBLO = null;

        private OperationBLO operationBLO = null;

        private ParametreGeneralBLO parametreGeneralBLO = null;

        private EpargneBLO epargneBLO = new EpargneBLO();

        public TransactionBLO()
        {
            transactionBLO = new RepositoireDAOFile<Transaction>();
        }

        public void InitierTransaction(TypeCompte typeCompte, TypeTransaction typeTransaction, Epargne epargne, CompteClient compteClientEmetteur, 
            CompteClient compteClientDestinataire, Employe employe, double montant, int nombreJourAttente)
        {
            operationBLO = new OperationBLO();
            transactionBLO.Add(new Transaction(CodeTransaction(typeTransaction), typeCompte, typeTransaction, epargne, DateTime.Now, compteClientEmetteur, 
                                                                    compteClientDestinataire, employe, new Employe("Indefini"), 
                                                                    montant, StatutTransaction.En_cours_de_validité, nombreJourAttente));

            if (typeTransaction == TypeTransaction.Dépot)
                operationBLO.AjouterOperation(TypeOperation.Dépot, employe, compteClientEmetteur.Client, compteClientEmetteur, montant, "toto tata");

            else if (typeTransaction == TypeTransaction.Retrait)
                operationBLO.AjouterOperation(TypeOperation.Retrait, employe, compteClientEmetteur.Client, compteClientEmetteur, montant, "toto tata");

            else
                operationBLO.AjouterOperation(TypeOperation.Transfert_inter_compte, employe, compteClientEmetteur.Client, compteClientEmetteur, montant, "toto tata");

            new IdentifiantBLO().AddIdTransaction();
        }

        public void ValiderTransactionCompteCourant(Transaction transaction, Employe employe)
        {
            operationBLO = new OperationBLO();
            compteClientBLO = new CompteClientBLO();
            fondBLO = new FondBLO();
            Transaction oldTransaction = transaction;
            transaction.StatutTransaction = StatutTransaction.Validé;
            transaction.EmployeValideur = employe;
            transactionBLO[transactionBLO.IndexOf(oldTransaction)] = transaction;

            if (transaction.TypeTransaction == TypeTransaction.Dépot)
            {
                compteClientBLO.CrediterCompteClient(transaction.CompteClientEmetteur, transaction.Montant, employe);
                fondBLO.MettreArgentEnFond(employe, transaction.CompteClientDestinataire, transaction.Montant, "toto tata");
                operationBLO.AjouterOperation(TypeOperation.Dépot, employe, transaction.CompteClientEmetteur.Client, transaction.CompteClientEmetteur, 
                    transaction.Montant, "toto tata");
            }
            else if (transaction.TypeTransaction == TypeTransaction.Retrait)
            {
                compteClientBLO.DebiterCompteClient(transaction.CompteClientEmetteur, transaction.Montant, employe);
                fondBLO.SortirArgentEnFond(employe, transaction.CompteClientDestinataire, transaction.Montant, "toto tata");
                operationBLO.AjouterOperation(TypeOperation.Retrait, employe, transaction.CompteClientEmetteur.Client, transaction.CompteClientEmetteur, 
                    transaction.Montant, "toto tata");
            }
            else
            {
                compteClientBLO.CrediterUnAutreCompte(transaction.CompteClientEmetteur, transaction.CompteClientDestinataire, transaction.Montant, employe);
                operationBLO.AjouterOperation(TypeOperation.Transfert_inter_compte, employe, transaction.CompteClientEmetteur.Client, 
                    transaction.CompteClientEmetteur, transaction.Montant, "toto tata");
            }
        }

        public void ValiderTransactionCompteEpargne(Transaction transaction, Employe employe)
        {
            parametreGeneralBLO = new ParametreGeneralBLO();
            operationBLO = new OperationBLO();
            compteClientBLO = new CompteClientBLO();
            fondBLO = new FondBLO();
            epargneBLO = new EpargneBLO();
            Transaction oldTransaction = transaction;
            transaction.StatutTransaction = StatutTransaction.Validé;
            transaction.EmployeValideur = employe;
            transactionBLO[transactionBLO.IndexOf(oldTransaction)] = transaction;

            if (transaction.TypeTransaction == TypeTransaction.Dépot)
            {
                compteClientBLO.CrediterCompteClient(transaction.CompteClientEmetteur, transaction.Montant, employe);
                fondBLO.MettreArgentEnFond(employe, transaction.CompteClientDestinataire, transaction.Montant, "toto tata");
                operationBLO.AjouterOperation(TypeOperation.Dépot, employe, transaction.CompteClientEmetteur.Client, transaction.CompteClientEmetteur, 
                    transaction.Montant, "toto tata");
                epargneBLO.AugmenterMontantEpargner(transaction.Epargne, transaction.Montant, employe);
            }

            else if (transaction.TypeTransaction == TypeTransaction.Retrait && oldTransaction.StatutTransaction == StatutTransaction.Avisé && 
                (DateTime.Compare(oldTransaction.DateTransaction.AddDays(oldTransaction.NombreJourAttente), DateTime.Now)) >= 0)
            {
                compteClientBLO.DebiterCompteClient(transaction.CompteClientEmetteur, transaction.Montant, employe);
                fondBLO.SortirArgentEnFond(employe, transaction.CompteClientDestinataire, transaction.Montant, "toto tata");
                operationBLO.AjouterOperation(TypeOperation.Retrait, employe, transaction.CompteClientEmetteur.Client, transaction.CompteClientEmetteur, 
                    transaction.Montant, "toto tata");
                epargneBLO.ReduireMontantEpargner(transaction.Epargne, transaction.Montant, employe);
            }

            else if (transaction.TypeTransaction == TypeTransaction.Retrait && !VerifierSiAvis(transaction))
            {
                double montant = (transaction.Montant + ((parametreGeneralBLO.TousParametreGenerals[0].PourcentageRetraitEpargneSansAvis * transaction.Montant) / 100));
                compteClientBLO.DebiterCompteClient(transaction.CompteClientEmetteur, montant, employe);
                fondBLO.SortirArgentEnFond(employe, transaction.CompteClientDestinataire, transaction.Montant, "toto tata");
                operationBLO.AjouterOperation(TypeOperation.Retrait, employe, transaction.CompteClientEmetteur.Client, transaction.CompteClientEmetteur,
                    montant, "toto tata");
                epargneBLO.ReduireMontantEpargner(transaction.Epargne, montant, employe);
            }
        }

        public void AviserTransaction(Transaction transaction, Employe employe)
        {
            operationBLO = new OperationBLO();
            Transaction oldTransaction = transaction;
            transaction.StatutTransaction = StatutTransaction.Avisé;
            transaction.EmployeValideur = employe;
            transactionBLO[transactionBLO.IndexOf(oldTransaction)] = transaction;
            operationBLO.AjouterOperation(TypeOperation.Avis_de_retrait, employe, transaction.CompteClientEmetteur.Client, transaction.CompteClientEmetteur,
                transaction.Montant, "toto tata");
        }

        public bool VerifierSiAvis(Transaction transaction) => (transaction.NombreJourAttente > 0);

        public void AnnulerTransaction(Transaction transaction, Employe employe)
        {
            operationBLO = new OperationBLO();
            Transaction oldTransaction = transaction;
            transaction.StatutTransaction = StatutTransaction.Annulé;
            transaction.EmployeValideur = employe;
            transactionBLO[transactionBLO.IndexOf(oldTransaction)] = transaction;
            operationBLO.AjouterOperation(TypeOperation.Annulation, employe, transaction.CompteClientEmetteur.Client, transaction.CompteClientEmetteur,
                transaction.Montant, "toto tata");
        }

        public void SupprimerTransaction(Transaction transaction, Employe employe)
        {
            operationBLO = new OperationBLO();
            transactionBLO.Remove(transaction);
            operationBLO.AjouterOperation(TypeOperation.Annulation, employe, transaction.CompteClientEmetteur.Client, transaction.CompteClientEmetteur, 
                transaction.Montant, "toto tata");
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

        public IEnumerable<Transaction> RechercherLesTransactions(string valeur) =>  transactionBLO.Find(x => 
            x.CompteClientEmetteur.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.CompteClientDestinataire.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.CodeTransaction.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.DateTransaction.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.Montant.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.StatutTransaction.ToString().ToLower().Contains(valeur.ToLower()));

        public List<Transaction> ToutesTransactions => transactionBLO.AllItems;

    }
}
