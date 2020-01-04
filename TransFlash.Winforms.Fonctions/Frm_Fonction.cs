using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using MetroFramework.Forms;
using TransFlash.BO;
using TransFlash.Winforms.Fonctions.Properties;
using Tulpep.NotificationWindow;
using static TransFlash.BO.Statut;

namespace TransFlash.Winforms.Fonctions
{
    public partial class Frm_Fonction : MetroForm
    {

        public Frm_Fonction()
        {
            InitializeComponent();

            gunaTransition1 = new GunaTransition()
            {
                AnimationType = Guna.UI.Animation.AnimationType.HorizBlind,
                Interval = 10,
                MaxAnimationTime = 1500,
                TimeStep = 0.02f
            };

            gunaTransition2 = new GunaTransition()
            {
                AnimationType = Guna.UI.Animation.AnimationType.Transparent,
                Interval = 2,
                MaxAnimationTime = 500,
                TimeStep = 0.02f
            };

            gunaTransition3 = new GunaTransition()
            {
                AnimationType = Guna.UI.Animation.AnimationType.Particles,
                Interval = 30,
                MaxAnimationTime = 5000,
                TimeStep = 0.02f
            };
        }

        public void AnimationOuverture(GunaPanel panelMenu)
        {
            panelMenu.Visible = false;
            panelMenu.Width = 265;
            gunaTransition1.ShowSync(panelMenu);
        }

        public void AnimationIcone(Control but1, Control but2, Control but3)
        {
            gunaTransition3.ShowSync(but1);
            gunaTransition3.ShowSync(but2);
            gunaTransition3.ShowSync(but3);
        }

        public void MenuTop(GunaPanel panelPoste)
        {
            panelPoste.Visible = true;
            panelPoste.BringToFront();
        }

        public void AnimationUserControlHidde(GunaPanel panel)
        {
            if (panel.Width == 265)
            {
                panel.Visible = false;
                panel.Width = 50;
                gunaTransition1.ShowSync(panel);
            }
            else
            {
                panel.Visible = false;
                panel.Width = 265;
                gunaTransition1.ShowSync(panel);
            }
        }

        public void AfficheMenuPoste(UserControl controlMenu, GunaPanel panelPoste, UserControl menuPoste)
        {
            menuPoste = controlMenu;
            panelPoste.Controls.Clear();
            panelPoste.Controls.Add(controlMenu);
            controlMenu.Dock = DockStyle.Fill;
        }

