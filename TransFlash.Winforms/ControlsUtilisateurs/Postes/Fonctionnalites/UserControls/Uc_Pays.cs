using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransFlash.BO;
using TransFlash.BLL;
using TransFlash.Winforms.Fonctions;
using Guna.UI.WinForms;
using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_Pays : UserControl
    {

        private Employe employe = null;

        private Frm_Fonction fonction = null;

        public Uc_Pays(Employe employe)
        {
            InitializeComponent();
            this.employe = employe;
            fonction = new Frm_Fonction();
            RefreshGrid(new PaysBLO().RechercherPays(txbRechercher.Text, checkNom.Checked, checkCodeTelephone.Checked));
            Load += Uc_Pays_Load;
        }

        private void Uc_Pays_Load(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        public void RefreshGrid(IEnumerable<Pays> pays)
        {
            dataGridPays.DataSource = pays;
            fonction.DesignDataGrid(dataGridPays);
            lblCountItems.Text = $"{pays.Count()} pays";
        }

        private void btnExtraireSousExcel_Click(object sender, EventArgs e)
        {
            fonction.ExtractionSurExcel(dataGridPays);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            new Frm_GererPays(this.employe, this).ShowDialog();
        }

        private void dataGridPays_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridPays);
            btnModifier.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridPays);
        }

        public void txbRechercher_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(new PaysBLO().RechercherPays(txbRechercher.Text, checkNom.Checked, checkCodeTelephone.Checked));
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Pays pays = dataGridPays.SelectedRows[0].DataBoundItem as Pays;
            new Frm_GererPays(this.employe, this, pays).ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Etes-vous sur de vouloir supprimer pays ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridPays.SelectedRows.Count; i++)
                {
                    Pays pays = dataGridPays.SelectedRows[i].DataBoundItem as Pays;
                    new PaysBLO().SupprimerPays(pays, this.employe);
                }
                RefreshGrid(new PaysBLO().RechercherPays(txbRechercher.Text, checkNom.Checked, checkCodeTelephone.Checked));
            }
        }

        private void checkCodeTelephone_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkNom_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }
    }
}
