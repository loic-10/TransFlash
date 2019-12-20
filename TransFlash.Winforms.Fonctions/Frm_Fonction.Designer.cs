namespace TransFlash.Winforms.Fonctions
{
    partial class Frm_Fonction
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation4 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Fonction));
            Guna.UI.Animation.Animation animation5 = new Guna.UI.Animation.Animation();
            Guna.UI.Animation.Animation animation6 = new Guna.UI.Animation.Animation();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaTransition2 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaTransition3 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.SuspendLayout();
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.HorizBlind;
            this.gunaTransition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation4;
            // 
            // gunaTransition2
            // 
            this.gunaTransition2.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.gunaTransition2.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.gunaTransition2.DefaultAnimation = animation5;
            this.gunaTransition2.Interval = 2;
            this.gunaTransition2.MaxAnimationTime = 500;
            // 
            // gunaTransition3
            // 
            this.gunaTransition3.AnimationType = Guna.UI.Animation.AnimationType.Particles;
            this.gunaTransition3.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 1;
            animation6.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 2F;
            animation6.TransparencyCoeff = 0F;
            this.gunaTransition3.DefaultAnimation = animation6;
            this.gunaTransition3.Interval = 30;
            this.gunaTransition3.MaxAnimationTime = 5000;
            // 
            // Frm_Fonction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.gunaTransition2.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.gunaTransition3.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Fonction";
            this.Text = "Les fonctions";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private Guna.UI.WinForms.GunaTransition gunaTransition2;
        private Guna.UI.WinForms.GunaTransition gunaTransition3;
    }
}

