using Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransFlash.BO;
using static TransFlash.BO.Statut;

namespace TransFlash.BLL
{
    public class ParametreGeneralBLO
    {
        private IDAL<ParametreGeneral> parametreGeneralBLO = null;

        public ParametreGeneralBLO()
        {
            parametreGeneralBLO = new RepositoireDAOFile<ParametreGeneral>();
            if (parametreGeneralBLO.Count == 0)
            {
                AjouterParametreGeneral("nom_microfinance", string.Empty, "position geographique de la microfinance", "slogan de la microfinance",
                    new Devise("Dollar", "$"), 18, 3, 2, 30, 2.5f, 2, 5, 50000, 7500, 1000, 30, 2, 3, 1000000, 1000);
            }
        }

        public void AjouterParametreGeneral(string nomMicrofinance, string logoMicrofinance, string positionGeographiqueMicrofinance, string sloganMicrofinance,
            Devise deviseMicrofinance, int ageMinimalRequis, float pourcentageRetrait, float pourcentageRetraitEpargneSansAvis,
            float pourcentageDecouvertMaximal, float pourcentageBeneficeCompteEpargne, int nombreMinimalBeneficier,
            int nombreMaximalBeneficier, double montantPartSociale, double montantDeCreationCompte, double montantMininimumDepot,
            int nombreJourRetraitAviseDeEpargne, int nombreJourAttenteReponsePourCredit, int nombreMoisMinimalPourDecouvert,
            double soldeMaximalCompteCourant, double fraiesDebloquerCompte)
        {
            parametreGeneralBLO.Add(new ParametreGeneral(nomMicrofinance, logoMicrofinance, positionGeographiqueMicrofinance, sloganMicrofinance,
                deviseMicrofinance, ageMinimalRequis, pourcentageRetrait, pourcentageRetraitEpargneSansAvis, pourcentageDecouvertMaximal,
                pourcentageBeneficeCompteEpargne, nombreMinimalBeneficier, nombreMaximalBeneficier, montantPartSociale, montantDeCreationCompte,
                montantMininimumDepot, nombreJourRetraitAviseDeEpargne, nombreJourAttenteReponsePourCredit, nombreMoisMinimalPourDecouvert,
                soldeMaximalCompteCourant, fraiesDebloquerCompte)); ;
        }

        public void ModifierParametreGeneral(ParametreGeneral parametreGeneral, float pourcentageRetrait,
            float pourcentageRetraitEpargneSansAvis, int nombreMinimalBeneficier, int nombreMaximalBeneficier, 
            double montantPartSociale, double montantDeCreationCompte)
        {
            ParametreGeneral oldParametreGeneral = parametreGeneral;
            parametreGeneral.PourcentageRetrait = pourcentageRetrait;
            parametreGeneral.PourcentageRetraitEpargneSansAvis = pourcentageRetraitEpargneSansAvis;
            parametreGeneral.NombreMinimalBeneficier = nombreMinimalBeneficier;
            parametreGeneral.NombreMaximalBeneficier = nombreMinimalBeneficier;
            parametreGeneral.MontantPartSociale = montantPartSociale;
            parametreGeneral.MontantDeCreationCompte = montantDeCreationCompte;

            parametreGeneralBLO[parametreGeneralBLO.IndexOf(oldParametreGeneral)] = parametreGeneral;
        }

        public List<ParametreGeneral> TousParametreGenerals => parametreGeneralBLO.AllItems;

    }
}
