using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransFlash.Winforms.Fonctions;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_Beneficier : UserControl
    {

        private Frm_Fonction fonction = null;

        public Uc_Beneficier()
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
        }


        #region Propriete

        private int _numBeneficier;
        private string _nom;
        private string _description;
        private int _pourcentage;

        [Category("Nouvelle category")]
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; txbNom.Text = _nom; }
        }

        [Category("Nouvelle category")]
        public string Description 
        {
            get { return _description; }
            set { _description = value; txbDescription.Text = _description; }
        }

        [Category("Nouvelle category")]
        public int Pourcentage
        {
            get { return _pourcentage; }
            set { _pourcentage = value; txbPourcentage.Text = _pourcentage.ToString(); }
        }

        [Category("Nouvelle category")]
        public int NumBeneficier
        {
            get { return _numBeneficier; }
            set { _numBeneficier = value; gbBeneficier.Text += _numBeneficier.ToString(); }
        }

        #endregion

        private void txbNom_TextChanged(object sender, EventArgs e)
        {
            Nom = txbNom.Text;
        }

        private void txbDescription_TextChanged(object sender, EventArgs e)
        {
            Description = txbDescription.Text;
        }

        private void txbPourcentage_TextChanged(object sender, EventArgs e)
        {
            if (txbPourcentage.Text.Length <= 2)
            {
                fonction.PrendreUniquementChiffre(txbPourcentage);
                Pourcentage = int.Parse((txbPourcentage.Text != string.Empty) ? txbPourcentage.Text : 0.ToString());
            }
            else
            {
                txbPourcentage.Text = 100.ToString();
            }
        }
    }
}
