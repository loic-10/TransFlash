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
    public partial class Uc_GererClient : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_GererClient(Employe employe)
        {
            InitializeComponent();
            this.employe = employe;
            fonction = new Frm_Fonction();
            dataGridClient.AutoGenerateColumns = false;
            Load += Uc_GererClient_Load;
            RefreshDataGrid(new ClientBLO().RechercherDesClients(txbRechercher.Text, checkCode.Checked, checkDateEnregistrement.Checked,
                checkDateNaissance.Checked, checkLieuNaissance.Checked, checkNomComplet.Checked, checkProfession.Checked,
                checkNumeroCNI.Checked, checkNumeroTelephone.Checked, checkPays.Checked, checkSexe.Checked, checkStatutClient.Checked,
                checkVille.Checked));
        }

        private void Uc_GererClient_Load(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        public void RefreshDataGrid(IEnumerable<Client> clients)
        {
            dataGridClient.DataSource = clients;
            fonction.DesignDataGrid(dataGridClient);
            fonction.CouleurStatutClient(dataGridClient, 10);
            lblCountItems.Text = $"{clients.Count()} client" + ((clients.Count() > 1) ? "s" : string.Empty);
        }

        private void btnEnregistrerClient_Click(object sender, EventArgs e)
        {
            Uc_EnregistrerClient frm = new Uc_EnregistrerClient(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnEditerClient_Click(object sender, EventArgs e)
        {
            Client client = dataGridClient.SelectedRows[0].DataBoundItem as Client;
            Frm_EditerClient frm = new Frm_EditerClient(employe, client, this);
            frm.ShowDialog();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            Client client = dataGridClient.SelectedRows[0].DataBoundItem as Client;
            Frm_InformationClient frm = new Frm_InformationClient(employe, client, this);
            frm.ShowDialog();
        }

        public void txbRechercher_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(new ClientBLO().RechercherDesClients(txbRechercher.Text, checkCode.Checked, checkDateEnregistrement.Checked,
                checkDateNaissance.Checked, checkLieuNaissance.Checked, checkNomComplet.Checked, checkProfession.Checked,
                checkNumeroCNI.Checked, checkNumeroTelephone.Checked, checkPays.Checked, checkSexe.Checked, checkStatutClient.Checked,
                checkVille.Checked));
        }

        private void checkCode_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkNomComplet_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkDateNaissance_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkLieuNaissance_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkSexe_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkNumeroCNI_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkNumeroTelephone_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkPays_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkVille_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkProfession_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkStatutClient_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkDateEnregistrement_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void dataGridClient_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridClient);
            btnEditerClient.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridClient);
            btnInformationClient.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridClient);
        }

        private void btnExporterExcel_Click(object sender, EventArgs e)
        {
            try
            {
                fonction.ExtractionSurExcel(dataGridClient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nbr = (dataGridClient.SelectedRows.Count > 1) ? "s" : string.Empty;
            if (MessageBox.Show($"Etes-vous sur de vouloir supprimer client{nbr} ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridClient.SelectedRows.Count; i++)
                {
                    Client client = dataGridClient.SelectedRows[i].DataBoundItem as Client;
                    new ClientBLO().SupprimerClient(client, this.employe);
                }
                txbRechercher_TextChanged(sender, e);
            }
        }
    }
}
