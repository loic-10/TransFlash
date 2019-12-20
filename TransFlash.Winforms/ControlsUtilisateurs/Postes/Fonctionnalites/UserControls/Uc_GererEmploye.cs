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

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_GererEmploye : UserControl
    {

        private EmployeBLO employeBLO = null;

        private Frm_Fonction fonction = new Frm_Fonction();

        private Employe employeChef = null;

        public Uc_GererEmploye(Employe employeChef)
        {
            InitializeComponent();
            dataGridEmploye.AutoGenerateColumns = false;
            employeBLO = new EmployeBLO();
            this.employeChef = employeChef;
            Load += Uc_GererEmploye_Load;
            RefreshDataGrid(employeBLO.RechercherDesEmployes(txbRechercher.Text, checkCode.Checked, checkDateEnregistrement.Checked,
                checkDateNaissance.Checked, checkLieuNaissance.Checked, checkNomComplet.Checked, checkNomUtilisateur.Checked,
                checkNumeroCNI.Checked, checkNumeroTelephone.Checked, checkPays.Checked, checkSexe.Checked, checkStatutEmploye.Checked,
                checkVille.Checked));
        }

        private void Uc_GererEmploye_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(employeBLO.RechercherDesEmployes(txbRechercher.Text, checkCode.Checked, checkDateEnregistrement.Checked,
                checkDateNaissance.Checked, checkLieuNaissance.Checked, checkNomComplet.Checked, checkNomUtilisateur.Checked,
                checkNumeroCNI.Checked, checkNumeroTelephone.Checked, checkPays.Checked, checkSexe.Checked, checkStatutEmploye.Checked,
                checkVille.Checked));
        }

        public void RefreshDataGrid(IEnumerable<Employe> employes)
        {
            dataGridEmploye.DataSource = employes;
            fonction.DesignDataGrid(dataGridEmploye);
            lblCountItems.Text = $"{employes.Count()} employe" + ((employes.Count() > 1) ? "s" : string.Empty);
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnregistrerEmploye_Click(object sender, EventArgs e)
        {
            Uc_EnregistrerEmploye frm = new Uc_EnregistrerEmploye(this.employeChef);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnEditerEmploye_Click(object sender, EventArgs e)
        {
            Employe employe = dataGridEmploye.SelectedRows[0].DataBoundItem as Employe;
            Frm_EditerEmploye frm = new Frm_EditerEmploye(this.employeChef, employe);
            frm.ShowDialog();
        }

        private void btnEditerCompteEmploye_Click(object sender, EventArgs e)
        {
            Employe employe = dataGridEmploye.SelectedRows[0].DataBoundItem as Employe;
            Frm_EditerCompteEmploye frm = new Frm_EditerCompteEmploye(this.employeChef, employe);
            frm.ShowDialog();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            Employe employe = dataGridEmploye.SelectedRows[0].DataBoundItem as Employe;
            Frm_InformationEmploye frm = new Frm_InformationEmploye(this.employeChef, employe);
            frm.ShowDialog();
        }

        private void dataGridEmploye_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridEmploye);
            btnEditerEmploye.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridEmploye);
            btnEditerCompteEmploye.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridEmploye);
            btnInformationEmploye.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridEmploye);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string val = (dataGridEmploye.SelectedRows.Count > 1) ? "ces" : "cet";
            string nbr = (dataGridEmploye.SelectedRows.Count > 1) ? "s" : string.Empty;
            if(MessageBox.Show($"Etes-vous sur de vouloir supprimer {val} employe{nbr} ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridEmploye.SelectedRows.Count; i++)
                {
                    Employe employe = dataGridEmploye.SelectedRows[i].DataBoundItem as Employe;
                    if (employeBLO.RechercherDesEmployesMemeStatut(employe.StatutEmploye).Count() > 1)
                        employeBLO.SupprimerEmploye(employe, this.employeChef);
                    else
                        MessageBox.Show($"Vous ne pouvez pas supprimer l'employe {employe.NomComplet} car vous ne disposez que d'un seul {employe.StatutEmploye.ToString().Replace("_", " ")}", 
                            "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                RefreshDataGrid(new EmployeBLO().TousEmployes);
            }
        }

        private void txbRechercher_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(new EmployeBLO().RechercherDesEmployes(txbRechercher.Text, checkCode.Checked, checkDateEnregistrement.Checked,
                checkDateNaissance.Checked, checkLieuNaissance.Checked, checkNomComplet.Checked, checkNomUtilisateur.Checked,
                checkNumeroCNI.Checked, checkNumeroTelephone.Checked, checkPays.Checked, checkSexe.Checked, checkStatutEmploye.Checked,
                checkVille.Checked));
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
            new Frm_ReportEmploye(new EmployeBLO().RechercherDesEmployes(txbRechercher.Text, checkCode.Checked, checkDateEnregistrement.Checked,
                checkDateNaissance.Checked, checkLieuNaissance.Checked, checkNomComplet.Checked, checkNomUtilisateur.Checked,
                checkNumeroCNI.Checked, checkNumeroTelephone.Checked, checkPays.Checked, checkSexe.Checked, checkStatutEmploye.Checked,
                checkVille.Checked)).ShowDialog();
        }
    }
}
