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

        private OperationBLO operationBLO = new OperationBLO();

        public BeneficierBLO()
        {
            beneficierBLO = new RepositoireDAOFile<Beneficier>();
        }

        public void AjouterBeneficier(string nom, string descriptionCondition, int pourcentage, CompteClient compteClient, Employe employe)
        {
            operationBLO = new OperationBLO();
            beneficierBLO.Add(new Beneficier(new IdentifiantBLO().IdBeneficier, nom, descriptionCondition, pourcentage, compteClient));

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, compteClient.Client, compteClient, 0, "toto tata");

            new IdentifiantBLO().AddIdBeneficier();
        }

        public void ModifierBeneficier(Beneficier beneficier, string nom, string descriptionCondition, int pourcentage, Employe employe)
        {
            operationBLO = new OperationBLO();
            Beneficier oldBeneficier = beneficier;
            beneficier.Nom = nom;
            beneficier.DescriptionCondition = descriptionCondition;
            beneficier.Pourcentage = pourcentage;
            beneficierBLO[beneficierBLO.IndexOf(oldBeneficier)] = beneficier;

            operationBLO.AjouterOperation(TypeOperation.Modification, employe, beneficier.CompteClient.Client, beneficier.CompteClient, pourcentage, "toto tata");
        }

        public void SupprimerBeneficier(Beneficier beneficier, Employe employe)
        {
            operationBLO = new OperationBLO();
            beneficierBLO.Remove(beneficier);

            operationBLO.AjouterOperation(TypeOperation.Suppression, employe, beneficier.CompteClient.Client, beneficier.CompteClient, beneficier.Pourcentage, "toto tata");
        }

        public IEnumerable<Beneficier> RechercherLesBeneficiersDuCompte(CompteClient compteClient) => beneficierBLO.Find(x =>
            x.CompteClient == compteClient);

        public IEnumerable<Beneficier> RechercherLesBeneficiers(string valeur) => beneficierBLO.Find(x => 
            x.Nom.ToLower().Contains(valeur.ToLower()) ||
            x.DescriptionCondition.ToLower().Contains(valeur.ToLower()));

        public List<Beneficier> TousBeneficiers => beneficierBLO.AllItems;

    }
}
