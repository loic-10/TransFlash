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
    public partial class Uc_AccueilResponsableCompte : UserControl
    {

        private Frm_Principal principal = new Frm_Principal();

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_AccueilResponsableCompte()
        {
            InitializeComponent();
        }

        private void Uc_AccueilResponsableCompte_Load(object sender, EventArgs e)
        {
            gunaShadowPanel1.BaseColor = Color.FromArgb(150, 24, 57, 101);
        }

        private void btnGererClient_Click(object sender, EventArgs e)
        {
            //fonction.ChangerButtonActif(principal.btnGererEmpruntResponsableCompte, principal.btnAccueilResponsableCompte, principal.panelMenu);
            Uc_GererClient frm = new Uc_GererClient();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnGererCompte_Click(object sender, EventArgs e)
        {
            Uc_GererCompte frm = new Uc_GererCompte();
            fonction.AfficherPageChoisie(this, frm);
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

        private void btnGererBeneficier_Click(object sender, EventArgs e)
        {
        }
    }
}
