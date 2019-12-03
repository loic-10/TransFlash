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
    public class ButCreditBLO
    {
        private IDAL<ButCredit> butCreditBLO = null;

        public ButCreditBLO()
        {
            butCreditBLO = new RepositoireDAOFile<ButCredit>();
        }

        public void AjouterButCredit(string nom)
        {
            butCreditBLO.Add(new ButCredit(nom));
        }

        public void ModifierButCredit(ButCredit ButCredit, string nom)
        {
            ButCredit oldButCredit = ButCredit;
            ButCredit.Nom = nom;
            butCreditBLO[butCreditBLO.IndexOf(oldButCredit)] = ButCredit;
        }

        public void SupprimerButCredit(ButCredit ButCredit)
        {
            butCreditBLO.Remove(ButCredit);
        }

        public List<ButCredit> RechercherLesButCredits(string valeur)
        {
            var reqButCredits = butCreditBLO.Find(x => x.Nom.ToLower().Contains(valeur.ToLower()));
            return reqButCredits as List<ButCredit>;
        }

        public List<ButCredit> TousButCredits => butCreditBLO.AllItems;

    }
}
