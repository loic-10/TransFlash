using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO
{
    [Serializable]
    public class Epargne
    {
        public int Id { get; set; }
        public CompteClient CompteClient { get; set; }
        public DateTime DateEmpargne { get; set; }
        public int NombreMois { get; set; }
        public double Solde { get; set; }
        public StatutEpargne StatutEpargne { get; set; }

        public Epargne()
        {
        }

        public Epargne(int id)
        {
            Id = id;
        }

        public Epargne(int id, CompteClient compteClient, DateTime dateEmpargne, int nombreMois, double solde, StatutEpargne statutEpargne) : this(id)
        {
            CompteClient = compteClient;
            DateEmpargne = dateEmpargne;
            NombreMois = nombreMois;
            Solde = solde;
            StatutEpargne = statutEpargne;
        }

        public override bool Equals(object obj)
        {
            return obj is Epargne epargne &&
                   Id == epargne.Id;
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
