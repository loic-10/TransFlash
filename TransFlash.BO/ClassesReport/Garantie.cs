using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO.ClassesReport
{
    [Serializable]
    public class Garantie
    {
        public int Id { get; set; }
        public DateTime DateEnregistrement { get; set; }
        public string Credit { get; set; }
        public string Nom { get; set; }
        public string ElementEnGarantie { get; set; }
        public string Avaliste { get; set; }
        public string StatutGarantie { get; set; }
        public string Description { get; set; }
        public double MontantEvaluation { get; set; }

        public Garantie()
        {
        }

        public Garantie(int id)
        {
            Id = id;
        }

        public Garantie(int id, DateTime dateEnregistrement, string credit, string nom, string elementEnGarantie, string avaliste, string statutGarantie, 
            string description, double montantEvaluation) : this(id)
        {
            DateEnregistrement = dateEnregistrement;
            Credit = credit;
            Nom = nom;
            ElementEnGarantie = elementEnGarantie;
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
