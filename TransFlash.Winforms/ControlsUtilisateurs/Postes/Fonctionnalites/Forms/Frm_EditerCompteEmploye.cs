using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms
{
    public partial class Frm_EditerCompteEmploye : Form
    {
        public Frm_EditerCompteEmploye()
        {
            InitializeComponent();
            txbNomUtilisateur.Text = "emp_" + "150".PadLeft(8, '0');
            txbMDP.Text = txbNomUtilisateur.Text.Substring(0, 4);
            txbConfirmerMDP.Text = txbNomUtilisateur.Text.Substring(4, 8);
        }
    }
}
