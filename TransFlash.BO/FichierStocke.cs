using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO
{
    [Serializable]
    public class FichierStocke
    {
        public int Id { get; set; }
        public DateTime DateEnregistrement { get; set; }
        public string Nom { get; set; }
        public string FileName { get; set; }
        public Client Client { get; set; }
        public Garantie Garantie { get; set; }
        public StatutStockage StatutStockage { get; set; }

        public FichierStocke()
        {
        }

        public FichierStocke(int id)
        {
            Id = id;
        }

        public FichierStocke(int id, DateTime dateEnregistrement, string nom, string fileName, Client client, Garantie garantie, 
            StatutStockage statutStockage) : this(id)
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
