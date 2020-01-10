using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransFlash.BO.ClassesReport
{
    [Serializable]
    public class Avaliste
    {
        public int Id { get; set; }
        public string Garantie { get; set; }
        public string NomComplet { get; set; }
        public string Profession { get; set; }
        public string Description { get; set; }
        public double MontantParMois { get; set; }

        public Avaliste()
        {
        }

        public Avaliste(string nomComplet)
        {
            NomComplet = nomComplet;
        }

        public Avaliste(int id, string garantie, string nomComplet, string profession, string description, double montantParMois)
        {
            Id = id;
            Garantie = garantie;
            NomComplet = nomComplet;
            Profession = profession;
            Description = description;
            MontantParMois = montantParMois;
        }

        public override bool Equals(object obj)
        {
            return obj is Avaliste avaliste &&
                   Id == avaliste.Id;
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
