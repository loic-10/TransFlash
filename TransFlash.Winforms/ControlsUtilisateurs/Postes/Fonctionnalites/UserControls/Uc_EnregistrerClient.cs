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

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_EnregistrerClient : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        private int nombreBeneficier;

        Uc_Beneficier[] beneficiers = null;

        public Uc_EnregistrerClient()
        {
            InitializeComponent();
            nombreBeneficier = 2;
            

            MesBeneficiers(nombreBeneficier);
        }

        public void InitForm()
        {
            cmbSexe.DataSource = Statut.StatutSexe;
            cmbSexe.SelectedIndex = -1;
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
            Uc_GererClient frm = new Uc_GererClient();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            btnBack_Click(sender, e);
        }

        private void Uc_EnregistrerClient_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void txbNomStructure_TextChanged(object sender, EventArgs e)
        {
            string[] text = new string[txbNomStructure.Text.Length];
            string val = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (txbNomStructure.Text[i] == '0' || txbNomStructure.Text[i] == '1' || txbNomStructure.Text[i] == '2' || txbNomStructure.Text[i] == '3' || 
                    txbNomStructure.Text[i] == '4' || txbNomStructure.Text[i] == '5' || txbNomStructure.Text[i] == '6' || txbNomStructure.Text[i] == '7' || 
                    txbNomStructure.Text[i] == '8' || txbNomStructure.Text[i] == '9')
                {
                    val += txbNomStructure.Text[i].ToString();
                    txbNomStructure.Focus();
                }
            }

            txbNomStructure.Text = val;
            txbNomStructure.Select(val.Length, val.Length);
        }
    }
}
