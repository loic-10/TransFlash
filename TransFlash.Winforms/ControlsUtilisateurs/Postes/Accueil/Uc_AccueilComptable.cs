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
    public partial class Uc_AccueilComptable : UserControl
    {

        private Employe employe = null;

        private Frm_Principal frmPrincipal = null;

        public Uc_AccueilComptable(Employe employe)
        {
            InitializeComponent();
            this.employe = employe;

            frmPrincipal = new Frm_Principal(this.employe);
        }

        private void Uc_AccueilComptable_Load(object sender, EventArgs e)
        {
            gunaShadowPanel1.BaseColor = Color.FromArgb(150, 24, 57, 101);
        }

        private void BtnDepot_Click(object sender, EventArgs e)
        {
            Uc_AccueilChefAgence frm = new Uc_AccueilChefAgence(this.employe);
            AfficherPageChoisie(frm);
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
