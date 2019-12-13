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
    public class VilleBLO
    {
        private IDAL<Ville> villeBLO = null;
        private OperationBLO operationBLO = null;

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
            operationBLO = new OperationBLO();
            villeBLO.Add(new Ville(nom, nomPays));

            if(employe.CodeEmploye != string.Empty)
                operationBLO.AjouterOperation(TypeOperation.Ajout, employe, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
        }

        public void ModifierVille(Ville ville, string nom, Pays pays, Employe employe)
        {
            operationBLO = new OperationBLO();
            Ville oldVille = ville;
            ville.Nom = nom;
            ville.Pays = pays;
            villeBLO[villeBLO.IndexOf(oldVille)] = ville;

            operationBLO.AjouterOperation(TypeOperation.Modification, employe, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
        }

        public void SupprimerVille(Ville ville, Employe employe)
        {
            operationBLO = new OperationBLO();
            villeBLO.Remove(ville);

            operationBLO.AjouterOperation(TypeOperation.Suppression, employe, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
        }

        public IEnumerable<Ville> RechercherLesVillesDuPays(Pays pays) => villeBLO.Find(x => 
                x.Pays.ToString() == pays.ToString());

        public Ville RechercherUneVille(string nom) => villeBLO.Find(x => 
                x.Nom == nom).FirstOrDefault();

        public IEnumerable<Ville> RechercherLesVilles(string valeur) => villeBLO.Find(x => 
                x.Nom.ToLower().Contains(valeur.ToLower()) || 
                x.Pays.ToString().ToLower().Contains(valeur.ToLower()));

        public List<Ville> ToutesVilles => villeBLO.AllItems;

    }
}
