using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransFlash.BLL;
using TransFlash.BO;
using TransFlash.Winforms.Fonctions;
using static TransFlash.BO.Statut;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms
{
    public partial class Frm_EditerCompteEmploye : Form
    {

        private Frm_Fonction fonction = null;

        private Employe employe = null;

        private Employe employeChef = null;

        private EmployeBLO employeBLO = null;

        public Frm_EditerCompteEmploye(Employe employeChef, Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            this.employe = employe;
            this.employeChef = employeChef;
            employeBLO = new EmployeBLO();
            AfficheInformationEmploye(employe);
        }

        private void AfficheInformationEmploye(Employe employe)
        {
            txbNomUtilisateur.Text = employe.NomUtilisateur;
            txbMDP.Text = string.Empty;
            txbConfirmerMDP.Text = string.Empty;
            gbCompteEmploye.Text += employe.CodeEmploye;
            fonction.ChargerEnumerationComboBox(cmbRoleEmploye, Enum.GetNames(typeof(StatutEmploye)));
            cmbRoleEmploye.Items.Remove(Enum.GetNames(typeof(StatutEmploye))[0]);
            cmbRoleEmploye.Text = employe.StatutEmploye.ToString();
        }

        private void txbMDP_TextChanged(object sender, EventArgs e)
        {

        }

        private bool SiFormulaireRempliCorrectement => ((txbNomUtilisateur.Text != string.Empty) && (txbMDP.Text != string.Empty) && (txbConfirmerMDP.Text != string.Empty));

        private bool SiMDPConvient => (txbMDP.Text == txbConfirmerMDP.Text);

        private void btnMettreAJour_Click(object sender, EventArgs e)
        {
            try
            {
                if (SiFormulaireRempliCorrectement)
                {
                    if (SiMDPConvient)
                    {
                        employeBLO.ModifierEmploye(this.employe, txbMDP.Text, RetourStatutEmploye(cmbRoleEmploye.Text), this.employeChef);
                        new Uc_GererEmploye(this.employeChef).RefreshDataGrid(employeBLO.TousEmployes);
                        fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Modification",
                            $"Employe modifie !");
                    }
                    else
                        fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Modification", "Les mots de passe non identiques !");
                }
                else
                    fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Modification", "Veillez remplir tous les champs !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRoleEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCodeEmploye.Text = employeBLO.CodeEmploye(RetourStatutEmploye(cmbRoleEmploye.Text)).Split('-')[0] + "-" + this.employe.CodeEmploye.Split('-')[1];
        }
    }
}
