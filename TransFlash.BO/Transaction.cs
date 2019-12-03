using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO
{
    [Serializable]
    public class Transaction
    {
        public string CodeTransaction { get; set; }
        public TypeCompte TypeCompte { get; set; }
        public TypeTransaction TypeTransaction { get; set; }
        public Epargne Epargne { get; set; }
        public DateTime DateTransaction { get; set; }
        public CompteClient CompteClientEmetteur { get; set; }
        public CompteClient CompteClientDestinataire { get; set; }
        public double Montant { get; set; }
        public StatutTransaction StatutTransaction { get; set; }
        public int NombreJourAttente { get; set; }

        public Transaction()
        {
        }

        public Transaction(string codeTransaction)
        {
            CodeTransaction = codeTransaction;
        }

        public Transaction(string codeTransaction, TypeCompte typeCompte, TypeTransaction typeTransaction, Epargne epargne, 
            DateTime dateTransaction, CompteClient compteClientEmetteur, CompteClient compteClientDestinataire, double montant, 
            StatutTransaction statutTransaction, int nombreJourAttente) : this(codeTransaction)
        {
            TypeCompte = typeCompte;
            TypeTransaction = typeTransaction;
            Epargne = epargne;
            DateTransaction = dateTransaction;
            CompteClientEmetteur = compteClientEmetteur;
            CompteClientDestinataire = compteClientDestinataire;
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
