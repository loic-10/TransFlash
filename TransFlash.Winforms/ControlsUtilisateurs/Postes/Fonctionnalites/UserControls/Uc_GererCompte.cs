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
using TransFlash.BLL;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_GererCompte : UserControl
    {

        private Employe employe = null;

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_GererCompte()
        {
            InitializeComponent();
        }

        private void btnAjouterCompte_Click(object sender, EventArgs e)
        {
            Uc_AjouterCompteClient frm = new Uc_AjouterCompteClient();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnEditerCompte_Click(object sender, EventArgs e)
        {
            Frm_EditerCompte frm = new Frm_EditerCompte();
            frm.ShowDialog();
        }
    }
}
