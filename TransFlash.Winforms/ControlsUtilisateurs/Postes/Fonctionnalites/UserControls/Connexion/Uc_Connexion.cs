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
using TransFlash.Winforms.Fonctions;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls.Connexion
{
    public partial class Uc_Connexion : UserControl
    {

        private EmployeBLO employeBLO = null;

        private Frm_Fonction fonction = null;

        public Uc_Connexion()
        {
            InitializeComponent();
            employeBLO = new EmployeBLO();
            fonction = new Frm_Fonction();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                if(txbNomUtilisateur.Text != string.Empty || txbPassword.Text != string.Empty)
                {
                    Employe employe = employeBLO.SeConnecter(txbNomUtilisateur.Text, txbPassword.Text);
                    if (employe != null)
                    {
                        fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Authentification",
                            $"Bienvenue {employe.StatutEmploye.ToString().Replace("_", " ")} {employe.NomComplet}");
                        Frm_Principal frm_Principal = new Frm_Principal(employe);
                        frm_Principal.Show();
                    }
                    else
                        fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Authentification", "Compte errone");
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
