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
using TransFlash.BO;
using TransFlash.BLL;
using static TransFlash.BO.Statut;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_EnregistrerEmploye : UserControl
    {

        private Employe employe = null;

        private EmployeBLO employeBLO = null;

        private Frm_Fonction fonction = null;

        private PaysBLO paysBLO = null;

        private VilleBLO villeBLO = null;

        public Uc_EnregistrerEmploye(Employe employe)
        {
            InitializeComponent();
            this.employeBLO = new EmployeBLO();
            this.employe = employe;
            fonction = new Frm_Fonction();
            paysBLO = new PaysBLO();
            villeBLO = new VilleBLO();
            InitForm();

        }

        private void InitForm()
        {
            cmbPays.Items.Clear();
            cmbSexe.Items.Clear();
            cmbCodeTelephone1.Items.Clear();
            cmbCodeTelephone2.Items.Clear();
            cmbVille.Items.Clear();
            cmbRoleEmploye.Items.Clear();
            lblCodeEmploye.Text = string.Empty;
            txbNomUtilisateur.Text = string.Empty;
            txbNumeroCNI.Text = string.Empty;
            txbNomComplet.Text = string.Empty;
            txbMotDePasse.Text = string.Empty;
            txbConfirmMDP.Text = string.Empty;
            txbLieuNaissance.Text = string.Empty;
            txbNumero1.Text = string.Empty;
            txbNumero2.Text = string.Empty;
            txbAdresse.Text = string.Empty;
            fonction.ChargerEnumerationComboBox(cmbSexe, Enum.GetNames(typeof(StatutSexe)));
            fonction.ChargerEnumerationComboBox(cmbRoleEmploye, Enum.GetNames(typeof(StatutEmploye)));
            cmbRoleEmploye.Items.Remove(Enum.GetNames(typeof(StatutEmploye))[0]);
            fonction.ChargerPaysComboBox(cmbPays, paysBLO.TousPays);
            fonction.ChargerCodePhoneComboBox(cmbCodeTelephone1, paysBLO.TousPays);
            fonction.ChargerCodePhoneComboBox(cmbCodeTelephone2, paysBLO.TousPays);
            cmbPays.SelectedIndex = -1;
            cmbSexe.SelectedIndex = -1;
            cmbCodeTelephone1.SelectedIndex = -1;
            cmbCodeTelephone2.SelectedIndex = -1;
            cmbVille.SelectedIndex = -1;
            cmbRoleEmploye.SelectedIndex = -1;
            pbEmploye.Image = pbEmploye.InitialImage;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Uc_GererEmploye frm = new Uc_GererEmploye(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
        }

        private void cmbPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbVille.Items.Clear();
            fonction.ChargerVillesComboBox(cmbVille, villeBLO.RechercherLesVillesDuPays(paysBLO.RechercherUnPays(cmbPays.Text)));
            cmbVille.SelectedIndex = -1;
        }

        private void cmbRoleEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCodeEmploye.Text = employeBLO.CodeEmploye(RetourStatutEmploye(cmbRoleEmploye.Text));
            txbNomUtilisateur.Text = employeBLO.NomUtilisateur(txbNomComplet.Text, lblCodeEmploye.Text);
        }

        private bool SiAgeConvient => ((DateTime.Now.Year - dtDateNaissance.Value.Year) >= 
            new ParametreGeneralBLO().TousParametreGenerals[0].AgeMinimalRequis);

        private bool SiMDPConvient => (txbMotDePasse.Text == txbConfirmMDP.Text);

        private bool SiFormulaireRempliCorrectement => ((txbNomComplet.Text != string.Empty) && (txbLieuNaissance.Text != string.Empty) &&
            (txbNumeroCNI.Text != string.Empty) && (cmbSexe.Text != string.Empty) && (cmbCodeTelephone1.Text != string.Empty) &&
            (txbNumero1.Text != string.Empty) && (cmbPays.Text != string.Empty) && (cmbVille.Text != string.Empty) &&
            (txbAdresse.Text != string.Empty) && (txbLieuNaissance.Text != string.Empty) && (cmbRoleEmploye.Text != string.Empty) && 
            (txbNomUtilisateur.Text != string.Empty) && (txbMotDePasse.Text != string.Empty) && (txbConfirmMDP.Text != string.Empty) && 
            fonction.PictureName(pbEmploye) != string.Empty);

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fonction.ImporterImage(pbEmploye);
        }

        private void txbNumeroCNI_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbNumeroCNI);
        }

        private void txbNumero1_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbNumero1);
        }

        private void txbNumero2_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbNumero2);
        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            try
            {
                string fileName = fonction.PictureName(pbEmploye);

                if (SiFormulaireRempliCorrectement)
                {
                    if (SiAgeConvient)
                    {
                        if (PersonneBLO.VerifierCNIExist(txbNumeroCNI.Text, new Client(), new Employe()))
                        {
                            if (SiMDPConvient)
                            {
                                employeBLO.AjouterEmploye(txbNomComplet.Text, dtDateNaissance.Value.Date, txbLieuNaissance.Text,
                                    RetourSexe(cmbSexe.Text), txbNumeroCNI.Text, $"{cmbCodeTelephone1.Text} {txbNumero1.Text} ",
                                    $"{cmbCodeTelephone2.Text} {txbNumero2.Text} ", paysBLO.RechercherUnPays(cmbPays.Text),
                                    villeBLO.RechercherUneVille(cmbVille.Text), txbAdresse.Text, fileName, txbMotDePasse.Text, 
                                    RetourStatutEmploye(cmbRoleEmploye.Text), this.employe);

                                new Uc_GererEmploye(this.employe).RefreshDataGrid(employeBLO.TousEmployes);
                                fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Enregistrement", $"Employe ajoute !");

                                InitForm();
                            }
                            else
                                fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Enregistrement", "Les mots de passe non identiques !");
                        }
                        else
                            fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Enregistrement", "Ce numero de CNI est deja utilise !");
                    }
                    else
                        fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Enregistrement", $"Votre age ne convient pas a l'age minimal " +
                            $"({new ParametreGeneralBLO().TousParametreGenerals[0].AgeMinimalRequis}) !");
                }
                else
                    fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Enregistrement", "Veillez remplir tous les champs !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbNomComplet_TextChanged(object sender, EventArgs e)
        {
            txbNomUtilisateur.Text = employeBLO.NomUtilisateur(txbNomComplet.Text, lblCodeEmploye.Text);
        }
    }
}
