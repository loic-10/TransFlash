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
    public class RemboursementBLO
    {
        private IDAL<Remboursement> remboursementBLO = null;

        private CreditBLO creditBLO = null;

        public RemboursementBLO()
        {
            remboursementBLO = new RepositoireDAOFile<Remboursement>();
        }

        public void AjouterRemboursement(string codeRemboursement, Credit emprunt, double montant)
        {
            remboursementBLO.Add(new Remboursement(codeRemboursement, emprunt, DateTime.Now, montant,
            StatutRemboursement.En_attente_de_validité));
        }

        public void PayerDette(Remboursement remboursement, Credit credit, double montant)
        {
            creditBLO = new CreditBLO();
            creditBLO.ReduireMontantCredit(credit, montant);
            Remboursement oldRemboursement = remboursement;
            remboursement.StatutRemboursement = StatutRemboursement.Validé;
            remboursementBLO[remboursementBLO.IndexOf(oldRemboursement)] = remboursement;
        }

        public IEnumerable<Remboursement> RemboursementDuCredit(Credit credit) => remboursementBLO.Find(x => x.Credit == credit);

        public List<Remboursement> RechercherLesRemboursements(string valeur)
        {
            List<Remboursement> remboursements = new List<Remboursement>();
            foreach (var item in TousRemboursements)
                if (item.DateRemboursement.ToString().ToLower().Contains(valeur.ToLower()) ||
                    item.StatutRemboursement.ToString().ToLower().Contains(valeur.ToLower()) ||
                    item.Montant.ToString().ToLower().Contains(valeur.ToLower()))
                    remboursements.Add(item);

            return remboursements;
        }

        public void SupprimerRemboursement(Remboursement Remboursement)
        {
            remboursementBLO.Remove(Remboursement);
        }

        public List<Remboursement> TousRemboursements => remboursementBLO.AllItems;

    }
}
