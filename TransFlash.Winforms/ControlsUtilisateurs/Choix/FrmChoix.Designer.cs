namespace Couche.Winforms.ControlsUtilisateurs.Choix
{
    partial class FrmChoix
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lblAction = new Guna.UI.WinForms.GunaLabel();
            this.pbAction = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaMouseStateHelper1 = new Guna.UI.WinForms.GunaMouseStateHelper();
            ((System.ComponentModel.ISupportInitialize)(this.pbAction)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // lblAction
            // 
            this.lblAction.BackColor = System.Drawing.Color.Transparent;
            this.lblAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAction.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.ForeColor = System.Drawing.Color.DimGray;
            this.lblAction.Location = new System.Drawing.Point(3, 97);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(163, 50);
            this.lblAction.TabIndex = 3;
            this.lblAction.Text = "gunaLabel1";
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAction
            // 
            this.pbAction.BaseColor = System.Drawing.Color.White;
            this.pbAction.Image = global::Couche.Winforms.Properties.Resources.name_104px2;
            this.pbAction.Location = new System.Drawing.Point(45, 20);
            this.pbAction.Name = "pbAction";
            this.pbAction.Size = new System.Drawing.Size(81, 71);
            this.pbAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAction.TabIndex = 2;
            this.pbAction.TabStop = false;
            // 
            // gunaMouseStateHelper1
            // 
            this.gunaMouseStateHelper1.BackColor = System.Drawing.Color.Transparent;
            this.gunaMouseStateHelper1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaMouseStateHelper1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaMouseStateHelper1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaMouseStateHelper1.Location = new System.Drawing.Point(0, 0);
            this.gunaMouseStateHelper1.Name = "gunaMouseStateHelper1";
            this.gunaMouseStateHelper1.Size = new System.Drawing.Size(170, 155);
            this.gunaMouseStateHelper1.TabIndex = 4;
            this.gunaMouseStateHelper1.MouseLeave += new System.EventHandler(this.GunaMouseStateHelper1_MouseLeave);
            this.gunaMouseStateHelper1.MouseHover += new System.EventHandler(this.GunaMouseStateHelper1_MouseHover);
            // 
            // FrmChoix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaMouseStateHelper1);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.pbAction);
            this.Name = "FrmChoix";
            this.Size = new System.Drawing.Size(170, 155);
            this.Load += new System.EventHandler(this.FrmChoix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel lblAction;
        private Guna.UI.WinForms.GunaPictureBox pbAction;
        private Guna.UI.WinForms.GunaMouseStateHelper gunaMouseStateHelper1;
    }
}
