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

        public TransactionBLO()
        {
            transactionBLO = new RepositoireDAOFile<Transaction>();
        }

        public void InitierTransaction(string codeTransaction, TypeCompte typeCompte, TypeTransaction typeTransaction, Epargne epargne,
                                                    CompteClient compteClientEmetteur, CompteClient compteClientDestinataire, double montant,
                                                    int nombreJourAttente)
        {
            transactionBLO.Add(new Transaction(codeTransaction, typeCompte, typeTransaction, epargne, DateTime.Now, compteClientEmetteur, 
                                                                    compteClientDestinataire, montant, StatutTransaction.En_cours_de_validité, nombreJourAttente));
        }

        public void ValiderTransaction(Transaction transaction, Employe employe)
        {
            compteClientBLO = new CompteClientBLO();
            fondBLO = new FondBLO();
            Transaction oldTransaction = transaction;
            transaction.StatutTransaction = StatutTransaction.Validé;
            transactionBLO[transactionBLO.IndexOf(oldTransaction)] = transaction;

            if (transaction.TypeTransaction == TypeTransaction.Dépot)
            {
                compteClientBLO.CrediterCompteClient(transaction.CompteClientEmetteur, transaction.Montant);
                fondBLO.MettreArgentEnFond(1, employe, TypeActionFond.Entrée, transaction.Montant, "toto tata");
            }

            else if (transaction.TypeTransaction == TypeTransaction.Retrait)
            {
                compteClientBLO.DebiterCompteClient(transaction.CompteClientEmetteur, transaction.Montant);
                fondBLO.SortirArgentEnFond(1, employe, TypeActionFond.Entrée, transaction.Montant, "toto tata");
            }
            else
                compteClientBLO.CrediterUnAutreCompte(transaction.CompteClientEmetteur, transaction.CompteClientDestinataire, transaction.Montant);

            
        }

        public void AviserTransaction(Transaction Transaction)
        {
            Transaction oldTransaction = Transaction;
            Transaction.StatutTransaction = StatutTransaction.Avisé;
            transactionBLO[transactionBLO.IndexOf(oldTransaction)] = Transaction;
        }

        public void AnnulerTransaction(Transaction Transaction)
        {
            Transaction oldTransaction = Transaction;
            Transaction.StatutTransaction = StatutTransaction.Annulé;
            transactionBLO[transactionBLO.IndexOf(oldTransaction)] = Transaction;
        }

        public void SupprimerTransaction(Transaction Transaction)
        {
            transactionBLO.Remove(Transaction);
        }

        public IEnumerable<Transaction> RechercherTransactionsCompte(CompteClient compteClient) => transactionBLO.Find(x =>
                x.CompteClientEmetteur == compteClient);

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
