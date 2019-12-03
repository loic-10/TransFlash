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

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_AjouterCompteClient : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        private int nombreBeneficier;

        Uc_Beneficier[] beneficiers = null;

        public Uc_AjouterCompteClient()
        {
            InitializeComponent();
            nombreBeneficier = 2;

            MesBeneficiers(nombreBeneficier);
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
            Uc_GererCompte frm = new Uc_GererCompte();
            fonction.AfficherPageChoisie(this, frm);
        }
    }
}
