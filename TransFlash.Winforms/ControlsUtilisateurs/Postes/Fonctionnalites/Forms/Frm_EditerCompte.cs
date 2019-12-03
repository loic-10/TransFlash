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

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms
{
    public partial class Frm_EditerCompte : Form
    {
        private int nombreBeneficier;

        private Uc_Beneficier[] beneficiers;

        public Frm_EditerCompte()
        {
            InitializeComponent();
            //string toto = "mama";
            //toto.PadLeft(5, '0');
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
                if (nombreBeneficier == 5)
                    btnAdd.Visible = false;
            }
        }
    }
}
