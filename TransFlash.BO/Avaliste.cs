using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransFlash.BO
{
    [Serializable]
    public class Avaliste
    {
        public int Id { get; set; }
        public Garantie Garantie { get; set; }
        public string NomComplet { get; set; }
        public string Profession { get; set; }
        public string Description { get; set; }
        public double MontantParMois { get; set; }

        public Avaliste()
        {
        }

        public Avaliste(int id)
        {
            Id = id;
        }

        public Avaliste(int id, Garantie garantie, string nomComplet, string profession, string description, double montantParMois)
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
