using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couche.Winforms
{
    public enum Status
    {
        Activé,
        Desactivé
    }
    public class Personne
    {
        public string Nom { get; set; }
        public Status Status { get; set; }

        public Personne(string nom, Status status)
        {
            Nom = nom;
            Status = status;
        }

        public override bool Equals(object obj)
        {
            return obj is Personne personne &&
                   Nom == personne.Nom;
        }

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }
    }
}
