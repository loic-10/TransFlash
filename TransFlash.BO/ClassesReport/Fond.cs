using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO.ClassesReport
{
    [Serializable]
    public class Fond
    {
        public int Id { get; set; }
        public string Employe { get; set; }
        public string CompteClient { get; set; }
        public DateTime DateFond { get; set; }
        public string TypeActionFond { get; set; }
        public double MontantAction { get; set; }
        public double MontantTotal { get; set; }
        public string Description { get; set; }

        public Fond()
        {
        }

        public Fond(int id, string employe, string compteClient, DateTime dateFond, string typeActionFond, double montantAction,
            double montantTotal, string description)
        {
            Id = id;
            Employe = employe;
            CompteClient = compteClient;
            DateFond = dateFond;
            TypeActionFond = typeActionFond;
            MontantAction = montantAction;
            MontantTotal = montantTotal;
            Description = description;
        }

        public override bool Equals(object obj)
        {
            return obj is Fond fond &&
                   Id == fond.Id;
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
