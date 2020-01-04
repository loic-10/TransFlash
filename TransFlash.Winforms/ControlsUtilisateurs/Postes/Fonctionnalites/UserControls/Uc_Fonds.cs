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
    public partial class Uc_Fonds : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_Fonds(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            this.employe = employe;
            dataGridFond.AutoGenerateColumns = false;
            RefreshGrid(new FondBLO().RechercherFond(txbRechercher.Text, checkIdentifiant.Checked, checkEmploye.Checked, 
                checkCompteClient.Checked, checkDateFond.Checked, checkTypeActionFond.Checked, checkMontantAction.Checked, 
                checkDescription.Checked));
            Load += Uc_Fonds_Load;
        }

        private void Uc_Fonds_Load(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        public void RefreshGrid(IEnumerable<Fond> fonds)
        {
            dataGridFond.DataSource = null;
            dataGridFond.DataSource = fonds;
            fonction.DesignDataGrid(dataGridFond);
            lblCountItems.Text = $"{fonds.Count()} fond" + ((fonds.Count() > 1) ? "s" : string.Empty);
            lblMontantEnFond.Text = new List<Fond>(fonds)[0].MontantTotal + " (en fond)";
        }

        private void txbRechercher_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(new FondBLO().RechercherFond(txbRechercher.Text, checkIdentifiant.Checked, checkEmploye.Checked,
                checkCompteClient.Checked, checkDateFond.Checked, checkTypeActionFond.Checked, checkMontantAction.Checked,
                checkDescription.Checked));
        }

        private void checkIdentifiant_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkEmploye_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkCompteClient_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkDateFond_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkTypeActionFond_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkMontantAction_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkDescription_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void btnExtraireSousExcel_Click(object sender, EventArgs e)
        {
            fonction.ExtractionSurExcel(dataGridFond);
        }

        private void dataGridFond_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridFond);
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridFond);
        }
    }
}
