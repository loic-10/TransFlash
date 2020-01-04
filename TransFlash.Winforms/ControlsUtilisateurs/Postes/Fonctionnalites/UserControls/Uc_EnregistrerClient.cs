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
using static TransFlash.BO.Statut;
using TransFlash.BLL;
using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_EnregistrerClient : UserControl
    {

        private Employe employe = null;

        private Frm_Fonction fonction = null;

        private int nombreBeneficier;

        private List<Uc_Beneficier> beneficiers = null;

        private int nombreBeneficierMin;

        private int nombreBeneficierMax;

        public Uc_EnregistrerClient(Employe employe)
        {
            InitializeComponent();
            this.employe = employe;
            fonction = new Frm_Fonction();

            nombreBeneficierMin = new ParametreGeneralBLO().TousParametreGenerals[0].NombreMinimalBeneficier;
            nombreBeneficierMax = new ParametreGeneralBLO().TousParametreGenerals[0].NombreMaximalBeneficier;

        }

        private void Uc_EnregistrerClient_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        public void InitForm()
        {
            beneficiers = new List<Uc_Beneficier>();
            btnAdd.Visible = true;
            cmbSexe.Items.Clear();
            cmbTypeCompte.Items.Clear();
            cmbTypeAppartenant.Items.Clear();
            RefreshCMBPays();
            lblCodeClient.Text = string.Empty;
            lblCodeCompte.Text = string.Empty;
            txbNumeroCNI.Text = string.Empty;
            txbNomComplet.Text = string.Empty;
            txbLieuNaissance.Text = string.Empty;
            dtDateNaissance.Value = DateTime.Now.Date;
            txbNumero1.Text = string.Empty;
            txbNumero2.Text = string.Empty;
            txbAdresse.Text = string.Empty;
            txbNomStructure.Text = string.Empty;
            txbProfession.Text = string.Empty;
            fonction.ChargerEnumerationComboBox(cmbSexe, Enum.GetNames(typeof(StatutSexe)));
            fonction.ChargerEnumerationComboBox(cmbTypeCompte, Enum.GetNames(typeof(TypeCompte)));
            fonction.ChargerEnumerationComboBox(cmbTypeAppartenant, Enum.GetNames(typeof(TypeAppartenantCompteEpargne)));
            cmbSexe.SelectedIndex = -1;
            cmbPays.SelectedIndex = -1;
            cmbCodeTelephone1.SelectedIndex = -1;
            cmbCodeTelephone2.SelectedIndex = -1;
            cmbTypeCompte.SelectedIndex = -1;
            cmbTypeAppartenant.SelectedIndex = -1;
            cmbTypeAppartenant.Enabled = false;
            lblCodeClient.Text = new ClientBLO().CodeClient;
            txbNomStructure.Enabled = false;
            nombreBeneficier = nombreBeneficierMin;
            pbClient.Image = pbClient.InitialImage;
            gbEpargne.Enabled = false;
            txbNombreMoisEpargne.Text = "0";
            txbCodeEpargne.Text = "0";
            MesBeneficiers(nombreBeneficier);
            fonction.AfficherUneInfoBulle(txbMontantDepart, "Info", "Message");
            txbMontantDepart.Text = string.Empty;

        }

        private void MesBeneficiers(int nbrBeneficier)
        {
            panelBeneficiers.Controls.Clear();

            while(beneficiers.Count < nbrBeneficier)
            {
                beneficiers.Add(new Uc_Beneficier()
                {
                    NumBeneficier = beneficiers.Count + 1
                });
            }

            for (int i = 0; i < nbrBeneficier; i++)
            {
                panelBeneficiers.Controls.Add(beneficiers[i]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nombreBeneficier < nombreBeneficierMax)
            {
                nombreBeneficier+=1;
                MesBeneficiers(nombreBeneficier);
                if(nombreBeneficier == nombreBeneficierMax)
                    btnAdd.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Uc_GererClient frm = new Uc_GererClient(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void txbNomStructure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // Set l'evenement comme etant completement fini
                return;
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

        private void cmbTypeCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCodeCompte.Text = new CompteClientBLO().CodeCompteClient(RetourTypeCompte(cmbTypeCompte.Text),
                RetourTypeAppartenantCompteEpargne(cmbTypeAppartenant.Text));
            cmbTypeAppartenant.SelectedIndex = -1;
            if (fonction.SiTypeCompteSelectionneEpargne(cmbTypeCompte))
            {
                txbNomStructure.Text = string.Empty;
                txbNomStructure.Enabled = false;
                txbNombreMoisEpargne.Text = new ParametreGeneralBLO().TousParametreGenerals[0].NombreMoisMinimumPourEpargne.ToString();
                txbCodeEpargne.Text = new IdentifiantBLO().IdEpargne.ToString();
            }
            else
            {
                txbNombreMoisEpargne.Text = "0";
                txbCodeEpargne.Text = "0";
            }
            cmbTypeAppartenant.Enabled = fonction.SiTypeCompteSelectionneEpargne(cmbTypeCompte);
            gbEpargne.Enabled = fonction.SiTypeCompteSelectionneEpargne(cmbTypeCompte);
        }

        private void cmbTypeAppartenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCodeCompte.Text = new CompteClientBLO().CodeCompteClient(RetourTypeCompte(cmbTypeCompte.Text),
                RetourTypeAppartenantCompteEpargne(cmbTypeAppartenant.Text));

            if (fonction.SiTypeAppartenantSelectionneEntreprise(cmbTypeAppartenant))
            {
                txbNomStructure.Enabled = true;
            }
            else
            {
                txbNomStructure.Text = string.Empty;
                txbNomStructure.Enabled = false;
            }
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
            (txbAdresse.Text != string.Empty) &&
            (txbLieuNaissance.Text != string.Empty) &&
            (txbProfession.Text != string.Empty) && 
            (cmbTypeCompte.Text != string.Empty) &&
            ((double.Parse(txbMontantDepart.Text) >= new ParametreGeneralBLO().TousParametreGenerals[0].MontantMininimumDepot && 
            txbNomStructure.Text != string.Empty &&
            int.Parse(txbNombreMoisEpargne.Text) >= new ParametreGeneralBLO().TousParametreGenerals[0].NombreMoisMinimumPourEpargne) ||
            (cmbTypeCompte.Text == TypeCompte.Epargne.ToString() &&
            int.Parse(txbNombreMoisEpargne.Text) >= new ParametreGeneralBLO().TousParametreGenerals[0].NombreMoisMinimumPourEpargne &&
            cmbTypeAppartenant.Text == TypeAppartenantCompteEpargne.Particulier.ToString()) ||
            cmbTypeCompte.Text == TypeCompte.Courant.ToString()) &&
            fonction.PictureName(pbClient) != string.Empty;

        private int PourcentageBeneficierRenseigne(List<Uc_Beneficier> uc_Beneficiers)
        {
            int pourcentage = 0;
            foreach (var beneficier in uc_Beneficiers)
            {
                if (beneficier.Nom != string.Empty && beneficier.Description != string.Empty && beneficier.Pourcentage > 0)
                    pourcentage += beneficier.Pourcentage;
            }
            return pourcentage;
        }

        private void EnregistrerBeneficier(List<Uc_Beneficier> beneficiers)
        {
            foreach (var beneficier in beneficiers)
            {
                if (beneficier.Nom != string.Empty && beneficier.Description != string.Empty && beneficier.Pourcentage > 0)
                {
                    new BeneficierBLO().AjouterBeneficier(beneficier.Nom, beneficier.Description, beneficier.Pourcentage,
                        new CompteClientBLO().RechercherUnComptePourBeneficier(lblCodeCompte.Text), this.employe);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fonction.ImporterImage(pbClient);
        }

        private void txbMontantDepart_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbMontantDepart);
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

        private void btnEnregistrer_Click(object sender, EventArgs e)
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
                        if (PersonneBLO.VerifierCNIExist(txbNumeroCNI.Text, new Client(), new Employe()))
                        {
                            if (PourcentageBeneficierRenseigne(this.beneficiers) == 100)
                            {
                                new ClientBLO().AjouterClient(txbNomComplet.Text, dtDateNaissance.Value.Date, txbLieuNaissance.Text, RetourSexe(cmbSexe.Text),
                                    txbNumeroCNI.Text, $"{cmbCodeTelephone1.Text} {txbNumero1.Text} ", numeroTelehone2,
                                    new PaysBLO().RechercherUnPays(cmbPays.Text), new VilleBLO().RechercherUneVille(cmbVille.Text), txbAdresse.Text, fileName,
                                    txbProfession.Text, RetourTypeCompte(cmbTypeCompte.Text), RetourTypeAppartenantCompteEpargne(cmbTypeAppartenant.Text),
                                    txbNomStructure.Text, this.employe, int.Parse(txbNombreMoisEpargne.Text), double.Parse(txbMontantDepart.Text));

                                EnregistrerBeneficier(beneficiers);

                                fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Enregistrement", $"Client ajoute !");

                                InitForm();
                            }
                            else
                                fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Enregistrement", "Pourcentage ou information sur beneficier incomplete !");
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
    }
}
