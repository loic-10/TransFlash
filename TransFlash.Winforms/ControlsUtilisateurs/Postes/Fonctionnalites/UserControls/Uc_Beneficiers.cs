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
    public partial class Uc_Beneficiers : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_Beneficiers(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            this.employe = employe;
            RefreshGrid(new BeneficierBLO().RechercherLesBeneficiers(txbRechercher.Text, checkIdentifiant.Checked, checkNom.Checked,
                checkDescriptionCondition.Checked, checkPourcentage.Checked, checkCompte.Checked));
            Load += Uc_Beneficiers_Load;
        }

        private void Uc_Beneficiers_Load(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        public void RefreshGrid(IEnumerable<Beneficier> beneficiers)
        {
            dataGridBeneficier.DataSource = null;
            dataGridBeneficier.DataSource = beneficiers;
            fonction.DesignDataGrid(dataGridBeneficier);
            lblCountItems.Text = $"{beneficiers.Count()} beneficier" + ((beneficiers.Count() > 1) ? "s" : string.Empty);
        }

        private void txbRechercher_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(new BeneficierBLO().RechercherLesBeneficiers(txbRechercher.Text, checkIdentifiant.Checked, checkNom.Checked,
                checkDescriptionCondition.Checked, checkPourcentage.Checked, checkCompte.Checked));
        }

        private void checkIdentifiant_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkNom_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkDescriptionCondition_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkPourcentage_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkCompte_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void btnExtraireSousExcel_Click(object sender, EventArgs e)
        {
            fonction.ExtractionSurExcel(dataGridBeneficier);
        }

        private void dataGridBeneficier_SelectionChanged(object sender, EventArgs e)
        {
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridBeneficier);
        }
    }
}
