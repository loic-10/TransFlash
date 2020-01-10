using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransFlash.BO;
using TransFlash.BLL;
using static TransFlash.BO.Statut;
using TransFlash.Winforms.Fonctions;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_ClientTrouve : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_ClientTrouve(Client client)
        {
            InitializeComponent();
            InitForm();
            if (client != null)
                InformationEmploye(client);
        }

        private void InformationEmploye(Client client)
        {
            fonction.ChargerPaysComboBox(cmbPays, new PaysBLO().TousPays);
            fonction.ChargerVillesComboBox(cmbVille, new VilleBLO().ToutesVilles);
            fonction.ChargerEnumerationComboBox(cmbSexe, Enum.GetNames(typeof(StatutSexe)));
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

        public void InitForm()
        {
            cmbSexe.Items.Clear();
            lblCodeClient.Text = string.Empty;
            txbNumeroCNI.Text = string.Empty;
            txbNomComplet.Text = string.Empty;
            txbLieuNaissance.Text = string.Empty;
            dtDateNaissance.Value = DateTime.Now.Date;
            txbNumero1.Text = string.Empty;
            txbNumero2.Text = string.Empty;
            txbAdresse.Text = string.Empty;
            txbProfession.Text = string.Empty;
            fonction.ChargerEnumerationComboBox(cmbSexe, Enum.GetNames(typeof(StatutSexe)));
            cmbSexe.SelectedIndex = -1;
            cmbPays.SelectedIndex = -1;
            cmbVille.SelectedIndex = -1;
            cmbCodeTelephone1.SelectedIndex = -1;
            cmbCodeTelephone2.SelectedIndex = -1;
            lblCodeClient.Text = string.Empty;
            pbClient.Image = pbClient.InitialImage;

        }
    }
}
