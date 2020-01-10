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
    public partial class Uc_GererRemboursement : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_GererRemboursement(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            dataGridRemboursement.AutoGenerateColumns = false;
            this.employe = employe;
            Load += Uc_GererRemboursement_Load;
            RefreshDataGrid(new RemboursementBLO().RechercherLesRemboursements(txbRechercher.Text, checkCode.Checked, checkCredit.Checked, 
                checkDatePrevuRemboursement.Checked, checkDateRemboursement.Checked, checkMontant.Checked, checkStatutRemboursement.Checked));
        }

        private void Uc_GererRemboursement_Load(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        public void RefreshDataGrid(IEnumerable<Remboursement> remboursements)
        {
            dataGridRemboursement.DataSource = remboursements;
            fonction.DesignDataGrid(dataGridRemboursement);
            lblCountItems.Text = $"{remboursements.Count()} remboursement" + ((remboursements.Count() > 1) ? "s" : string.Empty);
        }

        private void btnInitierRemboursement_Click(object sender, EventArgs e)
        {
            Uc_InitierRemboursement frm = new Uc_InitierRemboursement();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void dataGridCredit_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridRemboursement);
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridRemboursement);
        }

        private void txbRechercher_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(new RemboursementBLO().RechercherLesRemboursements(txbRechercher.Text, checkCode.Checked, checkCredit.Checked,
               checkDatePrevuRemboursement.Checked, checkDateRemboursement.Checked, checkMontant.Checked, checkStatutRemboursement.Checked));
        }

        private void checkCode_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkCredit_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkDateRemboursement_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkMontant_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkStatutRemboursement_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void btnExporterExcel_Click(object sender, EventArgs e)
        {
            try
            {
                fonction.ExtractionSurExcel(dataGridRemboursement);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nbr = (dataGridRemboursement.SelectedRows.Count > 1) ? "s" : string.Empty;
            if (MessageBox.Show($"Etes-vous sur de vouloir supprimer remboursement{nbr} ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridRemboursement.SelectedRows.Count; i++)
                {
                    Remboursement remboursement = dataGridRemboursement.SelectedRows[i].DataBoundItem as Remboursement;
                    new RemboursementBLO().SupprimerRemboursement(remboursement, this.employe);
                }
                txbRechercher_TextChanged(sender, e);
            }
        }
    }
}
