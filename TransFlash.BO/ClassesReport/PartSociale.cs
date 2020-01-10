using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO.ClassesReport
{
    [Serializable]
    public class PartSociale
    {
        public string CompteClient { get; set; }
        public string StatutPartSociale { get; set; }
        public double Montant { get; set; }

        public PartSociale()
        {
        }

        public PartSociale(string compteClient)
        {
            CompteClient = compteClient;
        }

        public PartSociale(string compteClient, string statutPartSociale, double montant) : this(compteClient)
        {
            StatutPartSociale = statutPartSociale;
            Montant = montant;
        }

        public override bool Equals(object obj)
        {
            return obj is PartSociale sociale &&
                   EqualityComparer<string>.Default.Equals(CompteClient, sociale.CompteClient);
        }

        public override int GetHashCode()
        {
            return CompteClient.GetHashCode();
        }
    }
}
