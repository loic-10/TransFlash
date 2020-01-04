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
using TransFlash.BO;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms
{
    public partial class Frm_InformationClient : Form
    {

        private Employe employe = null;

        private Client client = null;

        private Uc_GererClient uc_GererClient = null;

        public Frm_InformationClient(Employe employe, Client client, Uc_GererClient uc_GererClient)
        {
            InitializeComponent();
            this.client = client;
            this.employe = employe;
            this.uc_GererClient = uc_GererClient;
            InformationEmploye(this.client);
        }

        private void InformationEmploye(Client client)
        {
            gbCodeClient.Text += client.CodeClient;
            lblCNI.Text = client.NumeroCNI;
            lblAdresse.Text = client.Adresse;
            lblDateNaissance.Text = (client.DateNaissance != null) ? client.DateNaissance.Value.ToShortDateString() : client.DateNaissance.ToString();
            lblLieuNaissance.Text = client.LieuNaissance;
            lblNomComplet.Text = client.NomComplet;
            lblNumeroTelephone1.Text = client.NumeroTelephone1;
            lblNumeroTelephone2.Text = client.NumeroTelephone2;
            lblPays.Text = client.Pays.ToString();
            lblSexe.Text = client.Sexe.ToString();
            lblVille.Text = client.Ville.ToString();
            lblProfession.Text = client.Profession;

            pbProfil.Image = (client.PhotoProfil != string.Empty) ? Image.FromFile(client.PhotoProfil) : pbProfil.InitialImage;
        }

        private void btnMettreAJour_Click(object sender, EventArgs e)
        {
            Close();
            Visible = false;
            Frm_EditerClient frm = new Frm_EditerClient(this.employe, this.client, this.uc_GererClient);
            frm.ShowDialog();
        }

        private void Frm_InformationClient_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void gunaLabel18_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel14_Click(object sender, EventArgs e)
        {

        }
    }
}
