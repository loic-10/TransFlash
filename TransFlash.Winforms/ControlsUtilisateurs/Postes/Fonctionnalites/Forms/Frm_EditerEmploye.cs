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
using TransFlash.BLL;
using TransFlash.BO;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms
{
    public partial class Frm_EditerEmploye : Form
    {

        private EmployeBLO employeBLO = null;

        private Employe employe = null;

        private Employe employeChef = null;

        public Frm_EditerEmploye(Employe employeChef, Employe employe)
        {
            InitializeComponent();
            employeBLO = new EmployeBLO();
            this.employeChef = employeChef;
            this.employe = employe;
        }
    }
}
