namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    partial class Uc_Pays
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
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkNom = new Guna.UI.WinForms.GunaCheckBox();
            this.checkCodeTelephone = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.txbRechercher = new PlaceholderTextBox.PlaceholderTextBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.dataGridPays = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.lblCountItems = new Guna.UI.WinForms.GunaLabel();
            this.dataGrid = new Guna.UI.WinForms.GunaGroupBox();
            this.btnAjouter = new Guna.UI.WinForms.GunaButton();
            this.btnModifier = new Guna.UI.WinForms.GunaButton();
            this.btnSupprimer = new Guna.UI.WinForms.GunaButton();
            this.btnImprimer = new Guna.UI.WinForms.GunaButton();
            this.btnExtraireSousExcel = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaButton8 = new Guna.UI.WinForms.GunaButton();
            this.personneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel6.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPays)).BeginInit();
            this.gunaPanel4.SuspendLayout();
            this.dataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaPanel6);
            this.gunaPanel1.Controls.Add(this.gunaPanel3);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 135);
            this.gunaPanel1.TabIndex = 10;
            // 
            // gunaPanel6
            // 
            this.gunaPanel6.Controls.Add(this.lblTitre);
            this.gunaPanel6.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel6.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel6.Name = "gunaPanel6";
            this.gunaPanel6.Size = new System.Drawing.Size(800, 70);
            this.gunaPanel6.TabIndex = 12;
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
            this.lblTitre.Size = new System.Drawing.Size(735, 70);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "Pays";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.flowLayoutPanel1);
            this.gunaPanel3.Controls.Add(this.gunaPanel5);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 70);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.gunaPanel3.Size = new System.Drawing.Size(800, 65);
            this.gunaPanel3.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.checkNom);
            this.flowLayoutPanel1.Controls.Add(this.checkCodeTelephone);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(451, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 65);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // checkNom
            // 
            this.checkNom.BaseColor = System.Drawing.Color.White;
            this.checkNom.Checked = true;
            this.checkNom.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkNom.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkNom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkNom.FillColor = System.Drawing.Color.White;
            this.checkNom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNom.Location = new System.Drawing.Point(15, 20);
            this.checkNom.Margin = new System.Windows.Forms.Padding(5);
            this.checkNom.Name = "checkNom";
            this.checkNom.Size = new System.Drawing.Size(67, 22);
            this.checkNom.TabIndex = 10;
            this.checkNom.Text = "Nom";
            this.checkNom.CheckedChanged += new System.EventHandler(this.checkNom_CheckedChanged);
            // 
            // checkCodeTelephone
            // 
            this.checkCodeTelephone.BaseColor = System.Drawing.Color.White;
            this.checkCodeTelephone.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkCodeTelephone.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkCodeTelephone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCodeTelephone.FillColor = System.Drawing.Color.White;
            this.checkCodeTelephone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCodeTelephone.Location = new System.Drawing.Point(92, 20);
            this.checkCodeTelephone.Margin = new System.Windows.Forms.Padding(5);
            this.checkCodeTelephone.Name = "checkCodeTelephone";
            this.checkCodeTelephone.Size = new System.Drawing.Size(157, 22);
            this.checkCodeTelephone.TabIndex = 11;
            this.checkCodeTelephone.Text = "Code telephone";
            this.checkCodeTelephone.CheckedChanged += new System.EventHandler(this.checkCodeTelephone_CheckedChanged);
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.Controls.Add(this.gunaLinePanel1);
            this.gunaPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel5.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Padding = new System.Windows.Forms.Padding(10);
            this.gunaPanel5.Size = new System.Drawing.Size(451, 65);
            this.gunaPanel5.TabIndex = 9;
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
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.Controls.Add(this.flowLayoutPanel2);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 135);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(800, 60);
            this.gunaPanel2.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.btnAjouter);
            this.flowLayoutPanel2.Controls.Add(this.btnModifier);
            this.flowLayoutPanel2.Controls.Add(this.btnSupprimer);
            this.flowLayoutPanel2.Controls.Add(this.btnImprimer);
            this.flowLayoutPanel2.Controls.Add(this.btnExtraireSousExcel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(800, 60);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this.dataGridPays;
            // 
            // dataGridPays
            // 
            this.dataGridPays.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.dataGridPays.AllowUserToAddRows = false;
            this.dataGridPays.AllowUserToDeleteRows = false;
            this.dataGridPays.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataGridPays.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPays.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridPays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridPays.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridPays.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridPays.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPays.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPays.ColumnHeadersHeight = 30;
            this.dataGridPays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridPays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPays.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPays.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridPays.EnableHeadersVisualStyles = false;
            this.dataGridPays.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataGridPays.Location = new System.Drawing.Point(0, 0);
            this.dataGridPays.Name = "dataGridPays";
            this.dataGridPays.ReadOnly = true;
            this.dataGridPays.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridPays.RowHeadersVisible = false;
            this.dataGridPays.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridPays.RowTemplate.DividerHeight = 1;
            this.dataGridPays.RowTemplate.Height = 30;
            this.dataGridPays.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPays.Size = new System.Drawing.Size(780, 445);
            this.dataGridPays.StandardTab = true;
            this.dataGridPays.TabIndex = 1;
            this.dataGridPays.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dataGridPays.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataGridPays.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridPays.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridPays.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridPays.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridPays.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridPays.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataGridPays.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridPays.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridPays.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridPays.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridPays.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridPays.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridPays.ThemeStyle.ReadOnly = true;
            this.dataGridPays.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dataGridPays.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridPays.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridPays.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridPays.ThemeStyle.RowsStyle.Height = 30;
            this.dataGridPays.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dataGridPays.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridPays.SelectionChanged += new System.EventHandler(this.dataGridPays_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nom";
            this.Column1.HeaderText = "Nom";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CodePhone";
            this.Column2.HeaderText = "Code telephone";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.AutoScroll = true;
            this.gunaPanel4.BackColor = System.Drawing.Color.White;
            this.gunaPanel4.Controls.Add(this.lblCountItems);
            this.gunaPanel4.Controls.Add(this.dataGrid);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel4.ForeColor = System.Drawing.Color.Transparent;
            this.gunaPanel4.Location = new System.Drawing.Point(0, 195);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Padding = new System.Windows.Forms.Padding(10, 10, 10, 50);
            this.gunaPanel4.Size = new System.Drawing.Size(800, 505);
            this.gunaPanel4.TabIndex = 12;
            // 
            // lblCountItems
            // 
            this.lblCountItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCountItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCountItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountItems.ForeColor = System.Drawing.Color.Black;
            this.lblCountItems.Location = new System.Drawing.Point(10, 462);
            this.lblCountItems.Name = "lblCountItems";
            this.lblCountItems.Size = new System.Drawing.Size(433, 35);
            this.lblCountItems.TabIndex = 12;
            this.lblCountItems.Text = "0 pays";
            this.lblCountItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGrid
            // 
            this.dataGrid.AutoScroll = true;
            this.dataGrid.BackColor = System.Drawing.Color.Transparent;
            this.dataGrid.BaseColor = System.Drawing.Color.Transparent;
            this.dataGrid.BorderColor = System.Drawing.Color.Transparent;
            this.dataGrid.Controls.Add(this.dataGridPays);
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
            this.dataGrid.Size = new System.Drawing.Size(780, 445);
            this.dataGrid.TabIndex = 9;
            this.dataGrid.TextLocation = new System.Drawing.Point(10, 10);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.Animated = true;
            this.btnAjouter.AnimationHoverSpeed = 0.07F;
            this.btnAjouter.AnimationSpeed = 0.03F;
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BaseColor = System.Drawing.Color.White;
            this.btnAjouter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnAjouter.BorderSize = 1;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FocusedColor = System.Drawing.Color.Empty;
            this.btnAjouter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnAjouter.Image = global::Couche.Winforms.Properties.Resources.add_property_48px;
            this.btnAjouter.ImageOffsetX = -5;
            this.btnAjouter.ImageSize = new System.Drawing.Size(24, 24);
            this.btnAjouter.Location = new System.Drawing.Point(10, 15);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnAjouter.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnAjouter.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAjouter.OnHoverImage = global::Couche.Winforms.Properties.Resources.add_property_24px;
            this.btnAjouter.OnPressedColor = System.Drawing.Color.Black;
            this.btnAjouter.Padding = new System.Windows.Forms.Padding(5);
            this.btnAjouter.Radius = 15;
            this.btnAjouter.Size = new System.Drawing.Size(95, 35);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextOffsetX = -5;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Animated = true;
            this.btnModifier.AnimationHoverSpeed = 0.07F;
            this.btnModifier.AnimationSpeed = 0.03F;
            this.btnModifier.BackColor = System.Drawing.Color.Transparent;
            this.btnModifier.BaseColor = System.Drawing.Color.White;
            this.btnModifier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnModifier.BorderSize = 1;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.Enabled = false;
            this.btnModifier.FocusedColor = System.Drawing.Color.Empty;
            this.btnModifier.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnModifier.Image = global::Couche.Winforms.Properties.Resources.edit_property_24px;
            this.btnModifier.ImageOffsetX = -5;
            this.btnModifier.ImageSize = new System.Drawing.Size(24, 24);
            this.btnModifier.Location = new System.Drawing.Point(115, 15);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnModifier.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnModifier.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModifier.OnHoverImage = global::Couche.Winforms.Properties.Resources.edit_property_24px1;
            this.btnModifier.OnPressedColor = System.Drawing.Color.Black;
            this.btnModifier.Padding = new System.Windows.Forms.Padding(5);
            this.btnModifier.Radius = 15;
            this.btnModifier.Size = new System.Drawing.Size(102, 35);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextOffsetX = -5;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Animated = true;
            this.btnSupprimer.AnimationHoverSpeed = 0.07F;
            this.btnSupprimer.AnimationSpeed = 0.03F;
            this.btnSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.BaseColor = System.Drawing.Color.White;
            this.btnSupprimer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnSupprimer.BorderSize = 1;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.FocusedColor = System.Drawing.Color.Empty;
            this.btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnSupprimer.Image = global::Couche.Winforms.Properties.Resources.delete_property_24px;
            this.btnSupprimer.ImageOffsetX = -5;
            this.btnSupprimer.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSupprimer.Location = new System.Drawing.Point(227, 15);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnSupprimer.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnSupprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSupprimer.OnHoverImage = global::Couche.Winforms.Properties.Resources.delete_property_24px1;
            this.btnSupprimer.OnPressedColor = System.Drawing.Color.Black;
            this.btnSupprimer.Padding = new System.Windows.Forms.Padding(5);
            this.btnSupprimer.Radius = 15;
            this.btnSupprimer.Size = new System.Drawing.Size(115, 35);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextOffsetX = -5;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.Animated = true;
            this.btnImprimer.AnimationHoverSpeed = 0.07F;
            this.btnImprimer.AnimationSpeed = 0.03F;
            this.btnImprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimer.BaseColor = System.Drawing.Color.White;
            this.btnImprimer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnImprimer.BorderSize = 1;
            this.btnImprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimer.FocusedColor = System.Drawing.Color.Empty;
            this.btnImprimer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnImprimer.Image = global::Couche.Winforms.Properties.Resources.print_24px;
            this.btnImprimer.ImageOffsetX = -5;
            this.btnImprimer.ImageSize = new System.Drawing.Size(24, 24);
            this.btnImprimer.Location = new System.Drawing.Point(352, 15);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(5);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnImprimer.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnImprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImprimer.OnHoverImage = global::Couche.Winforms.Properties.Resources.print_24px1;
            this.btnImprimer.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimer.Padding = new System.Windows.Forms.Padding(5);
            this.btnImprimer.Radius = 15;
            this.btnImprimer.Size = new System.Drawing.Size(105, 35);
            this.btnImprimer.TabIndex = 7;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.TextOffsetX = -5;
            // 
            // btnExtraireSousExcel
            // 
            this.btnExtraireSousExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtraireSousExcel.Animated = true;
            this.btnExtraireSousExcel.AnimationHoverSpeed = 0.07F;
            this.btnExtraireSousExcel.AnimationSpeed = 0.03F;
            this.btnExtraireSousExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExtraireSousExcel.BaseColor = System.Drawing.Color.White;
            this.btnExtraireSousExcel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnExtraireSousExcel.BorderSize = 1;
            this.btnExtraireSousExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtraireSousExcel.FocusedColor = System.Drawing.Color.Empty;
            this.btnExtraireSousExcel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraireSousExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnExtraireSousExcel.Image = global::Couche.Winforms.Properties.Resources.ms_excel_24px;
            this.btnExtraireSousExcel.ImageOffsetX = -5;
            this.btnExtraireSousExcel.ImageSize = new System.Drawing.Size(24, 24);
            this.btnExtraireSousExcel.Location = new System.Drawing.Point(467, 15);
            this.btnExtraireSousExcel.Margin = new System.Windows.Forms.Padding(5);
            this.btnExtraireSousExcel.Name = "btnExtraireSousExcel";
            this.btnExtraireSousExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnExtraireSousExcel.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnExtraireSousExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExtraireSousExcel.OnHoverImage = global::Couche.Winforms.Properties.Resources.ms_excel_24px1;
            this.btnExtraireSousExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnExtraireSousExcel.Padding = new System.Windows.Forms.Padding(5);
            this.btnExtraireSousExcel.Radius = 15;
            this.btnExtraireSousExcel.Size = new System.Drawing.Size(180, 35);
            this.btnExtraireSousExcel.TabIndex = 8;
            this.btnExtraireSousExcel.Text = "Exporter sous Excel";
            this.btnExtraireSousExcel.TextOffsetX = -5;
            this.btnExtraireSousExcel.Click += new System.EventHandler(this.btnExtraireSousExcel_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPictureBox1.Image = global::Couche.Winforms.Properties.Resources.geography_48px;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(65, 70);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gunaPictureBox1.TabIndex = 7;
            this.gunaPictureBox1.TabStop = false;
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
            this.gunaButton8.Image = global::Couche.Winforms.Properties.Resources.search_property_24px;
            this.gunaButton8.ImageOffsetX = -7;
            this.gunaButton8.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaButton8.Location = new System.Drawing.Point(0, 0);
            this.gunaButton8.Name = "gunaButton8";
            this.gunaButton8.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton8.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton8.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton8.OnHoverImage = global::Couche.Winforms.Properties.Resources.search_property_24px;
            this.gunaButton8.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton8.Radius = 15;
            this.gunaButton8.Size = new System.Drawing.Size(30, 45);
            this.gunaButton8.TabIndex = 8;
            // 
            // personneBindingSource
            // 
            this.personneBindingSource.DataSource = typeof(Couche.Winforms.Personne);
            // 
            // Uc_Pays
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "Uc_Pays";
            this.Size = new System.Drawing.Size(800, 700);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel6.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.gunaPanel5.ResumeLayout(false);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPays)).EndInit();
            this.gunaPanel4.ResumeLayout(false);
            this.dataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDataGridView dataGridPays;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaGroupBox dataGrid;
        private Guna.UI.WinForms.GunaButton btnSupprimer;
        private Guna.UI.WinForms.GunaButton btnAjouter;
        private Guna.UI.WinForms.GunaButton btnModifier;
        private Guna.UI.WinForms.GunaButton btnExtraireSousExcel;
        private Guna.UI.WinForms.GunaButton btnImprimer;
        private System.Windows.Forms.BindingSource personneBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaCheckBox checkNom;
        private Guna.UI.WinForms.GunaCheckBox checkCodeTelephone;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaButton gunaButton8;
        private Guna.UI.WinForms.GunaLabel lblCountItems;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel6;
        private Guna.UI.WinForms.GunaLabel lblTitre;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private PlaceholderTextBox.PlaceholderTextBox txbRechercher;
    }
}
