using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO.ClassesReport
{
    [Serializable]
    public class Transaction
    {
        public string CodeTransaction { get; set; }
        public string TypeCompte { get; set; }
        public string TypeTransaction { get; set; }
        public string Epargne { get; set; }
        public DateTime DateTransaction { get; set; }
        public string EmployeEmetteur { get; set; }
        public string EmployeValideur { get; set; }
        public string CompteClientEmetteur { get; set; }
        public string CompteClientDestinataire { get; set; }
        public double Montant { get; set; }
        public string StatutTransaction { get; set; }
        public int NombreJourAttente { get; set; }

        public Transaction()
        {
        }

        public Transaction(string codeTransaction)
        {
            CodeTransaction = codeTransaction;
        }

        public Transaction(string codeTransaction, string typeCompte, string typeTransaction, string epargne, 
            DateTime dateTransaction, string compteClientEmetteur, string compteClientDestinataire, string employeEmetteur,
            string employeValideur, double montant, string statutTransaction, int nombreJourAttente) : this(codeTransaction)
        {
            TypeCompte = typeCompte;
            TypeTransaction = typeTransaction;
            Epargne = epargne;
            DateTransaction = dateTransaction;
            CompteClientEmetteur = compteClientEmetteur;
            CompteClientDestinataire = compteClientDestinataire;
            EmployeEmetteur = employeEmetteur;
            EmployeValideur = employeValideur;
            Montant = montant;
            StatutTransaction = statutTransaction;
            NombreJourAttente = nombreJourAttente;
        }

        public override bool Equals(object obj)
        {
            return obj is Transaction transaction &&
                   CodeTransaction == transaction.CodeTransaction;
        }

        public override int GetHashCode()
        {
            return CodeTransaction.GetHashCode();
        }

        public override string ToString()
        {
            return CodeTransaction;
        }
    }

}
