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
            RefreshDataGrid(employeBLO.TousEmployes);
        }

        private void Uc_GererEmploye_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(employeBLO.TousEmployes);
        }

        private void RefreshDataGrid(IEnumerable<Employe> employes)
        {
            dataGridEmploye.DataSource = employes;
            fonction.DesignDataGrid(dataGridEmploye);
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
            Frm_EditerCompteEmploye frm = new Frm_EditerCompteEmploye();
            frm.ShowDialog();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            Employe employe = dataGridEmploye.SelectedRows[0].DataBoundItem as Employe;
            Frm_InformationEmploye frm = new Frm_InformationEmploye(this.employeChef, employe);
            frm.ShowDialog();
        }

        private void btnCompteEmploye_Click(object sender, EventArgs e)
        {
            Frm_InformationCompteEmploye frm = new Frm_InformationCompteEmploye();
            frm.ShowDialog();
        }

        private void dataGridEmploye_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridEmploye);
            btnEditerEmploye.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridEmploye);
            btnEditerCompteEmploye.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridEmploye);
            btnInformationEmploye.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridEmploye);
            btnInformationCompteEmploye.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridEmploye);
        }
    }
}
