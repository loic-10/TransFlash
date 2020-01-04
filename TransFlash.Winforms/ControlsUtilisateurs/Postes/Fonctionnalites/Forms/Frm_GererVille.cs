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
    public partial class Frm_GererVille : Form
    {

        private Frm_Fonction fonction = null;

        private Ville ville = null;

        private Employe employe = null;

        private Uc_Villes uc_Ville = null;

        private Uc_EnregistrerEmploye uc_EnregistrerEmploye = null;

        private Frm_EditerEmploye frm_EditerEmploye = null;

        private Frm_EditerClient frm_EditerClient = null;

        private Uc_EnregistrerClient uc_EnregistrerClient = null;

        private bool isClosed = true;

        public Frm_GererVille(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            this.employe = employe;
            cmbPays.Items.Clear();
            fonction.ChargerPaysComboBox(cmbPays, new PaysBLO().TousPays);
            cmbPays.Items.Add("add new land >>");
        }

        public Frm_GererVille(Employe employe, Uc_Villes uc_Ville) : this(employe)
        {
            this.uc_Ville = uc_Ville;
        }

        public Frm_GererVille(Employe employe, Uc_EnregistrerEmploye uc_EnregistrerEmploye) : this(employe)
        {
            this.uc_EnregistrerEmploye = uc_EnregistrerEmploye;
        }

        public Frm_GererVille(Employe employe, Uc_EnregistrerClient uc_EnregistrerClient) : this(employe)
        {
            this.uc_EnregistrerClient = uc_EnregistrerClient;
        }

        public Frm_GererVille(Employe employe, Frm_EditerEmploye frm_EditerEmploye) : this(employe)
        {
            this.frm_EditerEmploye = frm_EditerEmploye;
        }

        public Frm_GererVille(Employe employe, Frm_EditerClient frm_EditerClient) : this(employe)
        {
            this.frm_EditerClient = frm_EditerClient;
        }

        public Frm_GererVille(Employe employe, Uc_Villes uc_Ville, Ville Ville) : this(employe, uc_Ville)
        {
            this.ville = Ville;
            AfficheInformationVille(this.ville);
        }

        public void RefreshCMBPays()
        {
            cmbPays.Items.Clear();
            fonction.ChargerPaysComboBox(cmbPays, new PaysBLO().TousPays);
            cmbPays.Items.Add("add new land >>");
            cmbPays.SelectedIndex = cmbPays.Items.Count - 2;
        }

        private void AfficheInformationVille(Ville ville)
        {
            try
            {
                cmbPays.Items.Clear();
                fonction.ChargerPaysComboBox(cmbPays, new PaysBLO().TousPays);
                cmbPays.Text = ville.Pays.Nom;
                txbNom.Text = this.ville.Nom;
                cmbPays.Items.Add("add new land >>");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitForm()
        {
            txbNom.Text = string.Empty;
            cmbPays.Items.Clear();
            fonction.ChargerPaysComboBox(cmbPays, new PaysBLO().TousPays);
            cmbPays.Items.Add("add new land >>");
            cmbPays.SelectedIndex = -1;
        }

        private bool SiFormulaireRempliCorrectement => ((txbNom.Text != string.Empty) && (cmbPays.Text != string.Empty));

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (SiFormulaireRempliCorrectement)
                {
                    int pays = cmbPays.SelectedIndex;
                    if (this.ville == null)
                    {
                        new VilleBLO().AjouterVille(txbNom.Text, new PaysBLO().RechercherUnPays(cmbPays.Text), this.employe);
                        fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Ajout",
                            $"Ville ajoute !");
                        InitForm();
                    }
                    else
                    {
                        new VilleBLO().ModifierVille(this.ville, txbNom.Text, new PaysBLO().RechercherUnPays(cmbPays.Text), this.employe);
                        fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Modification",
                            $"Ville modifie !");
                    }
                    if (uc_Ville != null)
                    {
                        uc_Ville.txbRecherche_TextChanged(sender, e);
                    }

                    if (frm_EditerEmploye != null)
                    {
                        isClosed = false;
                        frm_EditerEmploye.RefreshCMBVille(pays);
                        Close();
                    }

                    if (frm_EditerClient != null)
                    {
                        isClosed = false;
                        frm_EditerClient.RefreshCMBVille(pays);
                        Close();
                    }

                    if (uc_EnregistrerEmploye != null)
                    {
                        isClosed = false;
                        uc_EnregistrerEmploye.RefreshCMBVille(pays);
                        Close();
                    }

                    if (uc_EnregistrerClient != null)
                    {
                        isClosed = false;
                        uc_EnregistrerClient.RefreshCMBVille(pays);
                        Close();
                    }
                }
                else
                    fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Modification", "Veillez remplir tous les champs !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPays.SelectedIndex == cmbPays.Items.Count - 1)
            {
                cmbPays.SelectedIndex = -1;
                new Frm_GererPays(this.employe, this).ShowDialog();
            }
        }

        private void Frm_GererVille_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isClosed)
            {
                if(uc_EnregistrerEmploye != null)
                    uc_EnregistrerEmploye.RefreshCMBVille(-1);
                    
                if(uc_EnregistrerClient != null)
                    uc_EnregistrerClient.RefreshCMBVille(-1);

                if(frm_EditerEmploye != null)
                    frm_EditerEmploye.RefreshCMBVille(-1);

                if(frm_EditerClient != null)
                    frm_EditerClient.RefreshCMBVille(-1);

            }
        }
    }
}
