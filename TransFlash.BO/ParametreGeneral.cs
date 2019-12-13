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

        // Age
        public int AgeMinimalRequis { get; set; }


        // Pourcentage
        public float PourcentageRetrait { get; set; }
        public float PourcentageRetraitEpargneSansAvis { get; set; }
        public float PourcentageDuCreditMaximalSalarie { get; set; }
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
        public double FraiesCreationCompte { get; set; }
        public double FraiesDebloquerCompte { get; set; }




        public ParametreGeneral()
        {
        }

        public ParametreGeneral(string nomMicrofinance, int ageMinimalRequis, float pourcentageRetrait, float pourcentageRetraitEpargneSansAvis, 
            float pourcentageDuCreditMaximalSalarie, float pourcentageDecouvertMaximal, float pourcentageBeneficeCompteEpargne, int nombreMinimalBeneficier, 
            int nombreMaximalBeneficier, double montantPartSociale, double montantDeCreationCompte, double montantMininimumDepot,
            int nombreJourRetraitAviseDeEpargne, int nombreJourAttenteReponsePourCredit, int nombreMoisMinimalPourDecouvert, 
            double soldeMaximalCompteCourant, double fraiesCreationCompte, double fraiesDebloquerCompte)
        {
            NomMicrofinance = nomMicrofinance;
            AgeMinimalRequis = ageMinimalRequis;
            PourcentageRetrait = pourcentageRetrait;
            PourcentageRetraitEpargneSansAvis = pourcentageRetraitEpargneSansAvis;
            PourcentageDuCreditMaximalSalarie = pourcentageDuCreditMaximalSalarie;
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
            FraiesCreationCompte = fraiesCreationCompte;
            FraiesDebloquerCompte = fraiesDebloquerCompte;
        }
    }
}
