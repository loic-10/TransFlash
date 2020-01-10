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

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_GererCredit : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_GererCredit(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            dataGridCredit.AutoGenerateColumns = false;
            this.employe = employe;
            Load += Uc_GererCredit_Load;
            RefreshDataGrid(new CreditBLO().RechercherLesCredits(txbRechercher.Text, checkCode.Checked, checkClient.Checked,
                checkDateOuvertureDossierCredit.Checked, checkDateValidationCredit.Checked, checkGarantie.Checked, checkMontantEmprunte.Checked,
                checkMontantRembourse.Checked, checkNombreMois.Checked, checkStatutCredit.Checked, checkTypeCredit.Checked));
        }

        private void Uc_GererCredit_Load(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        public void RefreshDataGrid(IEnumerable<Credit> credits)
        {
            dataGridCredit.DataSource = credits;
            fonction.DesignDataGrid(dataGridCredit);
            lblCountItems.Text = $"{credits.Count()} credit" + ((credits.Count() > 1) ? "s" : string.Empty);
        }

        private void btnInitierEmprunt_Click(object sender, EventArgs e)
        {
            Uc_InitierCredit frm = new Uc_InitierCredit(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnCompleterCredit_Click(object sender, EventArgs e)
        {
            Credit credit = dataGridCredit.SelectedRows[0].DataBoundItem as Credit;
            Uc_InitierCredit frm = new Uc_InitierCredit(this.employe, credit);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void txbRechercher_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(new CreditBLO().RechercherLesCredits(txbRechercher.Text, checkCode.Checked, checkClient.Checked,
                checkDateOuvertureDossierCredit.Checked, checkDateValidationCredit.Checked, checkGarantie.Checked, checkMontantEmprunte.Checked,
                checkMontantRembourse.Checked, checkNombreMois.Checked, checkStatutCredit.Checked, checkTypeCredit.Checked));
        }

        private void dataGridEmploye_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridCredit);
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridCredit);
            btnCompleterCredit.Enabled = fonction.SiActiveButtonPourCompleterCredit(dataGridCredit, 1, 9, 4);
            btnFinaliserCredit.Enabled = fonction.SiActiveButtonPourFinaliserCredit(dataGridCredit, 9);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nbr = (dataGridCredit.SelectedRows.Count > 1) ? "s" : string.Empty;
            if (MessageBox.Show($"Etes-vous sur de vouloir supprimer credit{nbr} ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridCredit.SelectedRows.Count; i++)
                {
                    Credit credit = dataGridCredit.SelectedRows[i].DataBoundItem as Credit;
                    new CreditBLO().SupprimerCredit(credit, this.employe);
                }
                txbRechercher_TextChanged(sender, e);
            }
        }

        private void btnExporterExcel_Click(object sender, EventArgs e)
        {
            try
            {
                fonction.ExtractionSurExcel(dataGridCredit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkCode_CheckedChanged_1(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkTypeCredit_CheckedChanged_1(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkDateOuvertureDossierCredit_CheckedChanged_1(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkDateValidationCredit_CheckedChanged_1(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkNombreMois_CheckedChanged_1(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkClient_CheckedChanged_1(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkGarantie_CheckedChanged_1(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkMontantEmprunte_CheckedChanged_1(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkMontantRembourse_CheckedChanged_1(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkStatutCredit_CheckedChanged_1(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }
    }
}
