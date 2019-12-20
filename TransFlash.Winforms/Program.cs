using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransFlash.BLL;
using TransFlash.BO;

namespace Couche.Winforms
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Frm_Demarrage());
            Application.Run(new Frm_Principal(new EmployeBLO().ChefAgence));
        }
    }
}
