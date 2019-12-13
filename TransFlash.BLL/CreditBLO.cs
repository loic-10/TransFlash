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

        private OperationBLO operationBLO = null;

        private CompteClientBLO compteClientBLO = null;

        public CreditBLO()
        {
            creditBLO = new RepositoireDAOFile<Credit>();
        }

        public void DemanderCredit(TypeCredit typeCredit, int nombreMois, Client client, Garantie garantie, double montantEmprunte, 
            Employe employe)
        {
            operationBLO = new OperationBLO();

            creditBLO.Add(new Credit(CodeCredit, typeCredit, DateTime.Now, null, nombreMois, client, garantie, montantEmprunte, 
                0, StatutCredit.Ouverture_du_dossier));

            operationBLO.AjouterOperation(TypeOperation.Credit, employe, garantie.Credit.Client, new CompteClient("Indefini"), montantEmprunte, "toto tata");

            new IdentifiantBLO().AddIdCredit();
        }

        public void InitierCredit(Credit credit, Employe employe)
        {
            operationBLO = new OperationBLO();
            Credit oldCredit = credit;
            credit.StatutCredit = StatutCredit.En_attente_de_validité;
            creditBLO[creditBLO.IndexOf(oldCredit)] = credit;

            operationBLO.AjouterOperation(TypeOperation.Remboursement, employe, credit.Client, new CompteClient("Indefini"), credit.MontantEmprunte, "toto tata");
        }

        public void ValiderDemandeCredit(Credit credit, string raison, Employe employe)
        {
            operationBLO = new OperationBLO();
            Credit oldCredit = credit;
            credit.StatutCredit = StatutCredit.Programmé;
            creditBLO[creditBLO.IndexOf(oldCredit)] = credit;

            operationBLO.AjouterOperation(TypeOperation.Remboursement, employe, credit.Client, new CompteClient("Indefini"), credit.MontantEmprunte, raison);
        }

        public void ValiderCredit(Credit credit, CompteClient compteClient, Employe employe)
        {
            compteClientBLO = new CompteClientBLO();
            operationBLO = new OperationBLO();
            Credit oldCredit = credit;
            
            if(compteClient != null)
                compteClientBLO.CrediterCompteClient(compteClient, credit.MontantEmprunte, employe);

            credit.StatutCredit = StatutCredit.Non_remboursé;
            credit.DateCreditValidation = DateTime.Now;
            creditBLO[creditBLO.IndexOf(oldCredit)] = credit;

            operationBLO.AjouterOperation(TypeOperation.Remboursement, employe, credit.Client, new CompteClient("Indefini"), credit.MontantEmprunte, "toto tata");
        }

        public void AnnulerCredit(Credit credit, string raison, Employe employe)
        {
            operationBLO = new OperationBLO();
            Credit oldCredit = credit;
            credit.StatutCredit = StatutCredit.Annulé;
            creditBLO[creditBLO.IndexOf(oldCredit)] = credit;

            operationBLO.AjouterOperation(TypeOperation.Remboursement, employe, credit.Client, new CompteClient("Indefini"), credit.MontantEmprunte, raison);
        }

        public void ReduireMontantCredit(Credit credit, double montant, Employe employe)
        {
            operationBLO = new OperationBLO();
            Credit oldCredit = credit;
            credit.MontantRembourse += montant;

            if (SiCreditRembourse(credit))
                credit.StatutCredit = StatutCredit.Remboursé;

            creditBLO[creditBLO.IndexOf(oldCredit)] = credit;

            operationBLO.AjouterOperation(TypeOperation.Remboursement, employe, credit.Client, new CompteClient("Indefini"), montant, "toto tata");
        }

        public bool SiCreditRembourse(Credit credit) => (credit.MontantEmprunte == credit.MontantRembourse);

        public string CodeCredit => "cre-" + new IdentifiantBLO().IdCredit.ToString().PadLeft(8, '0');

        public bool VerifierValidite(Credit credit, double montant) => (montant > 0 && (montant + credit.MontantRembourse) <= credit.MontantEmprunte);

        public IEnumerable<Credit> CreditDuClient(TypeCredit typeCredit, Client client) => creditBLO.Find(x =>
            x.TypeCredit == typeCredit &&
            x.Client == client);

        public Credit DecouvertDuClient(Client client) => creditBLO.Find(x =>
            x.TypeCredit == TypeCredit.A_court_terme &&
            x.Client == client &&
            x.MontantRembourse < x.MontantEmprunte).FirstOrDefault();

        public IEnumerable<Credit> RechercherLesCreditsDuCompte(Client client) => creditBLO.Find(x =>
            x.Client == client);

        public IEnumerable<Credit> RechercherLesCredits(string valeur) => creditBLO.Find(x => 
            x.DateCreditOuvertureDossier.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.StatutCredit.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.TypeCredit.ToString().ToLower().Contains(valeur.ToLower()));

        public void SupprimerCredit(Credit credit, Employe employe)
        {
            operationBLO = new OperationBLO();
            creditBLO.Remove(credit);

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, credit.Client, new CompteClient("Indefini"), credit.MontantEmprunte, "toto tata");
        }

        public List<Credit> TousCredits => creditBLO.AllItems;

    }
}