        public void AfficheCorp(UserControl controlCorp, Control control, UserControl leCorpDePage)
        {
            try
            {
                leCorpDePage = controlCorp;
                gunaTransition2.HideSync(control);
                control.Controls.Clear();
                control.Controls.Add(controlCorp);
                controlCorp.Dock = DockStyle.Fill;
                controlCorp.BringToFront();
                gunaTransition2.ShowSync(control);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AfficherPageChoisie(Control control, UserControl userPage)
        {
            try
            {
                gunaTransition2.HideSync(control);
                control.Controls.Clear();
                control.Controls.Add(userPage);
                userPage.Dock = DockStyle.Fill;
                userPage.BringToFront();
                gunaTransition2.ShowSync(control);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ChangerButtonActif(GunaAdvenceButton buttonAActiver, GunaAdvenceButton buttonADesactiver, GunaPanel panelMenu)
        {
            buttonAActiver.Checked = true;
            buttonAActiver.Refresh();
            buttonADesactiver.Checked = false;
            panelMenu.Refresh();

        }

        public void DesignDataGrid(GunaDataGridView dataGrid)
        {
            new GunaElipse()
            {
                TargetControl = dataGrid,
                Radius = 5
            };
            dataGrid.AutoGenerateColumns = false;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 72, 114);
            dataGrid.ColumnHeadersHeight = 50;
            dataGrid.RowHeadersVisible = true;

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                row.Selected = false;
                row.Height = 50;
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }

        public void PrendreUniquementChiffre(GunaTextBox textBox)
        {
            string[] text = new string[textBox.Text.Length];
            string val = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (textBox.Text[i] == '0' || textBox.Text[i] == '1' || textBox.Text[i] == '2' || textBox.Text[i] == '3' ||
                    textBox.Text[i] == '4' || textBox.Text[i] == '5' || textBox.Text[i] == '6' || textBox.Text[i] == '7' ||
                    textBox.Text[i] == '8' || textBox.Text[i] == '9')
                {
                    val += textBox.Text[i].ToString();
                    textBox.Focus();
                }
            }
            textBox.Text = val;
            textBox.Select(val.Length, val.Length);
        }

        public void ChargerEnumerationComboBox(GunaComboBox comboBox, string[] valeurs)
        {
            foreach (string valeur in valeurs)
                comboBox.Items.Add(valeur);
        }

        public void ChargerPaysComboBox(GunaComboBox comboBox, IEnumerable<Pays> pays)
        {
            foreach (var valeur in pays)
                comboBox.Items.Add(valeur.ToString());
        }

        public void ChargerCodePhoneComboBox(GunaComboBox comboBox, IEnumerable<Pays> pays)
        {
            foreach (var valeur in pays)
            {
                if(!comboBox.Items.Contains(valeur.CodePhone))
                    comboBox.Items.Add(valeur.CodePhone);
            }
        }

        public void ChargerVillesComboBox(GunaComboBox comboBox, IEnumerable<Ville> villes)
        {
            foreach (var valeur in villes)
                comboBox.Items.Add(valeur.ToString());
        }

        public void ChargerCompteClientComboBox(GunaComboBox comboBox, IEnumerable<CompteClient> compteClients)
        {
            foreach (var valeur in compteClients)
                comboBox.Items.Add(valeur.ToString());
        }

        public bool SiActiveButtonPourActiverCompte(GunaDataGridView dataGrid, int positionStatut) => 
            dataGrid.SelectedRows.Count == 1 && 
            dataGrid.SelectedRows[0].Cells[positionStatut].Value.ToString() == StatutCompte.Bloqué.ToString();

        public bool SiActiveButtonPourBloquerCompte(GunaDataGridView dataGrid, int positionStatut) => 
            dataGrid.SelectedRows.Count == 1 && 
            dataGrid.SelectedRows[0].Cells[positionStatut].Value.ToString() == StatutCompte.Activé.ToString();

        public bool SiClientEtCompteClientActiverPourTransaction(Transaction transaction) => 
            transaction.CompteClientEmetteur.Client.StatutClient == StatutClient.Activé && 
            (transaction.CompteClientEmetteur.StatutCompte == StatutCompte.Activé ||
            transaction.CompteClientEmetteur.StatutCompte == StatutCompte.En_attente_de_validité);

        public bool SiActiveButtonPourAnnulerTransaction(GunaDataGridView dataGrid, int positionStatut, Transaction transaction) => 
            dataGrid.SelectedRows.Count == 1 &&
            SiClientEtCompteClientActiverPourTransaction(transaction) &&
            dataGrid.SelectedRows[0].Cells[positionStatut].Value.ToString() == StatutTransaction.En_cours_de_validité.ToString();

        public bool SiActiveButtonPourValiderTransaction(GunaDataGridView dataGrid, int positionStatut, Transaction transaction) =>
            dataGrid.SelectedRows.Count == 1 &&
            SiClientEtCompteClientActiverPourTransaction(transaction) &&
            (dataGrid.SelectedRows[0].Cells[positionStatut].Value.ToString() == StatutTransaction.En_cours_de_validité.ToString() ||
            dataGrid.SelectedRows[0].Cells[positionStatut].Value.ToString() == StatutTransaction.Avisé.ToString());

        public bool SiActiveButtonPourAviserTransaction(GunaDataGridView dataGrid, int positionStatut, int positionTypeCompte,
            int positionTypeTransaction, Transaction transaction) =>
            dataGrid.SelectedRows.Count == 1 &&
            SiClientEtCompteClientActiverPourTransaction(transaction) &&
            dataGrid.SelectedRows[0].Cells[positionStatut].Value.ToString() == StatutTransaction.En_cours_de_validité.ToString() &&
            dataGrid.SelectedRows[0].Cells[positionTypeCompte].Value.ToString() == TypeCompte.Epargne.ToString() &&
            dataGrid.SelectedRows[0].Cells[positionTypeTransaction].Value.ToString() == TypeTransaction.Retrait.ToString();

        public bool SiActiveButtonPourUneSelection(GunaDataGridView dataGrid) => (dataGrid.SelectedRows.Count == 1);

        public bool SiActiveButtonPourPlusieursSelections(GunaDataGridView dataGrid) => (dataGrid.SelectedRows.Count > 0);

        public bool SiTypeCompteSelectionneEpargne(GunaComboBox comboBoxTypeCompte) =>
            (comboBoxTypeCompte.Text == TypeCompte.Epargne.ToString() && comboBoxTypeCompte.SelectedIndex > -1);

        public bool SiTypeAppartenantSelectionneEntreprise(GunaComboBox comboBoxTypeAppartenant) =>
            (comboBoxTypeAppartenant.Text == TypeAppartenantCompteEpargne.Entreprise.ToString() && comboBoxTypeAppartenant.SelectedIndex > -1);

        public void ImporterImage(PictureBox pictureBox)
        {
            OpenFileDialog of = new OpenFileDialog
            {
                Title = "Choose a picture",
                Filter = "Images(.jpg, jpeg, png, gif)|*.jpg; *.jpeg; *.png; *.gif"
            };
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = null;
                pictureBox.ImageLocation = of.FileName;
                pictureBox.Image = Image.FromFile(of.FileName);
            }
        }

        public string PictureName(PictureBox pictureBox)
        {
            const string folder = "Images";
            DirectoryInfo di = new DirectoryInfo(folder);
            if (!di.Exists)
            {
                di.Create();
            }
            string pictureName = string.Empty;
            if (pictureBox.ImageLocation != null)
            {
                pictureName = folder + "/" + Guid.NewGuid().ToString() + Path.GetExtension(pictureBox.ImageLocation);
                FileInfo fi = new FileInfo(pictureBox.ImageLocation);
                fi.CopyTo(pictureName);
            }
            return pictureName;
        }

        public void AfficheMessageNotification(Color couleurFond, string titre, string message)
        {
            PopupNotifier notifier = new PopupNotifier()
            {
                AnimationDuration = 1000,
                AnimationInterval = 10,
                BorderColor = Color.Transparent,
                BodyColor = couleurFond,
                ButtonHoverColor = Color.FromArgb(24, 57, 101),
                ContentColor = Color.White,
                ContentFont = new Font(new FontFamily("Century Gothic"), 12),
                ContentHoverColor = Color.Gainsboro,
                ContentPadding = new Padding(5),
                ContentText = message,
                Delay = 3000,
                GradientPower = 80,
                HeaderColor = Color.White,
                HeaderHeight = 10,
                Image = Resources.system_report_52px,
                ImagePadding = new Padding(5),
                ImageSize = new Size(40, 40),
                IsRightToLeft = false,
                Size = new Size(400, 150),
                TitleColor = Color.White,
                TitleFont = new Font(new FontFamily("Century Gothic"), 14),
                TitlePadding = new Padding(5),
                TitleText = titre
            };
            
            notifier.Popup();
        }

        public void ExtractionSurExcel(GunaDataGridView dataGrid)
        {
            try
            {
                if (dataGrid.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application applicationClass = new Microsoft.Office.Interop.Excel.Application();
                    applicationClass.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
                    {
                        applicationClass.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGrid.Columns.Count; j++)
                        {
                            if(dataGrid.Rows[i].Cells[j].Value != null)
                                applicationClass.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    applicationClass.Columns.AutoFit();
                    applicationClass.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AfficherUneInfoBulle(Control control, string titleInfoBulle, string messageInfoBulle)
        {
            ToolTip toolTip = new ToolTip()
            {
                BackColor = Color.FromArgb(13, 72, 114),
                ReshowDelay = 1000,
                ForeColor = Color.White,
                ToolTipTitle = titleInfoBulle,
                IsBalloon = true,
                UseAnimation = true,
                UseFading = true,
                Active = true
            };

            toolTip.SetToolTip(control, messageInfoBulle);
        }

        public void CouleurStatutClient(GunaDataGridView dataGrid,  int positionStatut)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[positionStatut].Value.ToString() == StatutClient.Activé.ToString())
                    row.Cells[positionStatut].Style.ForeColor = Color.Green;
                else
                    row.Cells[positionStatut].Style.ForeColor = Color.Crimson;
            }
        }

        public void CouleurStatutCompte(GunaDataGridView dataGrid, int positionStatut)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[positionStatut].Value.ToString() == StatutCompte.Activé.ToString())
                    row.Cells[positionStatut].Style.ForeColor = Color.Green;
                else if (row.Cells[positionStatut].Value.ToString() == StatutCompte.En_attente_de_validité.ToString())
                    row.Cells[positionStatut].Style.ForeColor = Color.FromArgb(24, 57, 101);
                else
                    row.Cells[positionStatut].Style.ForeColor = Color.Crimson;
            }
        }

        public bool RendreValideControl(object obj) => obj != null;
    }
}
