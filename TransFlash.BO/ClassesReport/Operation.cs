using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO.ClassesReport
{ 
    [Serializable]
    public class Operation
    {
        public int Id { get; set; }
        public DateTime DateOperation { get; set; }
        public string TypeOperation { get; set; }
        public string Employe { get; set; }
        public string Client { get; set; }
        public string CompteClient { get; set; }
        public double ValeurOperation { get; set; }
        public string Description { get; set; }

        public Operation()
        {
        }

        public Operation(int id)
        {
            Id = id;
        }

        public Operation(int id, DateTime dateOperation, string typeOperation, string employe, string client, 
            string compteClient, double valeurOperation, string description) : this(id)
        {
            DateOperation = dateOperation;
            TypeOperation = typeOperation;
            Employe = employe;
            Client = client;
            CompteClient = compteClient;
            ValeurOperation = valeurOperation;
            Description = description;
        }

        public override bool Equals(object obj)
        {
            return obj is Operation operation &&
                   Id == operation.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
