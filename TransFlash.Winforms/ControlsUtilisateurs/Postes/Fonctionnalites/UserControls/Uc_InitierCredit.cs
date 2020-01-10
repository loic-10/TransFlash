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
using TransFlash.BLL;
using static TransFlash.BO.Statut;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_InitierCredit : UserControl
    {

        private Employe employe = null;

        private Frm_Fonction fonction = null;

        private int nombreBeneficier;

        private List<Uc_Fichier> fichiers = null;

        private Credit credit = null;

        private Client client = null;

        public Uc_InitierCredit(Employe employe)
        {
            InitializeComponent();
            this.employe = employe;
            fonction = new Frm_Fonction();
            InitForm();
        }

        public Uc_InitierCredit(Employe employe, Credit credit) : this(employe)
        {
            InformationCredit(credit);
            this.credit = credit;
            this.client = credit.Client;
            gbInformationCredit.Enabled = false;
            gbInformationAvanceCredit.Visible = true;
        }

        private void AfficherClient(Client client)
        {
            Uc_ClientTrouve frm = new Uc_ClientTrouve(client);
            panelClient.Controls.Clear();
            panelClient.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelClient.Controls.Clear();
            Uc_GererCredit frm = new Uc_GererCredit(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void InformationClient(Client client)
        {
            AfficherClient(client);
        }

        public void InitForm()
        {
            txbCodeCredit.Text = (cmbTypeCredit.SelectedIndex > -1) ? new CreditBLO().CodeCredit(RetourTypeCredit(cmbTypeCredit.Text)) : string.Empty;
            cmbTypeCredit.Items.Clear();
            fichiers = new List<Uc_Fichier>();
            fonction.ChargerEnumerationComboBox(cmbTypeCredit, Enum.GetNames(typeof(TypeCredit)));
            nombreBeneficier = 2;
            MesFichiers(nombreBeneficier);
            //AfficherClient(null);

        }

        private void txbRecherche_TextChanged(object sender, EventArgs e)
        {
            this.client = new ClientBLO().RechercherUnClient(txbRecherche.Text);
            if (this.client == null)
                InitForm();
            InformationClient(client);
            if(credit == null)
                gbInformationCredit.Enabled = fonction.RendreValideControl(this.client);
        }

        private void ReinitialiserInfoAvaliste()
        {
            txbIdAvaliste.Text = string.Empty;
            txbNomAvaliste.Text = string.Empty;
            txbProfessionAvaliste.Text = string.Empty;
            txbDescriptionAvaliste.Text = string.Empty;
            txbMontantMois.Text = string.Empty;
        }

        private void checkAvaliste_CheckedChanged(object sender, EventArgs e)
        {
            gbInformationAvaliste.Enabled = checkAvaliste.Checked;
            ReinitialiserInfoAvaliste();
            if(checkAvaliste.Checked)
                txbIdAvaliste.Text = new IdentifiantBLO().IdAvaliste.ToString();
            txbMontantEvaluationGarantie.Text = string.Empty;
        }

        private void txbMontantMois_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbMontantMois);
            btnRefreshMontantGarantie_Click(sender, e);
        }

        private void txbMontantCredit_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbMontantCredit);
        }

        private void txbMontantEvaluationGarantie_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbMontantEvaluationGarantie);
        }

        private void MesFichiers(int nbrBeneficier)
        {
            panelFichier.Controls.Clear();

            while (fichiers.Count < nbrBeneficier)
            {
                fichiers.Add(new Uc_Fichier()
                {
                    NumFichier = fichiers.Count + 1
                });
            }

            for (int i = 0; i < nbrBeneficier; i++)
            {
                panelFichier.Controls.Add(fichiers[i]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nombreBeneficier += 1;
            MesFichiers(nombreBeneficier);
            btnRefreshMontantGarantie_Click(sender, e);
        }

        private void Uc_InitierCredit_Load(object sender, EventArgs e)
        {
        }

        private void InformationCredit(Credit credit)
        {
            cmbTypeCredit.Text = credit.TypeCredit.ToString();
            txbCodeCredit.Text = credit.CodeCredit;
            txbMontantCredit.Text = credit.MontantEmprunte.ToString();
            txbRecherche.Enabled = false;
            txbIdAvaliste.Text = checkAvaliste.Checked ? new IdentifiantBLO().IdAvaliste.ToString() : string.Empty;
        }

        private bool SiFormulaireInitiationRempliCorrectement =>
            this.client != null &&
            cmbTypeCredit.Text != string.Empty &&
            double.Parse(txbMontantCredit.Text) > 0 &&
            txbCodeCredit.Text != string.Empty;

        private bool SiFormulaireAvalisteRempliCorrectement =>
            txbIdAvaliste.Text != string.Empty &&
            txbNomAvaliste.Text != string.Empty &&
            txbProfessionAvaliste.Text != string.Empty &&
            txbDescriptionAvaliste.Text != string.Empty &&
            double.Parse(txbMontantMois.Text) > 0;

        private bool SiGarrantieRempliCorrectement =>
            int.Parse(txbDureeTotalCredit.Text) > 0 &&
            txbDescription.Text != string.Empty &&
            double.Parse(txbMontantEvaluationGarantie.Text) > 0;

        private double MontantTotalGarantie (List<Uc_Fichier> fichiers)
        {
            double montant = 0;
            foreach (var fichier in fichiers)
            {
                if (fichier.FormulaireRempliCorrectement)
                    montant += fichier.MontantEvaluation;
            }
            return montant;
        }

        private void EnregistrerBeneficier(List<Uc_Fichier> fichiers, Credit credit)
        {
            foreach (var fichier in fichiers)
            {
                if (fichier.FormulaireRempliCorrectement)
                {
                    new FichierStockeBLO().AjouterFichierStocke(fichier.Nom, fichier.FileName, this.client, credit.Garantie, fichier.MontantEvaluation, 
                        fichier.StatutStockage, this.employe);
                }
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (SiFormulaireInitiationRempliCorrectement)
                {
                    if (this.credit == null)
                    {
                        if (RetourTypeCredit(cmbTypeCredit.Text) == TypeCredit.Decouvert)
                            new CreditBLO().DemanderDecouvert(this.client, double.Parse(txbMontantCredit.Text), this.employe);
                        else if (RetourTypeCredit(cmbTypeCredit.Text) == TypeCredit.Credit_normal)
                            new CreditBLO().DemanderCredit(TypeCredit.Credit_normal, 0, this.client, double.Parse(txbMontantCredit.Text), this.employe);

                        fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Initialisation", $"Credit initie !");
                        txbRecherche.Text = string.Empty;
                        this.client = null;
                        InitForm();
                    }
                    else
                    {
                        btnRefreshMontantGarantie_Click(sender, e);
                        if ((SiFormulaireAvalisteRempliCorrectement && checkAvaliste.Checked) || (!SiFormulaireAvalisteRempliCorrectement && !checkAvaliste.Checked))
                        {
                            if (SiGarrantieRempliCorrectement)
                            {
                                if (double.Parse(txbMontantCredit.Text) <= double.Parse(txbMontantEvaluationGarantie.Text))
                                {
                                    Avaliste avaliste = new Avaliste(0);
                                    new GarantieBLO().ModifierGarantie(credit.Garantie, double.Parse(txbMontantEvaluationGarantie.Text), avaliste, credit, this.employe);
                                    if (checkAvaliste.Checked)
                                    {
                                        avaliste = new Avaliste(new IdentifiantBLO().IdAvaliste, new GarantieBLO().RechercherGarantie(credit.Garantie.Id), txbNomAvaliste.Text,
                                            txbProfessionAvaliste.Text, txbDescriptionAvaliste.Text, double.Parse(txbMontantMois.Text));
                                        new GarantieBLO().ModifierGarantie(credit.Garantie, double.Parse(txbMontantEvaluationGarantie.Text), avaliste, credit, this.employe);
                                    }
                                    new CreditBLO().CompleterCredit(credit, double.Parse(txbMontantEvaluationGarantie.Text),
                                        new GarantieBLO().RechercherGarantie(credit.Garantie.Id), int.Parse(txbDureeTotalCredit.Text), avaliste, this.employe);

                                    EnregistrerBeneficier(fichiers, new CreditBLO().RechercherCredit(txbCodeCredit.Text));

                                    fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Initialisation", $"Credit complete !");

                                    txbRecherche.Text = string.Empty;
                                    InitForm();
                                    btnBack_Click(sender, e);
                                }
                                else
                                    fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Initialisation", "Le montant de la garantie doit compenser celui du credit !");
                            }
                            else
                                fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Initialisation", "Erreur sur le remplissage des garanties !");
                        }
                        else
                            fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Initialisation", "Veillez remplir tous les champs !");
                    }
                }
                else
                    fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Initialisation", "Veillez remplir tous les champs !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbDureeTotalCredit_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbDureeTotalCredit);
            if(txbDureeTotalCredit.Text != string.Empty)
                txbDureeTotalCredit.Text = int.Parse(txbDureeTotalCredit.Text) > 0 ? txbDureeTotalCredit.Text : "1";
            btnRefreshMontantGarantie_Click(sender, e);
        }

        private void btnRefreshMontantGarantie_Click(object sender, EventArgs e)
        {
            txbMontantEvaluationGarantie.Text = (MontantTotalGarantie(this.fichiers) + 
                ((txbMontantMois.Text != string.Empty ? double.Parse(txbMontantMois.Text) : 0) * 
                (txbDureeTotalCredit.Text != string.Empty ? int.Parse(txbDureeTotalCredit.Text) : 1))).ToString();
        }

        private void gunaLabel13_Click(object sender, EventArgs e)
        {

        }

        private void gbClient_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AfficherClient(this.client);
            txbRecherche.Text = client != null ? client.CodeClient : string.Empty;
        }

        private void cmbTypeCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTypeCredit.SelectedIndex > -1)
                txbCodeCredit.Text = new CreditBLO().CodeCredit(RetourTypeCredit(cmbTypeCredit.Text));
        }
    }
}
