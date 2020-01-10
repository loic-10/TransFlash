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
using static TransFlash.BO.Statut;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_Fichier : UserControl
    {

        private Frm_Fonction fonction = null;

        public Uc_Fichier()
        {
            InitializeComponent();
            fonction = new Frm_Fonction();
            fonction.ChargerEnumerationComboBox(cmbStatutStockage, Enum.GetNames(typeof(StatutStockage)));
        }


        #region Propriete

        private int _numFichier;
        private string _nom;
        private double _montant;
        private StatutStockage? _statutStockage;
        private string _fileName;

        [Category("Nouvelle category")]
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; txbNom.Text = _nom; }
        }

        [Category("Nouvelle category")]
        public StatutStockage? StatutStockage 
        {
            get { return _statutStockage; }
            set { _statutStockage = value; cmbStatutStockage.Text = _statutStockage.ToString(); }
        }

        [Category("Nouvelle category")]
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; txbFileName.Text = _fileName.ToString(); }
        }

        [Category("Nouvelle category")]
        public double MontantEvaluation
        {
            get { return _montant; }
            set { _montant = value; txbMontantEvaluation.Text = _montant.ToString(); }
        }

        [Category("Nouvelle category")]
        public int NumFichier
        {
            get { return _numFichier; }
            set { _numFichier = value; gbFichier.Text += _numFichier.ToString(); }
        }

        #endregion

        private void txbNom_TextChanged(object sender, EventArgs e)
        {
            Nom = txbNom.Text;
        }

        private void cmbStatutStockage_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txbFileName_TextChanged(object sender, EventArgs e)
        {
            FileName = txbFileName.Text;
        }

        private void btnImporterFichier_Click(object sender, EventArgs e)
        {
            fonction.ImporterFichier(txbFileName);
            FileName = fonction.FileName(txbFileName);
        }

        private void Uc_Fichier_Load(object sender, EventArgs e)
        {
            fonction.ChargerEnumerationComboBox(cmbStatutStockage, Enum.GetNames(typeof(StatutStockage)));
        }

        private void txbMontantEvaluation_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbMontantEvaluation);
            MontantEvaluation = double.Parse(txbMontantEvaluation.Text != string.Empty ? txbMontantEvaluation.Text : "0");
        }

        public bool FormulaireRempliCorrectement =>
            Nom != string.Empty &&
            FileName != string.Empty &&
            StatutStockage != null &&
            MontantEvaluation > 0;
    }
}
