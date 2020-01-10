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
    public class RemboursementBLO
    {
        private IDAL<Remboursement> remboursementBLO = null;

        public RemboursementBLO()
        {
            remboursementBLO = new RepositoireDAOFile<Remboursement>();
        }

        public void PanifierRemboursement(Credit credit, double montant, DateTime datePrevuRemboursement, Employe employe)
        {

            remboursementBLO.Add(new Remboursement(CodeRemboursement, credit, null, datePrevuRemboursement, montant, 
                StatutRemboursement.Planifié));

            new OperationBLO().AjouterOperation(TypeOperation.Remboursement, employe, credit.Client, new CompteClient("/"), montant, 
                $"Plannification du remboursement du credit {credit}");

            new IdentifiantBLO().AddIdRemboursement();
        }

        public void ValiderRemboursement(Remboursement remboursement, Employe employe)
        {

            int index = remboursementBLO.IndexOf(remboursement);

            remboursement.StatutRemboursement = StatutRemboursement.Validé;
            remboursementBLO[index] = remboursement;

            new OperationBLO().AjouterOperation(TypeOperation.Validation, employe, remboursement.Credit.Client, new CompteClient("/"), 
                remboursement.Montant, $"Validation du remboursement {remboursement} du credit {remboursement.Credit}");

            new CreditBLO().ReduireMontantCredit(remboursement.Credit, remboursement.Montant, employe);

        }

        public string CodeRemboursement => "rem-" + new IdentifiantBLO().IdRemboursement.ToString().PadLeft(8, '0');

        public void PayerDette(Remboursement remboursement, Credit credit, double montant, Employe employe)
        {

            new CreditBLO().ReduireMontantCredit(credit, montant, employe);

            int index = remboursementBLO.IndexOf(remboursement);

            remboursement.StatutRemboursement = StatutRemboursement.Validé;
            remboursementBLO[index] = remboursement;

            new OperationBLO().AjouterOperation(TypeOperation.Payement, employe, credit.Client, new CompteClient("/"), montant,
                $"Payement du remboursement {remboursement}, du credit {credit} au montant de {montant}");
        }

        public IEnumerable<Remboursement> RemboursementDuCredit(Credit credit) => remboursementBLO.Find(x => 
            x.Credit == credit);

        public IEnumerable<Remboursement> RechercherLesRemboursements(string valeur, bool checkCode, bool checkCredit,
               bool checkDatePrevuRemboursement, bool checkDateRemboursement, bool checkMontant, bool checkStatutRemboursement) => remboursementBLO.Find(x =>
            (x.CodeRemboursement.ToString().ToLower().Contains(valeur.ToLower()) && checkCode) ||
            (x.Credit.ToString().ToLower().Contains(valeur.ToLower()) && checkCredit) ||
            (x.DatePrevuRemboursement.ToString().ToLower().Contains(valeur.ToLower()) && checkDatePrevuRemboursement) ||
            (x.DateRemboursement.ToString().ToLower().Contains(valeur.ToLower()) && checkDateRemboursement) ||
            (x.Montant.ToString().ToLower().Contains(valeur.ToLower()) && checkMontant) ||
            (x.StatutRemboursement.ToString().ToLower().Contains(valeur.ToLower()) && checkStatutRemboursement));

        public void SupprimerRemboursement(Remboursement remboursement, Employe employe)
        {
            remboursementBLO.Remove(remboursement);
            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employe, remboursement.Credit.Client, new CompteClient("/"), 
                remboursement.Montant, $"Suppression du remboursement {remboursement}");
        }

        public List<Remboursement> TousRemboursements => remboursementBLO.AllItems;

    }
}
