using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransFlash.BO;
using TransFlash.BLL;
using TransFlash.Winforms.Fonctions;
using Guna.UI.WinForms;
using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_Pays : UserControl
    {

        private PaysBLO paysBLO = null;

        private Employe employe = null;

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_Pays(Employe employe)
        {
            InitializeComponent();
            paysBLO = new PaysBLO();
            this.employe = employe;
            RefreshGrid(paysBLO.RechercherPays(string.Empty));
            Load += Uc_Pays_Load;
        }

        private void Uc_Pays_Load(object sender, EventArgs e)
        {
            fonction.DesignDataGrid(dataGridPays);
        }

        private void RefreshGrid(IEnumerable<Pays> pays)
        {
            dataGridPays.DataSource = pays;
            fonction.DesignDataGrid(dataGridPays);
        }

        private void btnExtraireSousExcel_Click(object sender, EventArgs e)
        {
            fonction.ExtractionSurExcel(dataGridPays);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            new Frm_GererPays(this.employe).ShowDialog();
        }

        private void dataGridPays_SelectionChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = fonction.SiActiveButtonPourPlusieursSelections(dataGridPays);
            btnModifier.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridPays);
            btnInformation.Enabled = fonction.SiActiveButtonPourUneSelection(dataGridPays);
        }
    }
}
