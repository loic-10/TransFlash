using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using MetroFramework.Forms;

namespace TransFlash.Winforms.Fonctions
{
    public partial class Frm_Fonction : MetroForm
    {

        public Frm_Fonction()
        {
            InitializeComponent();
        }

        public void AnimationOuverture(GunaPanel panelMenu)
        {
            panelMenu.Visible = false;
            panelMenu.Width = 265;
            gunaTransition1.ShowSync(panelMenu);
        }

        public void AnimationIcone(Control but1, Control but2, Control but3)
        {
            gunaTransition3.ShowSync(but1);
            gunaTransition3.ShowSync(but2);
            gunaTransition3.ShowSync(but3);
        }

        public void MenuTop(GunaPanel panelPoste)
        {
            panelPoste.Visible = true;
            panelPoste.BringToFront();
        }

        public void AnimationUserControlHidde(GunaPanel panel)
        {
            if (panel.Width == 265)
            {
                panel.Visible = false;
                panel.Width = 55;
                gunaTransition1.ShowSync(panel);
            }
            else
            {
                panel.Visible = false;
                panel.Width = 265;
                gunaTransition1.ShowSync(panel);
            }
        }

        public void AfficheMenuPoste(UserControl controlMenu, GunaPanel panelPoste, UserControl menuPoste)
        {
            menuPoste = controlMenu;
            panelPoste.Controls.Clear();
            panelPoste.Controls.Add(controlMenu);
            controlMenu.Dock = DockStyle.Fill;
        }

        public void AfficheCorp(UserControl controlCorp, Control control, UserControl leCorpDePage)
        {
            leCorpDePage = controlCorp;
            gunaTransition2.HideSync(control);
            control.Controls.Clear();
            control.Controls.Add(controlCorp);
            controlCorp.Dock = DockStyle.Fill;
            gunaTransition2.ShowSync(control);
        }

        public void AfficherPageChoisie(Control control, UserControl userPage)
        {
            gunaTransition2.HideSync(control);
            control.Controls.Clear();
            control.Controls.Add(userPage);
            userPage.Dock = DockStyle.Fill;
            userPage.BringToFront();
            gunaTransition2.ShowSync(control);
        }

        public void ChangerButtonActif(GunaAdvenceButton buttonAActiver, GunaAdvenceButton buttonADesactiver, GunaPanel panelMenu)
        {
            buttonAActiver.Checked = true;
            buttonAActiver.Refresh();
            buttonADesactiver.Checked = false;
            panelMenu.Refresh();

        }

        public void DesignDataGrid(GunaDataGridView dataGrid)
        {
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 72, 114);
            dataGrid.ColumnHeadersHeight = 45;
            dataGrid.RowHeadersVisible = true;

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                row.Selected = false;
                row.Height = 45;
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }
    }
}
