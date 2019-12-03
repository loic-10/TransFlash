using Multicouche.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransFlash.BO;

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
                AjouterPays("Cameroun", "+237");
            }
        }

        public void AjouterPays(string nom, string codePhone)
        {
            paysBLO.Add(new Pays(nom, codePhone));
        }

        public void ModifierPays(Pays pays, string nom, string codePhone)
        {
            Pays oldPays = pays;
            pays.Nom = nom;
            pays.CodePhone = codePhone;
            paysBLO[paysBLO.IndexOf(oldPays)] = pays;
        }

        public void SupprimerPays(Pays pays)
        {
            paysBLO.Remove(pays);
        }

        public List<Pays> TousPays => paysBLO.AllItems;

    }
}
