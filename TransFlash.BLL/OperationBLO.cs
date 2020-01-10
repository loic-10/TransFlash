using TransFlash.DAL;
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
            x.CompteClient.CodeCompte == compteClient.CodeCompte);

        public IEnumerable<Operation> RechercherLesOperations(string valeur, bool checkId, bool checkTypeOperation,
            bool checkEmploye, bool checkDateOperation, bool checkCompteClient, bool checkValeurOperation, 
            bool checkDescription, bool checkClient) => operationBLO.Find(x => 
            (x.Id.ToString().ToLower().Contains(valeur.ToLower()) && checkId) ||
            (x.TypeOperation.ToString().ToLower().Contains(valeur.ToLower()) && checkTypeOperation) ||
            (x.Employe .ToString().ToLower().Contains(valeur.ToLower()) && checkEmploye) ||
            (x.DateOperation.ToString().ToLower().Contains(valeur.ToLower()) && checkDateOperation) ||
            ((x.CompteClient == null ? new CompteClient("/") : x.CompteClient).ToString().ToLower().Contains(valeur.ToLower()) && checkCompteClient) ||
            (x.ValeurOperation.ToString().ToLower().Contains(valeur.ToLower()) && checkValeurOperation) ||
            (x.Description.ToString().ToLower().Contains(valeur.ToLower()) && checkDescription) ||
            ((x.Client != null ? x.Client : new Client("/")).ToString().ToLower().Contains(valeur.ToLower()) && checkClient));

        public List<Operation> TousOperations => operationBLO.AllItems;

    }
}
