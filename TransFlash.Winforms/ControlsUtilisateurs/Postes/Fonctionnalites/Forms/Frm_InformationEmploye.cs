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

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms
{
    public partial class Frm_InformationEmploye : Form
    {

        private Employe employe = null;

        private Employe employeChef = null;

        public Frm_InformationEmploye(Employe employeChef, Employe employe)
        {
            InitializeComponent();
            this.employeChef = employeChef;
            this.employe = employe;
            InformationEmploye(this.employe);
        }

        private void InformationEmploye(Employe employe)
        {
            gbCodeEmploye.Text += employe.CodeEmploye;
            lblCNI.Text = employe.NumeroCNI;
            lblAdresse.Text = employe.Adresse;
            lblDateNaissance.Text = employe.DateNaissance.ToString();
            lblLieuNaissance.Text = employe.LieuNaissance;
            lblNomComplet.Text = employe.NomComplet;
            lblNumeroTelephone1.Text = employe.NumeroTelephone1;
            lblNumeroTelephone2.Text = employe.NumeroTelephone2;
            lblPays.Text = employe.Pays.ToString();
            lblSexe.Text = employe.Sexe.ToString();
            lblVille.Text = employe.Ville.ToString();
        }

        private void btnMettreAJour_Click(object sender, EventArgs e)
        {
            Close();
            Visible = false;
            Frm_EditerEmploye frm = new Frm_EditerEmploye(this.employeChef, this.employe) ;
            frm.ShowDialog();
        }
    }
}
