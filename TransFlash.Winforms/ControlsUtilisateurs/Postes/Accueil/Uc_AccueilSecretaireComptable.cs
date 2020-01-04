using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransFlash.BO;

namespace Couche.Winforms.ControlsUtilisateurs.Accueil
{
    public partial class Uc_AccueilSecretaireComptable : UserControl
    {

        private Employe employe = null;

        Frm_Principal frmPrincipal = null;

        public Uc_AccueilSecretaireComptable(Employe employe, Frm_Principal frm_Principal)
        {
            InitializeComponent();

            this.employe = employe;
            frmPrincipal = new Frm_Principal(employe);
        }

        private void Uc_AccueilSecretaireComptable_Load(object sender, EventArgs e)
        {
            gunaShadowPanel1.BaseColor = Color.FromArgb(150, 24, 57, 101);
        }

        private void AfficherPageChoisie(UserControl userPage)
        {
            Controls.Clear();
            Controls.Add(userPage);
            userPage.Dock = DockStyle.Fill;
            userPage.BringToFront();
        }
    }
}
