namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms
{
    partial class Frm_GererVille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControl = new Guna.UI.WinForms.GunaPanel();
            this.GunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnAjouter = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gbCompteEmploye = new Guna.UI.WinForms.GunaGroupBox();
            this.panelMontantDepart = new Guna.UI.WinForms.GunaGroupBox();
            this.txbNom = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.panelNomStructure = new Guna.UI.WinForms.GunaGroupBox();
            this.cmbPays = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel21 = new Guna.UI.WinForms.GunaLabel();
            this.panelControl.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gbCompteEmploye.SuspendLayout();
            this.panelMontantDepart.SuspendLayout();
            this.panelNomStructure.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.panelControl.Controls.Add(this.GunaControlBox1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(483, 43);
            this.panelControl.TabIndex = 11;
            // 
            // GunaControlBox1
            // 
            this.GunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaControlBox1.Animated = true;
            this.GunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.GunaControlBox1.AnimationSpeed = 0.03F;
            this.GunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.GunaControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaControlBox1.IconColor = System.Drawing.Color.White;
            this.GunaControlBox1.IconSize = 12F;
            this.GunaControlBox1.Location = new System.Drawing.Point(445, 6);
            this.GunaControlBox1.Name = "GunaControlBox1";
            this.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.GunaControlBox1.Size = new System.Drawing.Size(30, 30);
            this.GunaControlBox1.TabIndex = 7;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelControl;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.gunaPanel1.Controls.Add(this.btnAjouter);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 349);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(483, 66);
            this.gunaPanel1.TabIndex = 12;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAjouter.Animated = true;
            this.btnAjouter.AnimationHoverSpeed = 0.07F;
            this.btnAjouter.AnimationSpeed = 0.03F;
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnAjouter.BorderColor = System.Drawing.Color.Black;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FocusedColor = System.Drawing.Color.Empty;
            this.btnAjouter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = global::Couche.Winforms.Properties.Resources.checked_24px;
            this.btnAjouter.ImageOffsetX = 5;
            this.btnAjouter.ImageSize = new System.Drawing.Size(24, 24);
            this.btnAjouter.Location = new System.Drawing.Point(172, 10);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.btnAjouter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAjouter.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAjouter.OnHoverImage = global::Couche.Winforms.Properties.Resources.checked_radio_button_24px;
            this.btnAjouter.OnPressedColor = System.Drawing.Color.Black;
            this.btnAjouter.Radius = 5;
            this.btnAjouter.Size = new System.Drawing.Size(138, 47);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Valider";
            this.btnAjouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAjouter.TextOffsetX = 10;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // gbCompteEmploye
            // 
            this.gbCompteEmploye.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbCompteEmploye.BackColor = System.Drawing.Color.Transparent;
            this.gbCompteEmploye.BaseColor = System.Drawing.Color.Transparent;
            this.gbCompteEmploye.BorderColor = System.Drawing.Color.DarkGray;
            this.gbCompteEmploye.BorderSize = 1;
            this.gbCompteEmploye.Controls.Add(this.panelMontantDepart);
            this.gbCompteEmploye.Controls.Add(this.panelNomStructure);
            this.gbCompteEmploye.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompteEmploye.LineColor = System.Drawing.Color.Gainsboro;
            this.gbCompteEmploye.LineTop = 0;
            this.gbCompteEmploye.Location = new System.Drawing.Point(35, 82);
            this.gbCompteEmploye.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.gbCompteEmploye.Name = "gbCompteEmploye";
            this.gbCompteEmploye.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.gbCompteEmploye.Radius = 5;
            this.gbCompteEmploye.Size = new System.Drawing.Size(412, 226);
            this.gbCompteEmploye.TabIndex = 13;
            this.gbCompteEmploye.Text = "Information de la ville";
            this.gbCompteEmploye.TextLocation = new System.Drawing.Point(10, 10);
            // 
            // panelMontantDepart
            // 
            this.panelMontantDepart.BackColor = System.Drawing.Color.Transparent;
            this.panelMontantDepart.BaseColor = System.Drawing.Color.Transparent;
            this.panelMontantDepart.BorderColor = System.Drawing.Color.DarkGray;
            this.panelMontantDepart.Controls.Add(this.txbNom);
            this.panelMontantDepart.Controls.Add(this.gunaLabel18);
            this.panelMontantDepart.LineColor = System.Drawing.Color.Gainsboro;
            this.panelMontantDepart.LineTop = 0;
            this.panelMontantDepart.Location = new System.Drawing.Point(18, 77);
            this.panelMontantDepart.Name = "panelMontantDepart";
            this.panelMontantDepart.Radius = 5;
            this.panelMontantDepart.Size = new System.Drawing.Size(376, 38);
            this.panelMontantDepart.TabIndex = 15;
            this.panelMontantDepart.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txbNom
            // 
            this.txbNom.BackColor = System.Drawing.Color.Transparent;
            this.txbNom.BaseColor = System.Drawing.Color.White;
            this.txbNom.BorderColor = System.Drawing.Color.DarkGray;
            this.txbNom.BorderSize = 1;
            this.txbNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbNom.FocusedBaseColor = System.Drawing.Color.White;
            this.txbNom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.txbNom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbNom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNom.Location = new System.Drawing.Point(83, 0);
            this.txbNom.Name = "txbNom";
            this.txbNom.PasswordChar = '\0';
            this.txbNom.Radius = 5;
            this.txbNom.Size = new System.Drawing.Size(293, 38);
            this.txbNom.TabIndex = 5;
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLabel18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel18.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(83, 38);
            this.gunaLabel18.TabIndex = 4;
            this.gunaLabel18.Text = "Nom*";
            this.gunaLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelNomStructure
            // 
            this.panelNomStructure.BackColor = System.Drawing.Color.Transparent;
            this.panelNomStructure.BaseColor = System.Drawing.Color.Transparent;
            this.panelNomStructure.BorderColor = System.Drawing.Color.DarkGray;
            this.panelNomStructure.Controls.Add(this.cmbPays);
            this.panelNomStructure.Controls.Add(this.gunaLabel21);
            this.panelNomStructure.LineColor = System.Drawing.Color.Gainsboro;
            this.panelNomStructure.LineTop = 0;
            this.panelNomStructure.Location = new System.Drawing.Point(18, 142);
            this.panelNomStructure.Name = "panelNomStructure";
            this.panelNomStructure.Radius = 5;
            this.panelNomStructure.Size = new System.Drawing.Size(376, 38);
            this.panelNomStructure.TabIndex = 14;
            this.panelNomStructure.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cmbPays
            // 
            this.cmbPays.BackColor = System.Drawing.Color.Transparent;
            this.cmbPays.BaseColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbPays.BorderColor = System.Drawing.Color.DarkGray;
            this.cmbPays.BorderSize = 1;
            this.cmbPays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPays.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPays.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPays.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbPays.FormattingEnabled = true;
            this.cmbPays.Location = new System.Drawing.Point(83, 0);
            this.cmbPays.Name = "cmbPays";
            this.cmbPays.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.cmbPays.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbPays.Radius = 5;
            this.cmbPays.Size = new System.Drawing.Size(293, 38);
            this.cmbPays.TabIndex = 10;
            this.cmbPays.SelectedIndexChanged += new System.EventHandler(this.cmbPays_SelectedIndexChanged);
            // 
            // gunaLabel21
            // 
            this.gunaLabel21.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLabel21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel21.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel21.Name = "gunaLabel21";
            this.gunaLabel21.Size = new System.Drawing.Size(83, 38);
            this.gunaLabel21.TabIndex = 4;
            this.gunaLabel21.Text = "Pays*";
            this.gunaLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_GererVille
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(483, 415);
            this.Controls.Add(this.gbCompteEmploye);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_GererVille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_GererVille_FormClosing);
            this.panelControl.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gbCompteEmploye.ResumeLayout(false);
            this.panelMontantDepart.ResumeLayout(false);
            this.panelNomStructure.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel panelControl;
        internal Guna.UI.WinForms.GunaControlBox GunaControlBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaGroupBox gbCompteEmploye;
        private Guna.UI.WinForms.GunaButton btnAjouter;
        private Guna.UI.WinForms.GunaGroupBox panelMontantDepart;
        private Guna.UI.WinForms.GunaTextBox txbNom;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaGroupBox panelNomStructure;
        private Guna.UI.WinForms.GunaLabel gunaLabel21;
        private Guna.UI.WinForms.GunaComboBox cmbPays;
    }
}