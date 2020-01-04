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
    public class PaysBLO
    {
        private IDAL<Pays> paysBLO = null;

        public PaysBLO()
        {
            paysBLO = new RepositoireDAOFile<Pays>();
            if(paysBLO.Count == 0)
            {
                AjouterPays("Cameroun", 237, new Employe(string.Empty));
            }
        }

        public void AjouterPays(string nom, int codePhone, Employe employe)
        {
            paysBLO.Add(new Pays(nom, $"+{codePhone}"));

            if (employe.CodeEmploye != string.Empty)
                new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, new Client("/"), new CompteClient("/"), 0, 
                    $"Ajout du pays {nom} ayant comme code de telephone {codePhone}");
        }

        public void ModifierPays(Pays pays, string nom, int codePhone, Employe employe)
        {
            int index = paysBLO.IndexOf(pays);

            new OperationBLO().AjouterOperation(TypeOperation.Modification, employe, new Client("/"), new CompteClient("/"), 0,
                $"Modification du pays {pays.Nom + (nom != pays.Nom ? $" change par {nom}" : string.Empty )} ayant comme code de telephone " +
                $"{pays.CodePhone + (pays.CodePhone != $"+{codePhone}" ? $" change par +{codePhone}" : string.Empty)}");

            pays.Nom = nom;
            pays.CodePhone = $"+{codePhone}";
            paysBLO[index] = pays;
        }

        public void SupprimerPays(Pays pays, Employe employe)
        {

            paysBLO.Remove(pays);

            foreach (var ville in new VilleBLO().RechercherLesVillesDuPays(pays))
            {
                new VilleBLO().SupprimerVille(ville, employe);
            }

            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employe, new Client("/"), new CompteClient("/"), 0,
                $"Suppression du pays {pays.Nom} ayant comme code de telephone {pays.CodePhone}");
        }

        public IEnumerable<Pays> RechercherPays(string valeur, bool checkNom, bool checkCodeTelephone) => paysBLO.Find(x => 
                (x.CodePhone.ToLower().Contains(valeur.ToLower()) && checkCodeTelephone) || 
                (x.Nom.ToLower().Contains(valeur.ToLower()) && checkNom));

        public Pays RechercherUnPays(string valeur) => paysBLO.Find(x => 
                x.Nom.ToLower() == valeur.ToLower()).FirstOrDefault();

        public IEnumerable<Pays> TousPays => paysBLO.AllItems;

    }
}
