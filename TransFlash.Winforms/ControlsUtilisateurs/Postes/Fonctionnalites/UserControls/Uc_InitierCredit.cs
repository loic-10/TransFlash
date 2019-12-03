using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using TransFlash.Winforms.Fonctions;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_InitierCredit : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_InitierCredit()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Uc_GererCredit frm = new Uc_GererCredit();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbChoixCompte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTypeCompte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
