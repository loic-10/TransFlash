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
    public partial class Uc_InitierDepot : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_InitierDepot()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Uc_GererTransaction frm = new Uc_GererTransaction();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void txbRecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
