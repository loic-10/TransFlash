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
    public class FichierStockeBLO
    {
        private IDAL<FichierStocke> fichierStockeBLO = null;

        public FichierStockeBLO()
        {
            fichierStockeBLO = new RepositoireDAOFile<FichierStocke>();
        }

        public void AjouterFichierStocke(string nom, string fileName, Client client, Garantie garantie, double montantEvaluation, StatutStockage? statutStockage, 
            Employe employe)
        {

            fichierStockeBLO.Add(new FichierStocke(new IdentifiantBLO().IdFichierStocke, DateTime.Now, nom, fileName, client, garantie, montantEvaluation, statutStockage));

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, client, new CompteClient("/"), montantEvaluation, 
                $"Ajout du fichier {new IdentifiantBLO().IdFichierStocke}");

            new IdentifiantBLO().AddIdFichierStocke();
        }

        public void ModifierNomFichierStocke(FichierStocke fichierStocke, string nom, Employe employe)
        {

            FichierStocke oldFichierStocke = fichierStocke;
            fichierStocke.Nom = nom;
            fichierStockeBLO[fichierStockeBLO.IndexOf(oldFichierStocke)] = fichierStocke;

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, fichierStocke.Client, new CompteClient("/"), 
                fichierStocke.Garantie.MontantEvaluation, $"Modification du fichier {fichierStocke + (oldFichierStocke.Nom != nom ? $" avec {oldFichierStocke.Nom} change par {nom}" : string.Empty)} " );
        }

        public void SupprimerFichierStocke(FichierStocke fichierStocke, Employe employe)
        {

            fichierStockeBLO.Remove(fichierStocke);

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, fichierStocke.Client, new CompteClient("/"), 
                fichierStocke.Garantie.MontantEvaluation, $"Suppression du fichier {fichierStocke}");
        }

        public IEnumerable<FichierStocke> RechercherLesFichierStockes(string valeur, bool checkIdentifiant, bool checkDateEnregistrement, bool checkClient, 
            bool checkGarantie, bool checkMontant, bool checkNom, bool checkNomFichier, bool checkStatutStockage) => fichierStockeBLO.Find(x =>
            (x.Id.ToString().ToLower().Contains(valeur.ToLower()) && checkIdentifiant) ||
            (x.Client.ToString().ToLower().Contains(valeur.ToLower()) && checkClient) ||
            (x.DateEnregistrement.ToString().ToLower().Contains(valeur.ToLower()) && checkDateEnregistrement) ||
            (x.FileName.ToString().ToLower().Contains(valeur.ToLower()) && checkNomFichier) ||
            (x.Garantie.ToString().ToLower().Contains(valeur.ToLower()) && checkGarantie) ||
            (x.MontantEvaluation.ToString().ToLower().Contains(valeur.ToLower()) && checkMontant) ||
            (x.Nom.ToString().ToLower().Contains(valeur.ToLower()) && checkNom) ||
            (x.StatutStockage.ToString().ToLower().Contains(valeur.ToLower()) && checkStatutStockage));

        public IEnumerable<FichierStocke> RechercherFichierStockesClient(Client client) => fichierStockeBLO.Find(x =>
            x.Client == client);

        public IEnumerable<FichierStocke> RechercherFichierStockesGarantie(Garantie garantie) => fichierStockeBLO.Find(x =>
            x.Garantie.Id == garantie.Id);

        public List<FichierStocke> TousFichierStockes => fichierStockeBLO.AllItems;

    }
}
