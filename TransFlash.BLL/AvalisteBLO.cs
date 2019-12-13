
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
    public class AvalisteBLO
    {
        private IDAL<Avaliste> avalisteBLO = null;

        private OperationBLO operationBLO = null;

        public AvalisteBLO()
        {
            avalisteBLO = new RepositoireDAOFile<Avaliste>();
        }

        public void AjouterAvaliste(Garantie garantie, string nomComplet, string profession, string description, double montantParMois, Employe employe)
        {
            operationBLO = new OperationBLO();
            avalisteBLO.Add(new Avaliste(new IdentifiantBLO().IdAvaliste, garantie, nomComplet, profession, description, montantParMois));
            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, garantie.Credit.Client, new CompteClient("Indefini"), montantParMois, "toto tata");

            new IdentifiantBLO().AddIdAvaliste();
        }

        public void SupprimerAvaliste(Avaliste avaliste, Employe employe)
        {
            operationBLO = new OperationBLO();
            avalisteBLO.Remove(avaliste);

            operationBLO.AjouterOperation(TypeOperation.Suppression, employe, avaliste.Garantie.Credit.Client, new CompteClient("Indefini"), avaliste.MontantParMois, "toto tata");
        }

        public Avaliste RechercherAvalistesGarantie(Garantie garantie) => avalisteBLO.Find(x =>
            x.Garantie == garantie).FirstOrDefault();

        public IEnumerable<Avaliste> RechercherLesAvalistes(string valeur) => avalisteBLO.Find(x => 
            x.NomComplet.ToLower().Contains(valeur.ToLower()) ||
            x.Profession.ToLower().Contains(valeur.ToLower()) ||
            x.Description.ToLower().Contains(valeur.ToLower()) ||
            x.MontantParMois.ToString().Contains(valeur));

        public List<Avaliste> TousAvalistes => avalisteBLO.AllItems;

    }
}
