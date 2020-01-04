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
using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms;
using TransFlash.BO;
using TransFlash.BLL;
using static TransFlash.BO.Statut;
using TransFlash.Reporting;
using System.IO;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_GererTouteOperation : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_GererTouteOperation(Employe employe)
        {
            InitializeComponent();
        fonction = new Frm_Fonction();
            dataGridEmploye.AutoGenerateColumns = false;
            this.employe = employe;
            Load += Uc_GererTouteOperation_Load;
            RefreshDataGrid(new OperationBLO().RechercherLesOperations(txbRechercher.Text, checkId.Checked, checkTypeOperation.Checked,
                checkEmploye.Checked, checkDateOperation.Checked, checkCompteClient.Checked, checkValeurOperation.Checked,
                checkDescription.Checked, checkClient.Checked));
        }

        private void Uc_GererTouteOperation_Load(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
            
            //File.Open("C:\\Users\\Loic NGUEGANG\\Downloads\\WhatsApp Animated Gifs\\VID_20191225_184946.mp4", FileMode.Open, FileAccess.ReadWrite);
        }

        public void RefreshDataGrid(IEnumerable<Operation> operations)
        {
            dataGridEmploye.DataSource = operations;
            fonction.DesignDataGrid(dataGridEmploye);
            lblCountItems.Text = $"{operations.Count()} operation" + ((operations.Count() > 1) ? "s" : string.Empty);
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            //Employe employe = dataGridEmploye.SelectedRows[0].DataBoundItem as Employe;
            //Frm_InformationEmploye frm = new Frm_InformationEmploye(this.employe, employe, this);
            //frm.ShowDialog();
        }

        private void dataGridEmploye_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridEmploye);
            btnInformationEmploye.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridEmploye);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nbr = (dataGridEmploye.SelectedRows.Count > 1) ? "s" : string.Empty;
            if(MessageBox.Show($"Etes-vous sur de vouloir supprimer employe{nbr} ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridEmploye.SelectedRows.Count; i++)
                {
                    Employe employe = dataGridEmploye.SelectedRows[i].DataBoundItem as Employe;
                    if (new EmployeBLO().RechercherDesEmployesMemeStatut(employe.StatutEmploye).Count() > 1)
                        new EmployeBLO().SupprimerEmploye(employe, this.employe);
                    else
                        MessageBox.Show($"Vous ne pouvez pas supprimer l'employe {employe.NomComplet} car vous ne disposez que d'un seul {employe.StatutEmploye.ToString().Replace("_", " ")}", 
                            "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txbRechercher_TextChanged(sender, e);
            }
        }

        public void txbRechercher_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(new OperationBLO().RechercherLesOperations(txbRechercher.Text, checkId.Checked, checkTypeOperation.Checked,
                checkEmploye.Checked, checkDateOperation.Checked, checkCompteClient.Checked, checkValeurOperation.Checked,
                checkDescription.Checked, checkClient.Checked));
        }

        private void btnExporterExcel_Click(object sender, EventArgs e)
        {
            try
            {
                fonction.ExtractionSurExcel(dataGridEmploye);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void checkNomUtilisateur_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkStatutEmploye_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkDateEnregistrement_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
        }
    }
}
