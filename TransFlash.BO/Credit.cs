using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO
{
    [Serializable]
    public class Credit
    {
        public string CodeCredit { get; set; }
        public TypeCredit TypeCredit { get; set; }
        public DateTime DateCreditOuvertureDossier { get; set; }
        public DateTime? DateCreditValidation { get; set; }
        public int NombreMois { get; set; }
        public Client Client { get; set; }
        public Garantie Garantie { get; set; }
        public double MontantEmprunte { get; set; }
        public double MontantRembourse { get; set; }
        public StatutCredit StatutCredit { get; set; }

        public Credit()
        {
        }

        public Credit(string codeCredit)
        {
            CodeCredit = codeCredit;
        }

        public Credit(string codeCredit, TypeCredit typeCredit, DateTime dateCreditOuvertureDossier, DateTime? dateCreditValidation, int nombreMois, 
            Client client, Garantie garantie, double montantEmprunte, double montantRembourse, StatutCredit statutCredit) : this(codeCredit)
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
