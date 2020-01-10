namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    partial class Uc_GererRemboursement
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
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.btnExporterExcel = new Guna.UI.WinForms.GunaButton();
            this.btnImprimer = new Guna.UI.WinForms.GunaButton();
            this.btnInformation = new Guna.UI.WinForms.GunaButton();
            this.btnSupprimer = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.btnInitierRemboursement = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.lblCountItems = new Guna.UI.WinForms.GunaLabel();
            this.dataGrid = new Guna.UI.WinForms.GunaGroupBox();
            this.dataGridRemboursement = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel6 = new Guna.UI.WinForms.GunaPanel();
            this.lblTitre = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkCode = new Guna.UI.WinForms.GunaCheckBox();
            this.checkCredit = new Guna.UI.WinForms.GunaCheckBox();
            this.checkDateRemboursement = new Guna.UI.WinForms.GunaCheckBox();
            this.checkMontant = new Guna.UI.WinForms.GunaCheckBox();
            this.checkStatutRemboursement = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel7 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.txbRechercher = new PlaceholderTextBox.PlaceholderTextBox();
            this.gunaButton8 = new Guna.UI.WinForms.GunaButton();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkDatePrevuRemboursement = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel5.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.dataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemboursement)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gunaPanel7.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaPanel5.Controls.Add(this.btnExporterExcel);
            this.gunaPanel5.Controls.Add(this.btnImprimer);
            this.gunaPanel5.Controls.Add(this.btnInformation);
            this.gunaPanel5.Controls.Add(this.btnSupprimer);
            this.gunaPanel5.Controls.Add(this.gunaButton4);
            this.gunaPanel5.Controls.Add(this.gunaButton2);
            this.gunaPanel5.Controls.Add(this.btnInitierRemboursement);
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
            this.btnExporterExcel.Location = new System.Drawing.Point(0, 302);
            this.btnExporterExcel.Name = "btnExporterExcel";
            this.btnExporterExcel.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnExporterExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExporterExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExporterExcel.OnHoverImage = global::Couche.Winforms.Properties.Resources.ms_excel_52px;
            this.btnExporterExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnExporterExcel.Size = new System.Drawing.Size(200, 42);
            this.btnExporterExcel.TabIndex = 24;
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
            this.btnImprimer.Location = new System.Drawing.Point(0, 260);
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
            this.btnInformation.Location = new System.Drawing.Point(0, 218);
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
            this.btnSupprimer.Location = new System.Drawing.Point(0, 176);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSupprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSupprimer.OnHoverImage = global::Couche.Winforms.Properties.Resources.info_52px2;
            this.btnSupprimer.OnPressedColor = System.Drawing.Color.Black;
            this.btnSupprimer.Size = new System.Drawing.Size(200, 42);
            this.btnSupprimer.TabIndex = 21;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = global::Couche.Winforms.Properties.Resources.remove_user_male_64px;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(0, 134);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = global::Couche.Winforms.Properties.Resources.remove_user_52px;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Size = new System.Drawing.Size(200, 42);
            this.gunaButton4.TabIndex = 11;
            this.gunaButton4.Text = "Annuler remboursement";
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::Couche.Winforms.Properties.Resources.info_64px;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(0, 92);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = global::Couche.Winforms.Properties.Resources.info_52px2;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(200, 42);
            this.gunaButton2.TabIndex = 10;
            this.gunaButton2.Text = "Finaliser remboursement";
            // 
            // btnInitierRemboursement
            // 
            this.btnInitierRemboursement.AnimationHoverSpeed = 0.07F;
            this.btnInitierRemboursement.AnimationSpeed = 0.03F;
            this.btnInitierRemboursement.BaseColor = System.Drawing.Color.Transparent;
            this.btnInitierRemboursement.BorderColor = System.Drawing.Color.Black;
            this.btnInitierRemboursement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInitierRemboursement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInitierRemboursement.FocusedColor = System.Drawing.Color.Empty;
            this.btnInitierRemboursement.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitierRemboursement.ForeColor = System.Drawing.Color.White;
            this.btnInitierRemboursement.Image = global::Couche.Winforms.Properties.Resources.add_user_male_64px;
            this.btnInitierRemboursement.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInitierRemboursement.Location = new System.Drawing.Point(0, 50);
            this.btnInitierRemboursement.Name = "btnInitierRemboursement";
            this.btnInitierRemboursement.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnInitierRemboursement.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInitierRemboursement.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInitierRemboursement.OnHoverImage = global::Couche.Winforms.Properties.Resources.add_user_52px;
            this.btnInitierRemboursement.OnPressedColor = System.Drawing.Color.Black;
            this.btnInitierRemboursement.Size = new System.Drawing.Size(200, 42);
            this.btnInitierRemboursement.TabIndex = 1;
            this.btnInitierRemboursement.Text = "Initier remboursement";
            this.btnInitierRemboursement.Click += new System.EventHandler(this.btnInitierRemboursement_Click);
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
            this.gunaButton1.Text = "Tout sur remboursement";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 3;
            this.gunaElipse1.TargetControl = this;
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
            this.gunaPanel4.TabIndex = 17;
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
            this.lblCountItems.Text = "0 remboursement";
            this.lblCountItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGrid
            // 
            this.dataGrid.AutoScroll = true;
            this.dataGrid.BackColor = System.Drawing.Color.Transparent;
            this.dataGrid.BaseColor = System.Drawing.Color.Transparent;
            this.dataGrid.BorderColor = System.Drawing.Color.Transparent;
            this.dataGrid.Controls.Add(this.dataGridRemboursement);
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
            // dataGridRemboursement
            // 
            this.dataGridRemboursement.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.dataGridRemboursement.AllowUserToAddRows = false;
            this.dataGridRemboursement.AllowUserToDeleteRows = false;
            this.dataGridRemboursement.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataGridRemboursement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridRemboursement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRemboursement.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridRemboursement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridRemboursement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridRemboursement.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridRemboursement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRemboursement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridRemboursement.ColumnHeadersHeight = 40;
            this.dataGridRemboursement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridRemboursement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRemboursement.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridRemboursement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRemboursement.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridRemboursement.EnableHeadersVisualStyles = false;
            this.dataGridRemboursement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataGridRemboursement.Location = new System.Drawing.Point(0, 0);
            this.dataGridRemboursement.Name = "dataGridRemboursement";
            this.dataGridRemboursement.ReadOnly = true;
            this.dataGridRemboursement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridRemboursement.RowHeadersVisible = false;
            this.dataGridRemboursement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridRemboursement.RowTemplate.DividerHeight = 1;
            this.dataGridRemboursement.RowTemplate.Height = 30;
            this.dataGridRemboursement.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRemboursement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRemboursement.Size = new System.Drawing.Size(780, 500);
            this.dataGridRemboursement.StandardTab = true;
            this.dataGridRemboursement.TabIndex = 1;
            this.dataGridRemboursement.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dataGridRemboursement.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataGridRemboursement.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridRemboursement.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridRemboursement.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridRemboursement.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridRemboursement.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridRemboursement.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataGridRemboursement.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridRemboursement.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridRemboursement.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridRemboursement.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridRemboursement.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridRemboursement.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridRemboursement.ThemeStyle.ReadOnly = true;
            this.dataGridRemboursement.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dataGridRemboursement.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridRemboursement.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridRemboursement.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridRemboursement.ThemeStyle.RowsStyle.Height = 30;
            this.dataGridRemboursement.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dataGridRemboursement.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridRemboursement.SelectionChanged += new System.EventHandler(this.dataGridCredit_SelectionChanged);
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
            this.gunaPanel1.TabIndex = 16;
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
            this.lblTitre.Text = "Gestion des remboursements";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblTitre.UseCompatibleTextRendering = true;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPictureBox1.Image = global::Couche.Winforms.Properties.Resources.transaction_48px;
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
            this.flowLayoutPanel1.Controls.Add(this.checkCode);
            this.flowLayoutPanel1.Controls.Add(this.checkCredit);
            this.flowLayoutPanel1.Controls.Add(this.checkDatePrevuRemboursement);
            this.flowLayoutPanel1.Controls.Add(this.checkDateRemboursement);
            this.flowLayoutPanel1.Controls.Add(this.checkMontant);
            this.flowLayoutPanel1.Controls.Add(this.checkStatutRemboursement);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 65);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.TabStop = true;
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
            this.checkCode.TabIndex = 15;
            this.checkCode.Text = "Code";
            this.checkCode.CheckedChanged += new System.EventHandler(this.checkCode_CheckedChanged);
            // 
            // checkCredit
            // 
            this.checkCredit.BaseColor = System.Drawing.Color.White;
            this.checkCredit.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkCredit.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCredit.FillColor = System.Drawing.Color.White;
            this.checkCredit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCredit.Location = new System.Drawing.Point(99, 5);
            this.checkCredit.Margin = new System.Windows.Forms.Padding(5);
            this.checkCredit.Name = "checkCredit";
            this.checkCredit.Size = new System.Drawing.Size(77, 22);
            this.checkCredit.TabIndex = 16;
            this.checkCredit.Text = "Credit";
            this.checkCredit.CheckedChanged += new System.EventHandler(this.checkCredit_CheckedChanged);
            // 
            // checkDateRemboursement
            // 
            this.checkDateRemboursement.BaseColor = System.Drawing.Color.White;
            this.checkDateRemboursement.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkDateRemboursement.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkDateRemboursement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkDateRemboursement.FillColor = System.Drawing.Color.White;
            this.checkDateRemboursement.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDateRemboursement.Location = new System.Drawing.Point(15, 69);
            this.checkDateRemboursement.Margin = new System.Windows.Forms.Padding(5);
            this.checkDateRemboursement.Name = "checkDateRemboursement";
            this.checkDateRemboursement.Size = new System.Drawing.Size(192, 22);
            this.checkDateRemboursement.TabIndex = 17;
            this.checkDateRemboursement.Text = "Date remboursement";
            this.checkDateRemboursement.CheckedChanged += new System.EventHandler(this.checkDateRemboursement_CheckedChanged);
            // 
            // checkMontant
            // 
            this.checkMontant.BaseColor = System.Drawing.Color.White;
            this.checkMontant.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkMontant.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkMontant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkMontant.FillColor = System.Drawing.Color.White;
            this.checkMontant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMontant.Location = new System.Drawing.Point(15, 101);
            this.checkMontant.Margin = new System.Windows.Forms.Padding(5);
            this.checkMontant.Name = "checkMontant";
            this.checkMontant.Size = new System.Drawing.Size(95, 22);
            this.checkMontant.TabIndex = 18;
            this.checkMontant.Text = "Montant";
            this.checkMontant.CheckedChanged += new System.EventHandler(this.checkMontant_CheckedChanged);
            // 
            // checkStatutRemboursement
            // 
            this.checkStatutRemboursement.BaseColor = System.Drawing.Color.White;
            this.checkStatutRemboursement.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkStatutRemboursement.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkStatutRemboursement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkStatutRemboursement.FillColor = System.Drawing.Color.White;
            this.checkStatutRemboursement.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStatutRemboursement.Location = new System.Drawing.Point(15, 133);
            this.checkStatutRemboursement.Margin = new System.Windows.Forms.Padding(5);
            this.checkStatutRemboursement.Name = "checkStatutRemboursement";
            this.checkStatutRemboursement.Size = new System.Drawing.Size(198, 22);
            this.checkStatutRemboursement.TabIndex = 19;
            this.checkStatutRemboursement.Text = "Statut remboursement";
            this.checkStatutRemboursement.CheckedChanged += new System.EventHandler(this.checkStatutRemboursement_CheckedChanged);
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
            // Column1
            // 
            this.Column1.DataPropertyName = "CodeRemboursement";
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Credit";
            this.Column2.HeaderText = "Credit";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DatePrevuRemboursement";
            this.Column6.HeaderText = "Date prevu remboursement";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateRemboursement";
            this.Column3.HeaderText = "Date remboursement";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Montant";
            this.Column4.HeaderText = "Montant";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "StatutRemboursement";
            this.Column5.HeaderText = "StatutRemboursement";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // checkDatePrevuRemboursement
            // 
            this.checkDatePrevuRemboursement.BaseColor = System.Drawing.Color.White;
            this.checkDatePrevuRemboursement.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkDatePrevuRemboursement.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.checkDatePrevuRemboursement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkDatePrevuRemboursement.FillColor = System.Drawing.Color.White;
            this.checkDatePrevuRemboursement.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDatePrevuRemboursement.Location = new System.Drawing.Point(15, 37);
            this.checkDatePrevuRemboursement.Margin = new System.Windows.Forms.Padding(5);
            this.checkDatePrevuRemboursement.Name = "checkDatePrevuRemboursement";
            this.checkDatePrevuRemboursement.Size = new System.Drawing.Size(239, 22);
            this.checkDatePrevuRemboursement.TabIndex = 26;
            this.checkDatePrevuRemboursement.Text = "Date prevu remboursement";
            // 
            // Uc_GererRemboursement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPanel5);
            this.Name = "Uc_GererRemboursement";
            this.Size = new System.Drawing.Size(1000, 700);
            this.gunaPanel5.ResumeLayout(false);
            this.gunaPanel4.ResumeLayout(false);
            this.dataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemboursement)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private Guna.UI.WinForms.GunaButton btnInitierRemboursement;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton btnExporterExcel;
        private Guna.UI.WinForms.GunaButton btnImprimer;
        private Guna.UI.WinForms.GunaButton btnInformation;
        private Guna.UI.WinForms.GunaButton btnSupprimer;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaLabel lblCountItems;
        private Guna.UI.WinForms.GunaGroupBox dataGrid;
        private Guna.UI.WinForms.GunaDataGridView dataGridRemboursement;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel6;
        private Guna.UI.WinForms.GunaLabel lblTitre;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel7;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private PlaceholderTextBox.PlaceholderTextBox txbRechercher;
        private Guna.UI.WinForms.GunaButton gunaButton8;
        private Guna.UI.WinForms.GunaCheckBox checkCode;
        public Guna.UI.WinForms.GunaCheckBox checkCredit;
        private Guna.UI.WinForms.GunaCheckBox checkDateRemboursement;
        private Guna.UI.WinForms.GunaCheckBox checkMontant;
        private Guna.UI.WinForms.GunaCheckBox checkStatutRemboursement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI.WinForms.GunaCheckBox checkDatePrevuRemboursement;
    }
}
