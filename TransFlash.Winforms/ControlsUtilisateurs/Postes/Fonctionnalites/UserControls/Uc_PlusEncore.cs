using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms;
using TransFlash.Winforms.Fonctions;
using TransFlash.BO;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_PlusEncore : UserControl
    {

        private static UserControl leCorpDePage = null;

        private Employe employe = null;

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_PlusEncore(Employe employe)
        {
            InitializeComponent();
            this.employe = employe;
            Uc_Beneficiers frm = new Uc_Beneficiers(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void Uc_PlusEncore_Load(object sender, EventArgs e)
        {
        }

        private void btnBeneficiers_Click(object sender, EventArgs e)
        {
            Uc_Beneficiers frm = new Uc_Beneficiers(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnPartsSociales_Click(object sender, EventArgs e)
        {
            Uc_PartsSociales frm = new Uc_PartsSociales(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnNumerosComptables_Click(object sender, EventArgs e)
        {
            Uc_Fonds frm = new Uc_Fonds(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGaranties_Click(object sender, EventArgs e)
        {
            Uc_Garanties frm = new Uc_Garanties(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnAvalistes_Click(object sender, EventArgs e)
        {
            Uc_Avalistes frm = new Uc_Avalistes(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnSalaries_Click(object sender, EventArgs e)
        {
            Uc_Salaries frm = new Uc_Salaries(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnPays_Click(object sender, EventArgs e)
        {
            Uc_Pays frm = new Uc_Pays(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnVilles_Click(object sender, EventArgs e)
        {
            Uc_Villes frm = new Uc_Villes(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnFichierStocke_Click(object sender, EventArgs e)
        {
            Uc_FichiersStockes frm = new Uc_FichiersStockes(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnEpargne_Click(object sender, EventArgs e)
        {
            Uc_Epargne frm = new Uc_Epargne(this.employe);
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }
    }
}
