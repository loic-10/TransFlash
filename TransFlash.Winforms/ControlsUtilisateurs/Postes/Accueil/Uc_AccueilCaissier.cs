using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls;
using TransFlash.Winforms.Fonctions;

namespace Couche.Winforms.ControlsUtilisateurs.Accueil
{
    public partial class Uc_AccueilCaissier : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_AccueilCaissier()
        {
            InitializeComponent();
        }

        private void Uc_AccueilCaissier_Load_1(object sender, EventArgs e)
        {
            gunaShadowPanel1.BaseColor = Color.FromArgb(150, 24, 57, 101);

        }

        private void btnGererTransaction_Click(object sender, EventArgs e)
        {
            Uc_GererTransaction frm = new Uc_GererTransaction();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnGererEmprunt_Click(object sender, EventArgs e)
        {
            Uc_GererCredit frm = new Uc_GererCredit();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnGererRemboursement_Click(object sender, EventArgs e)
        {
            Uc_GererRemboursement frm = new Uc_GererRemboursement();
            fonction.AfficherPageChoisie(this, frm);
        }
    }
}
