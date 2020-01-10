using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO.ClassesReport
{
    [Serializable]
    public class Credit
    {
        public string CodeCredit { get; set; }
        public string TypeCredit { get; set; }
        public DateTime DateCreditOuvertureDossier { get; set; }
        public DateTime? DateCreditValidation { get; set; }
        public int NombreMois { get; set; }
        public string Client { get; set; }
        public string Garantie { get; set; }
        public double MontantEmprunte { get; set; }
        public double MontantRembourse { get; set; }
        public string StatutCredit { get; set; }

        public Credit()
        {
        }

        public Credit(string codeCredit)
        {
            CodeCredit = codeCredit;
        }

        public Credit(string codeCredit, string typeCredit, DateTime dateCreditOuvertureDossier, DateTime? dateCreditValidation, int nombreMois, 
            string client, string garantie, double montantEmprunte, double montantRembourse, string statutCredit) : this(codeCredit)
        {
            TypeCredit = typeCredit;
            DateCreditOuvertureDossier = dateCreditOuvertureDossier;
            DateCreditValidation = dateCreditValidation;
            NombreMois = nombreMois;
            Client = client;
            Garantie = garantie;
            MontantEmprunte = montantEmprunte;
            MontantRembourse = montantRembourse;
            StatutCredit = statutCredit;
        }

        public override bool Equals(object obj)
        {
            return obj is Credit Credit &&
                   CodeCredit == Credit.CodeCredit;
        }

        public override int GetHashCode()
        {
            return CodeCredit.GetHashCode();
        }

        public override string ToString()
        {
            return CodeCredit;
        }
    }
}
