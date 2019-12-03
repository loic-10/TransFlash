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
    public class FichierStockeBLO
    {
        private IDAL<FichierStocke> fichierStockeBLO = null;

        public FichierStockeBLO()
        {
            fichierStockeBLO = new RepositoireDAOFile<FichierStocke>();
        }

        public void AjouterFichierStocke(int id, string nom, string fileName, Client client, Garantie garantie,
            StatutStockage statutStockage)
        {
            fichierStockeBLO.Add(new FichierStocke(id, DateTime.Now, nom, fileName, client, garantie, statutStockage));
        }

        public void ModifierFichierStocke(FichierStocke FichierStocke, string nom, string fileName, Client client, Garantie garantie,
            StatutStockage statutStockage)
        {
            FichierStocke oldFichierStocke = FichierStocke;
            FichierStocke.Nom = nom;
            fichierStockeBLO[fichierStockeBLO.IndexOf(oldFichierStocke)] = FichierStocke;
        }

        public void SupprimerFichierStocke(FichierStocke fichierStocke)
        {
            fichierStockeBLO.Remove(fichierStocke);
        }

        public List<FichierStocke> RechercherLesFichierStockes(string valeur)
        {
            List<FichierStocke> fichierStockes = new List<FichierStocke>();
            foreach (var item in TousFichierStockes)
                if (item.Nom.ToLower() == valeur.ToLower() ||
                    item.StatutStockage.ToString().ToLower() == valeur.ToLower() ||
                    item.DateEnregistrement.ToString().ToLower() == valeur.ToLower())
                    fichierStockes.Add(item);
                    
            return fichierStockes;
        }

        public List<FichierStocke> RechercherFichierStockesClient(Client client)
        {
            List<FichierStocke> fichierStockes = new List<FichierStocke>();
            foreach (var item in TousFichierStockes)
                if (item.Client == client)
                    fichierStockes.Add(item);
                    
            return fichierStockes;
        }

        public List<FichierStocke> RechercherFichierStockesGarantie(Garantie garantie)
        {
            List<FichierStocke> fichierStockes = new List<FichierStocke>();
            foreach (var item in TousFichierStockes)
                if (item.Garantie == garantie)
                    fichierStockes.Add(item);
                    
            return fichierStockes;
        }

        public List<FichierStocke> TousFichierStockes => fichierStockeBLO.AllItems;

    }
}
