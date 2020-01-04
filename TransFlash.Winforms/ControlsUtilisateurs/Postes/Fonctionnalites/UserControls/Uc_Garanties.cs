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
    public partial class Uc_Garanties : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_Garanties(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            this.employe = employe;
            RefreshGrid(new GarantieBLO().RechercherLesGaranties(txbRechercher.Text, checkAvaliste.Checked, checkCredit.Checked,
                checkDateEnregistrement.Checked, checkElementEnGarantie.Checked, checkId.Checked, checkNom.Checked, checkStatutGarantie.Checked,
                checkMontantEvaluation.Checked));
            Load += Uc_Garanties_Load;
        }

        private void Uc_Garanties_Load(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        public void RefreshGrid(IEnumerable<Garantie> garanties)
        {
            dataGridGarantie.DataSource = null;
            dataGridGarantie.DataSource = garanties;
            fonction.DesignDataGrid(dataGridGarantie);
            lblCountItems.Text = $"{garanties.Count()} garantie" + ((garanties.Count() > 1) ? "s" : string.Empty);
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExtraireSousExcel_Click(object sender, EventArgs e)
        {
            fonction.ExtractionSurExcel(dataGridGarantie);
        }

        private void txbRechercher_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(new GarantieBLO().RechercherLesGaranties(txbRechercher.Text, checkAvaliste.Checked, checkCredit.Checked,
                checkDateEnregistrement.Checked, checkElementEnGarantie.Checked, checkId.Checked, checkNom.Checked, checkStatutGarantie.Checked, 
                checkMontantEvaluation.Checked));
        }

        private void dataGridGarantie_SelectionChanged(object sender, EventArgs e)
        {
            btnFichiersLies.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridGarantie);
        }

        private void checkId_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkDateEnregistrement_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkCredit_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkNom_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkElementEnGarantie_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkAvaliste_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkStatutGarantie_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkMontantEvaluation_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }
    }
}
