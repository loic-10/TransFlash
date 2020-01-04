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
    public class EpargneBLO
    {
        private IDAL<Epargne> epargneBLO = null;

        public EpargneBLO()
        {
            epargneBLO = new RepositoireDAOFile<Epargne>();
        }

        public void AjouterEpargne(CompteClient compteClient, int nombreMois, double solde, Employe employe)
        {

            epargneBLO.Add(new Epargne(new IdentifiantBLO().IdEpargne, compteClient, DateTime.Now, nombreMois, solde, StatutEpargne.En_cours));

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, compteClient.Client, compteClient, solde, $"Ajout de l'epargne " +
                $"{new IdentifiantBLO().IdEpargne}");

            new IdentifiantBLO().AddIdEpargne();
        }

        public void RenouvelerEpargne(CompteClient compteClient, int nombreMois, double solde, Employe employe)
        {
            AjouterEpargne(compteClient, nombreMois, solde, employe);
        }

        public void AugmenterMontantEpargner(Epargne epargne, double montant, Employe employe)
        {

            Epargne oldEpargne = epargne;
            epargne.Solde += montant;

            epargneBLO[epargneBLO.IndexOf(oldEpargne)] = epargne;

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, epargne.CompteClient.Client, epargne.CompteClient, montant,
                $"Augmentation du montant l'epargne {epargne}");
        }

        public void ReduireMontantEpargner(Epargne epargne, double montant, Employe employe)
        {

            Epargne oldEpargne = epargne;
            epargne.Solde -= montant;

            epargneBLO[epargneBLO.IndexOf(oldEpargne)] = epargne;

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, epargne.CompteClient.Client, epargne.CompteClient, montant,
                $"Reduction du montant l'epargne {epargne}");

            //if(epargne.Solde == 0 && epargne.DateEmpargne.AddMonths(epargne.NombreMois) <= DateTime.Now)
            //    AjouterEpargne(epargne.CompteClient, )
        }

        public bool VerifierReductionEpargne(Epargne epargne, double montant) => (epargne.Solde >= (epargne.Solde - montant));

        public IEnumerable<Epargne> RechercherEpargnesDuClient(Client client) => epargneBLO.Find(x =>
            x.CompteClient.Client == client);

        public Epargne RechercherEpargneEnCoursDuCompte(CompteClient compteClient) => epargneBLO.Find(x =>
            x.CompteClient.CodeCompte == compteClient.CodeCompte && x.StatutEpargne == StatutEpargne.En_cours).FirstOrDefault();

        public IEnumerable<Epargne> RechercherEpargnesDuCompte(CompteClient compteClient) => epargneBLO.Find(x =>
            x.CompteClient == compteClient);

        public IEnumerable<Epargne> RechercherLesEpargnes(string valeur, bool checkIdentifiant, bool checkCompteClient, bool checkDateEpargne, 
            bool checkNombreMois, bool checkSolde, bool checkStatutEpargne) => epargneBLO.Find(x =>
            (x.Id.ToString().ToLower().Contains(valeur.ToLower()) && checkIdentifiant) ||
            (x.CompteClient.ToString().ToLower().Contains(valeur.ToLower()) && checkCompteClient) ||
            (x.DateEmpargne.ToString().ToLower().Contains(valeur.ToLower()) && checkDateEpargne) ||
            (x.NombreMois.ToString().ToLower().Contains(valeur.ToLower()) && checkNombreMois) ||
            (x.Solde.ToString().ToLower().Contains(valeur.ToLower()) && checkSolde) ||
            (x.StatutEpargne.ToString().ToLower().Contains(valeur.ToLower()) && checkStatutEpargne));

        public Epargne RechercheEpargne(int id) => epargneBLO.Find(x =>
            x.Id == id).FirstOrDefault();

        public void SupprimerEpargne(Epargne epargne, Employe employe)
        {

            epargneBLO.Remove(epargne);
            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, epargne.CompteClient.Client, epargne.CompteClient, epargne.Solde,
                $"Suppression de l'epargne {epargne}");
        }

        public List<Epargne> TousEpargnes => epargneBLO.AllItems;

    }
}
