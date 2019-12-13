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
    public class OperationBLO
    {
        private IDAL<Operation> operationBLO = null;

        public OperationBLO()
        {
            operationBLO = new RepositoireDAOFile<Operation>();
        }

        public void AjouterOperation(TypeOperation typeOperation, Employe employe, Client client,
                                                    CompteClient compteClient, double valeurOperation, string description)
        {
            operationBLO.Add(new Operation(new IdentifiantBLO().IdOperation, DateTime.Now, typeOperation, employe, client, compteClient, valeurOperation, description));
            
            new IdentifiantBLO().AddIdOperation();        
        }

        public void SupprimerOperation(Operation Operation)
        {
            operationBLO.Remove(Operation);
        }

        public IEnumerable<Operation> RechercherOperationsCompte(CompteClient compteClient) => operationBLO.Find(x => 
            x.CompteClient == compteClient);

        public IEnumerable<Operation> RechercherLesOperations(string valeur) => operationBLO.Find(x => 
            x.Client.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.Description.ToLower().Contains(valeur.ToLower()) ||
            x.CompteClient.ToString().ToLower().Contains(valeur.ToLower()) ||
            x.ValeurOperation.ToString().Contains(valeur.ToLower()) ||
            x.Employe.ToString().Contains(valeur.ToLower()));

        public List<Operation> TousOperations => operationBLO.AllItems;

    }
}
