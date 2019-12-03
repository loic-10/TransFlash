using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using TransFlash.Winforms.Fonctions;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_InitierRetrait : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_InitierRetrait()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Uc_GererTransaction frm = new Uc_GererTransaction();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void Uc_InitierRetrait_Load(object sender, EventArgs e)
        {
            //Personne personne1 = new Personne("Loic", Status.Desactivé);
            //Personne personne2 = new Personne("Loic", Status.Activé);
            //List<Personne> personnes = new List<Personne>{
            //    personne1,
            //    personne2, personne2, personne1
            //};

            //gunaDataGridView1.DataSource = personnes;

            //foreach (DataGridViewRow row in this.gunaDataGridView1.Rows)
            //{
            //    if (row.Cells[1].Value.ToString() == Status.Activé.ToString())
            //        row.Cells[1].Style.ForeColor = Color.Green;
            //    else
            //        row.Cells[1].Style.ForeColor = Color.Red;

            //}
        }

        private void gunaGroupBox13_Click(object sender, EventArgs e)
        {

        }

        private void gunaGroupBox19_Click(object sender, EventArgs e)
        {

        }

        private void gunaGroupBox16_Click(object sender, EventArgs e)
        {

        }

        private void gunaGroupBox18_Click(object sender, EventArgs e)
        {

        }
    }
}
