namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    partial class Uc_GererPorteFeuille
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
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.dgClient = new Guna.UI.WinForms.GunaDataGridView();
            this.LieuNaiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton8 = new Guna.UI.WinForms.GunaButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.btnExporterExcel = new Guna.UI.WinForms.GunaButton();
            this.btnImprimer = new Guna.UI.WinForms.GunaButton();
            this.btnInformation = new Guna.UI.WinForms.GunaButton();
            this.btnSupprimer = new Guna.UI.WinForms.GunaButton();
            this.btnEditerClient = new Guna.UI.WinForms.GunaButton();
            this.btnEnregistrerClient = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.AutoScroll = true;
            this.gunaPanel4.BackColor = System.Drawing.Color.White;
            this.gunaPanel4.Controls.Add(this.dgClient);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel4.Location = new System.Drawing.Point(200, 126);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.gunaPanel4.Size = new System.Drawing.Size(800, 574);
            this.gunaPanel4.TabIndex = 10;
            // 
            // dgClient
            // 
            this.dgClient.AllowUserToAddRows = false;
            this.dgClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgClient.AutoGenerateColumns = false;
            this.dgClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgClient.ColumnHeadersHeight = 50;
            this.dgClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LieuNaiss,
            this.CNI});
            this.dgClient.DataSource = this.clientsBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClient.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgClient.EnableHeadersVisualStyles = false;
            this.dgClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgClient.Location = new System.Drawing.Point(10, 10);
            this.dgClient.Name = "dgClient";
            this.dgClient.ReadOnly = true;
            this.dgClient.RowHeadersVisible = false;
            this.dgClient.RowTemplate.DividerHeight = 1;
            this.dgClient.RowTemplate.Height = 30;
            this.dgClient.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClient.Size = new System.Drawing.Size(780, 554);
            this.dgClient.TabIndex = 0;
            this.dgClient.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgClient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgClient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgClient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgClient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgClient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgClient.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgClient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgClient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgClient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgClient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgClient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgClient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgClient.ThemeStyle.HeaderStyle.Height = 50;
            this.dgClient.ThemeStyle.ReadOnly = true;
            this.dgClient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgClient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgClient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgClient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgClient.ThemeStyle.RowsStyle.Height = 30;
            this.dgClient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgClient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // LieuNaiss
            // 
            this.LieuNaiss.DataPropertyName = "LieuNaiss";
            this.LieuNaiss.HeaderText = "Lieu Naissance";
            this.LieuNaiss.Name = "LieuNaiss";
            this.LieuNaiss.ReadOnly = true;
            // 
            // CNI
            // 
            this.CNI.DataPropertyName = "CNI";
            this.CNI.HeaderText = "Numero CNI";
            this.CNI.Name = "CNI";
            this.CNI.ReadOnly = true;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaButton8);
            this.gunaPanel1.Controls.Add(this.gunaTextBox1);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(200, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 126);
            this.gunaPanel1.TabIndex = 9;
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
            this.gunaButton8.Location = new System.Drawing.Point(18, 87);
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
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.BorderSize = 1;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox1.Location = new System.Drawing.Point(10, 84);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 15;
            this.gunaTextBox1.Size = new System.Drawing.Size(433, 35);
            this.gunaTextBox1.TabIndex = 7;
            this.gunaTextBox1.Text = "Rechercher";
            this.gunaTextBox1.TextOffsetX = 35;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(3, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(455, 58);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Gestion des clients";
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaPanel5.Controls.Add(this.btnExporterExcel);
            this.gunaPanel5.Controls.Add(this.btnImprimer);
            this.gunaPanel5.Controls.Add(this.btnInformation);
            this.gunaPanel5.Controls.Add(this.btnSupprimer);
            this.gunaPanel5.Controls.Add(this.btnEditerClient);
            this.gunaPanel5.Controls.Add(this.btnEnregistrerClient);
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
            this.btnExporterExcel.Location = new System.Drawing.Point(0, 252);
            this.btnExporterExcel.Name = "btnExporterExcel";
            this.btnExporterExcel.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnExporterExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExporterExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExporterExcel.OnHoverImage = global::Couche.Winforms.Properties.Resources.ms_excel_52px;
            this.btnExporterExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnExporterExcel.Size = new System.Drawing.Size(200, 42);
            this.btnExporterExcel.TabIndex = 24;
            this.btnExporterExcel.Text = "Exporter sous Excel";
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
            this.btnImprimer.Location = new System.Drawing.Point(0, 210);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnImprimer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImprimer.OnHoverImage = global::Couche.Winforms.Properties.Resources.print_52px;
            this.btnImprimer.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimer.Size = new System.Drawing.Size(200, 42);
            this.btnImprimer.TabIndex = 23;
            this.btnImprimer.Text = "Imprimer";
            // 
            // btnInformation
            // 
            this.btnInformation.AnimationHoverSpeed = 0.07F;
            this.btnInformation.AnimationSpeed = 0.03F;
            this.btnInformation.BaseColor = System.Drawing.Color.Transparent;
            this.btnInformation.BorderColor = System.Drawing.Color.Black;
            this.btnInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformation.FocusedColor = System.Drawing.Color.Empty;
            this.btnInformation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformation.ForeColor = System.Drawing.Color.White;
            this.btnInformation.Image = global::Couche.Winforms.Properties.Resources.info_64px;
            this.btnInformation.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInformation.Location = new System.Drawing.Point(0, 168);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnInformation.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInformation.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInformation.OnHoverImage = global::Couche.Winforms.Properties.Resources.info_52px2;
            this.btnInformation.OnPressedColor = System.Drawing.Color.Black;
            this.btnInformation.Size = new System.Drawing.Size(200, 42);
            this.btnInformation.TabIndex = 22;
            this.btnInformation.Text = "Informations";
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.AnimationHoverSpeed = 0.07F;
            this.btnSupprimer.AnimationSpeed = 0.03F;
            this.btnSupprimer.BaseColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.BorderColor = System.Drawing.Color.Black;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupprimer.FocusedColor = System.Drawing.Color.Empty;
            this.btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Image = global::Couche.Winforms.Properties.Resources.info_64px;
            this.btnSupprimer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSupprimer.Location = new System.Drawing.Point(0, 126);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSupprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSupprimer.OnHoverImage = global::Couche.Winforms.Properties.Resources.info_52px2;
            this.btnSupprimer.OnPressedColor = System.Drawing.Color.Black;
            this.btnSupprimer.Size = new System.Drawing.Size(200, 42);
            this.btnSupprimer.TabIndex = 21;
            this.btnSupprimer.Text = "Supprimer";
            // 
            // btnEditerClient
            // 
            this.btnEditerClient.AnimationHoverSpeed = 0.07F;
            this.btnEditerClient.AnimationSpeed = 0.03F;
            this.btnEditerClient.BaseColor = System.Drawing.Color.Transparent;
            this.btnEditerClient.BorderColor = System.Drawing.Color.Black;
            this.btnEditerClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditerClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditerClient.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditerClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditerClient.ForeColor = System.Drawing.Color.White;
            this.btnEditerClient.Image = global::Couche.Winforms.Properties.Resources.edit_user_male_64px;
            this.btnEditerClient.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditerClient.Location = new System.Drawing.Point(0, 84);
            this.btnEditerClient.Name = "btnEditerClient";
            this.btnEditerClient.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnEditerClient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditerClient.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditerClient.OnHoverImage = global::Couche.Winforms.Properties.Resources.edit_user_52px;
            this.btnEditerClient.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditerClient.Size = new System.Drawing.Size(200, 42);
            this.btnEditerClient.TabIndex = 2;
            this.btnEditerClient.Text = "Editer";
            this.btnEditerClient.Click += new System.EventHandler(this.btnEditerClient_Click);
            // 
            // btnEnregistrerClient
            // 
            this.btnEnregistrerClient.AnimationHoverSpeed = 0.07F;
            this.btnEnregistrerClient.AnimationSpeed = 0.03F;
            this.btnEnregistrerClient.BaseColor = System.Drawing.Color.Transparent;
            this.btnEnregistrerClient.BorderColor = System.Drawing.Color.Black;
            this.btnEnregistrerClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrerClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnregistrerClient.FocusedColor = System.Drawing.Color.Empty;
            this.btnEnregistrerClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerClient.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrerClient.Image = global::Couche.Winforms.Properties.Resources.add_user_male_64px;
            this.btnEnregistrerClient.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEnregistrerClient.Location = new System.Drawing.Point(0, 42);
            this.btnEnregistrerClient.Name = "btnEnregistrerClient";
            this.btnEnregistrerClient.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnEnregistrerClient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEnregistrerClient.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEnregistrerClient.OnHoverImage = global::Couche.Winforms.Properties.Resources.add_user_52px;
            this.btnEnregistrerClient.OnPressedColor = System.Drawing.Color.Black;
            this.btnEnregistrerClient.Size = new System.Drawing.Size(200, 42);
            this.btnEnregistrerClient.TabIndex = 1;
            this.btnEnregistrerClient.Text = "Enregistrer";
            this.btnEnregistrerClient.Click += new System.EventHandler(this.btnEnregistrerClient_Click);
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
            this.gunaButton1.Text = "Tout sur client";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 3;
            this.gunaElipse1.TargetControl = this.dgClient;
            // 
            // Uc_GererClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPanel5);
            this.Name = "Uc_GererClient";
            this.Size = new System.Drawing.Size(1000, 700);
            this.gunaPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaDataGridView dgClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieuNaiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNI;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnEditerClient;
        private Guna.UI.WinForms.GunaButton btnEnregistrerClient;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaButton gunaButton8;
        private Guna.UI.WinForms.GunaButton btnExporterExcel;
        private Guna.UI.WinForms.GunaButton btnImprimer;
        private Guna.UI.WinForms.GunaButton btnInformation;
        private Guna.UI.WinForms.GunaButton btnSupprimer;
    }
}
