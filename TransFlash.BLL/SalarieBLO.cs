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
    public class SalarieBLO
    {
        private IDAL<Salarie> salarieBLO = null;

        public SalarieBLO()
        {
            salarieBLO = new RepositoireDAOFile<Salarie>();
        }

        public void AjouterSalarie(CompteClient compteClientEmploye, CompteClient compteClientEntreprise, double montantSalaire,
            DateTime dateEmbauche, int nombreJourPourPayement, Employe employe)
        {

            salarieBLO.Add(new Salarie(new IdentifiantBLO().IdSalarie, compteClientEmploye, compteClientEntreprise, montantSalaire,
                dateEmbauche,  DateTime.Now, StatutSalarie.En_service, null, null, nombreJourPourPayement));

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, compteClientEmploye.Client, new CompteClient("/"), 
                montantSalaire, $"Ajout du compte ({compteClientEmploye.CodeCompte}) comme salarie pour le compte ({compteClientEntreprise.CodeCompte}), " +
                $"pour un montant de salaire s'elevant a {montantSalaire}, paye apres {nombreJourPourPayement}");

            new IdentifiantBLO().AddIdSalarie();
        }

        public void ModifierSalarie(Salarie salarie, double montantSalaire, int nombreJourPourPayement, Employe employe)
        {

            int index = salarieBLO.IndexOf(salarie);

            salarie.MontantSalaire = montantSalaire;
            salarie.NombreJourPourPayement = nombreJourPourPayement;
            salarieBLO[index] = salarie;

            new OperationBLO().AjouterOperation(TypeOperation.Modification, employe, salarie.CompteClientEmploye.Client, new CompteClient("/"), 
                montantSalaire, $"Modification du compte ({salarie.CompteClientEmploye.CodeCompte}) comme salarie pour le compte " +
                $"({salarie.CompteClientEntreprise.CodeCompte}), pour un montant de salaire s'elevant a {montantSalaire}, paye apres {nombreJourPourPayement}");
        }

        public void ValiderDecouvert(Credit credit, Employe employe)
        {
            //operationBLO = new OperationBLO();
            //creditBLO = new CreditBLO();

        }

        public void RecevoirVirement(Salarie salarie, double montant, Employe employe)
        {

            new TransactionBLO().InitierTransaction(TypeCompte.Courant, TypeTransaction.Dépot, salarie.CompteClientEntreprise, salarie.CompteClientEmploye,
                employe, montant, 0);

            string codeTransaction = new TransactionBLO().CodeTransaction(TypeTransaction.Dépot);

            new TransactionBLO().ValiderTransactionCompteCourant(new TransactionBLO().RechercherUneTransaction(codeTransaction), employe);

            new OperationBLO().AjouterOperation(TypeOperation.Virement, employe, salarie.CompteClientEmploye.Client, new CompteClient("/"),
                montant, $"Virement bancaire effectue, qui debite le compte {salarie.CompteClientEntreprise} en creditant le compte " +
                $"{salarie.CompteClientEmploye} d'un montant de {montant}");

        }

        public bool VoirSiComptePossedeDecouvert(Salarie salarie)
        {
            if (new CreditBLO().DecouvertDuClient(salarie.CompteClientEmploye.Client) != null)
                return true;
            return false;
        }

        public double MontantMaximalDecouvert(Salarie salarie) => 
            ((salarieBLO[salarieBLO.IndexOf(salarie)].MontantSalaire) * (new ParametreGeneralBLO().TousParametreGenerals[0].PourcentageDecouvertMaximal/100));

        public void SupprimerSalarie(Salarie salarie, Employe employe)
        {
            salarieBLO.Remove(salarie);

            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employe, salarie.CompteClientEmploye.Client, new CompteClient("/"), 
                salarie.MontantSalaire, $"Suppression du salarie {salarie} lie au compte {salarie.CompteClientEmploye}, salarie du compte {salarie.CompteClientEntreprise}");
        }

        public IEnumerable<Salarie> RechercherSalariesCompte(CompteClient compte) => salarieBLO.Find(x => 
            x.CompteClientEmploye == compte);

        public IEnumerable<Salarie> RechercherLesSalaries(string valeur, bool checkCompteEmploye, bool checkCompteEntreprise, 
            bool checkDateEmbauche, bool checkDateEnregistrement, bool checkDatePayementMoisEnCours, 
            bool checkDatePayementProchainMois, bool checkIdentifiant, bool checkMontantSalaire, 
            bool checkNombreJourPourPayement, bool checkStatutSalarie) => salarieBLO.Find(x =>
            (x.Id.ToString().ToLower().Contains(valeur.ToLower()) && checkIdentifiant) ||
            (x.CompteClientEmploye.ToString().ToLower().Contains(valeur.ToLower()) && checkCompteEmploye) ||
            (x.CompteClientEntreprise.ToString().ToLower().Contains(valeur.ToLower()) && checkCompteEntreprise) ||
            (x.DateEmbauche.ToString().ToLower().Contains(valeur.ToLower()) && checkDateEmbauche) ||
            (x.DateEnregistrement.ToString().ToLower().Contains(valeur.ToLower()) && checkDateEnregistrement) ||
            (x.DatePayementMoisEnCours.ToString().ToLower().Contains(valeur.ToLower()) && checkDatePayementMoisEnCours) ||
            (x.DatePayementProchainMois.ToString().ToLower().Contains(valeur.ToLower()) && checkDatePayementProchainMois) ||
            (x.MontantSalaire.ToString().ToLower().Contains(valeur.ToLower()) && checkMontantSalaire) ||
            (x.NombreJourPourPayement.ToString().ToLower().Contains(valeur.ToLower()) && checkNombreJourPourPayement) ||
            (x.StatutSalarie.ToString().ToLower().Contains(valeur.ToLower()) && checkStatutSalarie));

        public List<Salarie> TousSalaries => salarieBLO.AllItems;

    }
}
