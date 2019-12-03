using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransFlash.Winforms.Fonctions;
using TransFlash.BO;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_GererCredit : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_GererCredit()
        {
            InitializeComponent();
        }

        private void btnInitierEmprunt_Click(object sender, EventArgs e)
        {
            Uc_InitierCredit frm = new Uc_InitierCredit();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void Uc_GererEmprunt_Load(object sender, EventArgs e)
        {
            Personne personne1 = new Personne("LEKOULAH Loic", Status.Desactivé);
            Personne personne2 = new Personne("NGUEGANG DONFACK", Status.Activé);
            List<Personne> personnes = new List<Personne>{
                personne1,
                personne2, personne2, personne1,
                personne2, personne2, personne1,
                personne2, personne2, personne1
            };

            dgClient.DataSource = personnes;
            dgClient.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 72, 114);
            dgClient.ColumnHeadersHeight = 45;
            dgClient.RowHeadersVisible = true;

            foreach (DataGridViewRow row in dgClient.Rows)
            {
                if (row.Cells[1].Value.ToString() == Status.Activé.ToString())
                    row.Cells[1].Style.ForeColor = Color.Green;
                else
                    row.Cells[1].Style.ForeColor = Color.Red;

                row.Selected = false;
                row.Height = 45;
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            }
        }

        private void createGraphicsColumn(int column)
        {
            Image image = Properties.Resources.approve_and_update_32px;
            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
            iconColumn.Image = image;
            iconColumn.Name = "Tree";
            iconColumn.HeaderText = "Nice tree";
            dgClient.Columns.Insert(column, iconColumn);
            dgClient.Columns[column].Width = 120;
        }

        private void dgClient_Resize(object sender, EventArgs e)
        {
        }

        private void dgClient_SelectionChanged(object sender, EventArgs e)
        {
            bool exist = false;
            foreach (DataGridViewRow row in dgClient.SelectedRows)
            {
                if (row.Cells[1].Value.ToString() == Status.Desactivé.ToString())
                {
                    exist = true;
                    break;
                }
            }

            if(exist == true || dgClient.SelectedRows.Count > 1)
                btnFinaliserCredit.Enabled = false;
            else
                btnFinaliserCredit.Enabled = true;

            txbRecherche.Text = dgClient.SelectedRows.Count.ToString();
        }
    }
}
