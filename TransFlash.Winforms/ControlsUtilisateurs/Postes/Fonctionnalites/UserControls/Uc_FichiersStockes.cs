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
    public partial class Uc_FichiersStockes : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_FichiersStockes(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            dataGridFichierStockes.AutoGenerateColumns = false;
            this.employe = employe;
            RefreshGrid(new FichierStockeBLO().RechercherLesFichierStockes(txbRechercher.Text, checkIdentifiant.Checked, checkDateEnregistrement.Checked, 
                checkClient.Checked, checkGarantie.Checked, checkMontant.Checked, checkNom.Checked, checkNomFichier.Checked, checkStatutStockage.Checked));
            Load += Uc_FichiersStockes_Load;
        }

        private void Uc_FichiersStockes_Load(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        public void RefreshGrid(IEnumerable<FichierStocke> fichierStockes)
        {
            dataGridFichierStockes.DataSource = null;
            dataGridFichierStockes.DataSource = fichierStockes;
            fonction.DesignDataGrid(dataGridFichierStockes);
            lblCountItems.Text = $"{fichierStockes.Count()} fichier" + ((fichierStockes.Count() > 1) ? "s" : string.Empty);
        }

        public void txbRecherche_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(new FichierStockeBLO().RechercherLesFichierStockes(txbRechercher.Text, checkIdentifiant.Checked, checkDateEnregistrement.Checked,
                checkClient.Checked, checkGarantie.Checked, checkMontant.Checked, checkNom.Checked, checkNomFichier.Checked, checkStatutStockage.Checked));
        }

        private void dataGridVille_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridFichierStockes);
            btnModifier.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridFichierStockes);
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridFichierStockes);
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
            //Ville ville = dataGridFichierStockes.SelectedRows[0].DataBoundItem as Ville;
            //new Frm_GererVille(employe, this, ville).ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nbr = (dataGridFichierStockes.SelectedRows.Count > 1) ? "s" : string.Empty;
            if (MessageBox.Show($"Etes-vous sur de vouloir supprimer ville{nbr} ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridFichierStockes.SelectedRows.Count; i++)
                {
                    Ville ville = dataGridFichierStockes.SelectedRows[i].DataBoundItem as Ville;
                    new VilleBLO().SupprimerVille(ville, this.employe);
                }
                txbRecherche_TextChanged(sender, e);
            }
        }

        private void btnExtraireSousExcel_Click(object sender, EventArgs e)
        {
            fonction.ExtractionSurExcel(dataGridFichierStockes);
        }

        private void checkNom_CheckedChanged_1(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkNomFichier_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkClient_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkGarantie_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkStatutStockage_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkMontant_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }
    }
}
