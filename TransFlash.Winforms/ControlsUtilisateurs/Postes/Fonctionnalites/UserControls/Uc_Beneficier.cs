using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_Beneficier : UserControl
    {
        public Uc_Beneficier()
        {
            InitializeComponent();
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
            set { _pourcentage = value; numPourcentage.Value = _pourcentage; }
        }

        [Category("Nouvelle category")]
        public int NumBeneficier
        {
            get { return _numBeneficier; }
            set { _numBeneficier = value; gbBeneficier.Text += _numBeneficier.ToString(); }
        }

        #endregion
    }
}
