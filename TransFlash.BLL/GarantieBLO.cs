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

        public void AjouterGarantie(Credit credit, Avaliste avaliste, string description, double montantEvaluation, Employe employe)
        {

            garantieBLO.Add(new Garantie(new IdentifiantBLO().IdGarantie, DateTime.Now, credit, avaliste, StatutGarantie.En_gage, description, montantEvaluation));

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, credit.Client, new CompteClient("/"), montantEvaluation,
                $"Ajout de la garantie {description}");

            new IdentifiantBLO().AddIdGarantie();
        }

        public void ModifierGarantie(Garantie garantie, double montantEvaluation, Avaliste avaliste, Credit credit, Employe employe)
        {

            Garantie oldGarantie = garantie;
            garantie.MontantEvaluation = montantEvaluation;
            garantie.Avaliste = avaliste;
            garantie.Credit = credit;

            garantieBLO[garantieBLO.IndexOf(oldGarantie)] = garantie;

            new OperationBLO().AjouterOperation(TypeOperation.Modification, employe, garantie.Credit.Client, new CompteClient("/"), 
                montantEvaluation, $"Mis a jour de la garantie {garantie}");
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

        public Garantie RechercherGarantie(int id) => garantieBLO.Find(x => 
                x.Id == id).FirstOrDefault();

        public Garantie RechercherAvalise(Avaliste avaliste) => garantieBLO.Find(x => 
                x.Avaliste == avaliste).FirstOrDefault();

        public IEnumerable<Garantie> RechercherLesGaranties(string valeur, bool checkAvaliste, bool checkCredit, bool checkDateEnregistrement, 
            bool checkId, bool checkStatutGarantie, bool checkMontantEvaluation) => garantieBLO.Find(x =>
                (x.Avaliste.ToString().ToLower().Contains(valeur.ToLower()) && checkAvaliste) ||
                (x.DateEnregistrement.ToString().ToLower().Contains(valeur.ToLower()) && checkDateEnregistrement) ||
                (x.StatutGarantie.ToString().ToLower().Contains(valeur.ToLower()) && checkStatutGarantie) ||
                (x.Id.ToString().Contains(valeur.ToLower()) && checkId) ||
                (x.Credit.ToString().Contains(valeur.ToLower()) && checkCredit) ||
                (x.MontantEvaluation.ToString().Contains(valeur.ToLower()) && checkMontantEvaluation));

        public List<Garantie> TousGaranties => garantieBLO.AllItems;

    }
}
