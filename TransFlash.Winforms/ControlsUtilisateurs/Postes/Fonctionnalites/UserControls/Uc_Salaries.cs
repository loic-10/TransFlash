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
    public partial class Uc_Salaries : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_Salaries(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            this.employe = employe;
            RefreshGrid(new SalarieBLO().RechercherLesSalaries(txbRechercher.Text, checkCompteEmploye.Checked, 
                checkCompteEntreprise.Checked, checkDateEmbauche.Checked, checkDateEnregistrement.Checked, 
                checkDatePayementMoisEnCours.Checked, checkDatePayementProchainMois.Checked, checkIdentifiant.Checked, 
                checkMontantSalaire.Checked, checkNombreJourPourPayement.Checked, checkStatutSalarie.Checked));
            Load += Uc_Salaries_Load;
        }

        private void Uc_Salaries_Load(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        public void RefreshGrid(IEnumerable<Salarie> salaries)
        {
            dataGridSalaries.DataSource = null;
            dataGridSalaries.DataSource = salaries;
            fonction.DesignDataGrid(dataGridSalaries);
            lblCountItems.Text = $"{salaries.Count()} salarie" + ((salaries.Count() > 1) ? "s" : string.Empty);
        }

        public void txbRecherche_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(new SalarieBLO().RechercherLesSalaries(txbRechercher.Text, checkCompteEmploye.Checked,
                checkCompteEntreprise.Checked, checkDateEmbauche.Checked, checkDateEnregistrement.Checked,
                checkDatePayementMoisEnCours.Checked, checkDatePayementProchainMois.Checked, checkIdentifiant.Checked,
                checkMontantSalaire.Checked, checkNombreJourPourPayement.Checked, checkStatutSalarie.Checked));
        }

        private void dataGridVille_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridSalaries);
            btnModifier.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridSalaries);
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridSalaries);
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
            Ville ville = dataGridSalaries.SelectedRows[0].DataBoundItem as Ville;
            //new Frm_GererVille(employe, this, ville).ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nbr = (dataGridSalaries.SelectedRows.Count > 1) ? "s" : string.Empty;
            if (MessageBox.Show($"Etes-vous sur de vouloir supprimer ville{nbr} ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridSalaries.SelectedRows.Count; i++)
                {
                    Ville ville = dataGridSalaries.SelectedRows[i].DataBoundItem as Ville;
                    new VilleBLO().SupprimerVille(ville, this.employe);
                }
                txbRecherche_TextChanged(sender, e);
            }
        }

        private void btnExtraireSousExcel_Click(object sender, EventArgs e)
        {
            fonction.ExtractionSurExcel(dataGridSalaries);
        }

        private void checkCompteEntreprise_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkMontantSalaire_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkDateEmbauche_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkDateEnregistrement_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkStatutSalarie_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkDatePayementMoisEnCours_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkDatePayementProchainMois_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkNombreJourPourPayement_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }
    }
}
