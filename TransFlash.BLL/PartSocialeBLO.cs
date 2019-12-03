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
    public class PartSocialeBLO
    {
        private IDAL<PartSociale> partSocialeBLO = null;

        private ParametreGeneralBLO parametreGeneralBLO = null;

        public PartSocialeBLO()
        {
            partSocialeBLO = new RepositoireDAOFile<PartSociale>();
        }

        public void AjouterPartSociale(CompteClient compteClient, StatutPartSociale statutPartSociale, double montant)
        {
            partSocialeBLO.Add(new PartSociale(compteClient, statutPartSociale, montant));
        }

        public void AjouterMontantSociale(PartSociale partSociale, double montant)
        {
            PartSociale oldPartSociale = partSociale;
            partSociale.Montant += montant;
            partSocialeBLO[partSocialeBLO.IndexOf(oldPartSociale)] = partSociale;
        }

        public bool VerifierValidite(PartSociale partSociale, double montant)
        {
            parametreGeneralBLO = new ParametreGeneralBLO();
            partSociale.Montant += montant;
            if (parametreGeneralBLO.TousParametreGenerals[0].MontantPartSociale >= partSociale.Montant)
                return true;

            return false;
        }

        public void SupprimerPartSociale(PartSociale PartSociale)
        {
            partSocialeBLO.Remove(PartSociale);
        }

        public List<PartSociale> TousPartSociales => partSocialeBLO.AllItems;

    }
}
