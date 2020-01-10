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
    public class CompteClientBLO
    {
        private IDAL<CompteClient> compteClientBLO = null;

        public CompteClientBLO()
        {
            compteClientBLO = new RepositoireDAOFile<CompteClient>();
        }

        public void AjouterCompteClient(Client client, TypeCompte typeCompte, TypeAppartenantCompteEpargne? typeAppartenantCompteEpargne, 
            string nomStructure, int nombreMois, double montant, Employe employe)
        {

            int idEpargne = new IdentifiantBLO().IdEpargne;
            CompteClient compteClient = new CompteClient(CodeCompteClient(typeCompte, typeAppartenantCompteEpargne), client, typeCompte, typeAppartenantCompteEpargne,
                                                                            nomStructure, 0, StatutCompte.En_attente_de_validité, DateTime.Now);

            compteClientBLO.Add(compteClient);

            new PartSocialeBLO().AjouterPartSociale(compteClient, employe);

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, client, compteClient, 0, $"Ajout du compte {compteClient} pour le client " +
                $"{client}");

            if (typeCompte == TypeCompte.Epargne)
            {
                new EpargneBLO().AjouterEpargne(compteClient, nombreMois, 0, employe);
            }

            new TransactionBLO().InitierTransaction(typeCompte, TypeTransaction.Dépot, compteClient, new CompteClient("/"), employe, montant, 0);

            new IdentifiantBLO().AddIdCompteClient();
        }

        public string CodeCompteClient(TypeCompte typeCompte, TypeAppartenantCompteEpargne? typeAppartenantCompteEpargne) => 
            ((typeCompte == TypeCompte.Epargne && typeAppartenantCompteEpargne == TypeAppartenantCompteEpargne.Entreprise) ? "cen-" : "ccl-") + 
            (new IdentifiantBLO().IdCompteClient.ToString().PadLeft(8, '0'));

        public void ModifierNomStructureDuCompte(CompteClient compteClient, string nomStructure, Employe employe)
        {

            CompteClient oldCompteClient = compteClient;
            compteClient.NomStructure = nomStructure;
            compteClientBLO[compteClientBLO.IndexOf(oldCompteClient)] = compteClient;

            new OperationBLO().AjouterOperation(TypeOperation.Modification, employe, compteClient.Client, compteClient, 0, $"Modification du compte " +
                $"{compteClient} du client {compteClient.Client}");
        }

        public void ActiverCompteClient(CompteClient compteClient, double montant, Employe employe)
        {

            string description = $"Activation du compte {compteClient} du client {compteClient.Client}, au prix de {montant}";


            new FondBLO().MettreArgentEnFond(employe, compteClient, montant, description);

            CompteClient oldCompteClient = compteClient;
            compteClient.StatutCompte = StatutCompte.Activé;
            compteClientBLO[compteClientBLO.IndexOf(oldCompteClient)] = compteClient;

            new OperationBLO().AjouterOperation(TypeOperation.Activation, employe, compteClient.Client, compteClient, montant, description);
        }

        public double MontantSoldeCompteClient(CompteClient compteClient) => compteClient.Solde;

        public void BloquerCompteClient(CompteClient compteClient, Employe employe)
        {

            CompteClient oldCompteClient = compteClient;
            compteClient.StatutCompte = StatutCompte.Bloqué;
            compteClientBLO[compteClientBLO.IndexOf(oldCompteClient)] = compteClient;

            new OperationBLO().AjouterOperation(TypeOperation.Désactivation, employe, compteClient.Client, compteClient, 0, $"Desactivation du " +
                $"compte {compteClient} du client {compteClient.Client}");
        }

        public void CrediterCompteClient(CompteClient compteClient, double montant, Employe employe)
        {

            int index = compteClientBLO.IndexOf(compteClient);
            compteClient.Solde += montant;
            compteClientBLO[index] = compteClient;

            string raison = $"Depot du compte {compteClient} du client {compteClient.Client} au montant de {montant}";

            new FondBLO().MettreArgentEnFond(employe, compteClient, montant, raison);

            new OperationBLO().AjouterOperation(TypeOperation.Dépot, employe, compteClient.Client, compteClient, montant, raison);
        }

        public void DebiterCompteClient(CompteClient compteClient, double montant, Employe employe, bool appliquerFraiesRetrait, bool couperFrais)
        {

            double montantFinal = montant + (appliquerFraiesRetrait && couperFrais ? 
                CalculFraiesRetrait(montant) : 
                (!appliquerFraiesRetrait && couperFrais) ?
                CalculFraiesRetraitTransfert(montant) :
                0);
            int index = compteClientBLO.IndexOf(compteClient);
            compteClient.Solde -= montantFinal;
            compteClientBLO[index] = compteClient;

            string raison = $"Retrait du compte {compteClient} du client {compteClient.Client} au montant de {montant}";

            new FondBLO().SortirArgentEnFond(employe, compteClient, montant, raison);

            new OperationBLO().AjouterOperation(TypeOperation.Retrait, employe, compteClient.Client, compteClient, montantFinal, raison);
        }

        public void DebiterCompteClientEpargne(CompteClient compteClient, double montant, double montantReduit, Employe employe)
        {

            double montantFinal = montant - montantReduit;
            int index = compteClientBLO.IndexOf(compteClient);
            compteClient.Solde -= montant;
            compteClientBLO[index] = compteClient;

            string raison = $"Retrait du compte {compteClient} du client {compteClient.Client} au montant de {montantFinal}";

            new FondBLO().SortirArgentEnFond(employe, compteClient, montantFinal, raison);

            new OperationBLO().AjouterOperation(TypeOperation.Retrait, employe, compteClient.Client, compteClient, montantFinal, raison);
        }

        public void CrediterUnAutreCompte(CompteClient compteClientDebiter, CompteClient compteClientCrediter, double montant, Employe employe
            , bool appliquerFraiesRetrait, bool couperFrais)
        {
            DebiterCompteClient(compteClientDebiter, montant, employe, appliquerFraiesRetrait, couperFrais);
            CrediterCompteClient(compteClientCrediter, montant, employe);

            new OperationBLO().AjouterOperation(TypeOperation.Transfert_inter_compte, employe, compteClientDebiter.Client, compteClientDebiter, 
                montant, $"Transfert du compte {compteClientDebiter} du client {compteClientDebiter.Client} a l'endroit du compte {compteClientCrediter} " +
                $"du client {compteClientCrediter.Client} pour un montant de {montant}");
        }

        public double MontantDepots(CompteClient compteClient)
        {
            double montant = 0;
            foreach (var item in new TransactionBLO().RechercherDepotSurCompte(compteClient))
            {
                montant += item.Montant;
            }
            return montant;
        }

        public double CalculFraiesRetrait(double montant) => ((new ParametreGeneralBLO().TousParametreGenerals[0].PourcentageRetrait*montant)/100);

        public double CalculFraiesRetraitTransfert(double montant) => ((new ParametreGeneralBLO().TousParametreGenerals[0].PourcentageRetraitTransfert*montant)/100);

        public IEnumerable<CompteClient> CompteDesComptesDuClient(TypeCompte typeCompte, Client client) => compteClientBLO.Find(x =>
            x.TypeCompte == typeCompte && 
            x.Client.CodeClient == client.CodeClient);

        public CompteClient RechercherUnCompte(string codeCompte) => compteClientBLO.Find(x =>
            x.StatutCompte == StatutCompte.Activé &&
            x.CodeCompte.ToString() == codeCompte).FirstOrDefault();

        public CompteClient RechercherUnComptePourBeneficier(string codeCompte) => compteClientBLO.Find(x =>
            x.CodeCompte.ToString() == codeCompte).FirstOrDefault();

        public IEnumerable<CompteClient> RechercherLesComptesClientsDuClient(Client client) => compteClientBLO.Find(x =>
            x.Client.CodeClient == client.CodeClient);

        public IEnumerable<CompteClient> RechercherLesComptesClientsDuClientEnFonctionDuType(Client client, 
            string typeCompte) => compteClientBLO.Find(x =>
            x.Client.CodeClient == client.CodeClient &&
            x.TypeCompte.ToString() == typeCompte);

        public IEnumerable<CompteClient> RechercherLesCompteClients(string valeur, bool checkCode, bool checkDateEnregistrement, 
            bool checkClient, bool checkTypeCompte, bool checkTypeAppartenantCompteEpargne, bool checkNomStructure, bool checkSolde, 
            bool checkStatutCompte) => compteClientBLO.Find(x => 
            (x.TypeCompte.ToString().ToLower().Contains(valeur.ToLower()) && checkTypeCompte) ||
            (x.NomStructure.ToLower().Contains(valeur.ToLower()) && checkNomStructure) ||
            (x.Client.ToString().ToLower().Contains(valeur.ToLower()) && checkClient) ||
            (x.CodeCompte.ToLower().Contains(valeur.ToLower()) && checkCode) ||
            (x.DateEnregistrement.ToString().ToLower().Contains(valeur.ToLower()) && checkDateEnregistrement) ||
            (x.Solde.ToString().ToLower().Contains(valeur.ToLower()) && checkSolde) ||
            (x.StatutCompte.ToString().ToLower().Contains(valeur.ToLower()) && checkStatutCompte) ||
            (x.TypeAppartenantCompteEpargne.ToString().ToLower().Contains(valeur.ToLower()) && checkTypeAppartenantCompteEpargne));

        public void SupprimerCompteClient(CompteClient compteClient, Employe employe)
        {

            compteClientBLO.Remove(compteClient);

            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employe, compteClient.Client, compteClient, 0, $"Suppression du compte " +
                $"{compteClient} du client {compteClient.Client}");
        }

        public List<CompteClient> TousCompteClients => compteClientBLO.AllItems;

    }
}
