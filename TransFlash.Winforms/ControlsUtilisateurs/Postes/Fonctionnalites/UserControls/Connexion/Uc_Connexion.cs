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
using TransFlash.BO;
using Tulpep.NotificationWindow;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls.Connexion
{
    public partial class Uc_Connexion : UserControl
    {

        private EmployeBLO employeBLO = new EmployeBLO();

        public Uc_Connexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                if(txbNomUtilisateur.Text != string.Empty || txbPassword.Text != string.Empty)
                {
                    popupNotifier1.BodyColor = Color.FromArgb(33, 191, 116);
                    popupNotifier1.TitleText = "Authentification";
                    popupNotifier1.ContentColor = Color.White;
                    Employe employe = employeBLO.SeConnecter(txbNomUtilisateur.Text, txbPassword.Text);
                    if (employe != null)
                    {
                        popupNotifier1.ContentText = $"Bienvenue {employe.StatutEmploye.ToString().Replace("_", " ")} {employe.NomComplet}";
                        Frm_Principal frm_Principal = new Frm_Principal(employe);
                        frm_Principal.Show();
                    }
                    else
                    {
                        popupNotifier1.ContentText = $"Compte errone";
                        popupNotifier1.BodyColor = Color.FromArgb(248, 43, 43);
                    }
                    popupNotifier1.Popup();
                }
                else
                {
                    MessageBox.Show("Veillez remplir tous les champs !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
