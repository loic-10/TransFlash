using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couche.Winforms.ControlsUtilisateurs.Accueil;
using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls;
using Guna.UI.WinForms;
using TransFlash.Winforms.Fonctions;
using TransFlash.BO;

namespace Couche.Winforms
{
    public partial class Frm_Principal : Form
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        private UserControl leCorpDePage = null;

        private UserControl pageAccueil = null;

        private Employe employe = null;

        public Frm_Principal(Employe employe)
        {
            InitializeComponent();
            this.employe = employe;

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            fonction.MenuTop(panelMenuPoste);
            fonction.AnimationOuverture(panelMenu);
            fonction.AnimationIcone(btnMessage, btnNotification, btnManuelUtilisation);

            Uc_AccueilChefAgence frm = new Uc_AccueilChefAgence(this.employe);
            pageAccueil = frm;
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void BtnHidde_Click(object sender, EventArgs e)
        {
            btnView.Enabled = true;
            btnHidde.Enabled = false;
            fonction.AnimationUserControlHidde(panelMenu);
            btnHidde.Visible = false;
            btnView.Visible = true;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            btnHidde.Enabled = true;
            btnView.Enabled = false;
            fonction.AnimationUserControlHidde(panelMenu);
            btnView.Visible = false;
            btnHidde.Visible = true;
        }

        private void btnGererPorteFeuilleEntreprise_Click(object sender, EventArgs e)
        {
            //Uc_GererBeneficier frm = new Uc_GererBeneficier();
            //fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            fonction.AfficheCorp(pageAccueil, panelCorps, leCorpDePage);
        }

        private void btnGererEmprunt_Click(object sender, EventArgs e)
        {
            Uc_GererCredit frm = new Uc_GererCredit();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGererRemboursement_Click(object sender, EventArgs e)
        {
            Uc_GererRemboursement frm = new Uc_GererRemboursement();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGererTransaction_Click(object sender, EventArgs e)
        {
            Uc_GererTransaction frm = new Uc_GererTransaction();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGererClient_Click(object sender, EventArgs e)
        {
            Uc_GererClient frm = new Uc_GererClient(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGererCompte_Click(object sender, EventArgs e)
        {
            Uc_GererCompte frm = new Uc_GererCompte();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGererEmployes_Click(object sender, EventArgs e)
        {
            Uc_GererEmploye frm = new Uc_GererEmploye(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGererPorteFeuilleCaisse_Click(object sender, EventArgs e)
        {
            //Uc_GererBeneficier frm = new Uc_GererBeneficier();
            //fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void gererPorteFeuilleCredit_Click(object sender, EventArgs e)
        {
            //Uc_GererBeneficier frm = new Uc_GererBeneficier();
            //fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnPlusEncore_Click(object sender, EventArgs e)
        {
            Uc_PlusEncore frm = new Uc_PlusEncore();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gunaTransition1.HideSync(panelLogo);
            gunaTransition1.ShowSync(panelLogo);
            gunaTransition2.HideSync(btnParametre);
            gunaTransition2.ShowSync(btnParametre);
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            System.Threading.Thread.Sleep(1000);
            Application.Exit();
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
