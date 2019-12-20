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
        // Information microfinance
        public string NomMicrofinance { get; set; }
        public string LogoMicrofinance { get; set; }
        public string PositionGeographiqueMicrofinance { get; set; }
        public string SloganMicrofinance { get; set; }
        public Devise DeviseMicrofinance { get; set; }

        // Age
        public int AgeMinimalRequis { get; set; }

        // Pourcentage
        public float PourcentageRetrait { get; set; }
        public float PourcentageRetraitEpargneSansAvis { get; set; }
        public float PourcentageDecouvertMaximal { get; set; }
        public float PourcentageBeneficeCompteEpargne { get; set; }

        // Beneficier
        public int NombreMinimalBeneficier { get; set; }
        public int NombreMaximalBeneficier { get; set; }

        // Part sociale
        public double MontantPartSociale { get; set; }

        //Creation d'un compte
        public double MontantDeCreationCompte { get; set; }

        // Montant minimum de depot
        public double MontantMininimumDepot { get; set; }

        // Jour d'attente
        public int NombreJourRetraitAviseDeEpargne { get; set; }
        public int NombreJourAttenteReponsePourCredit { get; set; }
        public int NombreMoisMinimalPourDecouvert { get; set; }

        // Montant maximum
        public double SoldeMaximalCompteCourant { get; set; }

        // Fraies sur un compte
        public double FraiesDebloquerCompte { get; set; }




        public ParametreGeneral()
        {
        }

        public ParametreGeneral(string nomMicrofinance, string logoMicrofinance, string positionGeographiqueMicrofinance, string sloganMicrofinance,
            Devise deviseMicrofinance, int ageMinimalRequis, float pourcentageRetrait, float pourcentageRetraitEpargneSansAvis, 
            float pourcentageDecouvertMaximal, float pourcentageBeneficeCompteEpargne, int nombreMinimalBeneficier, int nombreMaximalBeneficier, 
            double montantPartSociale, double montantDeCreationCompte, double montantMininimumDepot, int nombreJourRetraitAviseDeEpargne,
            int nombreJourAttenteReponsePourCredit, int nombreMoisMinimalPourDecouvert, double soldeMaximalCompteCourant, 
            double fraiesDebloquerCompte)
        {
            NomMicrofinance = nomMicrofinance;
            LogoMicrofinance = logoMicrofinance;
            PositionGeographiqueMicrofinance = positionGeographiqueMicrofinance;
            SloganMicrofinance = sloganMicrofinance;
            DeviseMicrofinance = deviseMicrofinance;
            AgeMinimalRequis = ageMinimalRequis;
            PourcentageRetrait = pourcentageRetrait;
            PourcentageRetraitEpargneSansAvis = pourcentageRetraitEpargneSansAvis;
            PourcentageDecouvertMaximal = pourcentageDecouvertMaximal;
            PourcentageBeneficeCompteEpargne = pourcentageBeneficeCompteEpargne;
            NombreMinimalBeneficier = nombreMinimalBeneficier;
            NombreMaximalBeneficier = nombreMaximalBeneficier;
            MontantPartSociale = montantPartSociale;
            MontantDeCreationCompte = montantDeCreationCompte;
            MontantMininimumDepot = montantMininimumDepot;
            NombreJourRetraitAviseDeEpargne = nombreJourRetraitAviseDeEpargne;
            NombreJourAttenteReponsePourCredit = nombreJourAttenteReponsePourCredit;
            NombreMoisMinimalPourDecouvert = nombreMoisMinimalPourDecouvert;
            SoldeMaximalCompteCourant = soldeMaximalCompteCourant;
            FraiesDebloquerCompte = fraiesDebloquerCompte;
        }
    }
}
