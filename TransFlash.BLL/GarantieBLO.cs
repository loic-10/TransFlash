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
    public class GarantieBLO
    {
        private IDAL<Garantie> garantieBLO = null;

        public GarantieBLO()
        {
            garantieBLO = new RepositoireDAOFile<Garantie>();
        }

        public void AjouterGarantie(Credit credit, string nom, string elementEnGarantie, Avaliste avaliste, string description, double montantEvaluation, Employe employe)
        {

            garantieBLO.Add(new Garantie(new IdentifiantBLO().IdGarantie, DateTime.Now, credit, nom, elementEnGarantie, avaliste, StatutGarantie.En_gage, description, montantEvaluation));

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, credit.Client, new CompteClient("/"), montantEvaluation,
                $"Ajout de la garantie {description}");

            if (elementEnGarantie != string.Empty)
            {
                new FichierStockeBLO().AjouterFichierStocke($"Garantie {nom}", elementEnGarantie, credit.Client, RechercherCredit(new IdentifiantBLO().IdGarantie),
                    StatutStockage.Garantie, employe);
            }

            new IdentifiantBLO().AddIdGarantie();
        }

        public void LibererGarantie(Garantie garantie, Employe employe)
        {

            Garantie oldGarantie = garantie;
            garantie.StatutGarantie = StatutGarantie.Retourné;

            garantieBLO[garantieBLO.IndexOf(oldGarantie)] = garantie;

            new OperationBLO().AjouterOperation(TypeOperation.Retour_de_garantie, employe, garantie.Credit.Client, new CompteClient("/"), 
                garantie.MontantEvaluation, $"Liberation de la garantie {garantie}");
        }

        public void SupprimerGarantie(Garantie garantie, Employe employe)
        {

            garantieBLO.Remove(garantie);

            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employe, garantie.Credit.Client, new CompteClient("/"), 
                garantie.MontantEvaluation, $"Suppression de la garantie {garantie}");
        }

        public IEnumerable<Garantie> RechercherGarantiesCredit(Credit credit) => garantieBLO.Find(x => 
                x.Credit == credit);

        public Garantie RechercherCredit(int id) => garantieBLO.Find(x => 
                x.Id == id).FirstOrDefault();

        public Garantie RechercherAvalise(Avaliste avaliste) => garantieBLO.Find(x => 
                x.Avaliste == avaliste).FirstOrDefault();

        public IEnumerable<Garantie> RechercherLesGaranties(string valeur, bool checkAvaliste, bool checkCredit, bool checkDateEnregistrement, 
                bool checkElementEnGarantie, bool checkId, bool checkNom, bool checkStatutGarantie, bool checkMontantEvaluation) => garantieBLO.Find(x =>
                (x.Avaliste.ToString().ToLower().Contains(valeur.ToLower()) && checkAvaliste) ||
                (x.DateEnregistrement.ToString().ToLower().Contains(valeur.ToLower()) && checkDateEnregistrement) ||
                (x.StatutGarantie.ToString().ToLower().Contains(valeur.ToLower()) && checkStatutGarantie) ||
                (x.Nom.ToString().Contains(valeur.ToLower()) && checkNom) ||
                (x.Id.ToString().Contains(valeur.ToLower()) && checkId) ||
                (x.Credit.ToString().Contains(valeur.ToLower()) && checkCredit) ||
                (x.ElementEnGarantie.ToString().Contains(valeur.ToLower()) && checkElementEnGarantie) ||
                (x.MontantEvaluation.ToString().Contains(valeur.ToLower()) && checkMontantEvaluation));

        public List<Garantie> TousGaranties => garantieBLO.AllItems;

    }
}
