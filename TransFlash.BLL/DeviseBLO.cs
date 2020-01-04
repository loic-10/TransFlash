
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
    public class DeviseBLO
    {
        private IDAL<Devise> deviseBLO = null;

        public DeviseBLO()
        {
            deviseBLO = new RepositoireDAOFile<Devise>();
        }

        public void AjouterDevise(string nomDevise, string symboleDevise, Employe employe)
        {

            deviseBLO.Add(new Devise(nomDevise, symboleDevise));

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, new Client("/"), new CompteClient("/"), 0, 
                $"Ajout de la devise {nomDevise}, ayant pour symbole {symboleDevise}");

        }

        public void SupprimerDevise(Devise devise, Employe employe)
        {

            deviseBLO.Remove(devise);

            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employe, new Client("/"), new CompteClient("/"), 0,
                $"Suppression de la devise {devise.NomDevise}, ayant pour symbole {devise.SymboleDevise}");
        }

        public IEnumerable<Devise> RechercherLesDevises(string valeur) => deviseBLO.Find(x => 
            x.NomDevise.ToLower().Contains(valeur.ToLower()) ||
            x.SymboleDevise.ToLower().Contains(valeur.ToLower()));

        public IEnumerable<Devise> TousDevises => deviseBLO.AllItems;

    }
}
