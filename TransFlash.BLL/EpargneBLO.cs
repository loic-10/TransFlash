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

        public EpargneBLO()
        {
            epargneBLO = new RepositoireDAOFile<Epargne>();
        }

        public void AjouterEpargne(int id, CompteClient compteClient, int nombreMois, double solde)
        {
            epargneBLO.Add(new Epargne(id, compteClient, DateTime.Now, nombreMois, solde, StatutEpargne.En_cours));
        }

        public void AugmenterMontantEpargner(Epargne epargne, double montant)
        {
            Epargne oldEpargne = epargne;
            epargne.Solde += montant;

            epargneBLO[epargneBLO.IndexOf(oldEpargne)] = epargne;
        }

        public void ReduireMontantEpargner(Epargne epargne, double montant)
        {
            Epargne oldEpargne = epargne;
            epargne.Solde -= montant;

            epargneBLO[epargneBLO.IndexOf(oldEpargne)] = epargne;
        }

        public bool VerifierReductionEpargne(Epargne epargne, double montant)
        {
            if (epargne.Solde >= (epargne.Solde - montant))
                return true;
            return false;
        }

        public List<Epargne> RechercherEpargnesDuClient(Client client)
        {

            ClientBLO clientBLO = new ClientBLO();
            CompteClientBLO compteClientBLO = new CompteClientBLO();
            List<Epargne> epargnes = new List<Epargne>();

            foreach (var epargne in TousEpargnes)
            {
                foreach (var compteClient in compteClientBLO.TousCompteClients)
                {
                    if(epargne.CompteClient == compteClient)
                    {
                        foreach (var _client in clientBLO.TousClients)
                        {
                            if (compteClient.Client == client)
                                epargnes.Add(epargne);
                        }
                    }
                }
            }

            return epargnes;
        }

        public List<Epargne> RechercherEpargnesDuCompte(CompteClient compteClient)
        {
            List<Epargne> epargnes = new List<Epargne>();
            foreach (var item in TousEpargnes)
                if (item.CompteClient ==compteClient)
                    epargnes.Add(item);

            return epargnes;
        }

        public List<Epargne> RechercherLesEpargnes(string valeur)
        {
            List<Epargne> epargnes = new List<Epargne>();
            foreach (var item in TousEpargnes)
                if (item.DateEmpargne.ToString().ToLower() == valeur.ToLower() ||
                    item.StatutEpargne.ToString().ToLower() == valeur.ToLower() ||
                    item.Solde.ToString().ToLower() == valeur.ToLower())
                    epargnes.Add(item);

            return epargnes;
        }

        public void SupprimerEpargne(Epargne epargne)
        {
            epargneBLO.Remove(epargne);
        }

        public List<Epargne> TousEpargnes => epargneBLO.AllItems;

    }
}
