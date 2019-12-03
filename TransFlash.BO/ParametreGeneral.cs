using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransFlash.BO
{
    [Serializable]
    public class ParametreGeneral
    {
        // Nom microfinance
        public string NomMicrofinance { get; set; }

        // Pourcentage
        public float PourcentageRetrait { get; set; }
        public float PourcentageRetraitEpargneSansAvis { get; set; }
        public float PourcentageDuCreditMaximalSalarie { get; set; }
        public float PourcentageBeneficeCompteEpargne { get; set; }

        // Beneficier
        public int NombreMinimalBeneficier { get; set; }
        public int NombreMaximalBeneficier { get; set; }

        // Part sociale
        public double MontantPartSociale { get; set; }

        //Creation d'un compte
        public double MontantDeCreationCompte { get; set; }

        // Jour d'attente
        public int NombreJourRetraitAviseDeEpargne { get; set; }
        public int NombreJourAttenteReponsePourCredit { get; set; }
        public int NombreMoisMinimalPourDecouvert { get; set; }

        // Montant maximum
        public double SoldeMaximalCompteCourant { get; set; }




        public ParametreGeneral()
        {
        }

        public ParametreGeneral(float pourcentageRetrait, float pourcentageRetraitEpargneSansAvis, int nombreMinimalBeneficier, 
            int nombreMaximalBeneficier, double montantPartSociale, double montantDeCreationCompte)
        {
            PourcentageRetrait = pourcentageRetrait;
            PourcentageRetraitEpargneSansAvis = pourcentageRetraitEpargneSansAvis;
            NombreMinimalBeneficier = nombreMinimalBeneficier;
            NombreMaximalBeneficier = nombreMaximalBeneficier;
            MontantPartSociale = montantPartSociale;
            MontantDeCreationCompte = montantDeCreationCompte;
        }
    }
}
