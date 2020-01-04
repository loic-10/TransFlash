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
    public partial class Uc_Avalistes : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_Avalistes(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            this.employe = employe;
            RefreshGrid(new AvalisteBLO().RechercherLesAvalistes(txbRechercher.Text, checkIdentifiant.Checked, checkGarantie.Checked, 
                checkMontantParMois.Checked, checkNomComplet.Checked, checkProfession.Checked, checkDescription.Checked));
            Load += Uc_Avalistes_Load;
        }

        private void Uc_Avalistes_Load(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        public void RefreshGrid(IEnumerable<Avaliste> avalistes)
        {
            dataGridAvaliste.DataSource = null;
            dataGridAvaliste.DataSource = avalistes;
            fonction.DesignDataGrid(dataGridAvaliste);
            lblCountItems.Text = $"{avalistes.Count()} avaliste" + ((avalistes.Count() > 1) ? "s" : string.Empty);
        }

        public void txbRecherche_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(new AvalisteBLO().RechercherLesAvalistes(txbRechercher.Text, checkIdentifiant.Checked, checkGarantie.Checked,
                checkMontantParMois.Checked, checkNomComplet.Checked, checkProfession.Checked, checkDescription.Checked));
        }

        private void dataGridVille_SelectionChanged(object sender, EventArgs e)
        {
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridAvaliste);
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
            Ville ville = dataGridAvaliste.SelectedRows[0].DataBoundItem as Ville;
            //new Frm_GererVille(employe, this, ville).ShowDialog();
        }

        private void btnExtraireSousExcel_Click(object sender, EventArgs e)
        {
            fonction.ExtractionSurExcel(dataGridAvaliste);
        }

        private void checkNomComplet_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkProfession_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkDescription_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }

        private void checkMontantParMois_CheckedChanged(object sender, EventArgs e)
        {
            txbRecherche_TextChanged(sender, e);
        }
    }
}
