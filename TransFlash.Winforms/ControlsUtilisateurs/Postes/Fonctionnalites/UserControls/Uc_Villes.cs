using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransFlash.BLL;
using TransFlash.Winforms.Fonctions;
using TransFlash.BO;
using Guna.UI.WinForms;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_Villes : UserControl
    {

        private VilleBLO villeBLO = null;

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_Villes()
        {
            InitializeComponent();
            villeBLO = new VilleBLO();
            RefreshGrid(villeBLO.ToutesVilles);
            Load += Uc_Villes_Load;
        }

        private void Uc_Villes_Load(object sender, EventArgs e)
        {
            fonction.DesignDataGrid(dataGridVille);
        }

        private void RefreshGrid(IEnumerable<Ville> villes)
        {
            dataGridVille.DataSource = null;
            dataGridVille.DataSource = villes;
            fonction.DesignDataGrid(dataGridVille);
        }

        private void txbRecherche_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(villeBLO.RechercherLesVilles(txbRecherche.Text));
        }
    }
}
