using TransFlash.DAL;
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

        public PartSocialeBLO()
        {
            partSocialeBLO = new RepositoireDAOFile<PartSociale>();
        }

        public void AjouterPartSociale(CompteClient compteClient, Employe employe)
        {

            partSocialeBLO.Add(new PartSociale(compteClient, StatutPartSociale.Incomplete, 0));

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, compteClient.Client, compteClient, 0,
                $"Ajout de la part sociale du compte {compteClient}");
        }

        public void AjouterMontantPartSociale(PartSociale partSociale, double montant, Employe employe)
        {

            int index = partSocialeBLO.IndexOf(partSociale);

            partSociale.Montant += montant;
            partSocialeBLO[index] = partSociale;

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, partSociale.CompteClient.Client, partSociale.CompteClient, montant,
                $"Ajout de la part sociale {partSociale}, au montant de {montant} de part sociale par le client {partSociale.CompteClient.Client} dans le " +
                $"compte {partSociale.CompteClient}");
        }

        public bool VerifierValidite(PartSociale partSociale, double montant)
        {
            if (montant > 0 && new ParametreGeneralBLO().TousParametreGenerals[0].MontantPartSociale >= (partSociale.Montant = montant))
                return true;

            return false;
        }

        public void UtiliserArgentParSociale(PartSociale partSociale, double montant, Employe employe)
        {

            int index = partSocialeBLO.IndexOf(partSociale);

            partSociale.Montant -= montant;
            partSocialeBLO[index] = partSociale;

            new OperationBLO().AjouterOperation(TypeOperation.Reduction_du_montant_de_la_part_sociale, employe, partSociale.CompteClient.Client, 
                partSociale.CompteClient, montant, $"Reduction du montant de la part sociale {partSociale}, au montant de {montant} de part sociale par le client " +
                $"{partSociale.CompteClient.Client} dans le compte {partSociale.CompteClient}");
        }

        public void SupprimerPartSociale(PartSociale partSociale, Employe employe)
        {
            partSocialeBLO.Remove(partSociale);

            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employe, partSociale.CompteClient.Client, partSociale.CompteClient, 
                partSociale.Montant, $"Ajout de la part sociale {partSociale}, au montant de {partSociale.Montant} de part sociale par le client " +
                $"{partSociale.CompteClient.Client} dans le compte {partSociale.CompteClient}");
        }

        public PartSociale RechercherPartSocialesCompte(CompteClient compteClient) => partSocialeBLO.Find(x =>
              x.CompteClient == compteClient).FirstOrDefault();

        public IEnumerable<PartSociale> RechercherLesPartSociales(string valeur, bool checkStatutPartSociale, bool checkMontant,
                bool checkCompteClient) => partSocialeBLO.Find(x =>
            (x.CompteClient.ToString().ToLower().Contains(valeur.ToLower()) && checkCompteClient) ||
            (x.Montant.ToString().ToLower().Contains(valeur.ToLower()) && checkMontant) ||
            (x.StatutPartSociale.ToString().ToLower().Contains(valeur.ToLower()) && checkStatutPartSociale));

        public List<PartSociale> TousPartSociales => partSocialeBLO.AllItems;

    }
}
