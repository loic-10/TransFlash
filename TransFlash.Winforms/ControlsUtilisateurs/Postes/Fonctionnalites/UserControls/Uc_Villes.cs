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
    public partial class Uc_Villes : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_Villes(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            this.employe = employe;
            RefreshGrid(new VilleBLO().RechercherLesVilles(txbRechercher.Text, checkNom.Checked, checkPays.Checked));
            Load += Uc_Villes_Load;
        }

        private void Uc_Villes_Load(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        public void RefreshGrid(IEnumerable<Ville> villes)
        {
            dataGridVille.DataSource = null;
            dataGridVille.DataSource = villes;
            fonction.DesignDataGrid(dataGridVille);
            lblCountItems.Text = $"{villes.Count()} ville" + ((villes.Count() > 1) ? "s" : string.Empty);
        }

        public void txbRecherche_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(new VilleBLO().RechercherLesVilles(txbRechercher.Text, checkNom.Checked, checkPays.Checked));
        }

        private void dataGridVille_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridVille);
            btnModifier.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridVille);
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridVille);
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
            new Frm_GererVille(employe, this).ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Ville ville = dataGridVille.SelectedRows[0].DataBoundItem as Ville;
            new Frm_GererVille(employe, this, ville).ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nbr = (dataGridVille.SelectedRows.Count > 1) ? "s" : string.Empty;
            if (MessageBox.Show($"Etes-vous sur de vouloir supprimer ville{nbr} ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridVille.SelectedRows.Count; i++)
                {
                    Ville ville = dataGridVille.SelectedRows[i].DataBoundItem as Ville;
                    new VilleBLO().SupprimerVille(ville, this.employe);
                }
                txbRecherche_TextChanged(sender, e);
            }
        }

        private void btnExtraireSousExcel_Click(object sender, EventArgs e)
        {
            fonction.ExtractionSurExcel(dataGridVille);
        }
    }
}
