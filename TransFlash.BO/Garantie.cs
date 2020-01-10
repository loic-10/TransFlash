using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO
{
    [Serializable]
    public class Garantie
    {
        public int Id { get; set; }
        public DateTime DateEnregistrement { get; set; }
        public Credit Credit { get; set; }
        public Avaliste Avaliste { get; set; }
        public StatutGarantie StatutGarantie { get; set; }
        public string Description { get; set; }
        public double MontantEvaluation { get; set; }

        public Garantie()
        {
        }

        public Garantie(int id)
        {
            Id = id;
        }

        public Garantie(int id, DateTime dateEnregistrement, Credit credit, Avaliste avaliste, StatutGarantie statutGarantie, string description, 
            double montantEvaluation) : this(id)
        {
            DateEnregistrement = dateEnregistrement;
            Credit = credit;
            Avaliste = avaliste;
            StatutGarantie = statutGarantie;
            Description = description;
            MontantEvaluation = montantEvaluation;
        }

        public override bool Equals(object obj)
        {
            return obj is Garantie graantie &&
                   Id == graantie.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
