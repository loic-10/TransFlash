using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransFlash.BO.ClassesReport
{
    [Serializable]
    public class Devise
    {
        public string NomDevise { get; set; }
        public string SymboleDevise { get; set; }

        public Devise()
        {
        }

        public Devise(string nomDevise)
        {
            NomDevise = nomDevise;
        }

        public Devise(string nomDevise, string symboleDevise) : this(nomDevise)
        {
            SymboleDevise = symboleDevise;
        }

        public override bool Equals(object obj)
        {
            return obj is Devise devise &&
                   SymboleDevise == devise.SymboleDevise;
        }

        public override int GetHashCode()
        {
            return SymboleDevise.GetHashCode();
        }

        public override string ToString()
        {
            return SymboleDevise + " : " + NomDevise;
        }
    }
}
