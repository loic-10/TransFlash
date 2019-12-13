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

        private OperationBLO operationBLO = null;

        public ButCreditBLO()
        {
            butCreditBLO = new RepositoireDAOFile<ButCredit>();
            if(butCreditBLO.Count == 0)
            {
                AjouterButCredit("Investissement", new Employe("Indefini"));
                AjouterButCredit("Agriculture", new Employe("Indefini"));
                AjouterButCredit("Elevage", new Employe("Indefini"));
            }
        }

        public void AjouterButCredit(string nom, Employe employe)
        {
            operationBLO = new OperationBLO();
            butCreditBLO.Add(new ButCredit(nom));

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
        }

        public void SupprimerButCredit(ButCredit ButCredit, Employe employe)
        {
            operationBLO = new OperationBLO();
            butCreditBLO.Remove(ButCredit);

            operationBLO.AjouterOperation(TypeOperation.Suppression, employe, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
        }

        public IEnumerable<ButCredit> RechercherLesButCredits(string valeur) => butCreditBLO.Find(x => 
            x.Nom.ToLower().Contains(valeur.ToLower()));

        public List<ButCredit> TousButCredits => butCreditBLO.AllItems;

    }
}
