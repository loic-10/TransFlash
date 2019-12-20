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
        private static ClientBLO clientBLO = new ClientBLO();
        private static EmployeBLO employeBLO = new EmployeBLO();

        public static bool VerifierCNIExist(string numeroCNI, Client client, Employe employe) => (clientBLO.RechercherCNIExist(numeroCNI, client) == null && 
                                                                                                employeBLO.RechercherCNIExist(numeroCNI, employe) == null);

    }
}
