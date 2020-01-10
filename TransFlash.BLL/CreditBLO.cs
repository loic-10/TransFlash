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

        public void DemanderCredit(TypeCredit typeCredit, int nombreMois, Client client, double montantEmprunte, 
            Employe employe)
        {
            Garantie garantie = new Garantie(0);
            if (typeCredit == TypeCredit.Credit_normal)
                garantie = new Garantie(new IdentifiantBLO().IdGarantie, DateTime.Now, new Credit(CodeCredit(typeCredit)), new Avaliste(0),
                    StatutGarantie.En_gage, "Aucune information", 0);

            creditBLO.Add(new Credit(CodeCredit(typeCredit), typeCredit, DateTime.Now, null, nombreMois, client, garantie, montantEmprunte, 
                0, StatutCredit.Ouverture_du_dossier));

            if (typeCredit == TypeCredit.Credit_normal)
            {
                new GarantieBLO().AjouterGarantie(RechercherCredit(CodeCredit(typeCredit)), new Avaliste(0), "Aucune information", 0, employe);
                ModifierGarantieCredit(RechercherCredit(CodeCredit(typeCredit)), new GarantieBLO().RechercherGarantie(new IdentifiantBLO().IdGarantie - 1));
            }

            new OperationBLO().AjouterOperation(TypeOperation.Credit, employe, garantie.Credit.Client, new CompteClient("/"), 
                montantEmprunte, $"Nouveau credit de type {typeCredit}, demande par le client {client}, pour un montant de {montantEmprunte}, " +
                $"ayant comme garantie #{garantie}");

            new IdentifiantBLO().AddIdCredit();
        }

        public void ModifierGarantieCredit(Credit credit, Garantie garantie)
        {

            int index = creditBLO.IndexOf(credit);

            credit.Garantie = garantie;
            
            creditBLO[index] = credit;
        }

        public void CompleterCredit(Credit credit, double montantEvaluation, Garantie garantie, int nombreMois, Avaliste avaliste, Employe employe)
        {

            int index = creditBLO.IndexOf(credit);
            new GarantieBLO().ModifierGarantie(credit.Garantie, montantEvaluation, avaliste, credit, employe);
            credit.Garantie = garantie;
            credit.NombreMois = nombreMois;
            
            creditBLO[index] = credit;
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
                montantDecouvert, $"Initialisation du credit ({CodeCredit(TypeCredit.Decouvert)}), demande par le client {client}, pour un montant de {montantDecouvert}, " +
                $"ayant comme garantie #{new Garantie(0)}");

            DemanderCredit(TypeCredit.Decouvert, 0, client, montantDecouvert, employe);
        }

        public bool SiCreditRembourse(Credit credit) => (credit.MontantEmprunte == credit.MontantRembourse);

        public string CodeCredit(TypeCredit typeCredit) =>
            (typeCredit == TypeCredit.Credit_normal ? "cre-"  : "dec-") + new IdentifiantBLO().IdCredit.ToString().PadLeft(8, '0');

        public bool VerifierValidite(Credit credit, double montant) => (montant > 0 && (montant + credit.MontantRembourse) <= credit.MontantEmprunte);

        public IEnumerable<Credit> CreditDuClient(TypeCredit typeCredit, Client client) => creditBLO.Find(x =>
            x.TypeCredit == typeCredit &&
            x.Client == client);

        public Credit DecouvertDuClient(Client client) => creditBLO.Find(x =>
            x.TypeCredit == TypeCredit.Decouvert &&
            x.Client == client &&
            x.MontantRembourse < x.MontantEmprunte).FirstOrDefault();

        public Credit RechercherCredit(string codeCredit) => creditBLO.Find(x =>
            x.CodeCredit == codeCredit).FirstOrDefault();

        public double MontantDetteClient(Client client)
        {
            double montant = 0;
            foreach (var item in new List<Credit>(new CreditBLO().TousCredits))
            {
                if (item.Client.CodeClient == client.CodeClient && item.StatutCredit == StatutCredit.Non_remboursé)
                    montant += item.MontantEmprunte;
            }
            return montant;
        }

        public IEnumerable<Credit> RechercherLesCreditsDuCompte(Client client) => creditBLO.Find(x =>
            x.Client.CodeClient == client.CodeClient);

        public IEnumerable<Credit> RechercherLesCredits(string valeur, bool checkCode, bool checkClient, bool checkDateOuvertureDossierCredit,
            bool checkDateValidationCredit, bool checkGarantie, bool checkMontantEmprunte, bool checkMontantRembourse, bool checkNombreMois,
            bool checkStatutCredit, bool checkTypeCredit) => creditBLO.Find(x =>
            (x.CodeCredit.ToString().ToLower().Contains(valeur.ToLower()) && checkCode) ||
            (x.Client.ToString().ToLower().Contains(valeur.ToLower()) && checkClient) ||
            (x.DateCreditOuvertureDossier.ToString().ToLower().Contains(valeur.ToLower()) && checkDateOuvertureDossierCredit) ||
            (x.DateCreditValidation.ToString().ToLower().Contains(valeur.ToLower()) && checkDateValidationCredit) ||
            (x.Garantie.ToString().ToLower().Contains(valeur.ToLower()) && checkGarantie) ||
            (x.MontantEmprunte.ToString().ToLower().Contains(valeur.ToLower()) && checkMontantEmprunte) ||
            (x.MontantRembourse.ToString().ToLower().Contains(valeur.ToLower()) && checkMontantRembourse) ||
            (x.NombreMois.ToString().ToLower().Contains(valeur.ToLower()) && checkNombreMois) ||
            (x.StatutCredit.ToString().ToLower().Contains(valeur.ToLower()) && checkStatutCredit) ||
            (x.TypeCredit.ToString().ToLower().Contains(valeur.ToLower()) && checkTypeCredit));

        public void SupprimerCredit(Credit credit, Employe employe)
        {

            creditBLO.Remove(credit);

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, credit.Client, new CompteClient("/"), credit.MontantEmprunte, 
                $"Suppression du {credit}");
        }

        public List<Credit> TousCredits => creditBLO.AllItems;

    }
}
