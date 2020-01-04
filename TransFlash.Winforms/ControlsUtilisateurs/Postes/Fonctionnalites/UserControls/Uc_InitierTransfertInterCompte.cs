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
    public partial class Uc_InitierTransfertInterCompte : UserControl
    {

        private Frm_Fonction fonction = null;

        private Client clientEmetteur = null;

        private Client clientRecepteur = null;

        private Employe employe = null;

        public Uc_InitierTransfertInterCompte(Employe employe)
        {
            InitializeComponent();
            fonction = new Frm_Fonction();

            this.employe = employe;
            InitFormEmeteur();
            InitFormRecepteur();
        }

        private void InformationClientEmetteur(Client client)
        {
            fonction.ChargerPaysComboBox(cmbPays, new PaysBLO().TousPays);
            fonction.ChargerVillesComboBox(cmbVille, new VilleBLO().ToutesVilles);
            fonction.ChargerEnumerationComboBox(cmbSexe, Enum.GetNames(typeof(StatutSexe)));
            lblCodeClient.Text = client.CodeClient;
            txbNumeroCNI.Text = client.NumeroCNI;
            txbAdresse.Text = client.Adresse;
            txbProfession.Text = client.Profession;

            if (client.DateNaissance != null)
                dtDateNaissance.Value = client.DateNaissance.GetValueOrDefault();

            txbLieuNaissance.Text = client.LieuNaissance;
            txbNomComplet.Text = client.NomComplet;

            cmbCodeTelephone1.Text = client.NumeroTelephone1.Split(' ')[0];
            txbNumero1.Text = client.NumeroTelephone1.Split(' ')[1];

            cmbCodeTelephone2.Text = client.NumeroTelephone2.Split(' ')[0];
            txbNumero2.Text = client.NumeroTelephone2.Split(' ')[1];

            if (client.Pays.ToString() != "Indefini")
                cmbPays.Text = client.Pays.ToString();

            if (client.Sexe.ToString() != null)
                cmbSexe.Text = client.Sexe.ToString();

            if (client.Ville.ToString() != "Indefini")
                cmbVille.Text = client.Ville.ToString();

            pbClient.Image = (client.PhotoProfil != string.Empty) ? Image.FromFile(client.PhotoProfil) : pbClient.InitialImage;
            if (client.PhotoProfil != string.Empty)
                pbClient.ImageLocation = client.PhotoProfil;
            else
                pbClient.Image = pbClient.InitialImage;

            txbCodeDepot.Text = new TransactionBLO().CodeTransaction(TypeTransaction.Transfert_inter_compte);
        }

        private void InformationClientRecepteur(Client client)
        {
            fonction.ChargerPaysComboBox(cmbPays2, new PaysBLO().TousPays);
            fonction.ChargerVillesComboBox(cmbVille2, new VilleBLO().ToutesVilles);
            fonction.ChargerEnumerationComboBox(cmbSexe2, Enum.GetNames(typeof(StatutSexe)));
            lblCodeClient2.Text = client.CodeClient;
            txbNumeroCNI2.Text = client.NumeroCNI;
            txbAdresse2.Text = client.Adresse;
            txbProfession2.Text = client.Profession;

            if (client.DateNaissance != null)
                dtDateNaissance2.Value = client.DateNaissance.GetValueOrDefault();

            txbLieuNaissance2.Text = client.LieuNaissance;
            txbNomComplet2.Text = client.NomComplet;

            cmbCodeTelephone12.Text = client.NumeroTelephone1.Split(' ')[0];
            txbNumero12.Text = client.NumeroTelephone1.Split(' ')[1];

            cmbCodeTelephone22.Text = client.NumeroTelephone2.Split(' ')[0];
            txbNumero22.Text = client.NumeroTelephone2.Split(' ')[1];

            if (client.Pays.ToString() != "Indefini")
                cmbPays2.Text = client.Pays.ToString();

            if (client.Sexe.ToString() != null)
                cmbSexe2.Text = client.Sexe.ToString();

            if (client.Ville.ToString() != "Indefini")
                cmbVille2.Text = client.Ville.ToString();

            pbClient2.Image = (client.PhotoProfil != string.Empty) ? Image.FromFile(client.PhotoProfil) : pbClient2.InitialImage;
            if (client.PhotoProfil != string.Empty)
                pbClient2.ImageLocation = client.PhotoProfil;
            else
                pbClient2.Image = pbClient.InitialImage;

            txbCodeDepot.Text = new TransactionBLO().CodeTransaction(TypeTransaction.Transfert_inter_compte);
        }

        public void InitFormEmeteur()
        {
            this.clientEmetteur = null;
            cmbSexe.Items.Clear();
            cmbTypeCompte.Items.Clear();
            lblCodeClient.Text = string.Empty;
            txbNumeroCNI.Text = string.Empty;
            txbNomComplet.Text = string.Empty;
            txbLieuNaissance.Text = string.Empty;
            dtDateNaissance.Value = DateTime.Now.Date;
            txbNumero1.Text = string.Empty;
            txbNumero2.Text = string.Empty;
            txbAdresse.Text = string.Empty;
            txbProfession.Text = string.Empty;
            fonction.ChargerEnumerationComboBox(cmbSexe, Enum.GetNames(typeof(StatutSexe)));
            cmbSexe.SelectedIndex = -1;
            cmbPays.SelectedIndex = -1;
            cmbVille.SelectedIndex = -1;
            cmbCodeTelephone1.SelectedIndex = -1;
            cmbCodeTelephone2.SelectedIndex = -1;
            lblCodeClient.Text = string.Empty;
            pbClient.Image = pbClient.InitialImage;
            gbInformationTransfertInterCompte.Enabled = false;

            txbCodeDepot.Text = new TransactionBLO().CodeTransaction(TypeTransaction.Transfert_inter_compte);

            InitGBInfoCompteEmetteur();

        }

        public void InitFormRecepteur()
        {
            this.clientRecepteur = null;
            cmbSexe2.Items.Clear();
            cmbTypeCompte2.Items.Clear();
            lblCodeClient2.Text = string.Empty;
            txbNumeroCNI2.Text = string.Empty;
            txbNomComplet2.Text = string.Empty;
            txbLieuNaissance2.Text = string.Empty;
            dtDateNaissance2.Value = DateTime.Now.Date;
            txbNumero12.Text = string.Empty;
            txbNumero22.Text = string.Empty;
            txbAdresse2.Text = string.Empty;
            txbProfession2.Text = string.Empty;
            fonction.ChargerEnumerationComboBox(cmbSexe2, Enum.GetNames(typeof(StatutSexe)));
            cmbSexe2.SelectedIndex = -1;
            cmbPays2.SelectedIndex = -1;
            cmbVille2.SelectedIndex = -1;
            cmbCodeTelephone12.SelectedIndex = -1;
            cmbCodeTelephone22.SelectedIndex = -1;
            lblCodeClient2.Text = string.Empty;
            pbClient2.Image = pbClient.InitialImage;
            gbInformationTransfertInterCompte.Enabled = false;

            txbCodeDepot.Text = new TransactionBLO().CodeTransaction(TypeTransaction.Transfert_inter_compte);

            InitGBInfoCompteRecepteur();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Uc_GererTransaction frm = new Uc_GererTransaction(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        private void txbRecherche_TextChanged(object sender, EventArgs e)
        {
            this.clientEmetteur = new ClientBLO().RechercherUnClient(txbRecherche.Text);
            if (this.clientEmetteur != null)
                InformationClientEmetteur(clientEmetteur);
            else
                InitFormEmeteur();

            gbInformationCompte.Enabled = fonction.RendreValideControl(this.clientEmetteur);
        }

        private void cmbTypeCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbChoixCompte.Items.Clear();
            txbIdentifiantEpargne_TextChanged(sender, e);
            InitGBInfoTransfert();
            cmbChoixCompte_SelectedIndexChanged(sender, e);
        }

        private void InitGBInfoTransfert()
        {
            fonction.ChargerCompteClientComboBox(cmbChoixCompte, 
                new CompteClientBLO().RechercherLesComptesClientsDuClientEnFonctionDuType(this.clientEmetteur != null ? this.clientEmetteur : new Client("Indefini"), 
                cmbTypeCompte.Text));
            fonction.ChargerCompteClientComboBox(cmbChoixCompte2, 
                new CompteClientBLO().RechercherLesComptesClientsDuClientEnFonctionDuType(this.clientRecepteur != null ? this.clientRecepteur : new Client("Indefini"), 
                cmbTypeCompte2.Text));
            txbMontantDepot.Text = string.Empty;
        }

        private void InitGBInfoCompteEmetteur()
        {
            cmbTypeCompte.Items.Clear();
            fonction.ChargerEnumerationComboBox(cmbTypeCompte, Enum.GetNames(typeof(TypeCompte)));
            cmbTypeCompte.SelectedIndex = -1;
            InitGBInfoTransfert();
            txbIdentifiantEpargne.Text = "0";
        }

        private void InitGBInfoCompteRecepteur()
        {
            cmbTypeCompte2.Items.Clear();
            fonction.ChargerEnumerationComboBox(cmbTypeCompte2, Enum.GetNames(typeof(TypeCompte)));
            cmbTypeCompte2.SelectedIndex = -1;
            InitGBInfoTransfert();
            txbIdentifiantEpargne2.Text = "0";
        }

        private void txbMontantDepot_TextChanged(object sender, EventArgs e)
        {
            fonction.PrendreUniquementChiffre(txbMontantDepot);
            lblPossibilite.Text = PossibiliteDepot(double.Parse(txbMontantDepot.Text != string.Empty ? txbMontantDepot.Text : "0"),
                new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text),
                new CompteClientBLO().RechercherUnCompte(cmbChoixCompte2.Text)) ?
                StatutPossibilite.Possible.ToString() :
                StatutPossibilite.Impossible.ToString();

            lblPossibilite.ForeColor = PossibiliteDepot(double.Parse(txbMontantDepot.Text != string.Empty ? txbMontantDepot.Text : "0"),
                new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text),
                new CompteClientBLO().RechercherUnCompte(cmbChoixCompte2.Text)) ?
                Color.Green :
                Color.Crimson;
        }

        private bool PossibiliteDepot(double montant, CompteClient compteClientEmetteur, CompteClient compteClientRecepteur) => 
            montant >= new ParametreGeneralBLO().TousParametreGenerals[0].MontantMininimumDepot &&
            montant <= new CompteClientBLO().MontantSoldeCompteClient(compteClientEmetteur) &&
            ((compteClientEmetteur.TypeCompte == TypeCompte.Courant && compteClientRecepteur.TypeCompte == TypeCompte.Courant) ? 
            ((new CompteClientBLO().MontantSoldeCompteClient(compteClientEmetteur) + montant) <= new ParametreGeneralBLO().TousParametreGenerals[0].SoldeMaximalCompteCourant &&
            (new CompteClientBLO().MontantSoldeCompteClient(compteClientRecepteur) + montant) <= new ParametreGeneralBLO().TousParametreGenerals[0].SoldeMaximalCompteCourant) :
            (compteClientEmetteur.TypeCompte == TypeCompte.Courant && compteClientRecepteur.TypeCompte == TypeCompte.Epargne) ? 
            ((new CompteClientBLO().MontantSoldeCompteClient(compteClientEmetteur) + montant) <= new ParametreGeneralBLO().TousParametreGenerals[0].SoldeMaximalCompteCourant) :
            (compteClientEmetteur.TypeCompte == TypeCompte.Epargne && compteClientRecepteur.TypeCompte == TypeCompte.Courant) ? 
            ((new CompteClientBLO().MontantSoldeCompteClient(compteClientRecepteur) + montant) <= new ParametreGeneralBLO().TousParametreGenerals[0].SoldeMaximalCompteCourant) :
            true);

        private void cmbChoixCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbIdentifiantEpargne_TextChanged(sender, e);
            gbInformationTransfertInterCompte.Enabled = (cmbChoixCompte.SelectedIndex > -1 && cmbChoixCompte2.SelectedIndex > -1) ? true : false;
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

        private void txbRecherche2_TextChanged(object sender, EventArgs e)
        {
            this.clientRecepteur = new ClientBLO().RechercherUnClient(txbRecherche2.Text);
            if (this.clientRecepteur != null)
                InformationClientRecepteur(clientRecepteur);
            else
                InitFormRecepteur();

            gbInformationCompte2.Enabled = fonction.RendreValideControl(this.clientRecepteur);
        }

        private void cmbTypeCompte2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbChoixCompte2.Items.Clear();
            txbIdentifiantEpargne2_TextChanged(sender, e);
            InitGBInfoTransfert();
            cmbChoixCompte2_SelectedIndexChanged(sender, e);
        }

        private void cmbChoixCompte2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbIdentifiantEpargne2_TextChanged(sender, e);
            gbInformationTransfertInterCompte.Enabled = (cmbChoixCompte.SelectedIndex > -1 && cmbChoixCompte2.SelectedIndex > -1) ? true : false;
            lblMontantCompte2.Text = (cmbChoixCompte2.SelectedIndex > -1) ?
                new CompteClientBLO().MontantSoldeCompteClient(new CompteClientBLO().RechercherUnCompte(cmbChoixCompte2.Text)).ToString() :
                string.Empty;
            txbMontantDepot_TextChanged(sender, e);
        }

        private void txbIdentifiantEpargne2_TextChanged(object sender, EventArgs e)
        {
            txbIdentifiantEpargne2.Text = cmbTypeCompte2.Text == TypeCompte.Courant.ToString() ?
            "0" :
            (cmbChoixCompte2.SelectedIndex > -1) ?
                (new EpargneBLO().RechercherEpargneEnCoursDuCompte(new CompteClientBLO().RechercherUnCompte(cmbChoixCompte2.Text)) != null) ?
                new EpargneBLO().RechercherEpargneEnCoursDuCompte(new CompteClientBLO().RechercherUnCompte(cmbChoixCompte2.Text)).ToString() :
                "0" : 
            "0";
        }

        private bool SiFormulaireRempliCorrectementEmetteur =>
            this.clientEmetteur != null &&
            cmbTypeCompte.Text != string.Empty &&
            cmbChoixCompte.Text != string.Empty &&
            txbIdentifiantEpargne.Text != string.Empty &&
            txbMontantDepot.Text != string.Empty &&
            txbCodeDepot.Text != string.Empty &&
            cmbChoixCompte.Text != string.Empty &&
            PossibiliteDepot(double.Parse(txbMontantDepot.Text), new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text), 
                new CompteClientBLO().RechercherUnCompte(cmbChoixCompte2.Text));

        private bool SiFormulaireRempliCorrectementRecepteur =>
            this.clientRecepteur != null &&
            cmbTypeCompte2.Text != string.Empty &&
            cmbChoixCompte2.Text != string.Empty &&
            txbIdentifiantEpargne2.Text != string.Empty &&
            txbMontantDepot.Text != string.Empty &&
            txbCodeDepot.Text != string.Empty &&
            cmbChoixCompte2.Text != string.Empty &&
            PossibiliteDepot(double.Parse(txbMontantDepot.Text), new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text), 
                new CompteClientBLO().RechercherUnCompte(cmbChoixCompte2.Text));

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (SiFormulaireRempliCorrectementEmetteur && SiFormulaireRempliCorrectementRecepteur)
                {
                    if (new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text).CodeCompte != 
                        new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text).CodeCompte)
                    {
                        new TransactionBLO().InitierTransaction(RetourTypeCompte(cmbTypeCompte.Text), TypeTransaction.Transfert_inter_compte,
                            new EpargneBLO().RechercheEpargne(int.Parse(txbIdentifiantEpargne.Text)), new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text),
                            new CompteClientBLO().RechercherUnCompte(cmbChoixCompte.Text), this.employe, double.Parse(txbMontantDepot.Text), 0
                            );

                        fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Initialisation", $"Depot initie !");

                        txbRecherche.Text = string.Empty;
                        InitFormEmeteur();
                    }
                    else
                        fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Initialisation", 
                            "Vous ne pouvez pas effectuer de transfert entre deux meme compte !");
                }
                else
                    fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Initialisation", "Veillez remplir tous les champs !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
