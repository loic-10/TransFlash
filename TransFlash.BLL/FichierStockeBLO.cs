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

        private OperationBLO operationBLO = null;

        public FichierStockeBLO()
        {
            fichierStockeBLO = new RepositoireDAOFile<FichierStocke>();
        }

        public void AjouterFichierStocke(string nom, string fileName, Client client, Garantie garantie, StatutStockage statutStockage, Employe employe)
        {
            operationBLO = new OperationBLO();

            fichierStockeBLO.Add(new FichierStocke(new IdentifiantBLO().IdFichierStocke, DateTime.Now, nom, fileName, client, garantie, statutStockage));

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, client, new CompteClient("Indefini"), garantie.MontantEvaluation, "toto tata");

            new IdentifiantBLO().AddIdFichierStocke();
        }

        public void ModifierNomFichierStocke(FichierStocke fichierStocke, string nom, Employe employe)
        {
            operationBLO = new OperationBLO();
            FichierStocke oldFichierStocke = fichierStocke;
            fichierStocke.Nom = nom;
            fichierStockeBLO[fichierStockeBLO.IndexOf(oldFichierStocke)] = fichierStocke;

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, fichierStocke.Client, new CompteClient("Indefini"), 
                fichierStocke.Garantie.MontantEvaluation, "toto tata");
        }

        public void SupprimerFichierStocke(FichierStocke fichierStocke, Employe employe)
        {
            operationBLO = new OperationBLO();
            fichierStockeBLO.Remove(fichierStocke);

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, fichierStocke.Client, new CompteClient("Indefini"), 
                fichierStocke.Garantie.MontantEvaluation, "toto tata");
        }

        public IEnumerable<FichierStocke> RechercherLesFichierStockes(string valeur) => fichierStockeBLO.Find(x =>
            x.Nom.ToLower().Contains(valeur.ToLower()) ||
            x.StatutStockage.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.DateEnregistrement.ToString().ToLower().Contains(valeur.ToLower()));

        public IEnumerable<FichierStocke> RechercherFichierStockesClient(Client client) => fichierStockeBLO.Find(x =>
            x.Client == client);

        public IEnumerable<FichierStocke> RechercherFichierStockesGarantie(Garantie garantie) => fichierStockeBLO.Find(x =>
            x.Garantie == garantie);

        public List<FichierStocke> TousFichierStockes => fichierStockeBLO.AllItems;

    }
}
