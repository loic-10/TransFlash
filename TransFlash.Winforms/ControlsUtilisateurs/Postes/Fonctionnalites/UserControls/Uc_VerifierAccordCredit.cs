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
    public partial class Uc_VerifierAccordCredit : UserControl
    {

        private Employe employe = null;

        private Frm_Fonction fonction = null;

        private Credit credit = null;

        private Client client = null;

        public Uc_VerifierAccordCredit(Employe employe)
        {
            InitializeComponent();
            this.employe = employe;
            fonction = new Frm_Fonction();
        }

        public Uc_VerifierAccordCredit(Employe employe, Credit credit) : this(employe)
        {
            InformationCredit(credit);
            InitForm(credit);
            this.credit = credit;
            this.client = credit.Client;
            gbInformationCredit.Enabled = false;
            gbInformationAvanceCredit.Visible = true;

            VerificationSurDepot(credit);
            VerificationSurDette(credit);
            VerificationSurDisponibiliteFond(credit);
            VerificationSurEpargne(credit);
            VerificationSurPartSociale(credit);
            VerificationSurPossibiliteCredit(credit);
            VerificationSurRetrait(credit);
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
            Uc_GererPorteFeuille frm = new Uc_GererPorteFeuille(this.employe);
            fonction.AfficherPageChoisie(this, frm);
        }

        public void InitForm(Credit credit)
        {
            cmbTypeCredit.Items.Clear();
            fonction.ChargerEnumerationComboBox(cmbTypeCredit, Enum.GetNames(typeof(TypeCredit)));
            txbCodeCredit.Text = credit.CodeCredit;
            cmbTypeCredit.Text = credit.TypeCredit.ToString();
            MesFichiers(new List<FichierStocke>(new FichierStockeBLO().RechercherFichierStockesGarantie(credit.Garantie)));
            if(credit.Garantie.Avaliste.Id != 0)
            {
                checkAvaliste.Checked = true;
                txbIdAvaliste.Text = credit.Garantie.Avaliste.Id.ToString();
                txbNomAvaliste.Text = credit.Garantie.Avaliste.NomComplet;
                txbProfessionAvaliste.Text = credit.Garantie.Avaliste.Profession;
                txbDescriptionAvaliste.Text = credit.Garantie.Avaliste.Description;
                txbMontantMois.Text = credit.Garantie.Avaliste.MontantParMois.ToString();
            }
            txbDescription.Text = credit.Garantie.Description;
            txbDureeTotalCredit.Text = credit.NombreMois.ToString();
            txbMontantEvaluationGarantie.Text = credit.Garantie.MontantEvaluation.ToString();

        }

        private void MesFichiers(List<FichierStocke> fichierStockes)
        {
            panelFichier.Controls.Clear();

            for (int i = 0; i < fichierStockes.Count; i++)
            {
                panelFichier.Controls.Add(new Uc_Fichier()
                { 
                    NumFichier = i+1,
                    Nom = fichierStockes[i].Nom,
                    FileName = fichierStockes[i].FileName,
                    StatutStockage = fichierStockes[i].StatutStockage,
                    MontantEvaluation = fichierStockes[i].MontantEvaluation
                });
            }
        }

        private void InformationCredit(Credit credit)
        {
            cmbTypeCredit.Text = credit.TypeCredit.ToString();
            txbCodeCredit.Text = credit.CodeCredit;
            txbMontantCredit.Text = credit.MontantEmprunte.ToString();
            txbIdAvaliste.Text = checkAvaliste.Checked ? new IdentifiantBLO().IdAvaliste.ToString() : string.Empty;
        }

        private bool SiCommentaireRenseigne =>
            txbCommentaire.Text != string.Empty;

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AfficherClient(this.client);
        }


        private Color CouleurLabelPourcentage(double pourcentage) => (pourcentage >= 0 && pourcentage < 50) ?
            Color.Red :
            (pourcentage >= 50 && pourcentage < 75) ?
            Color.GreenYellow :
            Color.Green;

        // Verification sur depot
        private void VerificationSurDepot(Credit credit)
        {
            lblMontantTotalDepots.Text = new TransactionBLO().MontantTotalDepotClient(credit.Client).ToString();
            lblPourcentageMontantTotalDepots.Text = PourcentageDepot(credit, new TransactionBLO().MontantTotalDepotClient(credit.Client))+ "%";
            lblPourcentageMontantTotalDepots.ForeColor = 
                CouleurLabelPourcentage(PourcentageDepot(credit, new TransactionBLO().MontantTotalDepotClient(credit.Client)));
        }

        private double PourcentageDepot(Credit credit, double montant) =>
            Math.Round((credit.MontantEmprunte > montant) ? ((montant * 100) / credit.MontantEmprunte) : 100);

        // Verification sur retrait
        private void VerificationSurRetrait(Credit credit)
        {
            lblMontantTotalRetraits.Text = new TransactionBLO().MontantTotalRetraitClient(credit.Client).ToString();
            lblPourcentageMontantTotalRetraits.Text = PourcentageRetrait(credit, new TransactionBLO().MontantTotalRetraitClient(credit.Client))+ "%";
            lblPourcentageMontantTotalRetraits.ForeColor = 
                CouleurLabelPourcentage(PourcentageRetrait(credit, new TransactionBLO().MontantTotalRetraitClient(credit.Client)));
        }

        private double PourcentageRetrait(Credit credit, double montant) =>
            Math.Round((credit.MontantEmprunte > montant) ? ((montant * 100) / credit.MontantEmprunte) : 100);


        // Verification sur part sociale
        private void VerificationSurPartSociale(Credit credit)
        {
            lblMontantPartsSociales.Text = $"{new PartSocialeBLO().MontantPartSocialeClient(credit.Client).ToString()} " +
                $"({new PartSocialeBLO().NombrePartSociale(credit.Client)} part(s) sociale(s))";
            lblPourcentageMontantPartSociales.Text = PourcentagePartSociale(new PartSocialeBLO().NombrePartSociale(credit.Client), 
                new PartSocialeBLO().MontantPartSocialeClient(credit.Client))+ "%";
            lblPourcentageMontantPartSociales.ForeColor = 
                CouleurLabelPourcentage(PourcentagePartSociale(new PartSocialeBLO().NombrePartSociale(credit.Client), 
                new PartSocialeBLO().MontantPartSocialeClient(credit.Client)));
        }

        private double PourcentagePartSociale(int nombrePartSociale, double montant) =>
            Math.Round(montant < (new ParametreGeneralBLO().TousParametreGenerals[0].MontantPartSociale * nombrePartSociale) ? 
                ((montant * 100) / (new ParametreGeneralBLO().TousParametreGenerals[0].MontantPartSociale * nombrePartSociale)): 100);


        // Verification sur epargne
        private void VerificationSurEpargne(Credit credit)
        {
            lblMontantTotalEpargne.Text = $"{new EpargneBLO().MontantEpargneClient(credit.Client).ToString()} " +
                $"({new EpargneBLO().NombreEpargne(credit.Client)} epargne(s))";
            lblPourcentageMontantTotalEpargne.Text = PourcentageEpargne(credit, new EpargneBLO().MontantEpargneClient(credit.Client))+ "%";
            lblPourcentageMontantTotalEpargne.ForeColor = 
                CouleurLabelPourcentage(PourcentageEpargne(credit, new EpargneBLO().MontantEpargneClient(credit.Client)));
        }

        private double PourcentageEpargne(Credit credit, double montant) =>
            Math.Round((credit.MontantEmprunte > montant) ? ((montant * 100) / credit.MontantEmprunte) : 100);


        // Verification sur dette
        private void VerificationSurDette(Credit credit)
        {
            lblMontantTotalDettes.Text = $"{new CreditBLO().MontantDetteClient(credit.Client).ToString()}";
            lblPourcentageMontantTotalDettes.Text = PourcentageDette(new CreditBLO().MontantDetteClient(credit.Client))+ "%";
            lblPourcentageMontantTotalDettes.ForeColor = 
                CouleurLabelPourcentage(PourcentageDette(new CreditBLO().MontantDetteClient(credit.Client)));

            btnAccorder.Enabled = (new CreditBLO().MontantDetteClient(credit.Client) == 0 && PourcentageDisponibiliteFond(credit.MontantEmprunte) == 100);
        }

        private double PourcentageDette(double montant) =>
            (montant > 0) ? 0 : 100;


        // Verification sur disponibilite des fonds necessaire
        private void VerificationSurDisponibiliteFond(Credit credit)
        {
            lblMontantTotalFondNecessaire.Text = $"{new FondBLO().TousFonds[0].MontantTotal.ToString()}";
            lblPourcentageMontantTotalFondNecessaire.Text = PourcentageDisponibiliteFond(credit.MontantEmprunte)+ "%";
            lblPourcentageMontantTotalFondNecessaire.ForeColor = 
                CouleurLabelPourcentage(PourcentageDisponibiliteFond(credit.MontantEmprunte));

            btnAccorder.Enabled = (new CreditBLO().MontantDetteClient(credit.Client) == 0 && PourcentageDisponibiliteFond(credit.MontantEmprunte) == 100);
        }

        private double PourcentageDisponibiliteFond(double montant) =>
            (montant > new FondBLO().TousFonds[0].MontantTotal) ? 0 : 100;


        // Verification sur possibilite credit
        private void VerificationSurPossibiliteCredit(Credit credit)
        {
            lblPossibilite.Text = PourcentagePossibiliteCredit(credit) < 50 ? StatutPossibilite.Risqué.ToString() : StatutPossibilite.Possible.ToString();
            lblPourcentagePossibilite.Text = PourcentagePossibiliteCredit(credit) + "%";
            lblPourcentagePossibilite.ForeColor =
                CouleurLabelPourcentage(PourcentagePossibiliteCredit(credit));
        }

        private double PourcentagePossibiliteCredit(Credit credit) =>
            Math.Round((PourcentageDepot(credit, new TransactionBLO().MontantTotalDepotClient(credit.Client)) +
            PourcentageRetrait(credit, new TransactionBLO().MontantTotalRetraitClient(credit.Client)) +
            PourcentagePartSociale(new PartSocialeBLO().NombrePartSociale(credit.Client),
                new PartSocialeBLO().MontantPartSocialeClient(credit.Client)) +
            PourcentageEpargne(credit, new EpargneBLO().MontantEpargneClient(credit.Client)) +
            PourcentageDette(new CreditBLO().MontantDetteClient(credit.Client)) +
            PourcentageDisponibiliteFond(credit.MontantEmprunte)) / 6);

        private void btnAccorder_Click(object sender, EventArgs e)
        {
            try
            {
                if (SiCommentaireRenseigne)
                {
                    if (MessageBox.Show($"Etes-vous sur de proceder a la validation de ce credit (avec {lblPourcentagePossibilite.Text} de possibilite) ?",
                        "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        new CreditBLO().ValiderDemandeCredit(this.credit, txbCommentaire.Text, this.employe);
                        fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Programmation", $"Credit accorde !");
                        btnBack_Click(sender, e);
                    }
                }
                else
                    fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Programmation", "Veillez renseigner un commentaire !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            try
            {
                if (SiCommentaireRenseigne)
                {
                    if (MessageBox.Show($"Etes-vous sur de proceder a l'annulation de ce credit (avec {lblPourcentagePossibilite.Text} de possibilite) ?",
                        "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        new CreditBLO().AnnulerCredit(this.credit, txbCommentaire.Text, this.employe);
                        fonction.AfficheMessageNotification(Color.FromArgb(33, 191, 116), "Programmation", $"Credit annule !");
                        btnBack_Click(sender, e);
                    }
                }
                else
                    fonction.AfficheMessageNotification(Color.FromArgb(248, 43, 43), "Programmation", "Veillez renseigner un commentaire !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
