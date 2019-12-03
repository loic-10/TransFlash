using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms;
using TransFlash.Winforms.Fonctions;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_GererClient : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_GererClient()
        {
            InitializeComponent();
        }

        private void btnEnregistrerClient_Click(object sender, EventArgs e)
        {
            Uc_EnregistrerClient frm = new Uc_EnregistrerClient();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnEditerClient_Click(object sender, EventArgs e)
        {
            Frm_EditerClient frm = new Frm_EditerClient();
            frm.ShowDialog();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            Frm_InformationClient frm = new Frm_InformationClient();
            frm.ShowDialog();
        }
    }
}
