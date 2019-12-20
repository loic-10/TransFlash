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
    public class RemboursementBLO
    {
        private IDAL<Remboursement> remboursementBLO = null;

        private CreditBLO creditBLO = null;

        private OperationBLO operationBLO = null;

        public RemboursementBLO()
        {
            remboursementBLO = new RepositoireDAOFile<Remboursement>();
        }

        public void EffectuerRemboursement(Credit credit, double montant, Employe employe)
        {
            operationBLO = new OperationBLO();

            remboursementBLO.Add(new Remboursement(CodeRemboursement, credit, DateTime.Now, montant, 
                StatutRemboursement.En_attente_de_validité));

            operationBLO.AjouterOperation(TypeOperation.Remboursement, employe, credit.Client, new CompteClient("Indefini"), montant, "toto tata");

            new IdentifiantBLO().AddIdRemboursement();
        }

        public void ValiderRemboursement(Remboursement remboursement, Employe employe)
        {
            operationBLO = new OperationBLO();
            creditBLO = new CreditBLO();

            int index = remboursementBLO.IndexOf(remboursement);

            remboursement.StatutRemboursement = StatutRemboursement.Validé;
            remboursementBLO[index] = remboursement;

            operationBLO.AjouterOperation(TypeOperation.Validation, employe, remboursement.Credit.Client, new CompteClient("Indefini"), remboursement.Montant, "toto tata");

            creditBLO.ReduireMontantCredit(remboursement.Credit, remboursement.Montant, employe);

        }

        public string CodeRemboursement => "rem-" + new IdentifiantBLO().IdRemboursement.ToString().PadLeft(8, '0');

        public void PayerDette(Remboursement remboursement, Credit credit, double montant, Employe employe)
        {
            operationBLO = new OperationBLO();
            creditBLO = new CreditBLO();
            creditBLO.ReduireMontantCredit(credit, montant, employe);

            int index = remboursementBLO.IndexOf(remboursement);

            remboursement.StatutRemboursement = StatutRemboursement.Validé;
            remboursementBLO[index] = remboursement;

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, credit.Client, new CompteClient("Indefini"), montant, "toto tata");
        }

        public IEnumerable<Remboursement> RemboursementDuCredit(Credit credit) => remboursementBLO.Find(x => 
            x.Credit == credit);

        public IEnumerable<Remboursement> RechercherLesRemboursements(string valeur) => remboursementBLO.Find(x =>
            x.DateRemboursement.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.StatutRemboursement.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.Montant.ToString().ToLower().Contains(valeur.ToLower()));

        public void SupprimerRemboursement(Remboursement remboursement, Employe employe)
        {
            operationBLO = new OperationBLO();
            remboursementBLO.Remove(remboursement);
            operationBLO.AjouterOperation(TypeOperation.Suppression, employe, remboursement.Credit.Client, new CompteClient("Indefini"), 
                remboursement.Montant, "toto tata");
        }

        public List<Remboursement> TousRemboursements => remboursementBLO.AllItems;

    }
}
