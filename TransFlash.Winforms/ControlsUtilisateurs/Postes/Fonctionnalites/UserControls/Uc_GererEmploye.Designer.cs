namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    partial class Uc_GererEmploye
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkCode = new Guna.UI.WinForms.GunaCheckBox();
            this.checkNomComplet = new Guna.UI.WinForms.GunaCheckBox();
            this.checkDateNaissance = new Guna.UI.WinForms.GunaCheckBox();
            this.checkLieuNaissance = new Guna.UI.WinForms.GunaCheckBox();
            this.checkSexe = new Guna.UI.WinForms.GunaCheckBox();
            this.checkNumeroCNI = new Guna.UI.WinForms.GunaCheckBox();
            this.checkNumeroTelephone = new Guna.UI.WinForms.GunaCheckBox();
            this.checkPays = new Guna.UI.WinForms.GunaCheckBox();
            this.checkVille = new Guna.UI.WinForms.GunaCheckBox();
            this.checkNomUtilisateur = new Guna.UI.WinForms.GunaCheckBox();
            this.checkStatutEmploye = new Guna.UI.WinForms.GunaCheckBox();
            this.checkDateEnregistrement = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton8 = new Guna.UI.WinForms.GunaButton();
            this.txbRechercher = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.btnExporterExcel = new Guna.UI.WinForms.GunaButton();
            this.btnImprimer = new Guna.UI.WinForms.GunaButton();
            this.btnInformationEmploye = new Guna.UI.WinForms.GunaButton();
            this.btnSupprimer = new Guna.UI.WinForms.GunaButton();
            this.btnEditerCompteEmploye = new Guna.UI.WinForms.GunaButton();
            this.btnEditerEmploye = new Guna.UI.WinForms.GunaButton();
            this.btnEnregistrerEmploye = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.dataGridEmploye = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.lblCountItems = new Guna.UI.WinForms.GunaLabel();
            this.dataGrid = new Guna.UI.WinForms.GunaGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmploye)).BeginInit();
            this.gunaPanel4.SuspendLayout();
            this.dataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(200, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 140);
            this.gunaPanel1.TabIndex = 9;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.flowLayoutPanel1);
            this.gunaPanel2.Controls.Add(this.gunaPanel3);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 75);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.gunaPanel2.Size = new System.Drawing.Size(800, 65);
            this.gunaPanel2.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.checkCode);
            this.flowLayoutPanel1.Controls.Add(this.checkNomComplet);
            this.flowLayoutPanel1.Controls.Add(this.checkDateNaissance);
            this.flowLayoutPanel1.Controls.Add(this.checkLieuNaissance);
            this.flowLayoutPanel1.Controls.Add(this.checkSexe);
            this.flowLayoutPanel1.Controls.Add(this.checkNumeroCNI);
            this.flowLayoutPanel1.Controls.Add(this.checkNumeroTelephone);
            this.flowLayoutPanel1.Controls.Add(this.checkPays);
            this.flowLayoutPanel1.Controls.Add(this.checkVille);
            this.flowLayoutPanel1.Controls.Add(this.checkNomUtilisateur);
            this.flowLayoutPanel1.Controls.Add(this.checkStatutEmploye);
            this.flowLayoutPanel1.Controls.Add(this.checkDateEnregistrement);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(451, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 65);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // checkCode
            // 
            this.checkCode.BaseColor = System.Drawing.Color.White;
            this.checkCode.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkCode.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCode.FillColor = System.Drawing.Color.White;
            this.checkCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCode.Location = new System.Drawing.Point(15, 5);
            this.checkCode.Margin = new System.Windows.Forms.Padding(5);
            this.checkCode.Name = "checkCode";
            this.checkCode.Size = new System.Drawing.Size(74, 22);
            this.checkCode.TabIndex = 10;
            this.checkCode.Text = "Code";
            this.checkCode.CheckedChanged += new System.EventHandler(this.checkCode_CheckedChanged);
            // 
            // checkNomComplet
            // 
            this.checkNomComplet.BaseColor = System.Drawing.Color.White;
            this.checkNomComplet.Checked = true;
            this.checkNomComplet.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkNomComplet.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkNomComplet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkNomComplet.FillColor = System.Drawing.Color.White;
            this.checkNomComplet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNomComplet.Location = new System.Drawing.Point(99, 5);
            this.checkNomComplet.Margin = new System.Windows.Forms.Padding(5);
            this.checkNomComplet.Name = "checkNomComplet";
            this.checkNomComplet.Size = new System.Drawing.Size(135, 22);
            this.checkNomComplet.TabIndex = 11;
            this.checkNomComplet.Text = "Nom complet";
            this.checkNomComplet.CheckedChanged += new System.EventHandler(this.checkNomComplet_CheckedChanged);
            // 
            // checkDateNaissance
            // 
            this.checkDateNaissance.BaseColor = System.Drawing.Color.White;
            this.checkDateNaissance.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkDateNaissance.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkDateNaissance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkDateNaissance.FillColor = System.Drawing.Color.White;
            this.checkDateNaissance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDateNaissance.Location = new System.Drawing.Point(15, 37);
            this.checkDateNaissance.Margin = new System.Windows.Forms.Padding(5);
            this.checkDateNaissance.Name = "checkDateNaissance";
            this.checkDateNaissance.Size = new System.Drawing.Size(148, 22);
            this.checkDateNaissance.TabIndex = 12;
            this.checkDateNaissance.Text = "Date naissance";
            this.checkDateNaissance.CheckedChanged += new System.EventHandler(this.checkDateNaissance_CheckedChanged);
            // 
            // checkLieuNaissance
            // 
            this.checkLieuNaissance.BaseColor = System.Drawing.Color.White;
            this.checkLieuNaissance.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkLieuNaissance.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkLieuNaissance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkLieuNaissance.FillColor = System.Drawing.Color.White;
            this.checkLieuNaissance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLieuNaissance.Location = new System.Drawing.Point(15, 69);
            this.checkLieuNaissance.Margin = new System.Windows.Forms.Padding(5);
            this.checkLieuNaissance.Name = "checkLieuNaissance";
            this.checkLieuNaissance.Size = new System.Drawing.Size(140, 22);
            this.checkLieuNaissance.TabIndex = 13;
            this.checkLieuNaissance.Text = "Lieu naissance";
            this.checkLieuNaissance.CheckedChanged += new System.EventHandler(this.checkLieuNaissance_CheckedChanged);
            // 
            // checkSexe
            // 
            this.checkSexe.BaseColor = System.Drawing.Color.White;
            this.checkSexe.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkSexe.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkSexe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkSexe.FillColor = System.Drawing.Color.White;
            this.checkSexe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSexe.Location = new System.Drawing.Point(165, 69);
            this.checkSexe.Margin = new System.Windows.Forms.Padding(5);
            this.checkSexe.Name = "checkSexe";
            this.checkSexe.Size = new System.Drawing.Size(66, 22);
            this.checkSexe.TabIndex = 14;
            this.checkSexe.Text = "Sexe";
            this.checkSexe.CheckedChanged += new System.EventHandler(this.checkSexe_CheckedChanged);
            // 
            // checkNumeroCNI
            // 
            this.checkNumeroCNI.BaseColor = System.Drawing.Color.White;
            this.checkNumeroCNI.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkNumeroCNI.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkNumeroCNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkNumeroCNI.FillColor = System.Drawing.Color.White;
            this.checkNumeroCNI.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNumeroCNI.Location = new System.Drawing.Point(15, 101);
            this.checkNumeroCNI.Margin = new System.Windows.Forms.Padding(5);
            this.checkNumeroCNI.Name = "checkNumeroCNI";
            this.checkNumeroCNI.Size = new System.Drawing.Size(123, 22);
            this.checkNumeroCNI.TabIndex = 15;
            this.checkNumeroCNI.Text = "Numero CNI";
            this.checkNumeroCNI.CheckedChanged += new System.EventHandler(this.checkNumeroCNI_CheckedChanged);
            // 
            // checkNumeroTelephone
            // 
            this.checkNumeroTelephone.BaseColor = System.Drawing.Color.White;
            this.checkNumeroTelephone.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkNumeroTelephone.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkNumeroTelephone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkNumeroTelephone.FillColor = System.Drawing.Color.White;
            this.checkNumeroTelephone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNumeroTelephone.Location = new System.Drawing.Point(15, 133);
            this.checkNumeroTelephone.Margin = new System.Windows.Forms.Padding(5);
            this.checkNumeroTelephone.Name = "checkNumeroTelephone";
            this.checkNumeroTelephone.Size = new System.Drawing.Size(173, 22);
            this.checkNumeroTelephone.TabIndex = 16;
            this.checkNumeroTelephone.Text = "Numero telephone";
            this.checkNumeroTelephone.CheckedChanged += new System.EventHandler(this.checkNumeroTelephone_CheckedChanged);
            // 
            // checkPays
            // 
            this.checkPays.BaseColor = System.Drawing.Color.White;
            this.checkPays.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkPays.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkPays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPays.FillColor = System.Drawing.Color.White;
            this.checkPays.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPays.Location = new System.Drawing.Point(198, 133);
            this.checkPays.Margin = new System.Windows.Forms.Padding(5);
            this.checkPays.Name = "checkPays";
            this.checkPays.Size = new System.Drawing.Size(65, 22);
            this.checkPays.TabIndex = 17;
            this.checkPays.Text = "Pays";
            this.checkPays.CheckedChanged += new System.EventHandler(this.checkPays_CheckedChanged);
            // 
            // checkVille
            // 
            this.checkVille.BaseColor = System.Drawing.Color.White;
            this.checkVille.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkVille.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkVille.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkVille.FillColor = System.Drawing.Color.White;
            this.checkVille.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkVille.Location = new System.Drawing.Point(15, 165);
            this.checkVille.Margin = new System.Windows.Forms.Padding(5);
            this.checkVille.Name = "checkVille";
            this.checkVille.Size = new System.Drawing.Size(61, 22);
            this.checkVille.TabIndex = 21;
            this.checkVille.Text = "Ville";
            this.checkVille.CheckedChanged += new System.EventHandler(this.checkVille_CheckedChanged);
            // 
            // checkNomUtilisateur
            // 
            this.checkNomUtilisateur.BaseColor = System.Drawing.Color.White;
            this.checkNomUtilisateur.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkNomUtilisateur.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkNomUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkNomUtilisateur.FillColor = System.Drawing.Color.White;
            this.checkNomUtilisateur.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNomUtilisateur.Location = new System.Drawing.Point(86, 165);
            this.checkNomUtilisateur.Margin = new System.Windows.Forms.Padding(5);
            this.checkNomUtilisateur.Name = "checkNomUtilisateur";
            this.checkNomUtilisateur.Size = new System.Drawing.Size(141, 22);
            this.checkNomUtilisateur.TabIndex = 22;
            this.checkNomUtilisateur.Text = "Nom utilisateur";
            this.checkNomUtilisateur.CheckedChanged += new System.EventHandler(this.checkNomUtilisateur_CheckedChanged);
            // 
            // checkStatutEmploye
            // 
            this.checkStatutEmploye.BaseColor = System.Drawing.Color.White;
            this.checkStatutEmploye.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkStatutEmploye.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkStatutEmploye.FillColor = System.Drawing.Color.White;
            this.checkStatutEmploye.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStatutEmploye.Location = new System.Drawing.Point(15, 197);
            this.checkStatutEmploye.Margin = new System.Windows.Forms.Padding(5);
            this.checkStatutEmploye.Name = "checkStatutEmploye";
            this.checkStatutEmploye.Size = new System.Drawing.Size(145, 22);
            this.checkStatutEmploye.TabIndex = 23;
            this.checkStatutEmploye.Text = "Statut employe";
            this.checkStatutEmploye.CheckedChanged += new System.EventHandler(this.checkStatutEmploye_CheckedChanged);
            // 
            // checkDateEnregistrement
            // 
            this.checkDateEnregistrement.BaseColor = System.Drawing.Color.White;
            this.checkDateEnregistrement.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkDateEnregistrement.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkDateEnregistrement.FillColor = System.Drawing.Color.White;
            this.checkDateEnregistrement.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDateEnregistrement.Location = new System.Drawing.Point(15, 229);
            this.checkDateEnregistrement.Margin = new System.Windows.Forms.Padding(5);
            this.checkDateEnregistrement.Name = "checkDateEnregistrement";
            this.checkDateEnregistrement.Size = new System.Drawing.Size(199, 22);
            this.checkDateEnregistrement.TabIndex = 24;
            this.checkDateEnregistrement.Text = "Date d\'enregistrement";
            this.checkDateEnregistrement.CheckedChanged += new System.EventHandler(this.checkDateEnregistrement_CheckedChanged);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.gunaButton8);
            this.gunaPanel3.Controls.Add(this.txbRechercher);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(451, 65);
            this.gunaPanel3.TabIndex = 9;
            // 
            // gunaButton8
            // 
            this.gunaButton8.AnimationHoverSpeed = 0.07F;
            this.gunaButton8.AnimationSpeed = 0.03F;
            this.gunaButton8.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton8.BaseColor = System.Drawing.Color.White;
            this.gunaButton8.BorderColor = System.Drawing.Color.Black;
            this.gunaButton8.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton8.ForeColor = System.Drawing.Color.Black;
            this.gunaButton8.Image = global::Couche.Winforms.Properties.Resources.find_user_52px;
            this.gunaButton8.ImageOffsetX = -7;
            this.gunaButton8.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton8.Location = new System.Drawing.Point(18, 18);
            this.gunaButton8.Name = "gunaButton8";
            this.gunaButton8.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton8.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton8.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton8.OnHoverImage = global::Couche.Winforms.Properties.Resources.find_user_52px;
            this.gunaButton8.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton8.Radius = 15;
            this.gunaButton8.Size = new System.Drawing.Size(29, 29);
            this.gunaButton8.TabIndex = 8;
            // 
            // txbRechercher
            // 
            this.txbRechercher.BackColor = System.Drawing.Color.Transparent;
            this.txbRechercher.BaseColor = System.Drawing.Color.White;
            this.txbRechercher.BorderColor = System.Drawing.Color.Silver;
            this.txbRechercher.BorderSize = 1;
            this.txbRechercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRechercher.FocusedBaseColor = System.Drawing.Color.White;
            this.txbRechercher.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.txbRechercher.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbRechercher.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRechercher.Location = new System.Drawing.Point(10, 15);
            this.txbRechercher.Name = "txbRechercher";
            this.txbRechercher.PasswordChar = '\0';
            this.txbRechercher.Radius = 15;
            this.txbRechercher.Size = new System.Drawing.Size(433, 35);
            this.txbRechercher.TabIndex = 7;
            this.txbRechercher.TextOffsetX = 35;
            this.txbRechercher.TextChanged += new System.EventHandler(this.txbRechercher_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(3, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(536, 58);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Gestion des employes";
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaPanel5.Controls.Add(this.btnExporterExcel);
            this.gunaPanel5.Controls.Add(this.btnImprimer);
            this.gunaPanel5.Controls.Add(this.btnInformationEmploye);
            this.gunaPanel5.Controls.Add(this.btnSupprimer);
            this.gunaPanel5.Controls.Add(this.btnEditerCompteEmploye);
            this.gunaPanel5.Controls.Add(this.btnEditerEmploye);
            this.gunaPanel5.Controls.Add(this.btnEnregistrerEmploye);
            this.gunaPanel5.Controls.Add(this.gunaButton1);
            this.gunaPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel5.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(200, 700);
            this.gunaPanel5.TabIndex = 8;
            // 
            // btnExporterExcel
            // 
            this.btnExporterExcel.AnimationHoverSpeed = 0.07F;
            this.btnExporterExcel.AnimationSpeed = 0.03F;
            this.btnExporterExcel.BaseColor = System.Drawing.Color.Transparent;
            this.btnExporterExcel.BorderColor = System.Drawing.Color.Black;
            this.btnExporterExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExporterExcel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExporterExcel.FocusedColor = System.Drawing.Color.Empty;
            this.btnExporterExcel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExporterExcel.ForeColor = System.Drawing.Color.White;
            this.btnExporterExcel.Image = global::Couche.Winforms.Properties.Resources.ms_excel_64px;
            this.btnExporterExcel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExporterExcel.Location = new System.Drawing.Point(0, 294);
            this.btnExporterExcel.Name = "btnExporterExcel";
            this.btnExporterExcel.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnExporterExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExporterExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExporterExcel.OnHoverImage = global::Couche.Winforms.Properties.Resources.ms_excel_52px;
            this.btnExporterExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnExporterExcel.Size = new System.Drawing.Size(200, 42);
            this.btnExporterExcel.TabIndex = 32;
            this.btnExporterExcel.Text = "Exporter sous Excel";
            this.btnExporterExcel.Click += new System.EventHandler(this.btnExporterExcel_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.AnimationHoverSpeed = 0.07F;
            this.btnImprimer.AnimationSpeed = 0.03F;
            this.btnImprimer.BaseColor = System.Drawing.Color.Transparent;
            this.btnImprimer.BorderColor = System.Drawing.Color.Black;
            this.btnImprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImprimer.FocusedColor = System.Drawing.Color.Empty;
            this.btnImprimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.Image = global::Couche.Winforms.Properties.Resources.print_64px;
            this.btnImprimer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImprimer.Location = new System.Drawing.Point(0, 252);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnImprimer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImprimer.OnHoverImage = global::Couche.Winforms.Properties.Resources.print_52px;
            this.btnImprimer.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimer.Size = new System.Drawing.Size(200, 42);
            this.btnImprimer.TabIndex = 31;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnInformationEmploye
            // 
            this.btnInformationEmploye.AnimationHoverSpeed = 0.07F;
            this.btnInformationEmploye.AnimationSpeed = 0.03F;
            this.btnInformationEmploye.BaseColor = System.Drawing.Color.Transparent;
            this.btnInformationEmploye.BorderColor = System.Drawing.Color.Black;
            this.btnInformationEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformationEmploye.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformationEmploye.Enabled = false;
            this.btnInformationEmploye.FocusedColor = System.Drawing.Color.Empty;
            this.btnInformationEmploye.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformationEmploye.ForeColor = System.Drawing.Color.White;
            this.btnInformationEmploye.Image = global::Couche.Winforms.Properties.Resources.info_64px;
            this.btnInformationEmploye.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInformationEmploye.Location = new System.Drawing.Point(0, 210);
            this.btnInformationEmploye.Name = "btnInformationEmploye";
            this.btnInformationEmploye.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnInformationEmploye.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInformationEmploye.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInformationEmploye.OnHoverImage = global::Couche.Winforms.Properties.Resources.info_52px2;
            this.btnInformationEmploye.OnPressedColor = System.Drawing.Color.Black;
            this.btnInformationEmploye.Size = new System.Drawing.Size(200, 42);
            this.btnInformationEmploye.TabIndex = 27;
            this.btnInformationEmploye.Text = "Informations employe";
            this.btnInformationEmploye.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.AnimationHoverSpeed = 0.07F;
            this.btnSupprimer.AnimationSpeed = 0.03F;
            this.btnSupprimer.BaseColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.BorderColor = System.Drawing.Color.Black;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.FocusedColor = System.Drawing.Color.Empty;
            this.btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Image = global::Couche.Winforms.Properties.Resources.info_64px;
            this.btnSupprimer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSupprimer.Location = new System.Drawing.Point(0, 168);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSupprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSupprimer.OnHoverImage = global::Couche.Winforms.Properties.Resources.info_52px2;
            this.btnSupprimer.OnPressedColor = System.Drawing.Color.Black;
            this.btnSupprimer.Size = new System.Drawing.Size(200, 42);
            this.btnSupprimer.TabIndex = 26;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnEditerCompteEmploye
            // 
            this.btnEditerCompteEmploye.AnimationHoverSpeed = 0.07F;
            this.btnEditerCompteEmploye.AnimationSpeed = 0.03F;
            this.btnEditerCompteEmploye.BaseColor = System.Drawing.Color.Transparent;
            this.btnEditerCompteEmploye.BorderColor = System.Drawing.Color.Black;
            this.btnEditerCompteEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditerCompteEmploye.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditerCompteEmploye.Enabled = false;
            this.btnEditerCompteEmploye.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditerCompteEmploye.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditerCompteEmploye.ForeColor = System.Drawing.Color.White;
            this.btnEditerCompteEmploye.Image = global::Couche.Winforms.Properties.Resources.edit_user_male_64px;
            this.btnEditerCompteEmploye.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditerCompteEmploye.Location = new System.Drawing.Point(0, 126);
            this.btnEditerCompteEmploye.Name = "btnEditerCompteEmploye";
            this.btnEditerCompteEmploye.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnEditerCompteEmploye.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditerCompteEmploye.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditerCompteEmploye.OnHoverImage = global::Couche.Winforms.Properties.Resources.edit_user_52px;
            this.btnEditerCompteEmploye.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditerCompteEmploye.Size = new System.Drawing.Size(200, 42);
            this.btnEditerCompteEmploye.TabIndex = 25;
            this.btnEditerCompteEmploye.Text = "Editer compte employe";
            this.btnEditerCompteEmploye.Click += new System.EventHandler(this.btnEditerCompteEmploye_Click);
            // 
            // btnEditerEmploye
            // 
            this.btnEditerEmploye.AnimationHoverSpeed = 0.07F;
            this.btnEditerEmploye.AnimationSpeed = 0.03F;
            this.btnEditerEmploye.BaseColor = System.Drawing.Color.Transparent;
            this.btnEditerEmploye.BorderColor = System.Drawing.Color.Black;
            this.btnEditerEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditerEmploye.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditerEmploye.Enabled = false;
            this.btnEditerEmploye.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditerEmploye.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditerEmploye.ForeColor = System.Drawing.Color.White;
            this.btnEditerEmploye.Image = global::Couche.Winforms.Properties.Resources.edit_user_male_64px;
            this.btnEditerEmploye.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditerEmploye.Location = new System.Drawing.Point(0, 84);
            this.btnEditerEmploye.Name = "btnEditerEmploye";
            this.btnEditerEmploye.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnEditerEmploye.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditerEmploye.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditerEmploye.OnHoverImage = global::Couche.Winforms.Properties.Resources.edit_user_52px;
            this.btnEditerEmploye.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditerEmploye.Size = new System.Drawing.Size(200, 42);
            this.btnEditerEmploye.TabIndex = 2;
            this.btnEditerEmploye.Text = "Editer employe";
            this.btnEditerEmploye.Click += new System.EventHandler(this.btnEditerEmploye_Click);
            // 
            // btnEnregistrerEmploye
            // 
            this.btnEnregistrerEmploye.AnimationHoverSpeed = 0.07F;
            this.btnEnregistrerEmploye.AnimationSpeed = 0.03F;
            this.btnEnregistrerEmploye.BaseColor = System.Drawing.Color.Transparent;
            this.btnEnregistrerEmploye.BorderColor = System.Drawing.Color.Black;
            this.btnEnregistrerEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrerEmploye.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnregistrerEmploye.FocusedColor = System.Drawing.Color.Empty;
            this.btnEnregistrerEmploye.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerEmploye.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrerEmploye.Image = global::Couche.Winforms.Properties.Resources.add_user_male_64px;
            this.btnEnregistrerEmploye.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEnregistrerEmploye.Location = new System.Drawing.Point(0, 42);
            this.btnEnregistrerEmploye.Name = "btnEnregistrerEmploye";
            this.btnEnregistrerEmploye.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnEnregistrerEmploye.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEnregistrerEmploye.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEnregistrerEmploye.OnHoverImage = global::Couche.Winforms.Properties.Resources.add_user_52px;
            this.btnEnregistrerEmploye.OnPressedColor = System.Drawing.Color.Black;
            this.btnEnregistrerEmploye.Size = new System.Drawing.Size(200, 42);
            this.btnEnregistrerEmploye.TabIndex = 1;
            this.btnEnregistrerEmploye.Text = "Enregistrer employe";
            this.btnEnregistrerEmploye.Click += new System.EventHandler(this.btnEnregistrerEmploye_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.White;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton1.FocusedColor = System.Drawing.Color.White;
            this.gunaButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = global::Couche.Winforms.Properties.Resources.myspace_squared_52px;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = global::Couche.Winforms.Properties.Resources.myspace_squared_52px;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(200, 42);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "Tout sur employe";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this.dataGridEmploye;
            // 
            // dataGridEmploye
            // 
            this.dataGridEmploye.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.dataGridEmploye.AllowUserToAddRows = false;
            this.dataGridEmploye.AllowUserToDeleteRows = false;
            this.dataGridEmploye.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataGridEmploye.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEmploye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmploye.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridEmploye.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridEmploye.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridEmploye.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridEmploye.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmploye.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEmploye.ColumnHeadersHeight = 40;
            this.dataGridEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridEmploye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column12});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmploye.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEmploye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridEmploye.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridEmploye.EnableHeadersVisualStyles = false;
            this.dataGridEmploye.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataGridEmploye.Location = new System.Drawing.Point(0, 0);
            this.dataGridEmploye.Name = "dataGridEmploye";
            this.dataGridEmploye.ReadOnly = true;
            this.dataGridEmploye.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridEmploye.RowHeadersVisible = false;
            this.dataGridEmploye.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridEmploye.RowTemplate.DividerHeight = 1;
            this.dataGridEmploye.RowTemplate.Height = 30;
            this.dataGridEmploye.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmploye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmploye.Size = new System.Drawing.Size(780, 500);
            this.dataGridEmploye.StandardTab = true;
            this.dataGridEmploye.TabIndex = 1;
            this.dataGridEmploye.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dataGridEmploye.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataGridEmploye.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridEmploye.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridEmploye.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridEmploye.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridEmploye.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridEmploye.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataGridEmploye.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridEmploye.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridEmploye.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridEmploye.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridEmploye.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridEmploye.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridEmploye.ThemeStyle.ReadOnly = true;
            this.dataGridEmploye.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dataGridEmploye.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridEmploye.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridEmploye.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridEmploye.ThemeStyle.RowsStyle.Height = 30;
            this.dataGridEmploye.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dataGridEmploye.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridEmploye.SelectionChanged += new System.EventHandler(this.dataGridEmploye_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodeEmploye";
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NomComplet";
            this.Column2.HeaderText = "Nom complet";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateNaissance";
            this.Column3.HeaderText = "Date naissance";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LieuNaissance";
            this.Column4.HeaderText = "Lieu naissance";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Sexe";
            this.Column5.HeaderText = "Sexe";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NumeroCNI";
            this.Column6.HeaderText = "Numero CNI";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NumeroTelephone1";
            this.Column7.HeaderText = "Numero";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Pays";
            this.Column8.HeaderText = "Pays";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Ville";
            this.Column9.HeaderText = "Ville";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "NomUtilisateur";
            this.Column10.HeaderText = "Nom utilisateur";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "StatutEmploye";
            this.Column12.HeaderText = "Statut";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.AutoScroll = true;
            this.gunaPanel4.BackColor = System.Drawing.Color.White;
            this.gunaPanel4.Controls.Add(this.lblCountItems);
            this.gunaPanel4.Controls.Add(this.dataGrid);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel4.ForeColor = System.Drawing.Color.Transparent;
            this.gunaPanel4.Location = new System.Drawing.Point(200, 140);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Padding = new System.Windows.Forms.Padding(10, 10, 10, 50);
            this.gunaPanel4.Size = new System.Drawing.Size(800, 560);
            this.gunaPanel4.TabIndex = 13;
            // 
            // lblCountItems
            // 
            this.lblCountItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCountItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCountItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountItems.ForeColor = System.Drawing.Color.Black;
            this.lblCountItems.Location = new System.Drawing.Point(10, 516);
            this.lblCountItems.Name = "lblCountItems";
            this.lblCountItems.Size = new System.Drawing.Size(433, 35);
            this.lblCountItems.TabIndex = 11;
            this.lblCountItems.Text = "0 employes";
            this.lblCountItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGrid
            // 
            this.dataGrid.AutoScroll = true;
            this.dataGrid.BackColor = System.Drawing.Color.Transparent;
            this.dataGrid.BaseColor = System.Drawing.Color.Transparent;
            this.dataGrid.BorderColor = System.Drawing.Color.Transparent;
            this.dataGrid.Controls.Add(this.dataGridEmploye);
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ForeColor = System.Drawing.Color.DimGray;
            this.dataGrid.LineBottom = 2;
            this.dataGrid.LineColor = System.Drawing.Color.Gainsboro;
            this.dataGrid.LineLeft = 2;
            this.dataGrid.LineRight = 2;
            this.dataGrid.LineTop = 2;
            this.dataGrid.Location = new System.Drawing.Point(10, 10);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Radius = 5;
            this.dataGrid.Size = new System.Drawing.Size(780, 500);
            this.dataGrid.TabIndex = 9;
            this.dataGrid.TextLocation = new System.Drawing.Point(10, 10);
            // 
            // Uc_GererEmploye
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPanel5);
            this.Name = "Uc_GererEmploye";
            this.Size = new System.Drawing.Size(1000, 700);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmploye)).EndInit();
            this.gunaPanel4.ResumeLayout(false);
            this.dataGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnEditerEmploye;
        private Guna.UI.WinForms.GunaButton btnEnregistrerEmploye;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Guna.UI.WinForms.GunaTextBox txbRechercher;
        private Guna.UI.WinForms.GunaButton gunaButton8;
        private Guna.UI.WinForms.GunaButton btnInformationEmploye;
        private Guna.UI.WinForms.GunaButton btnSupprimer;
        private Guna.UI.WinForms.GunaButton btnEditerCompteEmploye;
        private Guna.UI.WinForms.GunaButton btnExporterExcel;
        private Guna.UI.WinForms.GunaButton btnImprimer;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDataGridView dataGridEmploye;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaGroupBox dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private Guna.UI.WinForms.GunaLabel lblCountItems;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaCheckBox checkCode;
        private Guna.UI.WinForms.GunaCheckBox checkNomComplet;
        private Guna.UI.WinForms.GunaCheckBox checkDateNaissance;
        private Guna.UI.WinForms.GunaCheckBox checkLieuNaissance;
        private Guna.UI.WinForms.GunaCheckBox checkSexe;
        private Guna.UI.WinForms.GunaCheckBox checkNumeroCNI;
        private Guna.UI.WinForms.GunaCheckBox checkNumeroTelephone;
        private Guna.UI.WinForms.GunaCheckBox checkPays;
        private Guna.UI.WinForms.GunaCheckBox checkVille;
        private Guna.UI.WinForms.GunaCheckBox checkNomUtilisateur;
        private Guna.UI.WinForms.GunaCheckBox checkStatutEmploye;
        private Guna.UI.WinForms.GunaCheckBox checkDateEnregistrement;
    }
}
