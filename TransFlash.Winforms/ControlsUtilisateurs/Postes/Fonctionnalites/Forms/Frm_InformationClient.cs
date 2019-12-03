using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms
{
    public partial class Frm_InformationClient : Form
    {
        public Frm_InformationClient()
        {
            InitializeComponent();
        }

        private void btnMettreAJour_Click(object sender, EventArgs e)
        {
            Close();
            Visible = false;
            Frm_EditerClient frm = new Frm_EditerClient();
            frm.ShowDialog();
        }

        private void Frm_InformationClient_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void gunaLabel18_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel14_Click(object sender, EventArgs e)
        {

        }
    }
}
