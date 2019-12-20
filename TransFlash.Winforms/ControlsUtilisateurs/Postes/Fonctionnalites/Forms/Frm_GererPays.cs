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

        private PaysBLO paysBLO = null;

        public Frm_GererPays(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            this.employe = employe;
            paysBLO = new PaysBLO();
        }

        public Frm_GererPays(Employe employe, Pays pays) : this(employe)
        {
            this.pays = pays;
            AfficheInformationPays(this.pays);
        }

        private void AfficheInformationPays(Pays pays)
        {
            txbNom.Text = pays.Nom;
            txbCodeTelephone.Text = pays.CodePhone;
        }

        private void InitForm()
        {
            txbNom.Text = string.Empty;
            txbCodeTelephone.Text = string.Empty;
            this.pays = null;
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
                        paysBLO.AjouterPays(txbNom.Text, txbCodeTelephone.Text, this.employe);
                        fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Ajout",
                            $"Pays ajoute !");
                    }
                    else
                    {
                        paysBLO.ModifierPays(this.pays, txbNom.Text, txbCodeTelephone.Text, this.employe);
                        fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Modification",
                            $"Pays modifie !");
                    }
                    InitForm();
                }
                else
                    fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Modification", "Veillez remplir tous les champs !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
