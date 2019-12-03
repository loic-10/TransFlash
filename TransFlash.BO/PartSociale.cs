using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO
{
    [Serializable]
    public class PartSociale
    {
        public CompteClient CompteClient { get; set; }
        public StatutPartSociale StatutPartSociale { get; set; }
        public double Montant { get; set; }

        public PartSociale()
        {
        }

        public PartSociale(CompteClient compteClient)
        {
            CompteClient = compteClient;
        }

        public PartSociale(CompteClient compteClient, StatutPartSociale statutPartSociale, double montant) : this(compteClient)
        {
            StatutPartSociale = statutPartSociale;
            Montant = montant;
        }

        public override bool Equals(object obj)
        {
            return obj is PartSociale sociale &&
                   EqualityComparer<CompteClient>.Default.Equals(CompteClient, sociale.CompteClient);
        }

        public override int GetHashCode()
        {
            return CompteClient.GetHashCode();
        }
    }
}
