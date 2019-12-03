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

        public CompteClientBLO()
        {
            compteClientBLO = new RepositoireDAOFile<CompteClient>();
        }

        public void AjouterCompteClient(string codeCompte, Client client, TypeCompte typeCompte,
            TypeAppartenantCompteEpargne typeAppartenantCompteEpargne, string nomStructure)
        {
            compteClientBLO.Add(new CompteClient(codeCompte, client, typeCompte, typeAppartenantCompteEpargne, 
                                                                            nomStructure, 0, StatutCompte.En_attente_de_validité, DateTime.Now));
        }

        public void ModifierNomStructureDuCompte(CompteClient compteClient,string nomStructure)
        {
            CompteClient oldCompteClient = compteClient;
            compteClient.NomStructure = nomStructure;
            compteClientBLO[compteClientBLO.IndexOf(oldCompteClient)] = compteClient;
        }

        public void ActiverCompteClient(CompteClient compteClient)
        {
            CompteClient oldCompteClient = compteClient;
            compteClient.StatutCompte = StatutCompte.Activé;
            compteClientBLO[compteClientBLO.IndexOf(oldCompteClient)] = compteClient;
        }

        public void BloquerCompteClient(CompteClient compteClient)
        {
            CompteClient oldCompteClient = compteClient;
            compteClient.StatutCompte = StatutCompte.Bloqué;
            compteClientBLO[compteClientBLO.IndexOf(oldCompteClient)] = compteClient;
        }

        public void CrediterCompteClient(CompteClient compteClient, double montant)
        {
            CompteClient oldCompteClient = compteClient;
            compteClient.Solde += montant;
            compteClientBLO[compteClientBLO.IndexOf(oldCompteClient)] = compteClient;
        }

        public void DebiterCompteClient(CompteClient compteClient, double montant)
        {
            CompteClient oldCompteClient = compteClient;
            compteClient.Solde -= montant;
            compteClientBLO[compteClientBLO.IndexOf(oldCompteClient)] = compteClient;
        }

        public void CrediterUnAutreCompte(CompteClient compteClientDebiter, CompteClient compteClientCrediter, double montant)
        {
            DebiterCompteClient(compteClientDebiter, montant);
            CrediterCompteClient(compteClientCrediter, montant);
        }

        internal void AjouterCompteClient(string codeCompte, Client client, TypeCompte typeCompte, 
            TypeAppartenantCompteEpargne? typeAppartenantCompteEpargne, string nomStructure)
        {
            compteClientBLO.Add(new CompteClient(codeCompte, client, typeCompte, typeAppartenantCompteEpargne, nomStructure, 0,
                StatutCompte.En_attente_de_validité, DateTime.Now));
        }

        public void PayerFraieOuvertureCompte(CompteClient compteClient, double montant)
        {

            ActiverCompteClient(compteClient);
        }

        public List<CompteClient> CompteDuClient(TypeCompte typeCompte, Client client)
        {
            var reqCompteClient = from compte in TousCompteClients
                                  where (compte.TypeCompte == typeCompte && compte.Client == client)
                                  select compte;

            return reqCompteClient as List<CompteClient>;
        }

        public CompteClient RechercherLesCompteClientsDuCompte(Client client)
        {
            var reqCompteClients = from cli in TousCompteClients
                                 where (cli.Client == client)
                                 select cli;
            return reqCompteClients.FirstOrDefault();
        }

        public List<CompteClient> RechercherLesCompteClients(string valeur)
        {
            var reqCompteClients = compteClientBLO.Find(x => x.TypeCompte.ToString().ToLower().Contains(valeur.ToLower()) ||
                                                                                x.NomStructure.ToLower().Contains(valeur.ToLower()));
            return reqCompteClients as List<CompteClient>;
        }

        public void SupprimerCompteClient(CompteClient CompteClient)
        {
            compteClientBLO.Remove(CompteClient);
        }

        public List<CompteClient> TousCompteClients => compteClientBLO.AllItems;

    }
}
