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
    public class CreditBLO
    {
        private IDAL<Credit> creditBLO = null;

        public CreditBLO()
        {
            creditBLO = new RepositoireDAOFile<Credit>();
        }

        public void DemanderCredit(TypeCredit typeCredit, int nombreMois, Client client, Garantie garantie, double montantEmprunte, 
            Employe employe)
        {

            creditBLO.Add(new Credit(CodeCredit, typeCredit, DateTime.Now, null, nombreMois, client, garantie, montantEmprunte, 
                0, StatutCredit.Ouverture_du_dossier));

            new OperationBLO().AjouterOperation(TypeOperation.Credit, employe, garantie.Credit.Client, new CompteClient("/"), 
                montantEmprunte, $"Nouveau credit de type {typeCredit}, demande par le client {client}, pour un montant de {montantEmprunte}, " +
                $"ayant comme garantie #{garantie}");

            new IdentifiantBLO().AddIdCredit();
        }

        public void InitierCredit(Credit credit, Employe employe)
        {

            Credit oldCredit = credit;
            credit.StatutCredit = StatutCredit.En_attente_de_validité;
            creditBLO[creditBLO.IndexOf(oldCredit)] = credit;

            new OperationBLO().AjouterOperation(TypeOperation.Credit, employe, credit.Client, new CompteClient("/"), 
                credit.MontantEmprunte, $"Initialisation du credit ({credit}), demande par le client {credit.Client}, pour un montant de {credit.MontantEmprunte}, " +
                $"ayant comme garantie #{credit.Garantie}");
        }

        public void ValiderDemandeCredit(Credit credit, string raison, Employe employe)
        {

            Credit oldCredit = credit;
            credit.StatutCredit = StatutCredit.Programmé;
            creditBLO[creditBLO.IndexOf(oldCredit)] = credit;

            new OperationBLO().AjouterOperation(TypeOperation.Validation, employe, credit.Client, new CompteClient("/"), credit.MontantEmprunte,
                $"Validation de la demande du credit ({credit}), demande par le client {credit.Client}, pour un montant de {credit.MontantEmprunte}, " +
                $"ayant comme garantie #{credit.Garantie}, car {raison}");
        }

        public void ValiderCredit(Credit credit, CompteClient compteClient, Employe employe)
        {
            Credit oldCredit = credit;
            
            if(compteClient != null)
                new CompteClientBLO().CrediterCompteClient(compteClient, credit.MontantEmprunte, employe);

            credit.StatutCredit = StatutCredit.Non_remboursé;
            credit.DateCreditValidation = DateTime.Now;
            creditBLO[creditBLO.IndexOf(oldCredit)] = credit;

            new OperationBLO().AjouterOperation(TypeOperation.Validation, employe, credit.Client, new CompteClient("/"), 
                credit.MontantEmprunte, $"Validation du credit ({credit}), demande par le client {credit.Client}, pour un montant de {credit.MontantEmprunte}, " +
                $"ayant comme garantie #{credit.Garantie}");
        }

        public void AnnulerCredit(Credit credit, string raison, Employe employe)
        {

            Credit oldCredit = credit;
            credit.StatutCredit = StatutCredit.Annulé;
            creditBLO[creditBLO.IndexOf(oldCredit)] = credit;

            new OperationBLO().AjouterOperation(TypeOperation.Annulation, employe, credit.Client, new CompteClient("/"), 
                credit.MontantEmprunte, $"Annulation du credit ({credit}), demande par le client {credit.Client}, pour un montant de {credit.MontantEmprunte}, " +
                $"ayant comme garantie #{credit.Garantie}, car {raison}");
        }

        public void ReduireMontantCredit(Credit credit, double montant, Employe employe)
        {

            Credit oldCredit = credit;
            credit.MontantRembourse += montant;

            if (SiCreditRembourse(credit))
                credit.StatutCredit = StatutCredit.Remboursé;

            creditBLO[creditBLO.IndexOf(oldCredit)] = credit;

            new OperationBLO().AjouterOperation(TypeOperation.Remboursement, employe, credit.Client, new CompteClient("/"), montant,
                $"Reduction du montant du credit ({credit}), demande par le client {credit.Client}, pour un montant de {credit.MontantEmprunte}, " +
                $"ayant comme garantie #{credit.Garantie}");
        }

        public void DemanderDecouvert(Client client, double montantDecouvert, Employe employe)
        {

            new OperationBLO().AjouterOperation(TypeOperation.Credit, employe, client, new CompteClient("/"), 
                montantDecouvert, $"Initialisation du credit ({CodeCredit}), demande par le client {client}, pour un montant de {montantDecouvert}, " +
                $"ayant comme garantie #{new Garantie(0)}");

            DemanderCredit(TypeCredit.A_court_terme, 1, client, new Garantie(0), montantDecouvert, employe);
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

            creditBLO.Remove(credit);

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, credit.Client, new CompteClient("/"), credit.MontantEmprunte, "toto tata");
        }

        public List<Credit> TousCredits => creditBLO.AllItems;

    }
}
