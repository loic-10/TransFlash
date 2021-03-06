﻿namespace Couche.Winforms.ControlsUtilisateurs.Accueil
{
    partial class Uc_AccueilCaissier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_AccueilCaissier));
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblTitreCaissier = new Guna.UI.WinForms.GunaLabel();
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.btnGererTransaction = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnGererRemboursement = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnGererCredit = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.popupNotifier1 = new Tulpep.NotificationWindow.PopupNotifier();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.gunaShadowPanel1.Controls.Add(this.gunaPanel2);
            this.gunaShadowPanel1.Controls.Add(this.gunaPanel1);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel3);
            this.gunaShadowPanel1.Controls.Add(this.lblTitreCaissier);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1000, 153);
            this.gunaShadowPanel1.TabIndex = 4;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel2.Location = new System.Drawing.Point(699, 106);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(301, 47);
            this.gunaPanel2.TabIndex = 5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(29, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(272, 47);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Afficher la liste de vos transactions";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPictureBox1.Image = global::Couche.Winforms.Properties.Resources.double_right_52px1;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(29, 47);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 106);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(301, 47);
            this.gunaPanel1.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(29, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(272, 47);
            this.gunaLabel4.TabIndex = 5;
            this.gunaLabel4.Text = "Acceder au manuel d\'utilisation";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPictureBox2.Image = global::Couche.Winforms.Properties.Resources.double_right_52px1;
            this.gunaPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(29, 47);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 4;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(0, 53);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(1000, 53);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Vos avez la possibilte d\'avoir acces a toutes vos operations et aussi au manuel d" +
    "\'utilisation consacre a votre poste";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreCaissier
            // 
            this.lblTitreCaissier.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitreCaissier.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreCaissier.ForeColor = System.Drawing.Color.White;
            this.lblTitreCaissier.Location = new System.Drawing.Point(0, 0);
            this.lblTitreCaissier.Name = "lblTitreCaissier";
            this.lblTitreCaissier.Size = new System.Drawing.Size(1000, 53);
            this.lblTitreCaissier.TabIndex = 2;
            this.lblTitreCaissier.Text = "Bienvenue, ";
            this.lblTitreCaissier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.gunaAnimateWindow1.Interval = 100;
            this.gunaAnimateWindow1.TargetControl = null;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.AutoScroll = true;
            this.gunaPanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel3.Controls.Add(this.btnGererTransaction);
            this.gunaPanel3.Controls.Add(this.btnGererRemboursement);
            this.gunaPanel3.Controls.Add(this.btnGererCredit);
            this.gunaPanel3.Controls.Add(this.gunaAdvenceTileButton1);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 153);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(1000, 547);
            this.gunaPanel3.TabIndex = 5;
            // 
            // btnGererTransaction
            // 
            this.btnGererTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGererTransaction.AnimationHoverSpeed = 0.07F;
            this.btnGererTransaction.AnimationSpeed = 0.03F;
            this.btnGererTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnGererTransaction.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGererTransaction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererTransaction.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGererTransaction.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererTransaction.CheckedForeColor = System.Drawing.Color.Black;
            this.btnGererTransaction.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnGererTransaction.CheckedImage")));
            this.btnGererTransaction.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnGererTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGererTransaction.FocusedColor = System.Drawing.Color.Empty;
            this.btnGererTransaction.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGererTransaction.ForeColor = System.Drawing.Color.DimGray;
            this.btnGererTransaction.Image = global::Couche.Winforms.Properties.Resources.data_in_both_directions_104px1;
            this.btnGererTransaction.ImageSize = new System.Drawing.Size(65, 65);
            this.btnGererTransaction.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererTransaction.Location = new System.Drawing.Point(312, 103);
            this.btnGererTransaction.Name = "btnGererTransaction";
            this.btnGererTransaction.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGererTransaction.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererTransaction.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnGererTransaction.OnHoverImage = global::Couche.Winforms.Properties.Resources.data_in_both_directions_104px;
            this.btnGererTransaction.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererTransaction.OnPressedColor = System.Drawing.Color.Black;
            this.btnGererTransaction.Radius = 5;
            this.btnGererTransaction.Size = new System.Drawing.Size(170, 155);
            this.btnGererTransaction.TabIndex = 53;
            this.btnGererTransaction.Text = "Gerer les transactions";
            this.btnGererTransaction.TextImageOffsetY = 15;
            this.btnGererTransaction.Click += new System.EventHandler(this.btnGererTransaction_Click);
            // 
            // btnGererRemboursement
            // 
            this.btnGererRemboursement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGererRemboursement.AnimationHoverSpeed = 0.07F;
            this.btnGererRemboursement.AnimationSpeed = 0.03F;
            this.btnGererRemboursement.BackColor = System.Drawing.Color.Transparent;
            this.btnGererRemboursement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGererRemboursement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererRemboursement.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGererRemboursement.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererRemboursement.CheckedForeColor = System.Drawing.Color.Black;
            this.btnGererRemboursement.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnGererRemboursement.CheckedImage")));
            this.btnGererRemboursement.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnGererRemboursement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGererRemboursement.FocusedColor = System.Drawing.Color.Empty;
            this.btnGererRemboursement.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGererRemboursement.ForeColor = System.Drawing.Color.DimGray;
            this.btnGererRemboursement.Image = global::Couche.Winforms.Properties.Resources.refund_104px;
            this.btnGererRemboursement.ImageSize = new System.Drawing.Size(65, 65);
            this.btnGererRemboursement.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererRemboursement.Location = new System.Drawing.Point(312, 289);
            this.btnGererRemboursement.Name = "btnGererRemboursement";
            this.btnGererRemboursement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGererRemboursement.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererRemboursement.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnGererRemboursement.OnHoverImage = global::Couche.Winforms.Properties.Resources.refund_104px1;
            this.btnGererRemboursement.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererRemboursement.OnPressedColor = System.Drawing.Color.Black;
            this.btnGererRemboursement.Radius = 5;
            this.btnGererRemboursement.Size = new System.Drawing.Size(170, 155);
            this.btnGererRemboursement.TabIndex = 52;
            this.btnGererRemboursement.Text = "Gerer les remboursements";
            this.btnGererRemboursement.TextImageOffsetY = 15;
            this.btnGererRemboursement.Click += new System.EventHandler(this.btnGererRemboursement_Click);
            // 
            // btnGererCredit
            // 
            this.btnGererCredit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGererCredit.AnimationHoverSpeed = 0.07F;
            this.btnGererCredit.AnimationSpeed = 0.03F;
            this.btnGererCredit.BackColor = System.Drawing.Color.Transparent;
            this.btnGererCredit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGererCredit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererCredit.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGererCredit.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererCredit.CheckedForeColor = System.Drawing.Color.Black;
            this.btnGererCredit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnGererCredit.CheckedImage")));
            this.btnGererCredit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnGererCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGererCredit.FocusedColor = System.Drawing.Color.Empty;
            this.btnGererCredit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGererCredit.ForeColor = System.Drawing.Color.DimGray;
            this.btnGererCredit.Image = global::Couche.Winforms.Properties.Resources.debt_104px;
            this.btnGererCredit.ImageSize = new System.Drawing.Size(65, 65);
            this.btnGererCredit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererCredit.Location = new System.Drawing.Point(518, 103);
            this.btnGererCredit.Name = "btnGererCredit";
            this.btnGererCredit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGererCredit.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererCredit.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnGererCredit.OnHoverImage = global::Couche.Winforms.Properties.Resources.debt_104px1;
            this.btnGererCredit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnGererCredit.OnPressedColor = System.Drawing.Color.Black;
            this.btnGererCredit.Radius = 5;
            this.btnGererCredit.Size = new System.Drawing.Size(170, 155);
            this.btnGererCredit.TabIndex = 51;
            this.btnGererCredit.Text = "Gerer les credits";
            this.btnGererCredit.TextImageOffsetY = 15;
            this.btnGererCredit.Click += new System.EventHandler(this.btnGererEmprunt_Click);
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.CheckedImage")));
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.Image = global::Couche.Winforms.Properties.Resources.dossier_folder_104px;
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(65, 65);
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(518, 289);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverImage = global::Couche.Winforms.Properties.Resources.dossier_folder_26px;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Radius = 5;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(170, 155);
            this.gunaAdvenceTileButton1.TabIndex = 34;
            this.gunaAdvenceTileButton1.Text = "Gerer votre porte-feuille";
            this.gunaAdvenceTileButton1.TextImageOffsetY = 15;
            // 
            // popupNotifier1
            // 
            this.popupNotifier1.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            this.popupNotifier1.ContentText = null;
            this.popupNotifier1.Image = null;
            this.popupNotifier1.IsRightToLeft = false;
            this.popupNotifier1.OptionsMenu = null;
            this.popupNotifier1.Size = new System.Drawing.Size(400, 100);
            this.popupNotifier1.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.popupNotifier1.TitleText = null;
            // 
            // Uc_AccueilCaissier
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = global::Couche.Winforms.Properties.Resources.others;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "Uc_AccueilCaissier";
            this.Size = new System.Drawing.Size(1000, 700);
            this.Load += new System.EventHandler(this.Uc_AccueilCaissier_Load_1);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.gunaPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblTitreCaissier;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnGererTransaction;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnGererRemboursement;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnGererCredit;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier1;
    }
}
