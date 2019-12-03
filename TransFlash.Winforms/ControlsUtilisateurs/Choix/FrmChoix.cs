using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couche.Winforms.Properties;

namespace Couche.Winforms.ControlsUtilisateurs.Choix
{
    public partial class FrmChoix : UserControl
    {
        public FrmChoix()
        {
            InitializeComponent();
        }

        #region Propriete
        private Image _image;
        private string _action;

        [Category("Nouvelle category")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; pbAction.Image = value; }
        }

        [Category("Nouvelle category")]
        public Image ImageHover { get; set; }

        [Category("Nouvelle category")]
        public string Action
        {
            get { return _action; }
            set { _action = value; lblAction.Text = value; }
        }

        #endregion

        private void GunaMouseStateHelper1_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(150, 255, 255, 255);
            lblAction.BackColor = Color.Black;
            pbAction.Image = ImageHover;
            lblAction.BackColor = Color.FromArgb(200, 255, 255, 255);
            lblAction.ForeColor = Color.Black;
            pbAction.BackColor = Color.Transparent;
            lblAction.BackColor = Color.Transparent;
        }

        private void GunaMouseStateHelper1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(220, 255, 255, 255);
            lblAction.BackColor = Color.Transparent;
            pbAction.Image = Image;
            pbAction.BackColor = Color.Transparent;
            lblAction.ForeColor = Color.DimGray;
            lblAction.BackColor = Color.Transparent;
        }

        private void FrmChoix_Load(object sender, EventArgs e)
        {
            GunaMouseStateHelper1_MouseLeave(sender, e);
        }
    }
}
