using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO
{
    [Serializable]
    public class Remboursement
    {
        public string CodeRemboursement { get; set; }
        public Credit Credit { get; set; }
        public DateTime? DateRemboursement { get; set; }
        public DateTime DatePrevuRemboursement { get; set; }
        public double Montant { get; set; }
        public StatutRemboursement StatutRemboursement { get; set; }

        public Remboursement()
        {
        }

        public Remboursement(string codeRemboursement)
        {
            CodeRemboursement = codeRemboursement;
        }

        public Remboursement(string codeRemboursement, Credit credit, DateTime? dateRemboursement, DateTime datePrevuRemboursement, 
            double montant, StatutRemboursement statutRemboursement) : this(codeRemboursement)
        {
            Credit = credit;
            DateRemboursement = dateRemboursement;
            DatePrevuRemboursement = datePrevuRemboursement;
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
