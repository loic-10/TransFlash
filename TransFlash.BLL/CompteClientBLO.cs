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
    public class CompteClientBLO
    {
        private IDAL<CompteClient> compteClientBLO = null;

        private OperationBLO operationBLO = null;

        private ParametreGeneralBLO parametreGeneralBLO = new ParametreGeneralBLO();

        private TransactionBLO transactionBLO = null;

        private FondBLO fondBLO = null;

        private EpargneBLO epargneBLO = null;

        public CompteClientBLO()
        {
            compteClientBLO = new RepositoireDAOFile<CompteClient>();
        }

        public void AjouterCompteClient(Client client, TypeCompte typeCompte, TypeAppartenantCompteEpargne? typeAppartenantCompteEpargne, 
            string nomStructure, int nombreMois, double montant, Employe employe)
        {
            epargneBLO = new EpargneBLO();
            operationBLO = new OperationBLO();
            transactionBLO = new TransactionBLO();

            int idEpargne = new IdentifiantBLO().IdEpargne;
            CompteClient compteClient = new CompteClient(CodeCompteClient(typeCompte, typeAppartenantCompteEpargne), client, typeCompte, typeAppartenantCompteEpargne,
                                                                            nomStructure, 0, StatutCompte.En_attente_de_validité, DateTime.Now);

            compteClientBLO.Add(compteClient);

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, client, compteClient, 0, "toto tata");

            Epargne epargne = new Epargne(0);
            if (typeCompte == TypeCompte.Epargne)
            {
                epargneBLO.AjouterEpargne(compteClient, nombreMois, 0, employe);

                epargne = epargneBLO.RechercheEpargne(idEpargne);
            }

            transactionBLO.InitierTransaction(typeCompte, TypeTransaction.Dépot, epargne, compteClient, new CompteClient("Indefini"), employe, montant, 0);

            new IdentifiantBLO().AddIdCompteClient();
        }

        public string CodeCompteClient(TypeCompte typeCompte, TypeAppartenantCompteEpargne? typeAppartenantCompteEpargne) => 
            ((typeCompte == TypeCompte.Epargne && typeAppartenantCompteEpargne == TypeAppartenantCompteEpargne.Entreprise) ? "cen-" : "ccl-") + 
            (new IdentifiantBLO().IdCompteClient.ToString().PadLeft(8, '0'));

        public void ModifierNomStructureDuCompte(CompteClient compteClient, string nomStructure, Employe employe)
        {
            operationBLO = new OperationBLO();

            CompteClient oldCompteClient = compteClient;
            compteClient.NomStructure = nomStructure;
            compteClientBLO[compteClientBLO.IndexOf(oldCompteClient)] = compteClient;

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, compteClient.Client, compteClient, 0, "toto tata");
        }

        public void ActiverCompteClient(CompteClient compteClient, double montantDepot, Employe employe)
        {
            fondBLO = new FondBLO();

            double montant;
            if (compteClient.StatutCompte == StatutCompte.En_attente_de_validité)
                montant = parametreGeneralBLO.TousParametreGenerals[0].FraiesCreationCompte;
            else
                montant = parametreGeneralBLO.TousParametreGenerals[0].FraiesDebloquerCompte;
            
            if(montant > 0)
                fondBLO.MettreArgentEnFond(employe, compteClient, montant, "toto tata");

            CompteClient oldCompteClient = compteClient;
            compteClient.StatutCompte = StatutCompte.Activé;
            compteClientBLO[compteClientBLO.IndexOf(oldCompteClient)] = compteClient;

            operationBLO.AjouterOperation(TypeOperation.Activation, employe, compteClient.Client, compteClient, montant, "toto tata");

            if(montantDepot > 0)
                CrediterCompteClient(compteClient, montantDepot, employe);
        }

        public void BloquerCompteClient(CompteClient compteClient, Employe employe)
        {
            operationBLO = new OperationBLO();
            CompteClient oldCompteClient = compteClient;
            compteClient.StatutCompte = StatutCompte.Bloqué;
            compteClientBLO[compteClientBLO.IndexOf(oldCompteClient)] = compteClient;

            operationBLO.AjouterOperation(TypeOperation.Désactivation, employe, compteClient.Client, compteClient, 0, "toto tata");
        }

        public void CrediterCompteClient(CompteClient compteClient, double montant, Employe employe)
        {
            operationBLO = new OperationBLO();
            epargneBLO = new EpargneBLO();
            fondBLO = new FondBLO();

            CompteClient oldCompteClient = compteClient;
            compteClient.Solde += montant;
            compteClientBLO[compteClientBLO.IndexOf(oldCompteClient)] = compteClient;

            if (compteClient.TypeCompte == TypeCompte.Epargne)
                epargneBLO.AugmenterMontantEpargner(epargneBLO.RechercherEpargneEnCoursDuCompte(compteClient), montant, employe);

            fondBLO.MettreArgentEnFond(employe, compteClient, montant, "toto tata");

            operationBLO.AjouterOperation(TypeOperation.Dépot, employe, compteClient.Client, compteClient, montant, "toto tata");
        }

        public void DebiterCompteClient(CompteClient compteClient, double montant, Employe employe)
        {
            operationBLO = new OperationBLO();

            fondBLO = new FondBLO();

            double montantFinal = (montant + CalculInteretRetrait(montant));

            CompteClient oldCompteClient = compteClient;
            compteClient.Solde -= montantFinal;
            compteClientBLO[compteClientBLO.IndexOf(oldCompteClient)] = compteClient;

            if (compteClient.TypeCompte == TypeCompte.Epargne)
                epargneBLO.ReduireMontantEpargner(epargneBLO.RechercherEpargneEnCoursDuCompte(compteClient), montant, employe);

            fondBLO.SortirArgentEnFond(employe, compteClient, montant, "toto tata");

            operationBLO.AjouterOperation(TypeOperation.Retrait, employe, compteClient.Client, compteClient, montantFinal, "toto tata");
        }

        public void CrediterUnAutreCompte(CompteClient compteClientDebiter, CompteClient compteClientCrediter, double montant, Employe employe)
        {
            operationBLO = new OperationBLO();
            DebiterCompteClient(compteClientDebiter, montant, employe);
            CrediterCompteClient(compteClientCrediter, montant, employe);

            operationBLO.AjouterOperation(TypeOperation.Transfert_inter_compte, employe, compteClientDebiter.Client, compteClientDebiter, montant, "toto tata");
        }

        public double MontantDepots(CompteClient compteClient)
        {
            double montant = 0;
            transactionBLO = new TransactionBLO();
            foreach (var item in transactionBLO.RechercherDepotSurCompte(compteClient))
            {
                montant += item.Montant;
            }
            return montant;
        }

        public double CalculInteretRetrait(double montant) => ((parametreGeneralBLO.TousParametreGenerals[0].PourcentageRetrait*montant)/100);

        public IEnumerable<CompteClient> CompteDesComptesDuClient(TypeCompte typeCompte, Client client) => compteClientBLO.Find(x =>
            x.TypeCompte == typeCompte && 
            x.Client == client);

        public CompteClient RechercherUnCompte(string codeCompte) => compteClientBLO.Find(x =>
            x.CodeCompte == codeCompte).FirstOrDefault();

        public IEnumerable<CompteClient> RechercherLesComptesClientsDuClient(Client client) => compteClientBLO.Find(x =>
            x.Client == client);

        public IEnumerable<CompteClient> RechercherLesCompteClients(string valeur) => compteClientBLO.Find(x => 
            x.TypeCompte.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.NomStructure.ToLower().Contains(valeur.ToLower()));

        public void SupprimerCompteClient(CompteClient compteClient, Employe employe)
        {
            operationBLO = new OperationBLO();

            compteClientBLO.Remove(compteClient);

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, compteClient.Client, compteClient, 0, "toto tata");
        }

        public List<CompteClient> TousCompteClients => compteClientBLO.AllItems;

    }
}
