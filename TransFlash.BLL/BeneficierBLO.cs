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
    public class BeneficierBLO
    {
        private IDAL<Beneficier> beneficierBLO = null;

        public BeneficierBLO()
        {
            beneficierBLO = new RepositoireDAOFile<Beneficier>();
        }

        public void AjouterBeneficier(int id, string nom, string descriptionCondition, int pourcentage, CompteClient compteClient)
        {
            beneficierBLO.Add(new Beneficier(id, nom, descriptionCondition, pourcentage, compteClient));
        }

        public void ModifierBeneficier(Beneficier beneficier, string nom, string descriptionCondition, int pourcentage, CompteClient compteClient)
        {
            Beneficier oldBeneficier = beneficier;
            beneficier.Nom = nom;
            beneficier.DescriptionCondition = descriptionCondition;
            beneficier.Pourcentage = pourcentage;
            beneficier.CompteClient = compteClient;
            beneficierBLO[beneficierBLO.IndexOf(oldBeneficier)] = beneficier;
        }

        public void SupprimerBeneficier(Beneficier Beneficier)
        {
            beneficierBLO.Remove(Beneficier);
        }

        public List<Beneficier> RechercherLesBeneficiersDuCompte(CompteClient compteClient)
        {
            var reqBeneficiers = from beneficier in TousBeneficiers
                             where (beneficier.CompteClient == compteClient)
                             select beneficier;
            return reqBeneficiers as List<Beneficier>;
        }

        public List<Beneficier> RechercherLesBeneficiers(string valeur)
        {
            var reqBeneficiers = beneficierBLO.Find(x => x.Nom.ToLower().Contains(valeur.ToLower()) ||
                                                                                x.DescriptionCondition.ToLower().Contains(valeur.ToLower()));
            return reqBeneficiers as List<Beneficier>;
        }

        public List<Beneficier> TousBeneficiers => beneficierBLO.AllItems;

    }
}
