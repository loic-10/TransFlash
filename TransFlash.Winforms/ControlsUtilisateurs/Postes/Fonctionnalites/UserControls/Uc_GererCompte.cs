using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms;
using TransFlash.Winforms.Fonctions;
using TransFlash.BO;
using TransFlash.BLL;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_GererCompte : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_GererCompte(Employe employe)
        {
            InitializeComponent();
            this.employe = employe;
            fonction = new Frm_Fonction();
            dataGridCompte.AutoGenerateColumns = false;
            Load += Uc_GererCompte_Load;
            RefreshDataGrid(new CompteClientBLO().RechercherLesCompteClients(txbRechercher.Text, checkCode.Checked, checkDateEnregistrement.Checked,
                checkClient.Checked, checkTypeCompte.Checked, checkTypeAppartenantCompteEpargne.Checked, checkNomStructure.Checked,
                checkSolde.Checked, checkStatutCompte.Checked));
        }

        private void Uc_GererCompte_Load(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        public void RefreshDataGrid(IEnumerable<CompteClient> CompteClients)
        {
            dataGridCompte.DataSource = CompteClients;
            fonction.DesignDataGrid(dataGridCompte);
            fonction.CouleurStatutCompte(dataGridCompte, 6);
            lblCountItems.Text = $"{CompteClients.Count()} compte" + ((CompteClients.Count() > 1) ? "s" : string.Empty);
        }

        private void btnAjouterCompte_Click(object sender, EventArgs e)
        {
            Uc_AjouterCompteClient frm = new Uc_AjouterCompteClient(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnEditerCompte_Click(object sender, EventArgs e)
        {
            CompteClient compteClient = dataGridCompte.SelectedRows[0].DataBoundItem as CompteClient;
            Frm_EditerCompte frm = new Frm_EditerCompte(this, compteClient, this.employe);
            frm.ShowDialog();
        }

        private void txbRechercher_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(new CompteClientBLO().RechercherLesCompteClients(txbRechercher.Text, checkCode.Checked, checkDateEnregistrement.Checked,
                checkClient.Checked, checkTypeCompte.Checked, checkTypeAppartenantCompteEpargne.Checked, checkNomStructure.Checked,
                checkSolde.Checked, checkStatutCompte.Checked));
        }

        private void checkCode_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkClient_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkTypeCompte_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkTypeAppartenantCompteEpargne_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkNomStructure_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkSolde_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkStatutCompte_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkDateEnregistrement_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {

        }

        private void btnExporterExcel_Click(object sender, EventArgs e)
        {
            try
            {
                fonction.ExtractionSurExcel(dataGridCompte);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridCompte_SelectionChanged(object sender, EventArgs e)
        {
            btnBloquer.Enabled = fonction.SiActiveButtonPourActiverCompte(dataGridCompte, 6);
            btnActiver.Enabled = fonction.SiActiveButtonPourBloquerCompte(dataGridCompte, 6);
            btnEditerCompte.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridCompte);
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridCompte);
        }
    }
}
