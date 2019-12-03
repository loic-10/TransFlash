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
    public partial class Uc_GererRemboursement : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_GererRemboursement()
        {
            InitializeComponent();
        }

        private void btnInitierRemboursement_Click(object sender, EventArgs e)
        {
            Uc_InitierRemboursement frm = new Uc_InitierRemboursement();
            fonction.AfficherPageChoisie(this, frm);
        }
    }
}
