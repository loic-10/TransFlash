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

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms
{
    public partial class Frm_EditerCompte : Form
    {

        private Employe employe = null;

        private Frm_Fonction fonction = null;

        private int nombreBeneficier;

        private List<Uc_Beneficier> beneficiers = null;

        private List<Beneficier> beneficiersVraies = null;

        private CompteClient compteClient = null;

        private Uc_GererCompte uc_GererCompte = null;

        private int nombreBeneficierMin;

        private int nombreBeneficierMax;

        public Frm_EditerCompte(Uc_GererCompte uc_GererCompte, CompteClient compteClient, Employe employe)
        {
            InitializeComponent();
            this.employe = employe;
            fonction = new Frm_Fonction();
            this.compteClient = compteClient;
            this.uc_GererCompte = uc_GererCompte;

            nombreBeneficierMin = new ParametreGeneralBLO().TousParametreGenerals[0].NombreMinimalBeneficier;
            nombreBeneficierMax = new ParametreGeneralBLO().TousParametreGenerals[0].NombreMaximalBeneficier;
            nombreBeneficier = new BeneficierBLO().RechercherLesBeneficiersDuCompte(compteClient).Count();
            InitMesBeneficiers(nombreBeneficier);
        }

        private void InformationCompte(CompteClient compteClient)
        {

            beneficiersVraies = (List<Beneficier>) new BeneficierBLO().RechercherLesBeneficiersDuCompte(compteClient);

            //fonction.ChargerEnumerationComboBox(cmbSexe, Enum.GetNames(typeof(StatutSexe)));
            //fonction.ChargerPaysComboBox(cmbPays, new PaysBLO().TousPays);
            //fonction.ChargerCodePhoneComboBox(cmbCodeTelephone1, new PaysBLO().TousPays);
            //fonction.ChargerCodePhoneComboBox(cmbCodeTelephone2, new PaysBLO().TousPays);

            //gbClient.Text += client.CodeClient;
            //lblCodeClient.Text = client.CodeClient;
            //txbNumeroCNI.Text = client.NumeroCNI;
            //txbAdresse.Text = client.Adresse;
            //txbProfession.Text = client.Profession;

        }

        private void InitMesBeneficiers(int nbrBeneficier)
        {
            panelBeneficiers.Controls.Clear();
            beneficiersVraies = new List<Beneficier>(new BeneficierBLO().RechercherLesBeneficiersDuCompte(compteClient));
            beneficiers = new List<Uc_Beneficier>();
            for (int i = 0; i < nbrBeneficier; i++)
            {
                Uc_Beneficier beneficier = new Uc_Beneficier()
                {
                    NumBeneficier = beneficiers.Count + 1,
                    Nom = beneficiersVraies[i].Nom,
                    Description = beneficiersVraies[i].DescriptionCondition,
                    Pourcentage = beneficiersVraies[i].Pourcentage
                };
                panelBeneficiers.Controls.Add(beneficier);
                beneficiers.Add(beneficier);
            }
        }

        private void MesBeneficiers(int nbrBeneficier)
        {
            panelBeneficiers.Controls.Clear();

            while (beneficiers.Count < nbrBeneficier)
            {
                beneficiers.Add(new Uc_Beneficier()
                {
                    NumBeneficier = beneficiers.Count + 1,
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
                nombreBeneficier += 1;
                MesBeneficiers(nombreBeneficier);
                if (nombreBeneficier == nombreBeneficierMax)
                    btnAdd.Visible = false;
            }
        }
    }
}
