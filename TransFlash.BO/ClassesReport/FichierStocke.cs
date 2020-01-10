using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO.ClassesReport
{
    [Serializable]
    public class FichierStocke
    {
        public int Id { get; set; }
        public DateTime DateEnregistrement { get; set; }
        public string Nom { get; set; }
        public string FileName { get; set; }
        public string Client { get; set; }
        public string Garantie { get; set; }
        public string StatutStockage { get; set; }

        public FichierStocke()
        {
        }

        public FichierStocke(int id)
        {
            Id = id;
        }

        public FichierStocke(int id, DateTime dateEnregistrement, string nom, string fileName, string client, string garantie, 
            string statutStockage) : this(id)
        {
            DateEnregistrement = dateEnregistrement;
            Nom = nom;
            FileName = fileName;
            Client = client;
            Garantie = garantie;
            StatutStockage = statutStockage;
        }

        public override bool Equals(object obj)
        {
            return obj is FichierStocke stocke &&
                   Id == stocke.Id;
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
