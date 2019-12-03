namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms
{
    partial class Frm_EditerCompteEmploye
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaGroupBox13 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaGroupBox14 = new Guna.UI.WinForms.GunaGroupBox();
            this.txbNomUtilisateur = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel23 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox15 = new Guna.UI.WinForms.GunaGroupBox();
            this.cmbTypeCompte = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.panelMontantDepart = new Guna.UI.WinForms.GunaGroupBox();
            this.txbConfirmerMDP = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.panelNomStructure = new Guna.UI.WinForms.GunaGroupBox();
            this.txbMDP = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel21 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.panelControl.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox13.SuspendLayout();
            this.gunaGroupBox14.SuspendLayout();
            this.gunaGroupBox15.SuspendLayout();
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
            this.panelControl.Size = new System.Drawing.Size(640, 43);
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
            this.GunaControlBox1.Location = new System.Drawing.Point(602, 6);
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
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 430);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(640, 66);
            this.gunaPanel1.TabIndex = 12;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaGroupBox13
            // 
            this.gunaGroupBox13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaGroupBox13.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox13.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox13.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaGroupBox13.BorderSize = 1;
            this.gunaGroupBox13.Controls.Add(this.gunaGroupBox14);
            this.gunaGroupBox13.Controls.Add(this.gunaGroupBox15);
            this.gunaGroupBox13.Controls.Add(this.panelMontantDepart);
            this.gunaGroupBox13.Controls.Add(this.panelNomStructure);
            this.gunaGroupBox13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox13.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox13.LineTop = 0;
            this.gunaGroupBox13.Location = new System.Drawing.Point(55, 73);
            this.gunaGroupBox13.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.gunaGroupBox13.Name = "gunaGroupBox13";
            this.gunaGroupBox13.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.gunaGroupBox13.Radius = 5;
            this.gunaGroupBox13.Size = new System.Drawing.Size(530, 328);
            this.gunaGroupBox13.TabIndex = 13;
            this.gunaGroupBox13.Text = "Mise a jour du compte l\'employe : emp_00000001";
            this.gunaGroupBox13.TextLocation = new System.Drawing.Point(10, 10);
            // 
            // gunaGroupBox14
            // 
            this.gunaGroupBox14.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox14.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox14.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaGroupBox14.Controls.Add(this.txbNomUtilisateur);
            this.gunaGroupBox14.Controls.Add(this.gunaLabel23);
            this.gunaGroupBox14.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox14.LineTop = 0;
            this.gunaGroupBox14.Location = new System.Drawing.Point(42, 129);
            this.gunaGroupBox14.Name = "gunaGroupBox14";
            this.gunaGroupBox14.Radius = 5;
            this.gunaGroupBox14.Size = new System.Drawing.Size(446, 38);
            this.gunaGroupBox14.TabIndex = 19;
            this.gunaGroupBox14.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txbNomUtilisateur
            // 
            this.txbNomUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.txbNomUtilisateur.BaseColor = System.Drawing.Color.White;
            this.txbNomUtilisateur.BorderColor = System.Drawing.Color.Silver;
            this.txbNomUtilisateur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNomUtilisateur.Dock = System.Windows.Forms.DockStyle.Right;
            this.txbNomUtilisateur.FocusedBaseColor = System.Drawing.Color.White;
            this.txbNomUtilisateur.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.txbNomUtilisateur.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbNomUtilisateur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomUtilisateur.Location = new System.Drawing.Point(221, 0);
            this.txbNomUtilisateur.Name = "txbNomUtilisateur";
            this.txbNomUtilisateur.PasswordChar = '\0';
            this.txbNomUtilisateur.Radius = 5;
            this.txbNomUtilisateur.Size = new System.Drawing.Size(225, 38);
            this.txbNomUtilisateur.TabIndex = 6;
            // 
            // gunaLabel23
            // 
            this.gunaLabel23.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLabel23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel23.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel23.Name = "gunaLabel23";
            this.gunaLabel23.Size = new System.Drawing.Size(205, 38);
            this.gunaLabel23.TabIndex = 4;
            this.gunaLabel23.Text = "Nom d\'utilisateur (pseudo)*";
            this.gunaLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaGroupBox15
            // 
            this.gunaGroupBox15.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox15.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox15.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaGroupBox15.Controls.Add(this.cmbTypeCompte);
            this.gunaGroupBox15.Controls.Add(this.gunaLabel13);
            this.gunaGroupBox15.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox15.LineTop = 0;
            this.gunaGroupBox15.Location = new System.Drawing.Point(42, 67);
            this.gunaGroupBox15.Name = "gunaGroupBox15";
            this.gunaGroupBox15.Radius = 5;
            this.gunaGroupBox15.Size = new System.Drawing.Size(446, 38);
            this.gunaGroupBox15.TabIndex = 13;
            this.gunaGroupBox15.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cmbTypeCompte
            // 
            this.cmbTypeCompte.BackColor = System.Drawing.Color.Transparent;
            this.cmbTypeCompte.BaseColor = System.Drawing.Color.White;
            this.cmbTypeCompte.BorderColor = System.Drawing.Color.Silver;
            this.cmbTypeCompte.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbTypeCompte.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTypeCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeCompte.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTypeCompte.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeCompte.ForeColor = System.Drawing.Color.Black;
            this.cmbTypeCompte.FormattingEnabled = true;
            this.cmbTypeCompte.Location = new System.Drawing.Point(164, 0);
            this.cmbTypeCompte.Name = "cmbTypeCompte";
            this.cmbTypeCompte.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.cmbTypeCompte.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbTypeCompte.Radius = 5;
            this.cmbTypeCompte.Size = new System.Drawing.Size(282, 38);
            this.cmbTypeCompte.TabIndex = 9;
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel13.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(144, 38);
            this.gunaLabel13.TabIndex = 4;
            this.gunaLabel13.Text = "Role de l\'employe*";
            this.gunaLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMontantDepart
            // 
            this.panelMontantDepart.BackColor = System.Drawing.Color.Transparent;
            this.panelMontantDepart.BaseColor = System.Drawing.Color.Transparent;
            this.panelMontantDepart.BorderColor = System.Drawing.Color.DarkGray;
            this.panelMontantDepart.Controls.Add(this.txbConfirmerMDP);
            this.panelMontantDepart.Controls.Add(this.gunaLabel18);
            this.panelMontantDepart.LineColor = System.Drawing.Color.Gainsboro;
            this.panelMontantDepart.LineTop = 0;
            this.panelMontantDepart.Location = new System.Drawing.Point(42, 253);
            this.panelMontantDepart.Name = "panelMontantDepart";
            this.panelMontantDepart.Radius = 5;
            this.panelMontantDepart.Size = new System.Drawing.Size(446, 38);
            this.panelMontantDepart.TabIndex = 9;
            this.panelMontantDepart.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txbConfirmerMDP
            // 
            this.txbConfirmerMDP.BackColor = System.Drawing.Color.Transparent;
            this.txbConfirmerMDP.BaseColor = System.Drawing.Color.White;
            this.txbConfirmerMDP.BorderColor = System.Drawing.Color.Silver;
            this.txbConfirmerMDP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbConfirmerMDP.Dock = System.Windows.Forms.DockStyle.Right;
            this.txbConfirmerMDP.FocusedBaseColor = System.Drawing.Color.White;
            this.txbConfirmerMDP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.txbConfirmerMDP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbConfirmerMDP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmerMDP.Location = new System.Drawing.Point(164, 0);
            this.txbConfirmerMDP.Name = "txbConfirmerMDP";
            this.txbConfirmerMDP.PasswordChar = '\0';
            this.txbConfirmerMDP.Radius = 5;
            this.txbConfirmerMDP.Size = new System.Drawing.Size(282, 38);
            this.txbConfirmerMDP.TabIndex = 5;
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLabel18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel18.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(150, 38);
            this.gunaLabel18.TabIndex = 4;
            this.gunaLabel18.Text = "Confirmation mdp*";
            this.gunaLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelNomStructure
            // 
            this.panelNomStructure.BackColor = System.Drawing.Color.Transparent;
            this.panelNomStructure.BaseColor = System.Drawing.Color.Transparent;
            this.panelNomStructure.BorderColor = System.Drawing.Color.DarkGray;
            this.panelNomStructure.Controls.Add(this.txbMDP);
            this.panelNomStructure.Controls.Add(this.gunaLabel21);
            this.panelNomStructure.LineColor = System.Drawing.Color.Gainsboro;
            this.panelNomStructure.LineTop = 0;
            this.panelNomStructure.Location = new System.Drawing.Point(42, 191);
            this.panelNomStructure.Name = "panelNomStructure";
            this.panelNomStructure.Radius = 5;
            this.panelNomStructure.Size = new System.Drawing.Size(446, 38);
            this.panelNomStructure.TabIndex = 6;
            this.panelNomStructure.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txbMDP
            // 
            this.txbMDP.BackColor = System.Drawing.Color.Transparent;
            this.txbMDP.BaseColor = System.Drawing.Color.White;
            this.txbMDP.BorderColor = System.Drawing.Color.Silver;
            this.txbMDP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMDP.Dock = System.Windows.Forms.DockStyle.Right;
            this.txbMDP.FocusedBaseColor = System.Drawing.Color.White;
            this.txbMDP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.txbMDP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbMDP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMDP.Location = new System.Drawing.Point(164, 0);
            this.txbMDP.Name = "txbMDP";
            this.txbMDP.PasswordChar = '\0';
            this.txbMDP.Radius = 5;
            this.txbMDP.Size = new System.Drawing.Size(282, 38);
            this.txbMDP.TabIndex = 6;
            // 
            // gunaLabel21
            // 
            this.gunaLabel21.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLabel21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel21.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel21.Name = "gunaLabel21";
            this.gunaLabel21.Size = new System.Drawing.Size(144, 38);
            this.gunaLabel21.TabIndex = 4;
            this.gunaLabel21.Text = "Mot de passe*";
            this.gunaLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::Couche.Winforms.Properties.Resources.approve_and_update_32px;
            this.gunaButton1.ImageOffsetX = 10;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(220, 10);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(101)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = global::Couche.Winforms.Properties.Resources.refresh_52px;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(200, 47);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "Mettre a jour";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton1.TextOffsetX = 10;
            // 
            // Frm_EditerCompteEmploye
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(640, 496);
            this.Controls.Add(this.gunaGroupBox13);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_EditerCompteEmploye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierClient";
            this.panelControl.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaGroupBox13.ResumeLayout(false);
            this.gunaGroupBox14.ResumeLayout(false);
            this.gunaGroupBox15.ResumeLayout(false);
            this.panelMontantDepart.ResumeLayout(false);
            this.panelNomStructure.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel panelControl;
        internal Guna.UI.WinForms.GunaControlBox GunaControlBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox13;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox14;
        private Guna.UI.WinForms.GunaTextBox txbNomUtilisateur;
        private Guna.UI.WinForms.GunaLabel gunaLabel23;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox15;
        private Guna.UI.WinForms.GunaComboBox cmbTypeCompte;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaGroupBox panelMontantDepart;
        private Guna.UI.WinForms.GunaTextBox txbConfirmerMDP;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaGroupBox panelNomStructure;
        private Guna.UI.WinForms.GunaTextBox txbMDP;
        private Guna.UI.WinForms.GunaLabel gunaLabel21;
    }
}