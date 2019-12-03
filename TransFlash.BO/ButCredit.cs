using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransFlash.BO
{
    [Serializable]
    public class ButCredit
    {
        public string Nom { get; set; }

        public ButCredit()
        {
        }

        public ButCredit(string nom)
        {
            Nom = nom;
        }

        public override bool Equals(object obj)
        {
            return obj is ButCredit credit &&
                   Nom == credit.Nom;
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
