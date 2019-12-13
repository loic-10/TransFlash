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
    public class FondBLO
    {
        private IDAL<Fond> fondBLO = null;

        private OperationBLO operationBLO = null;

        public FondBLO()
        {
            fondBLO = new RepositoireDAOFile<Fond>();
            if (fondBLO.Count == 0)
                MettreArgentEnFond(new Employe(string.Empty), new CompteClient("Indefini"), 0, string.Empty);
        }

        public void MettreArgentEnFond(Employe employe, CompteClient compteClient, double montantAction,string description)
        {
            operationBLO = new OperationBLO();

            double montantTotal = (TousFonds[0].MontantTotal + montantAction);
            fondBLO.Add(new Fond(new IdentifiantBLO().IdFond, employe, compteClient, DateTime.Now, TypeActionFond.Entrée, montantAction, montantTotal, description));
            RenouvellerMontantTotal(montantTotal);

            if(employe.CodeEmploye != string.Empty)
                operationBLO.AjouterOperation(TypeOperation.Entrée, employe, compteClient.Client, compteClient, montantAction, description);

            new IdentifiantBLO().AddIdFond();
        }

        public void SortirArgentEnFond(Employe employe, CompteClient compteClient, double montantAction,string description)
        {
            operationBLO = new OperationBLO();

            double montantTotal = (TousFonds[0].MontantTotal - montantAction);
            fondBLO.Add(new Fond(new IdentifiantBLO().IdFond, employe, compteClient, DateTime.Now, TypeActionFond.Sortie, montantAction, montantTotal, description));
            RenouvellerMontantTotal(montantTotal);

            operationBLO.AjouterOperation(TypeOperation.Sortie, employe, compteClient.Client, compteClient, montantAction, description);

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
            foreach (var fond in TousFonds)
            {
                Fond oldfond = fond;
                fond.MontantTotal = montantTotal;
                fondBLO[fondBLO.IndexOf(oldfond)] = fond;
            }
        }

        public IEnumerable<Fond> RechercherFond(string valeur) => fondBLO.Find(x => 
                x.DateFond.ToString().ToLower().Contains(valeur.ToLower()) ||
                x.Description.ToString().ToLower().Contains(valeur.ToLower()) ||
                x.Employe.ToString().ToLower().Contains(valeur.ToLower()) ||
                x.MontantAction.ToString().ToLower().Contains(valeur.ToLower()) || 
                x.TypeActionFond.ToString().ToLower().Contains(valeur.ToLower()));

        public double MontantTotalEnFond => TousFonds[0].MontantTotal;

        public List<Fond> TousFonds => fondBLO.AllItems;

    }
}
