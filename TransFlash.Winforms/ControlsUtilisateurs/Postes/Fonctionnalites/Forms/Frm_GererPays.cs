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
    public partial class Frm_GererPays : Form
    {

        private Frm_Fonction fonction = null;

        private Pays pays = null;

        private Employe employe = null;

        private Uc_Pays uc_Pays = null;

        private Frm_GererVille frm_GererVille = null;

        private Uc_EnregistrerEmploye uc_EnregistrerEmploye = null;

        private Frm_EditerEmploye frm_EditerEmploye = null;

        private Frm_EditerClient frm_EditerClient = null;

        private Uc_EnregistrerClient uc_EnregistrerClient = null;

        public Frm_GererPays(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            this.employe = employe;
        }

        public Frm_GererPays(Employe employe, Uc_Pays uc_Pays) : this(employe)
        {
            this.uc_Pays = uc_Pays;
        }

        public Frm_GererPays(Employe employe, Frm_GererVille frm_GererVille) : this(employe)
        {
            this.frm_GererVille = frm_GererVille;
        }

        public Frm_GererPays(Employe employe, Uc_EnregistrerEmploye uc_EnregistrerEmploye) : this(employe)
        {
            this.uc_EnregistrerEmploye = uc_EnregistrerEmploye;
        }

        public Frm_GererPays(Employe employe, Uc_EnregistrerClient uc_EnregistrerClient) : this(employe)
        {
            this.uc_EnregistrerClient = uc_EnregistrerClient;
        }

        public Frm_GererPays(Employe employe, Frm_EditerEmploye frm_EditerEmploye) : this(employe)
        {
            this.frm_EditerEmploye = frm_EditerEmploye;
        }

        public Frm_GererPays(Employe employe, Frm_EditerClient frm_EditerClient) : this(employe)
        {
            this.frm_EditerClient = frm_EditerClient;
        }

        public Frm_GererPays(Employe employe, Uc_Pays uc_Pays, Pays pays) : this(employe, uc_Pays)
        {
            this.pays = pays;
            AfficheInformationPays(this.pays);
        }

        private void AfficheInformationPays(Pays pays)
        {
            txbNom.Text = pays.Nom;
            txbCodeTelephone.Text = pays.CodePhone.Split('+')[1];
        }

        private void InitForm()
        {
            txbNom.Text = string.Empty;
            txbCodeTelephone.Text = string.Empty;
        }

        private bool SiFormulaireRempliCorrectement => ((txbNom.Text != string.Empty) && (txbCodeTelephone.Text != string.Empty));

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (SiFormulaireRempliCorrectement)
                {
                    if (this.pays == null)
                    {
                        new PaysBLO().AjouterPays(txbNom.Text, int.Parse(txbCodeTelephone.Text), this.employe);
                        fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Ajout",
                            $"Pays ajoute !");
                        InitForm();
                    }
                    else
                    {
                        new PaysBLO().ModifierPays(this.pays, txbNom.Text, int.Parse(txbCodeTelephone.Text), this.employe);
                        fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Modification",
                            $"Pays modifie !");
                    }
                    if(uc_Pays != null)
                        uc_Pays.txbRechercher_TextChanged(sender, e);

                    if (frm_GererVille != null)
                    {
                        frm_GererVille.RefreshCMBPays();
                        Close();
                    }

                    if (uc_EnregistrerEmploye != null)
                    {
                        uc_EnregistrerEmploye.RefreshCMBPays();
                        Close();
                    }

                    if (uc_EnregistrerClient != null)
                    {
                        uc_EnregistrerClient.RefreshCMBPays();
                        Close();
                    }

                    if (frm_EditerEmploye != null)
                    {
                        frm_EditerEmploye.RefreshCMBPays();
                        Close();
                    }

                    if (frm_EditerClient != null)
                    {
                        frm_EditerClient.RefreshCMBPays();
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

        private void txbCodeTelephone_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbCodeTelephone);
        }
    }
}
