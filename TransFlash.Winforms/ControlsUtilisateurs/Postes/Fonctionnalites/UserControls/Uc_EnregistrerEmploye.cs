﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using TransFlash.Winforms.Fonctions;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.UserControls
{
    public partial class Uc_EnregistrerEmploye : UserControl
    {

        private Frm_Fonction fonction = new Frm_Fonction();

        public Uc_EnregistrerEmploye()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Uc_GererEmploye frm = new Uc_GererEmploye();
            fonction.AfficherPageChoisie(this, frm);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
        }
    }
}
