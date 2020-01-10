using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO.ClassesReport
{
    [Serializable]
    public class Remboursement
    {
        public string CodeRemboursement { get; set; }
        public string Credit { get; set; }
        public DateTime DateRemboursement { get; set; }
        public double Montant { get; set; }
        public string StatutRemboursement { get; set; }

        public Remboursement()
        {
        }

        public Remboursement(string codeRemboursement)
        {
            CodeRemboursement = codeRemboursement;
        }

        public Remboursement(string codeRemboursement, string emprunt, DateTime dateRemboursement, double montant, 
            string statutRemboursement) : this(codeRemboursement)
        {
            Credit = emprunt;
            DateRemboursement = dateRemboursement;
            Montant = montant;
            StatutRemboursement = statutRemboursement;
        }

        public override bool Equals(object obj)
        {
            return obj is Remboursement remboursement &&
                   CodeRemboursement == remboursement.CodeRemboursement;
        }

        public override int GetHashCode()
        {
            return CodeRemboursement.GetHashCode();
        }

        public override string ToString()
        {
            return CodeRemboursement;
        }
    }
}
