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
    public class PaysBLO
    {
        private IDAL<Pays> paysBLO = null;
        private OperationBLO operationBLO = null;

        public PaysBLO()
        {
            paysBLO = new RepositoireDAOFile<Pays>();
            if(paysBLO.Count == 0)
            {
                AjouterPays("Cameroun", "+237", new Employe(string.Empty));
            }
        }

        public void AjouterPays(string nom, string codePhone, Employe employe)
        {
            operationBLO = new OperationBLO();
            paysBLO.Add(new Pays(nom, codePhone));

            if (employe.CodeEmploye != string.Empty)
                operationBLO.AjouterOperation(TypeOperation.Ajout, employe, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
        }

        public void ModifierPays(Pays pays, string nom, string codePhone, Employe employe)
        {
            operationBLO = new OperationBLO();
            Pays oldPays = pays;
            pays.Nom = nom;
            pays.CodePhone = codePhone;
            paysBLO[paysBLO.IndexOf(oldPays)] = pays;

            operationBLO.AjouterOperation(TypeOperation.Modification, employe, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
        }

        public void SupprimerPays(Pays pays, Employe employe)
        {
            operationBLO = new OperationBLO();
            paysBLO.Remove(pays); 

            operationBLO.AjouterOperation(TypeOperation.Suppression, employe, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
        }

        public IEnumerable<Pays> RechercherPays(string valeur) => paysBLO.Find(x => 
                x.CodePhone.ToLower().Contains(valeur.ToLower()) || 
                x.Nom.ToLower().Contains(valeur.ToLower()));

        public Pays RechercherUnPays(string valeur) => paysBLO.Find(x => 
                x.Nom.ToLower() == valeur.ToLower()).FirstOrDefault();

        public IEnumerable<Pays> TousPays => paysBLO.AllItems;

    }
}
