using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransFlash.BO.ClassesReport
{
    [Serializable]
    public class Pays
    {
        public string Nom { get; set; }
        public string CodePhone { get; set; }

        public Pays()
        {
        }

        public Pays(string nom)
        {
            Nom = nom;
        }

        public Pays(string nom, string codePhone) : this(nom)
        {
            CodePhone = codePhone;
        }

        public override bool Equals(object obj)
        {
            return obj is Pays pays &&
                   Nom == pays.Nom;
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
