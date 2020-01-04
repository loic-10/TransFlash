using TransFlash.DAL;
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

        public void AjouterBeneficier(string nom, string descriptionCondition, int pourcentage, CompteClient compteClient, Employe employe)
        {

            beneficierBLO.Add(new Beneficier(new IdentifiantBLO().IdBeneficier, nom, descriptionCondition, pourcentage, compteClient));

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, compteClient.Client, compteClient, 0,
                $"Ajout du beneficier {new IdentifiantBLO().IdBeneficier} du compte {compteClient}, qui beneficiera d'un pourcentage de {pourcentage}%");

            new IdentifiantBLO().AddIdBeneficier();
        }

        public void ModifierBeneficier(Beneficier beneficier, string nom, string descriptionCondition, int pourcentage, Employe employe)
        {

            int index = beneficierBLO.IndexOf(beneficier);

            beneficier.Nom = nom;
            beneficier.DescriptionCondition = descriptionCondition;
            beneficier.Pourcentage = pourcentage;
            beneficierBLO[index] = beneficier;

            new OperationBLO().AjouterOperation(TypeOperation.Modification, employe, beneficier.CompteClient.Client, beneficier.CompteClient, 
                pourcentage, $"Modification du beneficier {beneficier} du compte {beneficier.CompteClient}, qui beneficiera d'un pourcentage de {pourcentage}%");
        }

        public void SupprimerBeneficier(Beneficier beneficier, Employe employe)
        {

            beneficierBLO.Remove(beneficier);

            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employe, beneficier.CompteClient.Client, beneficier.CompteClient, 
                beneficier.Pourcentage, $"Suppression du beneficier {beneficier} du compte {beneficier.CompteClient}, qui beneficiait d'un pourcentage " +
                $"de {beneficier.Pourcentage}%");
        }

        public IEnumerable<Beneficier> RechercherLesBeneficiersDuCompte(CompteClient compteClient) => beneficierBLO.Find(x =>
            x.CompteClient.ToString() == compteClient.ToString());

        public IEnumerable<Beneficier> RechercherLesBeneficiers(string valeur, bool checkIdentifiant, bool checkNom,
            bool checkDescriptionCondition, bool checkPourcentage, bool checkCompte) => beneficierBLO.Find(x => 
            (x.Id.ToString().ToLower().Contains(valeur.ToLower()) && checkIdentifiant) ||
            (x.Nom.ToString().ToLower().Contains(valeur.ToLower()) && checkNom) ||
            (x.DescriptionCondition.ToString().ToLower().Contains(valeur.ToLower()) && checkDescriptionCondition) ||
            (x.Pourcentage.ToString().ToLower().Contains(valeur.ToLower()) && checkPourcentage) ||
            (x.CompteClient.ToString().ToLower().Contains(valeur.ToLower()) && checkCompte));

        public IEnumerable<Beneficier> TousBeneficiers => beneficierBLO.AllItems;

    }
}
