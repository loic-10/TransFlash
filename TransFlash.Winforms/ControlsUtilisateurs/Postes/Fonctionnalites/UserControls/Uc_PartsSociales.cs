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
    public partial class Uc_PartsSociales : UserControl
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        public Uc_PartsSociales(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            this.employe = employe;
            RefreshGrid(new PartSocialeBLO().RechercherLesPartSociales(txbRechercher.Text, checkStatutPartSociale.Checked, checkMontant.Checked,
                checkCompteClient.Checked));
            Load += Uc_PartsSociales_Load;
        }

        private void Uc_PartsSociales_Load(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        public void RefreshGrid(IEnumerable<PartSociale> partSociales)
        {
            dataGridPartSociale.DataSource = null;
            dataGridPartSociale.DataSource = partSociales;
            fonction.DesignDataGrid(dataGridPartSociale);
            string plus = (partSociales.Count() > 1) ? "s" : string.Empty;
            lblCountItems.Text = $"{partSociales.Count()} part{plus} sociale{plus}" ;
        }

        private void txbRechercher_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(new PartSocialeBLO().RechercherLesPartSociales(txbRechercher.Text, checkStatutPartSociale.Checked, checkMontant.Checked, 
                checkCompteClient.Checked));
        }

        private void checkCompteClient_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkMontant_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void checkStatutPartSociale_CheckedChanged(object sender, EventArgs e)
        {
            txbRechercher_TextChanged(sender, e);
        }

        private void btnExtraireSousExcel_Click(object sender, EventArgs e)
        {
            fonction.ExtractionSurExcel(dataGridPartSociale);
        }
    }
}
