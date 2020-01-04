using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransFlash.BLL;
using TransFlash.Winforms.Fonctions;
using TransFlash.BO;
using Guna.UI.WinForms;
using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_ButsCredits : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_ButsCredits(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            this.employe = employe;
            RefreshGrid(new ButCreditBLO().RechercherLesButCredits(txbRechercher.Text));
            Load += Uc_ButsCredits_Load;
        }

        private void Uc_ButsCredits_Load(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        public void RefreshGrid(IEnumerable<ButCredit> butCredits)
        {
            dataGridButCredit.DataSource = null;
            dataGridButCredit.DataSource = butCredits;
            fonction.DesignDataGrid(dataGridButCredit);
            lblCountItems.Text = $"{butCredits.Count()} but" + ((butCredits.Count() > 1) ? "s" : string.Empty);
        }

        public void txbRecherche_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(new ButCreditBLO().RechercherLesButCredits(txbRechercher.Text));
        }

        private void dataGridVille_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridButCredit);
            btnModifier.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridButCredit);
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridButCredit);
        }

        private void checkPays_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkNom_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //new Frm_GererVille(employe, this).ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Ville ville = dataGridButCredit.SelectedRows[0].DataBoundItem as Ville;
            //new Frm_GererVille(employe, this, ville).ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nbr = (dataGridButCredit.SelectedRows.Count > 1) ? "s" : string.Empty;
            if (MessageBox.Show($"Etes-vous sur de vouloir supprimer ville{nbr} ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridButCredit.SelectedRows.Count; i++)
                {
                    Ville ville = dataGridButCredit.SelectedRows[i].DataBoundItem as Ville;
                    new VilleBLO().SupprimerVille(ville, this.employe);
                }
                txbRecherche_TextChanged(sender, e);
            }
        }

        private void btnExtraireSousExcel_Click(object sender, EventArgs e)
        {
            fonction.ExtractionSurExcel(dataGridButCredit);
        }
    }
}
