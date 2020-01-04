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
    public class VilleBLO
    {
        private IDAL<Ville> villeBLO = null;

        public VilleBLO()
        {
            villeBLO = new RepositoireDAOFile<Ville>();
            if(villeBLO.Count == 0)
            {
                AjouterVille("Douala", new Pays("Cameroun"), new Employe(string.Empty));
                AjouterVille("Yaoundé", new Pays("Cameroun"), new Employe(string.Empty));
                AjouterVille("Bafoussam", new Pays("Cameroun"), new Employe(string.Empty));
                AjouterVille("Dschang", new Pays("Cameroun"), new Employe(string.Empty));
                AjouterVille("Bertoua", new Pays("Cameroun"), new Employe(string.Empty));
            }
        }

        public void AjouterVille(string nom, Pays nomPays, Employe employe)
        {
            villeBLO.Add(new Ville(nom, nomPays));

            if(employe.CodeEmploye != string.Empty)
                new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, new Client("/"), new CompteClient("/"), 0,
                    $"Ajout de la ville de {nom} au {nomPays}");
        }

        public void ModifierVille(Ville ville, string nom, Pays pays, Employe employe)
        {

            int index = villeBLO.IndexOf(ville);
            ville.Nom = nom;
            ville.Pays = pays;
            villeBLO[index] = ville;

            new OperationBLO().AjouterOperation(TypeOperation.Modification, employe, new Client("/"), new CompteClient("/"), 0,
                $"Modification de la ville de {nom} au {pays}");
        }

        public void SupprimerVille(Ville ville, Employe employe)
        {
            villeBLO.Remove(ville);

            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employe, new Client("/"), new CompteClient("/"), 0,
                $"Suppression de la ville de {ville.Nom} au {ville.Pays}");
        }

        public IEnumerable<Ville> RechercherLesVillesDuPays(Pays pays) => villeBLO.Find(x => 
                x.Pays.ToString() == pays.ToString());

        public Ville RechercherUneVille(string nom) => villeBLO.Find(x => 
                x.Nom == nom).FirstOrDefault();

        public IEnumerable<Ville> RechercherLesVilles(string valeur, bool checkNom, bool checkPays) => villeBLO.Find(x => 
                (x.Nom.ToLower().Contains(valeur.ToLower()) && checkNom) || 
                (x.Pays.ToString().ToLower().Contains(valeur.ToLower()) && checkPays));

        public IEnumerable<Ville> ToutesVilles => villeBLO.AllItems;

    }
}
