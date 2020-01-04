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
    public class FondBLO
    {
        private IDAL<Fond> fondBLO = null;

        public FondBLO()
        {
            fondBLO = new RepositoireDAOFile<Fond>();
            if (fondBLO.Count == 0)
                MettreArgentEnFond(new Employe("/"), new CompteClient("/"), 0, "/");
        }

        public void MettreArgentEnFond(Employe employe, CompteClient compteClient, double montantAction, string description)
        {

            double montantTotal = ((fondBLO.Count > 0 ? TousFonds[0].MontantTotal : 0 )+ montantAction);
            fondBLO.Add(new Fond(new IdentifiantBLO().IdFond, employe, compteClient, DateTime.Now, TypeActionFond.Entrée, montantAction, 
                montantTotal, description));
            RenouvellerMontantTotal(montantTotal);

            if(employe.CodeEmploye != "/")
                new OperationBLO().AjouterOperation(TypeOperation.Entrée, employe, compteClient.Client, compteClient, montantAction, description);

            new IdentifiantBLO().AddIdFond();
        }

        public void SortirArgentEnFond(Employe employe, CompteClient compteClient, double montantAction,string description)
        {

            double montantTotal = (TousFonds[0].MontantTotal - montantAction);
            fondBLO.Add(new Fond(new IdentifiantBLO().IdFond, employe, compteClient, DateTime.Now, TypeActionFond.Sortie, montantAction, montantTotal, description));
            RenouvellerMontantTotal(montantTotal);

            new OperationBLO().AjouterOperation(TypeOperation.Sortie, employe, compteClient.Client, compteClient, montantAction, description);

            new IdentifiantBLO().AddIdFond();
        }

        public bool VerifierPossibiliteFaireSortirArgentEnFond(double montant)
        {
            if (montant > 0 && TousFonds[0].MontantTotal > montant)
                return true;

            return false;
        }

        public void RenouvellerMontantTotal(double montantTotal)
        {
            foreach (var fond in new List<Fond>(TousFonds))
            {
                Fond oldfond = fond;
                fond.MontantTotal = montantTotal;
                fondBLO[fondBLO.IndexOf(oldfond)] = fond;
            }
        }

        public void SupprimerEpargne(Fond fond, Employe employe)
        {
            fondBLO.Remove(fond);
            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, fond.CompteClient.Client, fond.CompteClient, fond.MontantAction, 
                $"Suppression du fond {fond}");
        }

        public IEnumerable<Fond> RechercherFond(string valeur, bool checkIdentifiant, bool checkEmploye, bool checkCompteClient,
            bool checkDateFond, bool checkTypeActionFond, bool checkMontantAction, bool checkDescription) => fondBLO.Find(x => 
            (x.Id.ToString().ToLower().Contains(valeur.ToLower()) && checkIdentifiant) ||
            (x.Employe.ToString().ToLower().Contains(valeur.ToLower()) && checkEmploye) ||
            (x.CompteClient.ToString().ToLower().Contains(valeur.ToLower()) && checkCompteClient) ||
            (x.DateFond.ToString().ToLower().Contains(valeur.ToLower()) && checkDateFond) || 
            (x.TypeActionFond.ToString().ToLower().Contains(valeur.ToLower()) && checkTypeActionFond) ||
            (x.MontantAction.ToString().ToLower().Contains(valeur.ToLower()) && checkMontantAction) ||
            (x.Description.ToString().ToLower().Contains(valeur.ToLower()) && checkDescription));

        public double MontantTotalEnFond => TousFonds[0].MontantTotal;

        public List<Fond> TousFonds => fondBLO.AllItems;

    }
}
