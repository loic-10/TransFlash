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
    public class CreditBLO
    {
        private IDAL<Credit> creditBLO = null;

        public CreditBLO()
        {
            creditBLO = new RepositoireDAOFile<Credit>();
        }

        public void AjouterCredit(string codeCredit, TypeCredit typeCredit, int nombreMois, Client client, Garantie garantie,
            double montantEmprunte)
        {
            creditBLO.Add(new Credit(codeCredit, typeCredit, DateTime.Now, nombreMois, client, garantie, montantEmprunte, 
                0, StatutCredit.En_attente_de_validité));
        }

        public void ReduireMontantCredit(Credit credit, double montant)
        {
            Credit oldCredit = credit;
            credit.MontantRembourse += montant;
            creditBLO[creditBLO.IndexOf(oldCredit)] = credit;
        }

        public bool VerifierValidite(Credit credit, double montant)
        {
            if (montant > 0 && (montant + credit.MontantRembourse) <= credit.MontantEmprunte)
                return true;
            return false;
        }

        public List<Credit> CreditDuClient(TypeCredit typeCredit, Client client)
        {
            var reqCredit = from compte in TousCredits
                                  where (compte.TypeCredit == typeCredit && compte.Client == client)
                                  select compte;

            return reqCredit as List<Credit>;
        }

        public Credit RechercherLesCreditsDuCompte(Client client)
        {
            var reqCredits = from cli in TousCredits
                                 where (cli.Client == client)
                                 select cli;

            return reqCredits.FirstOrDefault();
        }

        public List<Credit> RechercherLesCredits(string valeur)
        {
            var reqCredits = creditBLO.Find(x => x.DateCredit.ToString().ToLower().Contains(valeur.ToLower()) ||
                                                                                x.StatutCredit.ToString().ToLower().Contains(valeur.ToLower()) ||
                                                                                x.TypeCredit.ToString().ToLower().Contains(valeur.ToLower()));

            return reqCredits as List<Credit>;
        }

        public void SupprimerCredit(Credit Credit)
        {
            creditBLO.Remove(Credit);
        }

        public List<Credit> TousCredits => creditBLO.AllItems;

    }
}
