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
    public class EpargneBLO
    {
        private IDAL<Epargne> epargneBLO = null;

        private OperationBLO operationBLO = null;

        public EpargneBLO()
        {
            epargneBLO = new RepositoireDAOFile<Epargne>();
        }

        public void AjouterEpargne(CompteClient compteClient, int nombreMois, double solde, Employe employe)
        {
            operationBLO = new OperationBLO();

            epargneBLO.Add(new Epargne(new IdentifiantBLO().IdEpargne, compteClient, DateTime.Now, nombreMois, solde, StatutEpargne.En_cours));

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, compteClient.Client, compteClient, solde, "toto tata");

            new IdentifiantBLO().AddIdEpargne();
        }

        public void RenouvelerEpargne(CompteClient compteClient, int nombreMois, double solde, Employe employe)
        {
            AjouterEpargne(compteClient, nombreMois, solde, employe);
        }

        public void AugmenterMontantEpargner(Epargne epargne, double montant, Employe employe)
        {
            operationBLO = new OperationBLO();
            Epargne oldEpargne = epargne;
            epargne.Solde += montant;

            epargneBLO[epargneBLO.IndexOf(oldEpargne)] = epargne;

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, epargne.CompteClient.Client, epargne.CompteClient, montant, "toto tata");
        }

        public void ReduireMontantEpargner(Epargne epargne, double montant, Employe employe)
        {
            operationBLO = new OperationBLO();
            Epargne oldEpargne = epargne;
            epargne.Solde -= montant;

            epargneBLO[epargneBLO.IndexOf(oldEpargne)] = epargne;

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, epargne.CompteClient.Client, epargne.CompteClient, montant, "toto tata");

            //if(epargne.Solde == 0 && epargne.DateEmpargne.AddMonths(epargne.NombreMois) <= DateTime.Now)
            //    AjouterEpargne(epargne.CompteClient, )
        }

        public bool VerifierReductionEpargne(Epargne epargne, double montant) => (epargne.Solde >= (epargne.Solde - montant));

        public IEnumerable<Epargne> RechercherEpargnesDuClient(Client client) => epargneBLO.Find(x =>
            x.CompteClient.Client == client);

        public Epargne RechercherEpargneEnCoursDuCompte(CompteClient compteClient) => epargneBLO.Find(x =>
            x.CompteClient == compteClient && x.StatutEpargne == StatutEpargne.En_cours).FirstOrDefault();

        public IEnumerable<Epargne> RechercherEpargnesDuCompte(CompteClient compteClient) => epargneBLO.Find(x =>
            x.CompteClient == compteClient);

        public IEnumerable<Epargne> RechercherLesEpargnes(string valeur) => epargneBLO.Find(x =>
            x.DateEmpargne.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.StatutEpargne.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.Solde.ToString().ToLower().Contains(valeur.ToLower()));

        public Epargne RechercheEpargne(int id) => epargneBLO.Find(x =>
            x.Id == id).FirstOrDefault();

        public void SupprimerEpargne(Epargne epargne, Employe employe)
        {
            operationBLO = new OperationBLO();
            epargneBLO.Remove(epargne);
            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, epargne.CompteClient.Client, epargne.CompteClient, epargne.Solde, "toto tata");
        }

        public List<Epargne> TousEpargnes => epargneBLO.AllItems;

    }
}
