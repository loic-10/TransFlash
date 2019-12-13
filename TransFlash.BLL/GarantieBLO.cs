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
    public class GarantieBLO
    {
        private IDAL<Garantie> garantieBLO = null;

        private OperationBLO operationBLO = null;

        private FichierStockeBLO fichierStockeBLO = null;

        public GarantieBLO()
        {
            garantieBLO = new RepositoireDAOFile<Garantie>();
        }

        public void AjouterGarantie(Credit credit, string nom, string elementEnGarantie, Avaliste avaliste, string description, double montantEvaluation, Employe employe)
        {
            operationBLO = new OperationBLO();

            fichierStockeBLO = new FichierStockeBLO();

            garantieBLO.Add(new Garantie(new IdentifiantBLO().IdGarantie, DateTime.Now, credit, nom, elementEnGarantie, avaliste, StatutGarantie.En_gage, description, montantEvaluation));

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, credit.Client, new CompteClient("Indefini"), montantEvaluation, description);

            if (elementEnGarantie != string.Empty)
            {
                fichierStockeBLO.AjouterFichierStocke($"Garantie {nom}", elementEnGarantie, credit.Client, RechercherCredit(new IdentifiantBLO().IdGarantie),
                    StatutStockage.Garantie, employe);
            }

            new IdentifiantBLO().AddIdGarantie();
        }

        public void LibererGarantie(Garantie garantie, Employe employe)
        {
            operationBLO = new OperationBLO();
            Garantie oldGarantie = garantie;
            garantie.StatutGarantie = StatutGarantie.Retourné;

            garantieBLO[garantieBLO.IndexOf(oldGarantie)] = garantie;

            operationBLO.AjouterOperation(TypeOperation.Retour_de_garantie, employe, garantie.Credit.Client, new CompteClient("Indefini"), 
                garantie.MontantEvaluation, "Credit rembourse");
        }

        public void SupprimerGarantie(Garantie garantie, Employe employe)
        {
            operationBLO = new OperationBLO();

            garantieBLO.Remove(garantie);

            operationBLO.AjouterOperation(TypeOperation.Suppression, employe, garantie.Credit.Client, new CompteClient("Indefini"), 
                garantie.MontantEvaluation, "Plus important");
        }

        public IEnumerable<Garantie> RechercherGarantiesCredit(Credit credit) => garantieBLO.Find(x => 
                x.Credit == credit);

        public Garantie RechercherCredit(int id) => garantieBLO.Find(x => 
                x.Id == id).FirstOrDefault();

        public Garantie RechercherAvalise(Avaliste avaliste) => garantieBLO.Find(x => 
                x.Avaliste == avaliste).FirstOrDefault();

        public IEnumerable<Garantie> RechercherLesGaranties(string valeur) => garantieBLO.Find(x =>
                x.Avaliste.ToString().ToLower().Contains(valeur.ToLower()) ||
                x.DateEnregistrement.ToString().ToLower().Contains(valeur.ToLower()) ||
                x.StatutGarantie.ToString().ToLower().Contains(valeur.ToLower()) ||
                x.Nom.ToString().Contains(valeur.ToLower()) ||
                x.Credit.ToString().Contains(valeur.ToLower()) ||
                x.Description.ToString().Contains(valeur.ToLower()) ||
                x.MontantEvaluation.ToString().Contains(valeur.ToLower()));

        public List<Garantie> TousGaranties => garantieBLO.AllItems;

    }
}
