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
    public partial class Uc_InitierRetrait : UserControl
    {

        private Frm_Fonction fonction = null;

        private Client client = null;

        private Employe employe = null;

        public Uc_InitierRetrait(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();

            this.employe = employe;
            InitForm();
        }
        private void AfficherClient(Client client)
        {
            Uc_ClientTrouve frm = new Uc_ClientTrouve(client);
            panelClient.Controls.Clear();
            panelClient.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
        }

        private void InformationClient(Client client)
        {
            AfficherClient(client);
            txbCodeDepot.Text = new TransactionBLO().CodeTransaction(TypeTransaction.Dépot);
        }

        public void InitForm()
        {
            this.client = null;
            cmbTypeCompte.Items.Clear();
            gbInformationDepot.Enabled = false;

            txbCodeDepot.Text = new TransactionBLO().CodeTransaction(TypeTransaction.Retrait);

            InitGBInfoCompte();

        }

        private void InformationEmploye(Client client)
        {

            txbCodeDepot.Text = new TransactionBLO().CodeTransaction(TypeTransaction.Retrait);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelClient.Controls.Clear();
            Uc_GererTransaction frm = new Uc_GererTransaction(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void txbRecherche_TextChanged(object sender, EventArgs e)
        {
            this.client = new ClientBLO().RechercherUnClient(txbRecherche.Text);
            if (this.client == null)
                InitForm();
            InformationClient(client);

            gbInformationCompte.Enabled = fonction.RendreValideControl(this.client);
        }

        private void cmbTypeCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbIdentifiantEpargne_TextChanged(sender, e);
            InitGBInfoDepot();
            cmbChoixCompte_SelectedIndexChanged(sender, e);
            txbNombreJourAttente.Text = (cmbTypeCompte.Text == TypeCompte.Epargne.ToString() ?
                        new ParametreGeneralBLO().TousParametreGenerals[0].NombreJourRetraitAviseDeEpargne.ToString() :
                        "0");
        }

        private void InitGBInfoDepot()
        {
            cmbChoixCompte.Items.Clear();
            fonction.ChargerCompteClientComboBox(cmbChoixCompte, 
                new CompteClientBLO().RechercherLesComptesClientsDuClientEnFonctionDuType(this.client != null ? this.client : new Client("Indefini"), 
                cmbTypeCompte.Text));
            txbMontantDepot.Text = string.Empty;
        }

        private void InitGBInfoCompte()
        {
            cmbTypeCompte.Items.Clear();
            fonction.ChargerEnumerationComboBox(cmbTypeCompte, Enum.GetNames(typeof(TypeCompte)));
            cmbTypeCompte.SelectedIndex = -1;
            InitGBInfoDepot();
            txbIdentifiantEpargne.Text = "0";
        }

        private void txbMontantDepot_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbMontantDepot);
            lblPossibilite.Text = PossibiliteRetrait(double.Parse(txbMontantDepot.Text != string.Empty ? txbMontantDepot.Text : "0"),
                new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text)) ?
                StatutPossibilite.Possible.ToString() :
                StatutPossibilite.Impossible.ToString();


            lblPossibilite.ForeColor = PossibiliteRetrait(double.Parse(txbMontantDepot.Text != string.Empty ? txbMontantDepot.Text : "0"),
                new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text)) ?
                Color.Green :
                Color.Crimson;
        }

        private bool PossibiliteRetrait(double montant, CompteClient compteClient) => 
            montant >= new ParametreGeneralBLO().TousParametreGenerals[0].MontantMininimumDepot &&
            (montant +
                (compteClient.TypeCompte == TypeCompte.Courant ? 
                new CompteClientBLO().CalculFraiesRetrait(montant) : 
                0)
            ) <= new CompteClientBLO().MontantSoldeCompteClient(compteClient) &&
            ((compteClient.TypeCompte == TypeCompte.Courant) ? 
            (new CompteClientBLO().MontantSoldeCompteClient(compteClient) + montant) <= new ParametreGeneralBLO().TousParametreGenerals[0].SoldeMaximalCompteCourant :
            true);

        private void cmbChoixCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbIdentifiantEpargne_TextChanged(sender, e);
            gbInformationDepot.Enabled = (cmbChoixCompte.SelectedIndex > -1) ? true : false;
            lblMontantCompte.Text = (cmbChoixCompte.SelectedIndex > -1) ? 
                new CompteClientBLO().MontantSoldeCompteClient(new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text)).ToString() : 
                string.Empty;
            txbMontantDepot_TextChanged(sender, e);
        }

        private void txbIdentifiantEpargne_TextChanged(object sender, EventArgs e)
        {
            txbIdentifiantEpargne.Text = cmbTypeCompte.Text == TypeCompte.Courant.ToString() ?
            "0" :
            (cmbChoixCompte.SelectedIndex > -1) ?
                (new EpargneBLO().RechercherEpargneEnCoursDuCompte(new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text)) != null) ?
                new EpargneBLO().RechercherEpargneEnCoursDuCompte(new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text)).ToString() :
                "0": "0" ;
        }

        private bool SiFormulaireRempliCorrectement =>
            this.client != null &&
            cmbTypeCompte.Text != string.Empty &&
            cmbChoixCompte.Text != string.Empty &&
            txbIdentifiantEpargne.Text != string.Empty &&
            txbMontantDepot.Text != string.Empty &&
            txbCodeDepot.Text != string.Empty &&
            cmbChoixCompte.Text != string.Empty &&
            PossibiliteRetrait(double.Parse(txbMontantDepot.Text), new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text));

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (SiFormulaireRempliCorrectement)
                {
                    Transaction transaction = new TransactionBLO().RechercherUneTransactionEnCours(new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text));
                    if (transaction == null)
                    {
                        new TransactionBLO().InitierTransaction(RetourTypeCompte(cmbTypeCompte.Text), TypeTransaction.Retrait,
                            new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text),
                        new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text), this.employe, double.Parse(txbMontantDepot.Text),
                        cmbTypeCompte.Text == TypeCompte.Epargne.ToString() ?
                        new ParametreGeneralBLO().TousParametreGenerals[0].NombreJourRetraitAviseDeEpargne :
                        0);

                        fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Initialisation", $"Retrait initie !");

                        txbRecherche.Text = string.Empty;
                        InitForm();
                    }
                    else
                        fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Initialisation", $"Veillez d'abord finaliser " +
                            $"{transaction.TypeTransaction} {transaction.CodeTransaction} !");
                }
                else
                    fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Initialisation", "Veillez remplir tous les champs !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AfficherClient(this.client);
            txbRecherche.Text = client != null ? client.CodeClient : string.Empty;
        }
    }
}
