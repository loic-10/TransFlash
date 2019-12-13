using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls.Connexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couche.Winforms
{
    public partial class Frm_Demarrage : Form
    {
        private Uc_Connexion frm = null;
        public Frm_Demarrage()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Enabled = true;
            AfficherFormConnexion();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            AffichePanelFormulaire();
        }

        private void AfficherFormConnexion()
        {
            this.frm = new Uc_Connexion();
            panelFormulaire.Controls.Clear();
            panelFormulaire.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
        }

        private void AffichePanelFormulaire()
        {
            while(panelSplashScreen.Width >= 300)
            {
                System.Threading.Thread.Sleep(15);
                panelSplashScreen.Width -= 50;
                frm.Dock = DockStyle.Fill;
            }
            gunaWinCircleProgressIndicator1.Visible = false;
        }
    }
}
