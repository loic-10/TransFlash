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

        private OperationBLO operationBLO = null;

        private ParametreGeneralBLO parametreGeneralBLO = null;

        public PartSocialeBLO()
        {
            partSocialeBLO = new RepositoireDAOFile<PartSociale>();
        }

        public void AjouterPartSociale(CompteClient compteClient, StatutPartSociale statutPartSociale, double montant, Employe employe)
        {
            operationBLO = new OperationBLO();

            partSocialeBLO.Add(new PartSociale(compteClient, statutPartSociale, montant));

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, compteClient.Client, compteClient, montant, "toto tata");
        }

        public void AjouterMontantSociale(PartSociale partSociale, double montant, Employe employe)
        {
            operationBLO = new OperationBLO();

            int index = partSocialeBLO.IndexOf(partSociale);

            partSociale.Montant += montant;
            partSocialeBLO[index] = partSociale;

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, partSociale.CompteClient.Client, partSociale.CompteClient, montant, "toto tata");
        }

        public bool VerifierValidite(PartSociale partSociale, double montant)
        {
            parametreGeneralBLO = new ParametreGeneralBLO();
            if (montant > 0 && parametreGeneralBLO.TousParametreGenerals[0].MontantPartSociale >= (partSociale.Montant = montant))
                return true;

            return false;
        }

        public void UtiliserArgentParSociale(PartSociale partSociale, double montant, Employe employe)
        {
            operationBLO = new OperationBLO();

            int index = partSocialeBLO.IndexOf(partSociale);

            partSociale.Montant -= montant;
            partSocialeBLO[index] = partSociale;

            operationBLO.AjouterOperation(TypeOperation.Reduction_du_montant_de_la_part_sociale, employe, partSociale.CompteClient.Client, 
                partSociale.CompteClient, montant, "toto tata");
        }

        public void SupprimerPartSociale(PartSociale partSociale, Employe employe)
        {
            operationBLO = new OperationBLO();
            partSocialeBLO.Remove(partSociale);

            operationBLO.AjouterOperation(TypeOperation.Suppression, employe, partSociale.CompteClient.Client, partSociale.CompteClient, partSociale.Montant, "toto tata");
        }

        public PartSociale RechercherPartSocialesCompte(CompteClient compteClient) => partSocialeBLO.Find(x =>
              x.CompteClient == compteClient).FirstOrDefault();

        public IEnumerable<PartSociale> RechercherLesPartSociales(string valeur) => partSocialeBLO.Find(x =>
            x.CompteClient.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.Montant.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.StatutPartSociale.ToString().ToLower().Contains(valeur.ToLower()));

        public List<PartSociale> TousPartSociales => partSocialeBLO.AllItems;

    }
}
