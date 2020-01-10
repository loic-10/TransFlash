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
using TransFlash.BO;

namespace Couche.Winforms.ControlsUtilisateurs.Accueil
{
    public partial class Uc_AccueilChefCredit : UserControl
    {

        private Frm_Principal principal = null;

        private Frm_Fonction fonction = new Frm_Fonction();

        private Employe employe = null;

        public Uc_AccueilChefCredit(Employe employe, Frm_Principal frm_Principal)
        {
            InitializeComponent();
            this.employe = employe;
            principal = new Frm_Principal(this.employe);
        }

        private void Uc_AccueilChefCredit_Load(object sender, EventArgs e)
        {
            gunaShadowPanel1.BaseColor = Color.FromArgb(150, 24, 57, 101);
        }

        private void btnGererClient_Click(object sender, EventArgs e)
        {
            //fonction.ChangerButtonActif(principal.btnGererEmpruntChefCredit, principal.btnAccueilChefCredit, principal.panelMenu);
            Uc_GererClient frm = new Uc_GererClient(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnGererCompte_Click(object sender, EventArgs e)
        {
            Uc_GererCompte frm = new Uc_GererCompte(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnGererTransaction_Click(object sender, EventArgs e)
        {
            Uc_GererTransaction frm = new Uc_GererTransaction(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnGererEmprunt_Click(object sender, EventArgs e)
        {
            Uc_GererCredit frm = new Uc_GererCredit(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnGererRemboursement_Click(object sender, EventArgs e)
        {
            Uc_GererRemboursement frm = new Uc_GererRemboursement(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnGererBeneficier_Click(object sender, EventArgs e)
        {
        }
    }
}
