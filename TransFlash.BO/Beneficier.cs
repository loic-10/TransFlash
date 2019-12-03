using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransFlash.BO
{
    [Serializable]
    public class Beneficier
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string DescriptionCondition { get; set; }
        public int Pourcentage { get; set; }
        public CompteClient CompteClient { get; set; }

        public Beneficier()
        {
        }

        public Beneficier(string nom)
        {
            Nom = nom;
        }

        public Beneficier(CompteClient compteClient)
        {
            CompteClient = compteClient;
        }

        public Beneficier(int id, string nom, string descriptionCondition, int pourcentage, CompteClient compteClient)
        {
            Id = id;
            Nom = nom;
            DescriptionCondition = descriptionCondition;
            Pourcentage = pourcentage;
            CompteClient = compteClient;
        }

        public override bool Equals(object obj)
        {
            return obj is Beneficier beneficier &&
                   Id == beneficier.Id;
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
