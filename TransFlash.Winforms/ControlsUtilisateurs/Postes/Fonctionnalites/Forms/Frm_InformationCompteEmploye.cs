using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls;
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
    public partial class Frm_InformationCompteEmploye : Form
    {
        public Frm_InformationCompteEmploye()
        {
            InitializeComponent();
        }

        private void btnMettreAJour_Click(object sender, EventArgs e)
        {
            Close();
            Visible = false;
            Frm_EditerCompteEmploye frm = new Frm_EditerCompteEmploye();
            frm.ShowDialog();
        }
    }
}
