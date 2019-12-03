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

        public FondBLO()
        {
            fondBLO = new RepositoireDAOFile<Fond>();
            if (fondBLO.Count == 0)
                MettreArgentEnFond(0, new Employe(), TypeActionFond.Entrée, 0, "");
        }

        public void MettreArgentEnFond(int id, Employe employe, TypeActionFond typeActionFond, double montantAction,string description)
        {
            double montantTotal = (TousFonds[0].MontantTotal + montantAction);
            fondBLO.Add(new Fond(id, employe, DateTime.Now, typeActionFond, montantAction, montantTotal, description));
            RenouvellerMontantTotal(montantTotal);
        }

        public void SortirArgentEnFond(int id, Employe employe, TypeActionFond typeActionFond, double montantAction,string description)
        {
            double montantTotal = (TousFonds[0].MontantTotal - montantAction);
            fondBLO.Add(new Fond(id, employe, DateTime.Now, typeActionFond, montantAction, montantTotal, description));
            RenouvellerMontantTotal(montantTotal);
        }

        public bool VerifierPossibiliteFaireSortirArgentEnFont(double montant)
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



        public List<Fond> TousFonds => fondBLO.AllItems;

    }
}
