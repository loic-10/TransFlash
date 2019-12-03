using Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransFlash.BO;

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
                AjouterVille("Douala", new Pays("Cameroun"));
                AjouterVille("Yaoundé", new Pays("Cameroun"));
                AjouterVille("Bafoussam", new Pays("Cameroun"));
                AjouterVille("Dschang", new Pays("Cameroun"));
                AjouterVille("Bertoua", new Pays("Cameroun"));
            }
        }

        public void AjouterVille(string nom, Pays nomPays)
        {
            villeBLO.Add(new Ville(nom, nomPays));
        }

        public void ModifierVille(Ville ville, string nom, Pays pays)
        {
            Ville oldVille = ville;
            ville.Nom = nom;
            ville.Pays = pays;
            villeBLO[villeBLO.IndexOf(oldVille)] = ville;
        }

        public void SupprimerVille(Ville ville)
        {
            villeBLO.Remove(ville);
        }

        public IEnumerable<Ville> RechercherLesVillesDuPays(Pays pays) =>
            villeBLO.Find(x => x.Pays == pays);

        public IEnumerable<Ville> RechercherLesVilles(string valeur) => 
            villeBLO.Find(x => x.Nom.ToLower().Contains(valeur.ToLower()) || x.Pays.ToString().ToLower().Contains(valeur.ToLower()));

        public List<Ville> ToutesVilles => villeBLO.AllItems;

    }
}
