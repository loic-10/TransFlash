namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    partial class Uc_Garanties
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
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.dataGridGarantie = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.dataGrid = new Guna.UI.WinForms.GunaGroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel6 = new Guna.UI.WinForms.GunaPanel();
            this.lblTitre = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel7 = new Guna.UI.WinForms.GunaPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkId = new Guna.UI.WinForms.GunaCheckBox();
            this.checkDateEnregistrement = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel8 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.txbRechercher = new PlaceholderTextBox.PlaceholderTextBox();
            this.lblCountItems = new Guna.UI.WinForms.GunaLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkCredit = new Guna.UI.WinForms.GunaCheckBox();
            this.checkNom = new Guna.UI.WinForms.GunaCheckBox();
            this.checkElementEnGarantie = new Guna.UI.WinForms.GunaCheckBox();
            this.checkAvaliste = new Guna.UI.WinForms.GunaCheckBox();
            this.checkStatutGarantie = new Guna.UI.WinForms.GunaCheckBox();
            this.checkMontantEvaluation = new Guna.UI.WinForms.GunaCheckBox();
            this.btnFichiersLies = new Guna.UI.WinForms.GunaButton();
            this.btnInformation = new Guna.UI.WinForms.GunaButton();
            this.btnImprimer = new Guna.UI.WinForms.GunaButton();
            this.btnExtraireSousExcel = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaButton8 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGarantie)).BeginInit();
            this.gunaPanel4.SuspendLayout();
            this.dataGrid.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            this.gunaPanel6.SuspendLayout();
            this.gunaPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gunaPanel8.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaPanel3);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 135);
            this.gunaPanel1.TabIndex = 10;
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
            this.gunaPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel2_Paint);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this.dataGridGarantie;
            // 
            // dataGridGarantie
            // 
            this.dataGridGarantie.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.dataGridGarantie.AllowUserToAddRows = false;
            this.dataGridGarantie.AllowUserToDeleteRows = false;
            this.dataGridGarantie.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataGridGarantie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridGarantie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGarantie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridGarantie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridGarantie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridGarantie.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridGarantie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGarantie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridGarantie.ColumnHeadersHeight = 50;
            this.dataGridGarantie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridGarantie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridGarantie.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridGarantie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridGarantie.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridGarantie.EnableHeadersVisualStyles = false;
            this.dataGridGarantie.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataGridGarantie.Location = new System.Drawing.Point(0, 0);
            this.dataGridGarantie.Name = "dataGridGarantie";
            this.dataGridGarantie.ReadOnly = true;
            this.dataGridGarantie.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridGarantie.RowHeadersVisible = false;
            this.dataGridGarantie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridGarantie.RowTemplate.DividerHeight = 1;
            this.dataGridGarantie.RowTemplate.Height = 30;
            this.dataGridGarantie.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridGarantie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridGarantie.Size = new System.Drawing.Size(780, 445);
            this.dataGridGarantie.StandardTab = true;
            this.dataGridGarantie.TabIndex = 1;
            this.dataGridGarantie.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dataGridGarantie.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataGridGarantie.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridGarantie.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridGarantie.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridGarantie.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridGarantie.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridGarantie.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataGridGarantie.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridGarantie.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridGarantie.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridGarantie.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridGarantie.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridGarantie.ThemeStyle.HeaderStyle.Height = 50;
            this.dataGridGarantie.ThemeStyle.ReadOnly = true;
            this.dataGridGarantie.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dataGridGarantie.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridGarantie.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridGarantie.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridGarantie.ThemeStyle.RowsStyle.Height = 30;
            this.dataGridGarantie.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dataGridGarantie.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridGarantie.SelectionChanged += new System.EventHandler(this.dataGridGarantie_SelectionChanged);
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
            // dataGrid
            // 
            this.dataGrid.AutoScroll = true;
            this.dataGrid.BackColor = System.Drawing.Color.Transparent;
            this.dataGrid.BaseColor = System.Drawing.Color.Transparent;
            this.dataGrid.BorderColor = System.Drawing.Color.Transparent;
            this.dataGrid.Controls.Add(this.dataGridGarantie);
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.btnFichiersLies);
            this.flowLayoutPanel2.Controls.Add(this.btnInformation);
            this.flowLayoutPanel2.Controls.Add(this.btnImprimer);
            this.flowLayoutPanel2.Controls.Add(this.btnExtraireSousExcel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(800, 60);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.White;
            this.gunaPanel3.Controls.Add(this.gunaPanel5);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(800, 135);
            this.gunaPanel3.TabIndex = 11;
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.White;
            this.gunaPanel5.Controls.Add(this.gunaPanel6);
            this.gunaPanel5.Controls.Add(this.gunaPanel7);
            this.gunaPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel5.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(800, 135);
            this.gunaPanel5.TabIndex = 11;
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
            this.lblTitre.Text = "Garantie";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaPanel7
            // 
            this.gunaPanel7.Controls.Add(this.flowLayoutPanel1);
            this.gunaPanel7.Controls.Add(this.gunaPanel8);
            this.gunaPanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel7.Location = new System.Drawing.Point(0, 70);
            this.gunaPanel7.Name = "gunaPanel7";
            this.gunaPanel7.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.gunaPanel7.Size = new System.Drawing.Size(800, 65);
            this.gunaPanel7.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.checkId);
            this.flowLayoutPanel1.Controls.Add(this.checkDateEnregistrement);
            this.flowLayoutPanel1.Controls.Add(this.checkCredit);
            this.flowLayoutPanel1.Controls.Add(this.checkNom);
            this.flowLayoutPanel1.Controls.Add(this.checkElementEnGarantie);
            this.flowLayoutPanel1.Controls.Add(this.checkAvaliste);
            this.flowLayoutPanel1.Controls.Add(this.checkStatutGarantie);
            this.flowLayoutPanel1.Controls.Add(this.checkMontantEvaluation);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(451, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 65);
            this.flowLayoutPanel1.TabIndex = 10;
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
            this.checkId.Size = new System.Drawing.Size(45, 22);
            this.checkId.TabIndex = 10;
            this.checkId.Text = "Id";
            this.checkId.CheckedChanged += new System.EventHandler(this.checkId_CheckedChanged);
            // 
            // checkDateEnregistrement
            // 
            this.checkDateEnregistrement.BaseColor = System.Drawing.Color.White;
            this.checkDateEnregistrement.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkDateEnregistrement.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkDateEnregistrement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkDateEnregistrement.FillColor = System.Drawing.Color.White;
            this.checkDateEnregistrement.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDateEnregistrement.Location = new System.Drawing.Point(70, 5);
            this.checkDateEnregistrement.Margin = new System.Windows.Forms.Padding(5);
            this.checkDateEnregistrement.Name = "checkDateEnregistrement";
            this.checkDateEnregistrement.Size = new System.Drawing.Size(185, 22);
            this.checkDateEnregistrement.TabIndex = 11;
            this.checkDateEnregistrement.Text = "Date enregistrement";
            this.checkDateEnregistrement.CheckedChanged += new System.EventHandler(this.checkDateEnregistrement_CheckedChanged);
            // 
            // gunaPanel8
            // 
            this.gunaPanel8.Controls.Add(this.gunaLinePanel1);
            this.gunaPanel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel8.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel8.Name = "gunaPanel8";
            this.gunaPanel8.Padding = new System.Windows.Forms.Padding(10);
            this.gunaPanel8.Size = new System.Drawing.Size(451, 65);
            this.gunaPanel8.TabIndex = 9;
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
            // lblCountItems
            // 
            this.lblCountItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCountItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCountItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountItems.ForeColor = System.Drawing.Color.Black;
            this.lblCountItems.Location = new System.Drawing.Point(10, 462);
            this.lblCountItems.Name = "lblCountItems";
            this.lblCountItems.Size = new System.Drawing.Size(433, 35);
            this.lblCountItems.TabIndex = 14;
            this.lblCountItems.Text = "0 garantie";
            this.lblCountItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DateEnregistrement";
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Credit";
            this.Column3.HeaderText = "Credit";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Nom";
            this.Column4.HeaderText = "Nom";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ElementEnGarantie";
            this.Column5.HeaderText = "Element garantie";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Avaliste";
            this.Column6.HeaderText = "Avaliste";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "StatutGarantie";
            this.Column7.HeaderText = "Statut garantie";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MontantEvaluation";
            this.Column8.HeaderText = "Montant evaluation";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // checkCredit
            // 
            this.checkCredit.BaseColor = System.Drawing.Color.White;
            this.checkCredit.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkCredit.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCredit.FillColor = System.Drawing.Color.White;
            this.checkCredit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCredit.Location = new System.Drawing.Point(15, 37);
            this.checkCredit.Margin = new System.Windows.Forms.Padding(5);
            this.checkCredit.Name = "checkCredit";
            this.checkCredit.Size = new System.Drawing.Size(77, 22);
            this.checkCredit.TabIndex = 12;
            this.checkCredit.Text = "Credit";
            this.checkCredit.CheckedChanged += new System.EventHandler(this.checkCredit_CheckedChanged);
            // 
            // checkNom
            // 
            this.checkNom.BaseColor = System.Drawing.Color.White;
            this.checkNom.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkNom.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkNom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkNom.FillColor = System.Drawing.Color.White;
            this.checkNom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNom.Location = new System.Drawing.Point(102, 37);
            this.checkNom.Margin = new System.Windows.Forms.Padding(5);
            this.checkNom.Name = "checkNom";
            this.checkNom.Size = new System.Drawing.Size(67, 22);
            this.checkNom.TabIndex = 13;
            this.checkNom.Text = "Nom";
            this.checkNom.CheckedChanged += new System.EventHandler(this.checkNom_CheckedChanged);
            // 
            // checkElementEnGarantie
            // 
            this.checkElementEnGarantie.BaseColor = System.Drawing.Color.White;
            this.checkElementEnGarantie.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkElementEnGarantie.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkElementEnGarantie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkElementEnGarantie.FillColor = System.Drawing.Color.White;
            this.checkElementEnGarantie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkElementEnGarantie.Location = new System.Drawing.Point(15, 69);
            this.checkElementEnGarantie.Margin = new System.Windows.Forms.Padding(5);
            this.checkElementEnGarantie.Name = "checkElementEnGarantie";
            this.checkElementEnGarantie.Size = new System.Drawing.Size(184, 22);
            this.checkElementEnGarantie.TabIndex = 14;
            this.checkElementEnGarantie.Text = "Element en garantie";
            this.checkElementEnGarantie.CheckedChanged += new System.EventHandler(this.checkElementEnGarantie_CheckedChanged);
            // 
            // checkAvaliste
            // 
            this.checkAvaliste.BaseColor = System.Drawing.Color.White;
            this.checkAvaliste.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkAvaliste.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkAvaliste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkAvaliste.FillColor = System.Drawing.Color.White;
            this.checkAvaliste.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAvaliste.Location = new System.Drawing.Point(209, 69);
            this.checkAvaliste.Margin = new System.Windows.Forms.Padding(5);
            this.checkAvaliste.Name = "checkAvaliste";
            this.checkAvaliste.Size = new System.Drawing.Size(89, 22);
            this.checkAvaliste.TabIndex = 15;
            this.checkAvaliste.Text = "Avaliste";
            this.checkAvaliste.CheckedChanged += new System.EventHandler(this.checkAvaliste_CheckedChanged);
            // 
            // checkStatutGarantie
            // 
            this.checkStatutGarantie.BaseColor = System.Drawing.Color.White;
            this.checkStatutGarantie.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkStatutGarantie.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkStatutGarantie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkStatutGarantie.FillColor = System.Drawing.Color.White;
            this.checkStatutGarantie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStatutGarantie.Location = new System.Drawing.Point(15, 101);
            this.checkStatutGarantie.Margin = new System.Windows.Forms.Padding(5);
            this.checkStatutGarantie.Name = "checkStatutGarantie";
            this.checkStatutGarantie.Size = new System.Drawing.Size(143, 22);
            this.checkStatutGarantie.TabIndex = 16;
            this.checkStatutGarantie.Text = "Statut garantie";
            this.checkStatutGarantie.CheckedChanged += new System.EventHandler(this.checkStatutGarantie_CheckedChanged);
            // 
            // checkMontantEvaluation
            // 
            this.checkMontantEvaluation.BaseColor = System.Drawing.Color.White;
            this.checkMontantEvaluation.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkMontantEvaluation.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkMontantEvaluation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkMontantEvaluation.FillColor = System.Drawing.Color.White;
            this.checkMontantEvaluation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMontantEvaluation.Location = new System.Drawing.Point(15, 133);
            this.checkMontantEvaluation.Margin = new System.Windows.Forms.Padding(5);
            this.checkMontantEvaluation.Name = "checkMontantEvaluation";
            this.checkMontantEvaluation.Size = new System.Drawing.Size(193, 22);
            this.checkMontantEvaluation.TabIndex = 17;
            this.checkMontantEvaluation.Text = "Montant d\'evaluation";
            this.checkMontantEvaluation.CheckedChanged += new System.EventHandler(this.checkMontantEvaluation_CheckedChanged);
            // 
            // btnFichiersLies
            // 
            this.btnFichiersLies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFichiersLies.Animated = true;
            this.btnFichiersLies.AnimationHoverSpeed = 0.07F;
            this.btnFichiersLies.AnimationSpeed = 0.03F;
            this.btnFichiersLies.BackColor = System.Drawing.Color.Transparent;
            this.btnFichiersLies.BaseColor = System.Drawing.Color.White;
            this.btnFichiersLies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnFichiersLies.BorderSize = 1;
            this.btnFichiersLies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFichiersLies.FocusedColor = System.Drawing.Color.Empty;
            this.btnFichiersLies.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFichiersLies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnFichiersLies.Image = global::Couche.Winforms.Properties.Resources.linked_file_24px;
            this.btnFichiersLies.ImageOffsetX = -5;
            this.btnFichiersLies.ImageSize = new System.Drawing.Size(24, 24);
            this.btnFichiersLies.Location = new System.Drawing.Point(10, 15);
            this.btnFichiersLies.Margin = new System.Windows.Forms.Padding(5);
            this.btnFichiersLies.Name = "btnFichiersLies";
            this.btnFichiersLies.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnFichiersLies.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnFichiersLies.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFichiersLies.OnHoverImage = global::Couche.Winforms.Properties.Resources.linked_file_24px1;
            this.btnFichiersLies.OnPressedColor = System.Drawing.Color.Black;
            this.btnFichiersLies.Padding = new System.Windows.Forms.Padding(5);
            this.btnFichiersLies.Radius = 15;
            this.btnFichiersLies.Size = new System.Drawing.Size(151, 35);
            this.btnFichiersLies.TabIndex = 3;
            this.btnFichiersLies.Text = "Voir fichiers lies";
            this.btnFichiersLies.TextOffsetX = -5;
            // 
            // btnInformation
            // 
            this.btnInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInformation.Animated = true;
            this.btnInformation.AnimationHoverSpeed = 0.07F;
            this.btnInformation.AnimationSpeed = 0.03F;
            this.btnInformation.BackColor = System.Drawing.Color.Transparent;
            this.btnInformation.BaseColor = System.Drawing.Color.White;
            this.btnInformation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnInformation.BorderSize = 1;
            this.btnInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformation.Enabled = false;
            this.btnInformation.FocusedColor = System.Drawing.Color.Empty;
            this.btnInformation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnInformation.Image = global::Couche.Winforms.Properties.Resources.info_24px;
            this.btnInformation.ImageOffsetX = -5;
            this.btnInformation.ImageSize = new System.Drawing.Size(24, 24);
            this.btnInformation.Location = new System.Drawing.Point(171, 15);
            this.btnInformation.Margin = new System.Windows.Forms.Padding(5);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnInformation.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.btnInformation.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInformation.OnHoverImage = global::Couche.Winforms.Properties.Resources.info_24px1;
            this.btnInformation.OnPressedColor = System.Drawing.Color.Black;
            this.btnInformation.Padding = new System.Windows.Forms.Padding(5);
            this.btnInformation.Radius = 15;
            this.btnInformation.Size = new System.Drawing.Size(130, 35);
            this.btnInformation.TabIndex = 6;
            this.btnInformation.Text = "Informations";
            this.btnInformation.TextOffsetX = -5;
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
            this.btnImprimer.Location = new System.Drawing.Point(311, 15);
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
            this.btnExtraireSousExcel.Location = new System.Drawing.Point(426, 15);
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
            this.gunaPictureBox1.Image = global::Couche.Winforms.Properties.Resources.guarantee_48px;
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
            // Uc_Garanties
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "Uc_Garanties";
            this.Size = new System.Drawing.Size(800, 700);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGarantie)).EndInit();
            this.gunaPanel4.ResumeLayout(false);
            this.dataGrid.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel5.ResumeLayout(false);
            this.gunaPanel6.ResumeLayout(false);
            this.gunaPanel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.gunaPanel8.ResumeLayout(false);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDataGridView dataGridGarantie;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaGroupBox dataGrid;
        private Guna.UI.WinForms.GunaButton btnFichiersLies;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI.WinForms.GunaButton btnInformation;
        private Guna.UI.WinForms.GunaButton btnImprimer;
        private Guna.UI.WinForms.GunaButton btnExtraireSousExcel;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaPanel gunaPanel6;
        private Guna.UI.WinForms.GunaLabel lblTitre;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaCheckBox checkId;
        private Guna.UI.WinForms.GunaCheckBox checkDateEnregistrement;
        private Guna.UI.WinForms.GunaPanel gunaPanel8;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private PlaceholderTextBox.PlaceholderTextBox txbRechercher;
        private Guna.UI.WinForms.GunaButton gunaButton8;
        private Guna.UI.WinForms.GunaLabel lblCountItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private Guna.UI.WinForms.GunaCheckBox checkCredit;
        private Guna.UI.WinForms.GunaCheckBox checkNom;
        private Guna.UI.WinForms.GunaCheckBox checkElementEnGarantie;
        private Guna.UI.WinForms.GunaCheckBox checkAvaliste;
        private Guna.UI.WinForms.GunaCheckBox checkStatutGarantie;
        private Guna.UI.WinForms.GunaCheckBox checkMontantEvaluation;
    }
}
