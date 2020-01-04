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
using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_EnregistrerEmploye : UserControl
    {

        private Employe employe = null;

        private Frm_Fonction fonction = null;

        public Uc_EnregistrerEmploye(Employe employe)
        {
            InitializeComponent();
            this.employe = employe;
            fonction = new Frm_Fonction();
            InitForm();

        }

        private void InitForm()
        {
            cmbSexe.Items.Clear();
            RefreshCMBPays();
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
            cmbSexe.SelectedIndex = -1;
            cmbRoleEmploye.SelectedIndex = -1;
            cmbPays.SelectedIndex = -1;
            pbEmploye.Image = pbEmploye.InitialImage;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Uc_GererEmploye frm = new Uc_GererEmploye(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void cmbPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbVille.Items.Clear();
            try
            {
                if (cmbPays.SelectedIndex == cmbPays.Items.Count - 1)
                {
                    cmbPays.SelectedIndex = -1;
                    new Frm_GererPays(this.employe, this).ShowDialog();
                }
                else if(cmbPays.SelectedIndex > -1)
                {
                    fonction.ChargerVillesComboBox(cmbVille, new VilleBLO().RechercherLesVillesDuPays(new PaysBLO().RechercherUnPays(cmbPays.Text)));
                    cmbVille.Items.Add("add new town >>");
                    cmbVille.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbVille.SelectedIndex == cmbVille.Items.Count - 1)
                {
                    cmbVille.SelectedIndex = -1;
                    new Frm_GererVille(this.employe, this).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RefreshCMBPays()
        {
            cmbPays.Items.Clear();
            cmbCodeTelephone1.Items.Clear();
            cmbCodeTelephone2.Items.Clear();
            fonction.ChargerPaysComboBox(cmbPays, new PaysBLO().TousPays);
            fonction.ChargerCodePhoneComboBox(cmbCodeTelephone1, new PaysBLO().TousPays);
            fonction.ChargerCodePhoneComboBox(cmbCodeTelephone2, new PaysBLO().TousPays);
            cmbPays.Items.Add("add new land >>");
            cmbPays.SelectedIndex = cmbPays.Items.Count - 2;
            cmbVille.Items.Clear();
            fonction.ChargerVillesComboBox(cmbVille, new VilleBLO().RechercherLesVillesDuPays(new PaysBLO().RechercherUnPays(cmbPays.Text)));
            cmbVille.Items.Add("add new town >>");
            cmbVille.SelectedIndex = -1;
        }

        public void RefreshCMBVille(int pays)
        {
            cmbPays.Items.Clear();
            cmbCodeTelephone1.Items.Clear();
            cmbCodeTelephone2.Items.Clear();
            fonction.ChargerPaysComboBox(cmbPays, new PaysBLO().TousPays);
            fonction.ChargerCodePhoneComboBox(cmbCodeTelephone1, new PaysBLO().TousPays);
            fonction.ChargerCodePhoneComboBox(cmbCodeTelephone2, new PaysBLO().TousPays);
            cmbPays.Items.Add("add new land >>");
            cmbPays.SelectedIndex = pays;
            cmbVille.Items.Clear();
            if (pays > -1)
            {
                fonction.ChargerVillesComboBox(cmbVille, new VilleBLO().RechercherLesVillesDuPays(new PaysBLO().RechercherUnPays(cmbPays.Items[pays].ToString())));
                cmbVille.Items.Add("add new town >>");
                cmbVille.SelectedIndex = cmbVille.Items.Count - 2;
            }
        }

        private void cmbRoleEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCodeEmploye.Text = new EmployeBLO().CodeEmploye(RetourStatutEmploye(cmbRoleEmploye.Text));
            txbNomUtilisateur.Text = new EmployeBLO().NomUtilisateur(txbNomComplet.Text, lblCodeEmploye.Text);
        }

        private bool SiMDPConvient => 
            txbMotDePasse.Text == txbConfirmMDP.Text;

        private bool SiAgeConvient => 
            (DateTime.Now.Year - dtDateNaissance.Value.Year) >=  new ParametreGeneralBLO().TousParametreGenerals[0].AgeMinimalRequis;

        private bool SiFormulaireRempliCorrectement => 
            (txbNomComplet.Text != string.Empty) && 
            (txbLieuNaissance.Text != string.Empty) &&
            (txbNumeroCNI.Text != string.Empty) &&
            (cmbSexe.Text != string.Empty) &&
            (cmbCodeTelephone1.Text != string.Empty) &&
            (txbNumero1.Text != string.Empty) && 
            (cmbPays.Text != string.Empty) && 
            (cmbVille.Text != string.Empty) &&
            (txbAdresse.Text != string.Empty) && 
            (txbLieuNaissance.Text != string.Empty) &&
            (cmbRoleEmploye.Text != string.Empty) && 
            (txbNomUtilisateur.Text != string.Empty) && 
            (txbMotDePasse.Text != string.Empty) && 
            (txbConfirmMDP.Text != string.Empty) && 
            fonction.PictureName(pbEmploye) != string.Empty;

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

                string numeroTelehone2 = (txbNumero2.Text != string.Empty && cmbCodeTelephone2.Text != string.Empty) ?
                    $"{cmbCodeTelephone2.Text} {txbNumero2.Text}" :
                    " ";

                if (SiFormulaireRempliCorrectement)
                {
                    if (SiAgeConvient)
                    {
                        if (PersonneBLO.VerifierCNIExist(txbNumeroCNI.Text, new Client(), new Employe()))
                        {
                            if (SiMDPConvient)
                            {
                                new EmployeBLO().AjouterEmploye(txbNomComplet.Text, dtDateNaissance.Value.Date, txbLieuNaissance.Text,
                                    RetourSexe(cmbSexe.Text), txbNumeroCNI.Text, $"{cmbCodeTelephone1.Text} {txbNumero1.Text} ",
                                    numeroTelehone2, new PaysBLO().RechercherUnPays(cmbPays.Text),
                                    new VilleBLO().RechercherUneVille(cmbVille.Text), txbAdresse.Text, fileName, txbMotDePasse.Text, 
                                    RetourStatutEmploye(cmbRoleEmploye.Text), this.employe);

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
            txbNomUtilisateur.Text = new EmployeBLO().NomUtilisateur(txbNomComplet.Text, lblCodeEmploye.Text);
        }
    }
}
