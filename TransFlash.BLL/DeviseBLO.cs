
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
    public class DeviseBLO
    {
        private IDAL<Devise> deviseBLO = null;

        private OperationBLO operationBLO = null;

        public DeviseBLO()
        {
            deviseBLO = new RepositoireDAOFile<Devise>();
        }

        public void AjouterDevise(string nomDevise, string symboleDevise, Employe employe)
        {
            operationBLO = new OperationBLO();

            deviseBLO.Add(new Devise(nomDevise, symboleDevise));

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");

        }

        public void SupprimerDevise(Devise devise, Employe employe)
        {
            operationBLO = new OperationBLO();
            deviseBLO.Remove(devise);

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
        }

        public IEnumerable<Devise> RechercherLesDevises(string valeur) => deviseBLO.Find(x => 
            x.NomDevise.ToLower().Contains(valeur.ToLower()) ||
            x.SymboleDevise.ToLower().Contains(valeur.ToLower()));

        public List<Devise> TousDevises => deviseBLO.AllItems;

    }
}
