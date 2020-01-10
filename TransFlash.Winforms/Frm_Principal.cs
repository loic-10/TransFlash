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
using static TransFlash.BO.Statut;

namespace Couche.Winforms
{
    public partial class Frm_Principal : Form
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        private UserControl leCorpDePage = null;

        private Employe employe = null;

        private Timer timer10 = null;

        private Timer timer20 = null;

        private GunaTransition gunaTransition1 = null;

        private GunaTransition gunaTransition2 = null;

        public Frm_Principal(Employe employe)
        {
            InitializeComponent();

            gunaTransition1 = new GunaTransition()
            {
                AnimationType = Guna.UI.Animation.AnimationType.Transparent,
                Interval = 10,
                MaxAnimationTime = 1500,
                TimeStep = 0.02f
            };

            gunaTransition2 = new GunaTransition()
            {
                AnimationType = Guna.UI.Animation.AnimationType.ScaleAndRotate,
                Interval = 10,
                MaxAnimationTime = 1500,
                TimeStep = 0.02f
            };

            timer10 = new Timer()
            {
                Interval = 5000,
                Enabled = true
            };

            timer20 = new Timer()
            {
                Interval = 1000,
                Enabled = true
            };

            timer10.Tick += Timer10_Tick1;

            timer20.Tick += Timer20_Tick;

            this.employe = employe;

            DebutProgramme(this.employe);

            Load += Frm_Principal_Load;
        }

        private void Timer20_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        private void Timer10_Tick1(object sender, EventArgs e)
        {
            try
            {
                gunaTransition1.ClearQueue();
                gunaTransition2.ClearQueue();
                gunaTransition1.HideSync(panelLogo);
                gunaTransition1.ShowSync(panelLogo);
                gunaTransition2.HideSync(btnParametre);
                gunaTransition2.ShowSync(btnParametre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ParametreArretTimer(Timer timer1, Timer timer2)
        {
            timer1.Enabled = false;
            timer1.Enabled = false;
        }

        private void Timer10_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            fonction.MenuTop(panelMenuPoste);
            fonction.AnimationOuverture(panelMenu);
            fonction.AnimationIcone(btnMessage, btnNotification, btnManuelUtilisation);

            fonction.AfficheCorp(VoirAccueilEmploye(this.employe) as UserControl, panelCorps, leCorpDePage);
        }

        public Control VoirAccueilEmploye(Employe employe) =>
            (employe.StatutEmploye == StatutEmploye.Caissier) ? new Control() :
            (employe.StatutEmploye == StatutEmploye.Secretaire_Comptable) ? new Uc_AccueilSecretaireComptable(employe, this) :
            (employe.StatutEmploye == StatutEmploye.Chef_Agence) ? new Uc_AccueilChefAgence(employe, this) :
            (employe.StatutEmploye == StatutEmploye.Chef_Credit) ? new Uc_AccueilChefCredit(employe, this) :
            (employe.StatutEmploye == StatutEmploye.Comptable) ? new Uc_AccueilComptable(employe, this) : 
            new Control();


        public void DebutProgramme(Employe employe)
        {
            if (employe.PhotoProfil != string.Empty)
                pbProfil.Image = Image.FromFile(employe.PhotoProfil);
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
            fonction.AfficheCorp(VoirAccueilEmploye(this.employe) as UserControl, panelCorps, leCorpDePage);
        }

        private void btnGererEmprunt_Click(object sender, EventArgs e)
        {
            Uc_GererCredit frm = new Uc_GererCredit(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGererRemboursement_Click(object sender, EventArgs e)
        {
            Uc_GererRemboursement frm = new Uc_GererRemboursement(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGererTransaction_Click(object sender, EventArgs e)
        {
            Uc_GererTransaction frm = new Uc_GererTransaction(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGererClient_Click(object sender, EventArgs e)
        {
            Uc_GererClient frm = new Uc_GererClient(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGererCompte_Click(object sender, EventArgs e)
        {
            Uc_GererCompte frm = new Uc_GererCompte(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGererEmployes_Click(object sender, EventArgs e)
        {
            Uc_GererEmploye frm = new Uc_GererEmploye(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGererTouteOperation_Click(object sender, EventArgs e)
        {
            Uc_GererTouteOperation frm = new Uc_GererTouteOperation(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void gererPorteFeuilleCredit_Click(object sender, EventArgs e)
        {
            Uc_GererPorteFeuille frm = new Uc_GererPorteFeuille(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnPlusEncore_Click(object sender, EventArgs e)
        {
            Uc_PlusEncore frm = new Uc_PlusEncore(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParametreArretTimer(timer10, timer20);
            Application.Exit();
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
