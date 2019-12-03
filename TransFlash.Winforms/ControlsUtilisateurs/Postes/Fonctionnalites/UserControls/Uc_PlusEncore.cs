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

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_PlusEncore : UserControl
    {

        private static UserControl leCorpDePage = null;

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_PlusEncore()
        {
            InitializeComponent();
            Uc_Beneficiers frm = new Uc_Beneficiers();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void Uc_PlusEncore_Load(object sender, EventArgs e)
        {
        }

        private void btnBeneficiers_Click(object sender, EventArgs e)
        {
            Uc_Beneficiers frm = new Uc_Beneficiers();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnPartsSociales_Click(object sender, EventArgs e)
        {
            Uc_PartsSociales frm = new Uc_PartsSociales();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnNumerosComptables_Click(object sender, EventArgs e)
        {
            Uc_NumerosComptables frm = new Uc_NumerosComptables();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnGaranties_Click(object sender, EventArgs e)
        {
            Uc_Garanties frm = new Uc_Garanties();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnButsCredits_Click(object sender, EventArgs e)
        {
            Uc_ButsCredits frm = new Uc_ButsCredits();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnAvalistes_Click(object sender, EventArgs e)
        {
            Uc_Avalistes frm = new Uc_Avalistes();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnSalaries_Click(object sender, EventArgs e)
        {
            Uc_Salaries frm = new Uc_Salaries();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnPays_Click(object sender, EventArgs e)
        {
            Uc_Pays frm = new Uc_Pays();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }

        private void btnVilles_Click(object sender, EventArgs e)
        {
            Uc_Villes frm = new Uc_Villes();
            fonction.AfficheCorp(frm, panelCorps, leCorpDePage);
        }
    }
}
