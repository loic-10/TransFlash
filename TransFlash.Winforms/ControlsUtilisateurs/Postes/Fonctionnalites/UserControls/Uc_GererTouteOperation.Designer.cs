namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    partial class Uc_GererTouteOperation
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel6 = new Guna.UI.WinForms.GunaPanel();
            this.lblTitre = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkId = new Guna.UI.WinForms.GunaCheckBox();
            this.checkDateOperation = new Guna.UI.WinForms.GunaCheckBox();
            this.checkTypeOperation = new Guna.UI.WinForms.GunaCheckBox();
            this.checkEmploye = new Guna.UI.WinForms.GunaCheckBox();
            this.checkClient = new Guna.UI.WinForms.GunaCheckBox();
            this.checkCompteClient = new Guna.UI.WinForms.GunaCheckBox();
            this.checkValeurOperation = new Guna.UI.WinForms.GunaCheckBox();
            this.checkDescription = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel7 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.txbRechercher = new PlaceholderTextBox.PlaceholderTextBox();
            this.gunaButton8 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.btnExporterExcel = new Guna.UI.WinForms.GunaButton();
            this.btnImprimer = new Guna.UI.WinForms.GunaButton();
            this.btnInformationEmploye = new Guna.UI.WinForms.GunaButton();
            this.btnSupprimer = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
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
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.lblCountItems = new Guna.UI.WinForms.GunaLabel();
            this.dataGrid = new Guna.UI.WinForms.GunaGroupBox();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gunaPanel7.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmploye)).BeginInit();
            this.gunaPanel4.SuspendLayout();
            this.dataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaPanel6);
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(200, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 140);
            this.gunaPanel1.TabIndex = 9;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaPanel6
            // 
            this.gunaPanel6.Controls.Add(this.lblTitre);
            this.gunaPanel6.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel6.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel6.Name = "gunaPanel6";
            this.gunaPanel6.Size = new System.Drawing.Size(800, 75);
            this.gunaPanel6.TabIndex = 13;
            // 
            // lblTitre
            // 
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitre.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.lblTitre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitre.ImageKey = "(aucun)";
            this.lblTitre.Location = new System.Drawing.Point(65, 0);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(735, 75);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "Gestion des operations";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPictureBox1.Image = global::Couche.Winforms.Properties.Resources.treatment_list_48px1;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(65, 75);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gunaPictureBox1.TabIndex = 7;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaPanel3);
            this.gunaPanel2.Controls.Add(this.gunaPanel7);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 75);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.gunaPanel2.Size = new System.Drawing.Size(800, 65);
            this.gunaPanel2.TabIndex = 10;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.flowLayoutPanel1);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel3.Location = new System.Drawing.Point(451, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(339, 65);
            this.gunaPanel3.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.checkId);
            this.flowLayoutPanel1.Controls.Add(this.checkDateOperation);
            this.flowLayoutPanel1.Controls.Add(this.checkTypeOperation);
            this.flowLayoutPanel1.Controls.Add(this.checkEmploye);
            this.flowLayoutPanel1.Controls.Add(this.checkClient);
            this.flowLayoutPanel1.Controls.Add(this.checkCompteClient);
            this.flowLayoutPanel1.Controls.Add(this.checkValeurOperation);
            this.flowLayoutPanel1.Controls.Add(this.checkDescription);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 65);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // checkId
            // 
            this.checkId.BaseColor = System.Drawing.Color.White;
            this.checkId.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkId.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkId.FillColor = System.Drawing.Color.White;
            this.checkId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkId.Location = new System.Drawing.Point(15, 5);
            this.checkId.Margin = new System.Windows.Forms.Padding(5);
            this.checkId.Name = "checkId";
            this.checkId.Size = new System.Drawing.Size(106, 22);
            this.checkId.TabIndex = 10;
            this.checkId.Text = "Identifiant";
            this.checkId.CheckedChanged += new System.EventHandler(this.checkCode_CheckedChanged);
            // 
            // checkDateOperation
            // 
            this.checkDateOperation.BaseColor = System.Drawing.Color.White;
            this.checkDateOperation.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkDateOperation.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkDateOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkDateOperation.FillColor = System.Drawing.Color.White;
            this.checkDateOperation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDateOperation.Location = new System.Drawing.Point(131, 5);
            this.checkDateOperation.Margin = new System.Windows.Forms.Padding(5);
            this.checkDateOperation.Name = "checkDateOperation";
            this.checkDateOperation.Size = new System.Drawing.Size(146, 22);
            this.checkDateOperation.TabIndex = 11;
            this.checkDateOperation.Text = "Date operation";
            this.checkDateOperation.CheckedChanged += new System.EventHandler(this.checkNomComplet_CheckedChanged);
            // 
            // checkTypeOperation
            // 
            this.checkTypeOperation.BaseColor = System.Drawing.Color.White;
            this.checkTypeOperation.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkTypeOperation.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkTypeOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkTypeOperation.FillColor = System.Drawing.Color.White;
            this.checkTypeOperation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTypeOperation.Location = new System.Drawing.Point(15, 37);
            this.checkTypeOperation.Margin = new System.Windows.Forms.Padding(5);
            this.checkTypeOperation.Name = "checkTypeOperation";
            this.checkTypeOperation.Size = new System.Drawing.Size(144, 22);
            this.checkTypeOperation.TabIndex = 12;
            this.checkTypeOperation.Text = "Type operation";
            this.checkTypeOperation.CheckedChanged += new System.EventHandler(this.checkDateNaissance_CheckedChanged);
            // 
            // checkEmploye
            // 
            this.checkEmploye.BaseColor = System.Drawing.Color.White;
            this.checkEmploye.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkEmploye.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkEmploye.FillColor = System.Drawing.Color.White;
            this.checkEmploye.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEmploye.Location = new System.Drawing.Point(169, 37);
            this.checkEmploye.Margin = new System.Windows.Forms.Padding(5);
            this.checkEmploye.Name = "checkEmploye";
            this.checkEmploye.Size = new System.Drawing.Size(96, 22);
            this.checkEmploye.TabIndex = 13;
            this.checkEmploye.Text = "Employe";
            this.checkEmploye.CheckedChanged += new System.EventHandler(this.checkLieuNaissance_CheckedChanged);
            // 
            // checkClient
            // 
            this.checkClient.BaseColor = System.Drawing.Color.White;
            this.checkClient.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkClient.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkClient.FillColor = System.Drawing.Color.White;
            this.checkClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkClient.Location = new System.Drawing.Point(15, 69);
            this.checkClient.Margin = new System.Windows.Forms.Padding(5);
            this.checkClient.Name = "checkClient";
            this.checkClient.Size = new System.Drawing.Size(74, 22);
            this.checkClient.TabIndex = 14;
            this.checkClient.Text = "Client";
            this.checkClient.CheckedChanged += new System.EventHandler(this.checkSexe_CheckedChanged);
            // 
            // checkCompteClient
            // 
            this.checkCompteClient.BaseColor = System.Drawing.Color.White;
            this.checkCompteClient.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkCompteClient.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkCompteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCompteClient.FillColor = System.Drawing.Color.White;
            this.checkCompteClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCompteClient.Location = new System.Drawing.Point(99, 69);
            this.checkCompteClient.Margin = new System.Windows.Forms.Padding(5);
            this.checkCompteClient.Name = "checkCompteClient";
            this.checkCompteClient.Size = new System.Drawing.Size(139, 22);
            this.checkCompteClient.TabIndex = 15;
            this.checkCompteClient.Text = "Compte client";
            this.checkCompteClient.CheckedChanged += new System.EventHandler(this.checkNumeroCNI_CheckedChanged);
            // 
            // checkValeurOperation
            // 
            this.checkValeurOperation.BaseColor = System.Drawing.Color.White;
            this.checkValeurOperation.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkValeurOperation.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkValeurOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkValeurOperation.FillColor = System.Drawing.Color.White;
            this.checkValeurOperation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkValeurOperation.Location = new System.Drawing.Point(15, 101);
            this.checkValeurOperation.Margin = new System.Windows.Forms.Padding(5);
            this.checkValeurOperation.Name = "checkValeurOperation";
            this.checkValeurOperation.Size = new System.Drawing.Size(158, 22);
            this.checkValeurOperation.TabIndex = 16;
            this.checkValeurOperation.Text = "Valeur operation";
            this.checkValeurOperation.CheckedChanged += new System.EventHandler(this.checkNumeroTelephone_CheckedChanged);
            // 
            // checkDescription
            // 
            this.checkDescription.BaseColor = System.Drawing.Color.White;
            this.checkDescription.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkDescription.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkDescription.FillColor = System.Drawing.Color.White;
            this.checkDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDescription.Location = new System.Drawing.Point(183, 101);
            this.checkDescription.Margin = new System.Windows.Forms.Padding(5);
            this.checkDescription.Name = "checkDescription";
            this.checkDescription.Size = new System.Drawing.Size(115, 22);
            this.checkDescription.TabIndex = 17;
            this.checkDescription.Text = "Description";
            this.checkDescription.CheckedChanged += new System.EventHandler(this.checkPays_CheckedChanged);
            // 
            // gunaPanel7
            // 
            this.gunaPanel7.Controls.Add(this.gunaLinePanel1);
            this.gunaPanel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel7.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel7.Name = "gunaPanel7";
            this.gunaPanel7.Padding = new System.Windows.Forms.Padding(10);
            this.gunaPanel7.Size = new System.Drawing.Size(451, 65);
            this.gunaPanel7.TabIndex = 11;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.txbRechercher);
            this.gunaLinePanel1.Controls.Add(this.gunaButton8);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 2;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(10, 10);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(431, 45);
            this.gunaLinePanel1.TabIndex = 10;
            // 
            // txbRechercher
            // 
            this.txbRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbRechercher.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRechercher.Location = new System.Drawing.Point(36, 10);
            this.txbRechercher.Name = "txbRechercher";
            this.txbRechercher.PlaceholderText = "Rechercher";
            this.txbRechercher.Size = new System.Drawing.Size(382, 24);
            this.txbRechercher.TabIndex = 10;
            this.txbRechercher.TextChanged += new System.EventHandler(this.txbRechercher_TextChanged);
            // 
            // gunaButton8
            // 
            this.gunaButton8.AnimationHoverSpeed = 0.07F;
            this.gunaButton8.AnimationSpeed = 0.03F;
            this.gunaButton8.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton8.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton8.BorderColor = System.Drawing.Color.Black;
            this.gunaButton8.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaButton8.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton8.ForeColor = System.Drawing.Color.Black;
            this.gunaButton8.Image = global::Couche.Winforms.Properties.Resources.find_user_male_24px;
            this.gunaButton8.ImageOffsetX = -7;
            this.gunaButton8.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaButton8.Location = new System.Drawing.Point(0, 0);
            this.gunaButton8.Name = "gunaButton8";
            this.gunaButton8.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton8.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton8.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton8.OnHoverImage = global::Couche.Winforms.Properties.Resources.find_user_male_24px;
            this.gunaButton8.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton8.Radius = 15;
            this.gunaButton8.Size = new System.Drawing.Size(30, 45);
            this.gunaButton8.TabIndex = 8;
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaPanel5.Controls.Add(this.btnExporterExcel);
            this.gunaPanel5.Controls.Add(this.btnImprimer);
            this.gunaPanel5.Controls.Add(this.btnInformationEmploye);
            this.gunaPanel5.Controls.Add(this.btnSupprimer);
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
            this.btnExporterExcel.Location = new System.Drawing.Point(0, 176);
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
            this.btnImprimer.Location = new System.Drawing.Point(0, 134);
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
            this.btnInformationEmploye.Location = new System.Drawing.Point(0, 92);
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
            this.btnSupprimer.Location = new System.Drawing.Point(0, 50);
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
            this.gunaButton1.Size = new System.Drawing.Size(200, 50);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "Tout sur operation";
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
            this.Column8});
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
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Identifiant";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DateOperation";
            this.Column2.HeaderText = "Date operation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TypeOperation";
            this.Column3.HeaderText = "Type operation";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Employe";
            this.Column4.HeaderText = "Employe";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Client";
            this.Column5.HeaderText = "Client";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CompteClient";
            this.Column6.HeaderText = "Compte client";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ValeurOperation";
            this.Column7.HeaderText = "Valeur operation";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Description";
            this.Column8.HeaderText = "Description";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
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
            // Uc_GererTouteOperation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPanel5);
            this.Name = "Uc_GererTouteOperation";
            this.Size = new System.Drawing.Size(1000, 700);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.gunaPanel7.ResumeLayout(false);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmploye)).EndInit();
            this.gunaPanel4.ResumeLayout(false);
            this.dataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Guna.UI.WinForms.GunaButton btnInformationEmploye;
        private Guna.UI.WinForms.GunaButton btnSupprimer;
        private Guna.UI.WinForms.GunaButton btnExporterExcel;
        private Guna.UI.WinForms.GunaButton btnImprimer;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDataGridView dataGridEmploye;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaGroupBox dataGrid;
        private Guna.UI.WinForms.GunaLabel lblCountItems;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaCheckBox checkId;
        private Guna.UI.WinForms.GunaCheckBox checkTypeOperation;
        private Guna.UI.WinForms.GunaCheckBox checkEmploye;
        private Guna.UI.WinForms.GunaCheckBox checkClient;
        private Guna.UI.WinForms.GunaCheckBox checkCompteClient;
        private Guna.UI.WinForms.GunaCheckBox checkValeurOperation;
        private Guna.UI.WinForms.GunaCheckBox checkDescription;
        public Guna.UI.WinForms.GunaCheckBox checkDateOperation;
        private Guna.UI.WinForms.GunaPanel gunaPanel7;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private PlaceholderTextBox.PlaceholderTextBox txbRechercher;
        private Guna.UI.WinForms.GunaButton gunaButton8;
        private Guna.UI.WinForms.GunaPanel gunaPanel6;
        private Guna.UI.WinForms.GunaLabel lblTitre;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
