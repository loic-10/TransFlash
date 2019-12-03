using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransFlash.BO
{
    [Serializable]
    public class Ville
    {
        public string Nom { get; set; }
        public Pays Pays { get; set; }

        public Ville()
        {
        }

        public Ville(string nom)
        {
            Nom = nom;
        }

        public Ville(string nom, Pays nomPays) : this(nom)
        {
            Pays = nomPays;
        }

        public override bool Equals(object obj)
        {
            return obj is Ville ville &&
                   Nom == ville.Nom;
        }

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
