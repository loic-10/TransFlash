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
    public class SalarieBLO
    {
        private IDAL<Salarie> salarieBLO = null;

        private OperationBLO operationBLO = null;

        private CreditBLO creditBLO = null;

        private TransactionBLO transactionBLO = null;

        private ParametreGeneralBLO parametreGeneralBLO = new ParametreGeneralBLO();

        public SalarieBLO()
        {
            salarieBLO = new RepositoireDAOFile<Salarie>();
        }

        public void AjouterSalarie(CompteClient compteClientEmploye, CompteClient compteClientEntreprise, double montantSalaire,
            DateTime dateEmbauche, int jourDePaye, Employe employe)
        {
            operationBLO = new OperationBLO();

            salarieBLO.Add(new Salarie(new IdentifiantBLO().IdSalarie, compteClientEmploye, compteClientEntreprise, montantSalaire, dateEmbauche,
                                            DateTime.Now, StatutSalarie.En_règle,  StatutPayementSalarie.Non_payé, jourDePaye));

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, compteClientEmploye.Client, new CompteClient("Indefini"), montantSalaire, "toto tata");

            new IdentifiantBLO().AddIdSalarie();
        }

        public void ModifierSalarie(Salarie salarie, double montantSalaire, int jourDePaye, Employe employe)
        {
            operationBLO = new OperationBLO();

            int index = salarieBLO.IndexOf(salarie);

            salarie.MontantSalaire = montantSalaire;
            salarie.JourDePaye = jourDePaye;
            salarieBLO[index] = salarie;

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, salarie.CompteClientEmploye.Client, new CompteClient("Indefini"), montantSalaire, "toto tata");
        }

        public void DemanderDecouvert(Salarie salarie, double montantDecouvert, Employe employe)
        {
            operationBLO = new OperationBLO();
            creditBLO = new CreditBLO();

            creditBLO.DemanderCredit(TypeCredit.A_court_terme, 1, salarie.CompteClientEmploye.Client, new Garantie(0), montantDecouvert, employe);

            operationBLO.AjouterOperation(TypeOperation.Credit, employe, salarie.CompteClientEmploye.Client, new CompteClient("Indefini"), 
                montantDecouvert, "toto tata");
        }

        public void ValiderDecouvert(Credit credit, Employe employe)
        {
            operationBLO = new OperationBLO();
            creditBLO = new CreditBLO();

        }

        public void RecevoirVirement(Salarie salarie, double montant, Employe employe)
        {
            transactionBLO = new TransactionBLO();
            operationBLO = new OperationBLO();
            creditBLO = new CreditBLO();

            transactionBLO.InitierTransaction(TypeCompte.Courant, TypeTransaction.Dépot, new Epargne(0), salarie.CompteClientEntreprise, salarie.CompteClientEmploye,
                employe, montant, 0);

            string codeTransaction = transactionBLO.CodeTransaction(TypeTransaction.Dépot);

            transactionBLO.ValiderTransactionCompteCourant(transactionBLO.RechercherUneTransaction(codeTransaction), employe);

            operationBLO.AjouterOperation(TypeOperation.Virement, employe, salarie.CompteClientEmploye.Client, new CompteClient("Indefini"), montant, "toto tata");

        }

        public bool VoirSiComptePossedeDecouvert(Salarie salarie)
        {
            creditBLO = new CreditBLO();
            if (creditBLO.DecouvertDuClient(salarie.CompteClientEmploye.Client) != null)
                return true;
            return false;
        }

        public double MontantMaximalDecouvert(Salarie salarie) => 
            ((salarieBLO[salarieBLO.IndexOf(salarie)].MontantSalaire) * (parametreGeneralBLO.TousParametreGenerals[0].PourcentageDecouvertMaximal/100));

        public void SupprimerSalarie(Salarie salarie, Employe employe)
        {
            operationBLO = new OperationBLO();
            salarieBLO.Remove(salarie);

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, salarie.CompteClientEmploye.Client, new CompteClient("Indefini"), salarie.MontantSalaire, "toto tata");
        }

        public IEnumerable<Salarie> RechercherSalariesCompte(CompteClient compte) => salarieBLO.Find(x => 
            x.CompteClientEmploye == compte);

        public IEnumerable<Salarie> RechercherLesSalaries(string valeur) => salarieBLO.Find(x =>
            x.CompteClientEntreprise.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.CompteClientEmploye.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.StatutPayementSalarie.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.DateEnregistrement.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.StatutSalarie.ToString().ToLower().Contains(valeur.ToLower()));

        public List<Salarie> TousSalaries => salarieBLO.AllItems;

    }
}
