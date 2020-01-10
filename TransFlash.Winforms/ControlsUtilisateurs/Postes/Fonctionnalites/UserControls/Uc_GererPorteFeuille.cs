using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms;
using TransFlash.Winforms.Fonctions;
using TransFlash.BO;
using TransFlash.BLL;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_GererPorteFeuille : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = new Employe();

        public Uc_GererPorteFeuille(Employe employe)
        {
            InitializeComponent();
            this.employe = employe;
            fonction = new Frm_Fonction();
            dataGridRemboursement.AutoGenerateColumns = false;
            dataGridCredit.AutoGenerateColumns = false;
            Load += Uc_GererPorteFeuille_Load;
            RefreshDataGridRemboursement(new RemboursementBLO().RechercherLesRemboursements(txbRechercherRemboursement.Text, 
                checkCodeRemboursement.Checked, checkCredit.Checked, checkDatePrevuRemboursement.Checked, checkDateRemboursement.Checked,
                checkMontant.Checked, checkStatutRemboursement.Checked));

            RefreshDataGridCredit(new CreditBLO().RechercherLesCredits(txbRechercherCredit.Text, checkCodeCredit.Checked, checkClient.Checked,
                checkDateOuvertureDossierCredit.Checked, checkDateValidationCredit.Checked, checkGarantie.Checked, checkMontantEmprunte.Checked,
                checkMontantRembourse.Checked, checkNombreMois.Checked, checkStatutCredit.Checked, checkTypeCredit.Checked));
        }

        private void Uc_GererPorteFeuille_Load(object sender, EventArgs e)
        {
            txbRechercherCredit_TextChanged(sender, e);
            txbRechercherRemboursement_TextChanged(sender, e);
        }

        public void RefreshDataGridCredit(IEnumerable<Credit> credits)
        {
            dataGridCredit.DataSource = credits;
            fonction.DesignDataGrid(dataGridCredit);
            lblCountItemsCredit.Text = $"{credits.Count()} credit" + ((credits.Count() > 1) ? "s" : string.Empty);
        }

        public void RefreshDataGridRemboursement(IEnumerable<Remboursement> remboursements)
        {
            dataGridRemboursement.DataSource = remboursements;
            fonction.DesignDataGrid(dataGridRemboursement);
            lblCountItemsRemboursement.Text = $"{remboursements.Count()} remboursement" + ((remboursements.Count() > 1) ? "s" : string.Empty);
        }

        private void btnEnregistrerClient_Click(object sender, EventArgs e)
        {
            Uc_EnregistrerClient frm = new Uc_EnregistrerClient(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void txbRechercherRemboursement_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGridRemboursement(new RemboursementBLO().RechercherLesRemboursements(txbRechercherRemboursement.Text,
                checkCodeRemboursement.Checked, checkCredit.Checked, checkDatePrevuRemboursement.Checked, checkDateRemboursement.Checked,
                checkMontant.Checked, checkStatutRemboursement.Checked));
        }

        private void txbRechercherCredit_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGridCredit(new CreditBLO().RechercherLesCredits(txbRechercherCredit.Text, checkCodeCredit.Checked, checkClient.Checked,
                checkDateOuvertureDossierCredit.Checked, checkDateValidationCredit.Checked, checkGarantie.Checked, checkMontantEmprunte.Checked,
                checkMontantRembourse.Checked, checkNombreMois.Checked, checkStatutCredit.Checked, checkTypeCredit.Checked));
        }

        private void checkCodeCredit_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherCredit_TextChanged(sender, e);
        }

        private void checkTypeCredit_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherCredit_TextChanged(sender, e);
        }

        private void checkDateOuvertureDossierCredit_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherCredit_TextChanged(sender, e);
        }

        private void checkDateValidationCredit_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherCredit_TextChanged(sender, e);
        }

        private void checkNombreMois_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherCredit_TextChanged(sender, e);
        }

        private void checkClient_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherCredit_TextChanged(sender, e);
        }

        private void checkGarantie_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherCredit_TextChanged(sender, e);
        }

        private void checkMontantEmprunte_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherCredit_TextChanged(sender, e);
        }

        private void checkMontantRembourse_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherCredit_TextChanged(sender, e);
        }

        private void checkStatutCredit_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherCredit_TextChanged(sender, e);
        }

        private void checkCodeRemboursement_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherRemboursement_TextChanged(sender, e);
        }

        private void checkCredit_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherRemboursement_TextChanged(sender, e);
        }

        private void checkDatePrevuRemboursement_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherRemboursement_TextChanged(sender, e);
        }

        private void checkDateRemboursement_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherRemboursement_TextChanged(sender, e);
        }

        private void checkMontant_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherRemboursement_TextChanged(sender, e);
        }

        private void checkStatutRemboursement_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercherRemboursement_TextChanged(sender, e);
        }

        private void dataGridCredit_SelectionChanged(object sender, EventArgs e)
        {
            btnTesterPossibilites.Enabled = fonction.SiActiveButtonPourTesterPossibiliteCredit(dataGridCredit, 1, 9, 4);
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridRemboursement);
        }

        private void btnTesterPossibilites_Click(object sender, EventArgs e)
        {
            Credit credit = dataGridCredit.SelectedRows[0].DataBoundItem as Credit;
            Uc_VerifierAccordCredit frm = new Uc_VerifierAccordCredit(this.employe, credit);
            fonction.AfficherPageChoisie(this, frm);
        }
    }
}
