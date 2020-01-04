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
    public partial class Frm_EditerClient : Form
    {

        private Employe employe = null;

        private Client client = null;

        private Frm_Fonction fonction = null;

        private Uc_GererClient uc_GererClient = null;

        public Frm_EditerClient(Employe employe, Client client, Uc_GererClient uc_GererClient)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();

            this.client = client;

            this.employe = employe;

            this.uc_GererClient = uc_GererClient;

            InformationClient(this.client);
        }

        private void InformationClient(Client client)
        {
            fonction.ChargerEnumerationComboBox(cmbSexe, Enum.GetNames(typeof(StatutSexe)));
            fonction.ChargerPaysComboBox(cmbPays, new PaysBLO().TousPays);
            fonction.ChargerCodePhoneComboBox(cmbCodeTelephone1, new PaysBLO().TousPays);
            fonction.ChargerCodePhoneComboBox(cmbCodeTelephone2, new PaysBLO().TousPays);

            gbClient.Text += client.CodeClient;
            lblCodeClient.Text = client.CodeClient;
            txbNumeroCNI.Text = client.NumeroCNI;
            txbAdresse.Text = client.Adresse;
            txbProfession.Text = client.Profession;

            if (client.DateNaissance != null)
                dtDateNaissance.Value = client.DateNaissance.GetValueOrDefault();

            txbLieuNaissance.Text = client.LieuNaissance;
            txbNomComplet.Text = client.NomComplet;

            cmbCodeTelephone1.Text = client.NumeroTelephone1.Split(' ')[0];
            txbNumero1.Text = client.NumeroTelephone1.Split(' ')[1];

            cmbCodeTelephone2.Text = client.NumeroTelephone2.Split(' ')[0];
            txbNumero2.Text = client.NumeroTelephone2.Split(' ')[1];

            cmbPays.Items.Add("add new land >>");

            if (client.Pays.ToString() != "Indefini")
                cmbPays.Text = client.Pays.ToString();

            if (client.Sexe.ToString() != null)
                cmbSexe.Text = client.Sexe.ToString();

            if (client.Ville.ToString() != "Indefini")
                cmbVille.Text = client.Ville.ToString();

            pbClient.Image = (client.PhotoProfil != string.Empty) ? Image.FromFile(client.PhotoProfil) : pbClient.InitialImage;
            if (client.PhotoProfil != string.Empty)
                pbClient.ImageLocation = client.PhotoProfil;
            else
                pbClient.Image = pbClient.InitialImage;

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
                else if (cmbPays.SelectedIndex > -1)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fonction.ImporterImage(pbClient);
        }

        private bool SiAgeConvient => 
            (DateTime.Now.Year - dtDateNaissance.Value.Year) >= new ParametreGeneralBLO().TousParametreGenerals[0].AgeMinimalRequis;

        private bool SiFormulaireRempliCorrectement => 
            (txbNomComplet.Text != string.Empty) &&
            (txbLieuNaissance.Text != string.Empty) &&
            (txbNumeroCNI.Text != string.Empty) && 
            (cmbSexe.Text != string.Empty) && 
            (cmbCodeTelephone1.Text != string.Empty) &&
            (txbNumero1.Text != string.Empty) &&
            (cmbPays.Text != string.Empty) && 
            (cmbVille.Text != string.Empty) &&
            (txbProfession.Text != string.Empty) &&
            (txbAdresse.Text != string.Empty) &&
            (txbLieuNaissance.Text != string.Empty) &&
            fonction.PictureName(pbClient) != string.Empty;

        private void btnMettreAJour_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = fonction.PictureName(pbClient);

                string numeroTelehone2 = (txbNumero2.Text != string.Empty && cmbCodeTelephone2.Text != string.Empty) ?
                    $"{cmbCodeTelephone2.Text} {txbNumero2.Text}" :
                    " ";

                if (SiFormulaireRempliCorrectement)
                {
                    if (SiAgeConvient)
                    {
                        if (PersonneBLO.VerifierCNIExist(txbNumeroCNI.Text, this.client, new Employe()))
                        {
                            new ClientBLO().EditerClient(this.client, txbNomComplet.Text, dtDateNaissance.Value.Date, txbLieuNaissance.Text,
                                RetourSexe(cmbSexe.Text), txbNumeroCNI.Text, $"{cmbCodeTelephone1.Text} {txbNumero1.Text} ",
                                numeroTelehone2, new PaysBLO().RechercherUnPays(cmbPays.Text), new VilleBLO().RechercherUneVille(cmbVille.Text), 
                                txbAdresse.Text, fileName, txbProfession.Text, this.employe);
                            this.uc_GererClient.txbRechercher_TextChanged(sender, e);
                            fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Modification", $"Employe modifie !");
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
    }
}
