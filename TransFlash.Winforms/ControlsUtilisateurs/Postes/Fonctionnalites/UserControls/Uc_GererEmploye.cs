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

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_GererEmploye : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_GererEmploye()
        {
            InitializeComponent();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnregistrerEmploye_Click(object sender, EventArgs e)
        {
            Uc_EnregistrerEmploye frm = new Uc_EnregistrerEmploye();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnEditerEmploye_Click(object sender, EventArgs e)
        {
            Frm_EditerEmploye frm = new Frm_EditerEmploye();
            frm.ShowDialog();
        }

        private void btnEditerCompteEmploye_Click(object sender, EventArgs e)
        {
            Frm_EditerCompteEmploye frm = new Frm_EditerCompteEmploye();
            frm.ShowDialog();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            Frm_InformationEmploye frm = new Frm_InformationEmploye();
            frm.ShowDialog();
        }

        private void btnCompteEmploye_Click(object sender, EventArgs e)
        {
            Frm_InformationCompteEmploye frm = new Frm_InformationCompteEmploye();
            frm.ShowDialog();
        }
    }
}
