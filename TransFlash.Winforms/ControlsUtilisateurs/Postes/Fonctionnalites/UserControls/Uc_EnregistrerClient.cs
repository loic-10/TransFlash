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

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_EnregistrerClient : UserControl
    {

        private Employe employe = null;

        private Frm_Fonction fonction = null;

        private int nombreBeneficier;

        private VilleBLO villeBLO = null;

        private PaysBLO paysBLO = null;

        private Uc_Beneficier[] beneficiers = null;

        private ClientBLO clientBLO = null;

        private CompteClientBLO compteClientBLO = null;

        private ParametreGeneralBLO parametreGeneralBLO = null;

        public Uc_EnregistrerClient(Employe employe)
        {
            InitializeComponent();

            this.employe = employe;

            fonction = new Frm_Fonction();

            villeBLO = new VilleBLO();

            paysBLO = new PaysBLO();

            clientBLO = new ClientBLO();

            compteClientBLO = new CompteClientBLO();

            parametreGeneralBLO = new ParametreGeneralBLO();

            nombreBeneficier = 2;

            InitForm();

            MesBeneficiers(nombreBeneficier);
        }

        public void InitForm()
        {
            cmbPays.Items.Clear();
            cmbSexe.Items.Clear();
            cmbCodeTelephone1.Items.Clear();
            cmbCodeTelephone2.Items.Clear();
            cmbVille.Items.Clear();
            cmbTypeCompte.Items.Clear();
            cmbTypeAppartenant.Items.Clear();
            lblCodeClient.Text = string.Empty;
            lblCodeCompte.Text = string.Empty;
            fonction.ChargerEnumerationComboBox(cmbSexe, Enum.GetNames(typeof(StatutSexe)));
            fonction.ChargerEnumerationComboBox(cmbTypeCompte, Enum.GetNames(typeof(TypeCompte)));
            fonction.ChargerEnumerationComboBox(cmbTypeAppartenant, Enum.GetNames(typeof(TypeAppartenantCompteEpargne)));
            fonction.ChargerPaysComboBox(cmbPays, paysBLO.TousPays);
            fonction.ChargerCodePhoneComboBox(cmbCodeTelephone1, paysBLO.TousPays);
            fonction.ChargerCodePhoneComboBox(cmbCodeTelephone2, paysBLO.TousPays);
            cmbPays.SelectedIndex = -1;
            cmbSexe.SelectedIndex = -1;
            cmbCodeTelephone1.SelectedIndex = -1;
            cmbCodeTelephone2.SelectedIndex = -1;
            cmbVille.SelectedIndex = -1;
            cmbTypeCompte.SelectedIndex = -1;
            cmbTypeAppartenant.SelectedIndex = -1;
            cmbTypeAppartenant.Enabled = false;
            lblCodeClient.Text = clientBLO.CodeClient;
            txbNomStructure.Text = string.Empty;
            txbNomStructure.Enabled = false;
        }

        private void MesBeneficiers(int nbrBeneficier)
        {
            panelBeneficiers.Controls.Clear();

            beneficiers = new Uc_Beneficier[nbrBeneficier];

            for (int i = 0; i < nbrBeneficier; i++)
            {
                beneficiers[i] = new Uc_Beneficier
                {
                    NumBeneficier = i + 1
                };
                panelBeneficiers.Controls.Add(beneficiers[i]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //TextBox myText = new TextBox();
            //myText.Location = new Point(25, 25);
            //this.Controls.Add(myText);
            if (nombreBeneficier < 5)
            {
                nombreBeneficier++;
                MesBeneficiers(nombreBeneficier);
                if(nombreBeneficier == 5)
                    btnAdd.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Uc_GererClient frm = new Uc_GererClient(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            btnBack_Click(sender, e);
        }

        private void Uc_EnregistrerClient_Load(object sender, EventArgs e)
        {
        }

        private void txbNomStructure_TextChanged(object sender, EventArgs e)
        {
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
            fonction.ChargerVillesComboBox(cmbVille, villeBLO.RechercherLesVillesDuPays(paysBLO.RechercherUnPays(cmbPays.Text)));
            cmbVille.SelectedIndex = -1;
        }

        private void cmbTypeCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCodeCompte.Text = compteClientBLO.CodeCompteClient(RetourTypeCompte(cmbTypeCompte.Text),
                RetourTypeAppartenantCompteEpargne(cmbTypeAppartenant.Text));
            cmbTypeAppartenant.SelectedIndex = -1;
            if (fonction.SiTypeCompteSelectionneEpargne(cmbTypeCompte))
            {
                txbNomStructure.Text = string.Empty;
                txbNomStructure.Enabled = false;
            }
            cmbTypeAppartenant.Enabled = fonction.SiTypeCompteSelectionneEpargne(cmbTypeCompte);
        }

        private void cmbTypeAppartenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCodeCompte.Text = compteClientBLO.CodeCompteClient(RetourTypeCompte(cmbTypeCompte.Text),
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

        private void txbNumeroCNI_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbNumeroCNI);
        }

        private void txbNumeroTelephone1_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbNumeroTelephone1);
        }

        private void txbNumeroTelephone2_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbNumeroTelephone2);
        }

        private void txbMontantDepart_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbMontantDepart);
        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
        }
    }
}
