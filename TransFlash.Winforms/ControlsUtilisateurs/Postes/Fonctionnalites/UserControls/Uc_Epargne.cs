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
    public partial class Uc_Epargne : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_Epargne(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            this.employe = employe;
            RefreshGrid(new EpargneBLO().RechercherLesEpargnes(txbRechercher.Text, checkIdentifiant.Checked, checkCompteClient.Checked, 
                checkDateEpargne.Checked, checkNombreMois.Checked, checkSolde.Checked, checkStatutEpargne.Checked));
            Load += Uc_Epargne_Load;
        }

        private void Uc_Epargne_Load(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        public void RefreshGrid(IEnumerable<Epargne> epargnes)
        {
            dataGridEpargne.DataSource = null;
            dataGridEpargne.DataSource = epargnes;
            fonction.DesignDataGrid(dataGridEpargne);
            lblCountItems.Text = $"{epargnes.Count()} epargne" + ((epargnes.Count() > 1) ? "s" : string.Empty);
        }

        public void txbRecherche_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(new EpargneBLO().RechercherLesEpargnes(txbRechercher.Text, checkIdentifiant.Checked, checkCompteClient.Checked,
                checkDateEpargne.Checked, checkNombreMois.Checked, checkSolde.Checked, checkStatutEpargne.Checked));
        }

        private void dataGridVille_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridEpargne);
            btnModifier.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridEpargne);
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridEpargne);
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
            Ville ville = dataGridEpargne.SelectedRows[0].DataBoundItem as Ville;
            //new Frm_GererVille(employe, this, ville).ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nbr = (dataGridEpargne.SelectedRows.Count > 1) ? "s" : string.Empty;
            if (MessageBox.Show($"Etes-vous sur de vouloir supprimer ville{nbr} ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridEpargne.SelectedRows.Count; i++)
                {
                    Ville ville = dataGridEpargne.SelectedRows[i].DataBoundItem as Ville;
                    new VilleBLO().SupprimerVille(ville, this.employe);
                }
                txbRecherche_TextChanged(sender, e);
            }
        }

        private void btnExtraireSousExcel_Click(object sender, EventArgs e)
        {
            fonction.ExtractionSurExcel(dataGridEpargne);
        }

        private void checkDateEpargne_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkNombreMois_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkSolde_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkStatutEpargne_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }
    }
}
