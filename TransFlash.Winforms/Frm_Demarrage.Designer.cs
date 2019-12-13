namespace Couche.Winforms
{
    partial class Frm_Demarrage
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
            Guna.UI.Animation.Animation animation3 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Demarrage));
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.panelSplashScreen = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaWinCircleProgressIndicator1 = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panelFormulaire = new Guna.UI.WinForms.GunaGradientPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSplashScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.gunaTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.gunaTransition1.DefaultAnimation = animation3;
            this.gunaTransition1.Interval = 100;
            this.gunaTransition1.MaxAnimationTime = 3000;
            // 
            // panelSplashScreen
            // 
            this.panelSplashScreen.BackColor = System.Drawing.Color.Transparent;
            this.panelSplashScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSplashScreen.BackgroundImage")));
            this.panelSplashScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSplashScreen.Controls.Add(this.gunaLabel1);
            this.panelSplashScreen.Controls.Add(this.gunaWinCircleProgressIndicator1);
            this.panelSplashScreen.Controls.Add(this.gunaPictureBox1);
            this.gunaTransition1.SetDecoration(this.panelSplashScreen, Guna.UI.Animation.DecorationType.None);
            this.panelSplashScreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSplashScreen.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.panelSplashScreen.GradientColor2 = System.Drawing.Color.White;
            this.panelSplashScreen.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.panelSplashScreen.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(154)))));
            this.panelSplashScreen.Location = new System.Drawing.Point(0, 0);
            this.panelSplashScreen.Name = "panelSplashScreen";
            this.panelSplashScreen.Size = new System.Drawing.Size(600, 450);
            this.panelSplashScreen.TabIndex = 3;
            this.panelSplashScreen.Text = "gunaGradientPanel1";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransition1.SetDecoration(this.gunaLabel1, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(205, 237);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(190, 48);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Tag = "";
            this.gunaLabel1.Text = "TransFlash";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaWinCircleProgressIndicator1
            // 
            this.gunaWinCircleProgressIndicator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaWinCircleProgressIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.gunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaTransition1.SetDecoration(this.gunaWinCircleProgressIndicator1, Guna.UI.Animation.DecorationType.None);
            this.gunaWinCircleProgressIndicator1.Location = new System.Drawing.Point(268, 355);
            this.gunaWinCircleProgressIndicator1.Name = "gunaWinCircleProgressIndicator1";
            this.gunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.White;
            this.gunaWinCircleProgressIndicator1.Size = new System.Drawing.Size(64, 64);
            this.gunaWinCircleProgressIndicator1.TabIndex = 4;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTransition1.SetDecoration(this.gunaPictureBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaPictureBox1.Image = global::Couche.Winforms.Properties.Resources.logo;
            this.gunaPictureBox1.Location = new System.Drawing.Point(205, 31);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(190, 203);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            // 
            // panelFormulaire
            // 
            this.panelFormulaire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFormulaire.BackgroundImage")));
            this.panelFormulaire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.panelFormulaire, Guna.UI.Animation.DecorationType.None);
            this.panelFormulaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulaire.GradientColor1 = System.Drawing.Color.White;
            this.panelFormulaire.GradientColor2 = System.Drawing.Color.White;
            this.panelFormulaire.GradientColor3 = System.Drawing.Color.White;
            this.panelFormulaire.GradientColor4 = System.Drawing.Color.White;
            this.panelFormulaire.Location = new System.Drawing.Point(600, 0);
            this.panelFormulaire.Name = "panelFormulaire";
            this.panelFormulaire.Size = new System.Drawing.Size(0, 450);
            this.panelFormulaire.TabIndex = 4;
            this.panelFormulaire.Text = "gunaGradientPanel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Demarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panelFormulaire);
            this.Controls.Add(this.panelSplashScreen);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Demarrage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(70)))));
            this.panelSplashScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaGradientPanel panelSplashScreen;
        private Guna.UI.WinForms.GunaGradientPanel panelFormulaire;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator gunaWinCircleProgressIndicator1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}