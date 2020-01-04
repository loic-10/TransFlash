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
using TransFlash.BO;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_GererPorteFeuille : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        private Employe employe = new Employe();

        public Uc_GererPorteFeuille(Employe employe)
        {
            InitializeComponent();
            this.employe = employe;
        }

        private void btnEnregistrerClient_Click(object sender, EventArgs e)
        {
            Uc_EnregistrerClient frm = new Uc_EnregistrerClient(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnEditerClient_Click(object sender, EventArgs e)
        {
            //Frm_EditerClient frm = new Frm_EditerClient(this.employe, ;
            //frm.ShowDialog();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            //Frm_InformationClient frm = new Frm_InformationClient();
            //frm.ShowDialog();
        }
    }
}
