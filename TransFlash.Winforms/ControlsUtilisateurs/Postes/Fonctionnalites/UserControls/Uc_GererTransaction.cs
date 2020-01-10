using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransFlash.Winforms.Fonctions;
using TransFlash.BO;
using TransFlash.BLL;
using static TransFlash.BO.Statut;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_GererTransaction : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_GererTransaction(Employe employe)
        {
            InitializeComponent();
            this.employe = employe;
            fonction = new Frm_Fonction();
            dataGridTransaction.AutoGenerateColumns = false;
            Load += Uc_GererCompte_Load;
            RefreshDataGrid(new TransactionBLO().RechercherLesTransactions(txbRechercher.Text, checkCode.Checked, checkTypeCompte.Checked,
                checkCompteEmetteur.Checked, checkTypeTransaction.Checked, checkEpargne.Checked, checkDateTransaction.Checked,
                checkEmployeEmetteur.Checked, checkEmployeValideur.Checked, checkCompteDestinataire.Checked, checkMontant.Checked,
                checkStatutTransaction.Checked, checkNombreJour.Checked));
        }

        public void RefreshDataGrid(IEnumerable<Transaction> transactions)
        {
            dataGridTransaction.DataSource = transactions;
            fonction.DesignDataGrid(dataGridTransaction);
            //fonction.CouleurStatutCompte(dataGridTransaction, 6);
            lblCountItems.Text = $"{transactions.Count()} transaction" + ((transactions.Count() > 1) ? "s" : string.Empty);
        }

        private void Uc_GererCompte_Load(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            Uc_InitierDepot frm = new Uc_InitierDepot(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnRetrait_Click(object sender, EventArgs e)
        {
            Uc_InitierRetrait frm = new Uc_InitierRetrait(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnTransfert_Click(object sender, EventArgs e)
        {
            Uc_InitierTransfertInterCompte frm = new Uc_InitierTransfertInterCompte(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void txbRechercher_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(new TransactionBLO().RechercherLesTransactions(txbRechercher.Text, checkCode.Checked, checkTypeCompte.Checked,
                checkCompteEmetteur.Checked, checkTypeTransaction.Checked, checkEpargne.Checked, checkDateTransaction.Checked,
                checkEmployeEmetteur.Checked, checkEmployeValideur.Checked, checkCompteDestinataire.Checked, checkMontant.Checked,
                checkStatutTransaction.Checked, checkNombreJour.Checked));
        }

        private void checkCode_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkTypeCompte_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkTypeTransaction_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkEpargne_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkDateTransaction_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkEmployeEmetteur_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkEmployeValideur_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkCompteEmetteur_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkCompteDestinataire_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkMontant_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkStatutTransaction_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkNombreJour_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void dataGridTransaction_SelectionChanged(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            if(dataGridTransaction.SelectedRows.Count > 0)
                transaction = dataGridTransaction.SelectedRows[0].DataBoundItem as Transaction;
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridTransaction);
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridTransaction);
            btnFinaliserTransaction.Enabled = fonction.SiActiveButtonPourValiderTransaction(dataGridTransaction, 10, transaction);
            btnAnnulerTransaction.Enabled = fonction.SiActiveButtonPourAnnulerTransaction(dataGridTransaction, 10, transaction);
            btnAviserTransaction.Enabled = fonction.SiActiveButtonPourAviserTransaction(dataGridTransaction, 10, 1, 2, transaction);
        }

        private void btnFinaliserTransaction_Click(object sender, EventArgs e)
        {
            Transaction transaction = dataGridTransaction.SelectedRows[0].DataBoundItem as Transaction;
            if (transaction.TypeCompte == TypeCompte.Courant)
            {
                if (MessageBox.Show($"Etes-vous sur de vouloir finaliser {transaction.TypeTransaction.ToString()} ? \n" +
                    (transaction.CompteClientEmetteur.StatutCompte == StatutCompte.En_attente_de_validité ? 
                    $"Depuis son creation, ce compte n'a pas ete active ! (le montant d'ouverture s'eleve a " +
                    $"{new ParametreGeneralBLO().TousParametreGenerals[0].MontantDeCreationCompte})\n" : "\n") +
                    ((transaction.TypeTransaction == TypeTransaction.Retrait) ? "Vous devez payer a ce client " : "Ce client doit payer ") + transaction.Montant +
                    ((transaction.TypeTransaction == TypeTransaction.Retrait) ?
                    $" et {new CompteClientBLO().CalculFraiesRetrait(transaction.Montant)} seront debiter de ce compte comme frais." :
                    ".") + 
                    ((transaction.CompteClientEmetteur.StatutCompte == StatutCompte.En_attente_de_validité) ?
                    "Il doit payer au total " + ((transaction.TypeTransaction == TypeTransaction.Retrait) ? 
                    (transaction.Montant + new CompteClientBLO().CalculFraiesRetrait(transaction.Montant) + 
                    new ParametreGeneralBLO().TousParametreGenerals[0].MontantDeCreationCompte) : 
                    (transaction.Montant + new ParametreGeneralBLO().TousParametreGenerals[0].MontantDeCreationCompte)) :  string.Empty) ,
                    "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new TransactionBLO().ValiderTransactionCompteCourant(transaction, this.employe);
                    txbRechercher_TextChanged(sender, e);

                    fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Finalisation", $"Transaction finalise !");
                }
            }
            else
            {
                if (MessageBox.Show($"Etes-vous sur de vouloir finaliser {transaction.TypeTransaction.ToString()} ? \n" +
                    (transaction.CompteClientEmetteur.StatutCompte == StatutCompte.En_attente_de_validité ?
                    $"Depuis sa creation, ce compte n'a pas ete active ! (le montant d'ouverture s'eleve a " +
                    $"{new ParametreGeneralBLO().TousParametreGenerals[0].MontantDeCreationCompte})\n" : "\n") +
                    ((transaction.TypeTransaction == TypeTransaction.Dépot) ? "Ce client doit payer " : "Vous devez payer a ce client ")  + transaction.Montant +
                    (!new TransactionBLO().VerifierSiAvis(transaction) && transaction.TypeTransaction == TypeTransaction.Retrait ? 
                    $" et {new TransactionBLO().FraisPourSansAvis(transaction)} seront appliquer comme frais.\n" :
                    transaction.TypeTransaction == TypeTransaction.Transfert_inter_compte ? 
                    $" et {new CompteClientBLO().CalculFraiesRetraitTransfert(transaction.Montant)} seront appliquer comme frais.\n" :
                    ".\n") +
                    ((transaction.CompteClientEmetteur.StatutCompte == StatutCompte.En_attente_de_validité) ?
                    "Il doit payer au total " + ((transaction.TypeTransaction == TypeTransaction.Retrait) ?
                    (transaction.Montant + new CompteClientBLO().CalculFraiesRetrait(transaction.Montant) +
                    new ParametreGeneralBLO().TousParametreGenerals[0].MontantDeCreationCompte) :
                    (transaction.Montant + new ParametreGeneralBLO().TousParametreGenerals[0].MontantDeCreationCompte)) : string.Empty),
                    "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new TransactionBLO().ValiderTransactionCompteEpargne(transaction, this.employe);
                    txbRechercher_TextChanged(sender, e);

                    fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Finalisation", $"Transaction finalise !");
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nbr = (dataGridTransaction.SelectedRows.Count > 1) ? "s" : string.Empty;
            if (MessageBox.Show($"Etes-vous sur de vouloir supprimer transaction{nbr} ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridTransaction.SelectedRows.Count; i++)
                {
                    Transaction transaction = dataGridTransaction.SelectedRows[i].DataBoundItem as Transaction;
                    new TransactionBLO().SupprimerTransaction(transaction, this.employe);
                }
                txbRechercher_TextChanged(sender, e);
            }
        }

        private void btnAnnulerTransaction_Click(object sender, EventArgs e)
        {
            Transaction transaction = dataGridTransaction.SelectedRows[0].DataBoundItem as Transaction;
            if (MessageBox.Show($"Etes-vous sur d'annuler {transaction.TypeTransaction.ToString()} ?", "Erreur", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                new TransactionBLO().AnnulerTransaction(transaction, this.employe);
                txbRechercher_TextChanged(sender, e);
            }
        }

        private void btnAviserTransaction_Click(object sender, EventArgs e)
        {

        }

        private void btnInformation_Click(object sender, EventArgs e)
        {

        }
    }
}
