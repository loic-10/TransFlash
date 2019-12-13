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
using TransFlash.BLL;
using TransFlash.Winforms.Fonctions;
using Guna.UI.WinForms;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_Pays : UserControl
    {

        private PaysBLO paysBLO = null;

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_Pays()
        {
            InitializeComponent();
            paysBLO = new PaysBLO();
            RefreshGrid(paysBLO.TousPays);
            Load += Uc_Pays_Load;
        }

        private void Uc_Pays_Load(object sender, EventArgs e)
        {
            fonction.DesignDataGrid(dataGridPays);
        }

        private void RefreshGrid(IEnumerable<Pays> pays)
        {
            dataGridPays.DataSource = pays;
            fonction.DesignDataGrid(dataGridPays);
        }
    }
}
