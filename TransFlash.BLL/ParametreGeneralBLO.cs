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
            //if(parametreGeneralBLO.Count == 0)
               //AjouterParametreGeneral()
        }

        public void AjouterParametreGeneral(string nomMicrofinance, int ageMinimalRequis, float pourcentageRetrait, float pourcentageRetraitEpargneSansAvis,
            float pourcentageDuCreditMaximalSalarie, float pourcentageDecouvertMaximal, float pourcentageBeneficeCompteEpargne, int nombreMinimalBeneficier,
            int nombreMaximalBeneficier, double montantPartSociale, double montantDeCreationCompte, double montantMininimumDepot,
            int nombreJourRetraitAviseDeEpargne, int nombreJourAttenteReponsePourCredit, int nombreMoisMinimalPourDecouvert,
            double soldeMaximalCompteCourant, double fraiesCreationCompte, double fraiesDebloquerCompte)
        {
            //parametreGeneralBLO.Add(new ParametreGeneral(nomMicrofinance, ageMinimalRequis, float pourcentageRetrait, float pourcentageRetraitEpargneSansAvis,
            //float pourcentageDuCreditMaximalSalarie, float pourcentageDecouvertMaximal, float pourcentageBeneficeCompteEpargne, int nombreMinimalBeneficier,
            //int nombreMaximalBeneficier, double montantPartSociale, double montantDeCreationCompte, double montantMininimumDepot,
            //int nombreJourRetraitAviseDeEpargne, int nombreJourAttenteReponsePourCredit, int nombreMoisMinimalPourDecouvert,
            //double soldeMaximalCompteCourant, double fraiesCreationCompte, double fraiesDebloquerCompte));
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
