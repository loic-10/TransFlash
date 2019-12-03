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

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_GererTransaction : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_GererTransaction()
        {
            InitializeComponent();
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            Uc_InitierDepot frm = new Uc_InitierDepot();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnRetrait_Click(object sender, EventArgs e)
        {
            Uc_InitierRetrait frm = new Uc_InitierRetrait();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnTransfert_Click(object sender, EventArgs e)
        {
            Uc_InitierTransfertInterCompte frm = new Uc_InitierTransfertInterCompte();
            fonction.AfficherPageChoisie(this, frm);
        }
    }
}
