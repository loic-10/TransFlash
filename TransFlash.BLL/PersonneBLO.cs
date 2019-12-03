using Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransFlash.BO;
using static TransFlash.BO.Statut;

namespace TransFlash.BLL
{
    public class PersonneBLO
    {

        public static bool VerifierCNIExist(string numeroCNI)
        {
            ClientBLO clientBLO = new ClientBLO();
            EmployeBLO employeBLO = new EmployeBLO();

            if (clientBLO.RechercherCNIExist(numeroCNI) != null && employeBLO.RechercherCNIExist(numeroCNI)  != null)
                return true;

            return false;
        }

    }
}
