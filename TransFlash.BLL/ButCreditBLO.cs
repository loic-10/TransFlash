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
    public class ButCreditBLO
    {
        private IDAL<ButCredit> butCreditBLO = null;

        public ButCreditBLO()
        {
            butCreditBLO = new RepositoireDAOFile<ButCredit>();
            if(butCreditBLO.Count == 0)
            {
                AjouterButCredit("Investissement", new Employe("/"));
                AjouterButCredit("Agriculture", new Employe("/"));
                AjouterButCredit("Elevage", new Employe("/"));
            }
        }

        public void AjouterButCredit(string nom, Employe employe)
        {

            butCreditBLO.Add(new ButCredit(nom));

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, new Client("/"), new CompteClient("/"), 0, 
                $"Ajout du but de credit {nom}");
        }

        public void SupprimerButCredit(ButCredit ButCredit, Employe employe)
        {

            butCreditBLO.Remove(ButCredit);

            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employe, new Client("/"), new CompteClient("/"), 0, 
                $"Suppression du but de credit {ButCredit.Nom}");
        }

        public IEnumerable<ButCredit> RechercherLesButCredits(string valeur) => butCreditBLO.Find(x => 
            x.Nom.ToLower().Contains(valeur.ToLower()));

        public List<ButCredit> TousButCredits => butCreditBLO.AllItems;

    }
}
