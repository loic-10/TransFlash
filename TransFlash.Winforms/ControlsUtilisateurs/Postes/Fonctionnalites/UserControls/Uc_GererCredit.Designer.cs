namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    partial class Uc_GererCredit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.dataGrid = new Guna.UI.WinForms.GunaGroupBox();
            this.dgClient = new Guna.UI.WinForms.GunaDataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton8 = new Guna.UI.WinForms.GunaButton();
            this.txbRecherche = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.btnExporterExcel = new Guna.UI.WinForms.GunaButton();
            this.btnImprimer = new Guna.UI.WinForms.GunaButton();
            this.btnInformation = new Guna.UI.WinForms.GunaButton();
            this.btnSupprimer = new Guna.UI.WinForms.GunaButton();
            this.btnAnnulerCredit = new Guna.UI.WinForms.GunaButton();
            this.btnFinaliserCredit = new Guna.UI.WinForms.GunaButton();
            this.btnInitierCredit = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaPanel4.SuspendLayout();
            this.dataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.AutoScroll = true;
            this.gunaPanel4.BackColor = System.Drawing.Color.White;
            this.gunaPanel4.Controls.Add(this.dataGrid);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel4.ForeColor = System.Drawing.Color.Transparent;
            this.gunaPanel4.Location = new System.Drawing.Point(200, 126);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.gunaPanel4.Size = new System.Drawing.Size(800, 574);
            this.gunaPanel4.TabIndex = 10;
            // 
            // dataGrid
            // 
            this.dataGrid.AutoScroll = true;
            this.dataGrid.BackColor = System.Drawing.Color.Transparent;
            this.dataGrid.BaseColor = System.Drawing.Color.Transparent;
            this.dataGrid.BorderColor = System.Drawing.Color.Transparent;
            this.dataGrid.Controls.Add(this.dgClient);
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
            this.dataGrid.Size = new System.Drawing.Size(780, 554);
            this.dataGrid.TabIndex = 9;
            this.dataGrid.TextLocation = new System.Drawing.Point(10, 10);
            // 
            // dgClient
            // 
            this.dgClient.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.dgClient.AllowUserToAddRows = false;
            this.dgClient.AllowUserToDeleteRows = false;
            this.dgClient.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgClient.AutoGenerateColumns = false;
            this.dgClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgClient.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgClient.ColumnHeadersHeight = 30;
            this.dgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgClient.DataSource = this.personneBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClient.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgClient.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgClient.EnableHeadersVisualStyles = false;
            this.dgClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgClient.Location = new System.Drawing.Point(0, 0);
            this.dgClient.Name = "dgClient";
            this.dgClient.ReadOnly = true;
            this.dgClient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgClient.RowHeadersVisible = false;
            this.dgClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgClient.RowTemplate.DividerHeight = 1;
            this.dgClient.RowTemplate.Height = 30;
            this.dgClient.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClient.Size = new System.Drawing.Size(780, 554);
            this.dgClient.StandardTab = true;
            this.dgClient.TabIndex = 1;
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
            this.dgClient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgClient.ThemeStyle.HeaderStyle.Height = 30;
            this.dgClient.ThemeStyle.ReadOnly = true;
            this.dgClient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgClient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgClient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgClient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgClient.ThemeStyle.RowsStyle.Height = 30;
            this.dgClient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgClient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgClient.SelectionChanged += new System.EventHandler(this.dgClient_SelectionChanged);
            this.dgClient.Resize += new System.EventHandler(this.dgClient_Resize);
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personneBindingSource
            // 
            this.personneBindingSource.DataSource = typeof(Couche.Winforms.Personne);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaButton8);
            this.gunaPanel1.Controls.Add(this.txbRecherche);
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
            // txbRecherche
            // 
            this.txbRecherche.BackColor = System.Drawing.Color.Transparent;
            this.txbRecherche.BaseColor = System.Drawing.Color.White;
            this.txbRecherche.BorderColor = System.Drawing.Color.Silver;
            this.txbRecherche.BorderSize = 1;
            this.txbRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRecherche.FocusedBaseColor = System.Drawing.Color.White;
            this.txbRecherche.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbRecherche.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbRecherche.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRecherche.Location = new System.Drawing.Point(10, 84);
            this.txbRecherche.Name = "txbRecherche";
            this.txbRecherche.PasswordChar = '\0';
            this.txbRecherche.Radius = 15;
            this.txbRecherche.Size = new System.Drawing.Size(433, 35);
            this.txbRecherche.TabIndex = 7;
            this.txbRecherche.Text = "Rechercher";
            this.txbRecherche.TextOffsetX = 35;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(3, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(462, 58);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Gestion des credits";
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaPanel5.Controls.Add(this.btnExporterExcel);
            this.gunaPanel5.Controls.Add(this.btnImprimer);
            this.gunaPanel5.Controls.Add(this.btnInformation);
            this.gunaPanel5.Controls.Add(this.btnSupprimer);
            this.gunaPanel5.Controls.Add(this.btnAnnulerCredit);
            this.gunaPanel5.Controls.Add(this.btnFinaliserCredit);
            this.gunaPanel5.Controls.Add(this.btnInitierCredit);
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
            this.btnImprimer.Location = new System.Drawing.Point(0, 252);
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
            this.btnInformation.Location = new System.Drawing.Point(0, 210);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnInformation.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInformation.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInformation.OnHoverImage = global::Couche.Winforms.Properties.Resources.info_52px2;
            this.btnInformation.OnPressedColor = System.Drawing.Color.Black;
            this.btnInformation.Size = new System.Drawing.Size(200, 42);
            this.btnInformation.TabIndex = 22;
            this.btnInformation.Text = "Informations";
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
            this.btnSupprimer.Location = new System.Drawing.Point(0, 168);
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
            // btnAnnulerCredit
            // 
            this.btnAnnulerCredit.AnimationHoverSpeed = 0.07F;
            this.btnAnnulerCredit.AnimationSpeed = 0.03F;
            this.btnAnnulerCredit.BaseColor = System.Drawing.Color.Transparent;
            this.btnAnnulerCredit.BorderColor = System.Drawing.Color.Black;
            this.btnAnnulerCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnulerCredit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnnulerCredit.FocusedColor = System.Drawing.Color.Empty;
            this.btnAnnulerCredit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerCredit.ForeColor = System.Drawing.Color.White;
            this.btnAnnulerCredit.Image = global::Couche.Winforms.Properties.Resources.remove_user_male_64px;
            this.btnAnnulerCredit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAnnulerCredit.Location = new System.Drawing.Point(0, 126);
            this.btnAnnulerCredit.Name = "btnAnnulerCredit";
            this.btnAnnulerCredit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnAnnulerCredit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAnnulerCredit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnnulerCredit.OnHoverImage = global::Couche.Winforms.Properties.Resources.remove_user_52px;
            this.btnAnnulerCredit.OnPressedColor = System.Drawing.Color.Black;
            this.btnAnnulerCredit.Size = new System.Drawing.Size(200, 42);
            this.btnAnnulerCredit.TabIndex = 11;
            this.btnAnnulerCredit.Text = "Annuler credit";
            // 
            // btnFinaliserCredit
            // 
            this.btnFinaliserCredit.AnimationHoverSpeed = 0.07F;
            this.btnFinaliserCredit.AnimationSpeed = 0.03F;
            this.btnFinaliserCredit.BaseColor = System.Drawing.Color.Transparent;
            this.btnFinaliserCredit.BorderColor = System.Drawing.Color.Black;
            this.btnFinaliserCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinaliserCredit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinaliserCredit.FocusedColor = System.Drawing.Color.Empty;
            this.btnFinaliserCredit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinaliserCredit.ForeColor = System.Drawing.Color.White;
            this.btnFinaliserCredit.Image = global::Couche.Winforms.Properties.Resources.info_64px;
            this.btnFinaliserCredit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFinaliserCredit.Location = new System.Drawing.Point(0, 84);
            this.btnFinaliserCredit.Name = "btnFinaliserCredit";
            this.btnFinaliserCredit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnFinaliserCredit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFinaliserCredit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFinaliserCredit.OnHoverImage = global::Couche.Winforms.Properties.Resources.info_52px2;
            this.btnFinaliserCredit.OnPressedColor = System.Drawing.Color.Black;
            this.btnFinaliserCredit.Size = new System.Drawing.Size(200, 42);
            this.btnFinaliserCredit.TabIndex = 10;
            this.btnFinaliserCredit.Text = "Finaliser credit";
            // 
            // btnInitierCredit
            // 
            this.btnInitierCredit.AnimationHoverSpeed = 0.07F;
            this.btnInitierCredit.AnimationSpeed = 0.03F;
            this.btnInitierCredit.BaseColor = System.Drawing.Color.Transparent;
            this.btnInitierCredit.BorderColor = System.Drawing.Color.Black;
            this.btnInitierCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInitierCredit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInitierCredit.FocusedColor = System.Drawing.Color.Empty;
            this.btnInitierCredit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitierCredit.ForeColor = System.Drawing.Color.White;
            this.btnInitierCredit.Image = global::Couche.Winforms.Properties.Resources.add_user_male_64px;
            this.btnInitierCredit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInitierCredit.Location = new System.Drawing.Point(0, 42);
            this.btnInitierCredit.Name = "btnInitierCredit";
            this.btnInitierCredit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnInitierCredit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInitierCredit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInitierCredit.OnHoverImage = global::Couche.Winforms.Properties.Resources.add_user_52px;
            this.btnInitierCredit.OnPressedColor = System.Drawing.Color.Black;
            this.btnInitierCredit.Size = new System.Drawing.Size(200, 42);
            this.btnInitierCredit.TabIndex = 1;
            this.btnInitierCredit.Text = "Initier credit";
            this.btnInitierCredit.Click += new System.EventHandler(this.btnInitierEmprunt_Click);
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
            this.gunaButton1.Text = "Tout sur credit";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this.dgClient;
            // 
            // Uc_GererCredit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPanel5);
            this.Name = "Uc_GererCredit";
            this.Size = new System.Drawing.Size(1000, 700);
            this.Load += new System.EventHandler(this.Uc_GererEmprunt_Load);
            this.gunaPanel4.ResumeLayout(false);
            this.dataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnInitierCredit;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox txbRecherche;
        private Guna.UI.WinForms.GunaButton gunaButton8;
        private Guna.UI.WinForms.GunaButton btnAnnulerCredit;
        private Guna.UI.WinForms.GunaButton btnFinaliserCredit;
        private Guna.UI.WinForms.GunaButton btnExporterExcel;
        private Guna.UI.WinForms.GunaButton btnImprimer;
        private Guna.UI.WinForms.GunaButton btnInformation;
        private Guna.UI.WinForms.GunaButton btnSupprimer;
        private System.Windows.Forms.BindingSource personneBindingSource;
        private Guna.UI.WinForms.GunaGroupBox dataGrid;
        private Guna.UI.WinForms.GunaDataGridView dgClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
