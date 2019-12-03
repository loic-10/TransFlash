using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couche.Winforms.ControlsUtilisateurs.Accueil
{
    public partial class Uc_AccueilSecretaireComptable : UserControl
    {

        Frm_Principal frmPrincipal = new Frm_Principal();

        public Uc_AccueilSecretaireComptable()
        {
            InitializeComponent();
        }

        private void Uc_AccueilSecretaireComptable_Load(object sender, EventArgs e)
        {
            gunaShadowPanel1.BaseColor = Color.FromArgb(150, 24, 57, 101);
        }

        private void BtnDepot_Click(object sender, EventArgs e)
        {
            Uc_AccueilChefAgence frm = new Uc_AccueilChefAgence();
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
