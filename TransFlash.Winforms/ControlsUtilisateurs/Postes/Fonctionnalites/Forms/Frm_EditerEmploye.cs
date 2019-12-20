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
    public partial class Frm_EditerEmploye : Form
    {

        private EmployeBLO employeBLO = null;

        private readonly Employe employe = null;

        private Employe employeChef = null;

        private Frm_Fonction fonction = null;

        private VilleBLO villeBLO = null;

        private PaysBLO paysBLO = null;

        public Frm_EditerEmploye(Employe employeChef, Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            paysBLO = new PaysBLO();
            villeBLO = new VilleBLO();

            employeBLO = new EmployeBLO();
            this.employeChef = employeChef;
            this.employe = employe;

            InformationEmploye(this.employe);
        }

        private void InformationEmploye(Employe employe)
        {
            fonction.ChargerEnumerationComboBox(cmbSexe, Enum.GetNames(typeof(StatutSexe)));
            fonction.ChargerPaysComboBox(cmbPays, paysBLO.TousPays);
            fonction.ChargerCodePhoneComboBox(cmbCodeTelephone1, paysBLO.TousPays);
            fonction.ChargerCodePhoneComboBox(cmbCodeTelephone2, paysBLO.TousPays);

            gbEmploye.Text += employe.CodeEmploye;
            lblCodeEmploye.Text = employe.CodeEmploye;
            txbNumeroCNI.Text = employe.NumeroCNI;
            txbAdresse.Text = employe.Adresse;
            
            if(employe.DateNaissance != null)
                dtDateNaissance.Value = employe.DateNaissance.GetValueOrDefault();

            txbLieuNaissance.Text = employe.LieuNaissance;
            txbNomComplet.Text = employe.NomComplet;

            cmbCodeTelephone1.Text = employe.NumeroTelephone1.Split(' ')[0];
            txbNumero1.Text = employe.NumeroTelephone1.Split(' ')[1];

            cmbCodeTelephone2.Text = employe.NumeroTelephone2.Split(' ')[0];
            txbNumero2.Text = employe.NumeroTelephone2.Split(' ')[1];

            if(employe.Pays.ToString()  != "Indefini")
                cmbPays.Text = employe.Pays.ToString();

            if(employe.Sexe.ToString()  != null)
                cmbSexe.Text = employe.Sexe.ToString();

            if(employe.Ville.ToString()  != "Indefini")
                cmbVille.Text = employe.Ville.ToString();

            pbEmploye.Image = (employe.PhotoProfil != string.Empty) ? Image.FromFile(employe.PhotoProfil) : pbEmploye.InitialImage;
            if (employe.PhotoProfil != string.Empty)
                pbEmploye.ImageLocation =employe.PhotoProfil;
            else
                pbEmploye.Image = pbEmploye.InitialImage;

        }

        private void cmbPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbVille.Items.Clear();
            fonction.ChargerVillesComboBox(cmbVille, villeBLO.RechercherLesVillesDuPays(paysBLO.RechercherUnPays(cmbPays.Text)));
            cmbVille.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fonction.ImporterImage(pbEmploye);
        }

        private bool SiAgeConvient => ((DateTime.Now.Year - dtDateNaissance.Value.Year) >=
            new ParametreGeneralBLO().TousParametreGenerals[0].AgeMinimalRequis);

        private bool SiFormulaireRempliCorrectement => ((txbNomComplet.Text != string.Empty) && (txbLieuNaissance.Text != string.Empty) &&
            (txbNumeroCNI.Text != string.Empty) && (cmbSexe.Text != string.Empty) && (cmbCodeTelephone1.Text != string.Empty) &&
            (txbNumero1.Text != string.Empty) && (cmbPays.Text != string.Empty) && (cmbVille.Text != string.Empty) &&
            (txbAdresse.Text != string.Empty) && (txbLieuNaissance.Text != string.Empty) && fonction.PictureName(pbEmploye) != string.Empty);

        private void btmMettreAJour_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = fonction.PictureName(pbEmploye);

                if (SiFormulaireRempliCorrectement)
                {
                    if (SiAgeConvient)
                    {
                        if (PersonneBLO.VerifierCNIExist(txbNumeroCNI.Text, new Client(), this.employe))
                        {
                            employeBLO.ModifierEmploye(this.employe, txbNomComplet.Text, dtDateNaissance.Value.Date, txbLieuNaissance.Text,
                                RetourSexe(cmbSexe.Text), txbNumeroCNI.Text, $"{cmbCodeTelephone1.Text} {txbNumero1.Text} ",
                                $"{cmbCodeTelephone2.Text} {txbNumero2.Text} ", paysBLO.RechercherUnPays(cmbPays.Text),
                                villeBLO.RechercherUneVille(cmbVille.Text), txbAdresse.Text, fileName, this.employeChef);
                            new Uc_GererEmploye(this.employeChef).RefreshDataGrid(employeBLO.TousEmployes);
                            fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Modification",
                                $"Employe modifie !");
                        }
                        else
                            fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Modification", "Ce numero de CNI est deja utilise !");
                    }
                    else
                        fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Modification", $"Votre age ne convient pas a l'age minimal " +
                            $"({new ParametreGeneralBLO().TousParametreGenerals[0].AgeMinimalRequis}) !");
                }
                else
                    fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Modification", "Veillez remplir tous les champs !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbNumero1_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbNumero1);
        }

        private void txbNumero2_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbNumero2);
        }

        private void txbNumeroCNI_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbNumeroCNI);
        }
    }
}
