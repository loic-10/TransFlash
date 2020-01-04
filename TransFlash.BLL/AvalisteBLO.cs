
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransFlash.BO;
using TransFlash.DAL;
using static TransFlash.BO.Statut;

namespace TransFlash.BLL
{
    public class AvalisteBLO
    {
        private IDAL<Avaliste> avalisteBLO = null;

        public AvalisteBLO()
        {
            avalisteBLO = new RepositoireDAOFile<Avaliste>();
        }

        public void AjouterAvaliste(Garantie garantie, string nomComplet, string profession, string description, double montantParMois, Employe employe)
        {

            avalisteBLO.Add(new Avaliste(new IdentifiantBLO().IdAvaliste, garantie, nomComplet, profession, description, montantParMois));
            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, garantie.Credit.Client, new CompteClient("/"), montantParMois, 
                $"Ajout de l'avaliste {new IdentifiantBLO().IdAvaliste}");

            new IdentifiantBLO().AddIdAvaliste();
        }

        public void SupprimerAvaliste(Avaliste avaliste, Employe employe)
        {

            avalisteBLO.Remove(avaliste);

            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employe, avaliste.Garantie.Credit.Client, new CompteClient("/"), 
                avaliste.MontantParMois, $"Suppression de l'avaliste {avaliste}");
        }

        public Avaliste RechercherAvalistesGarantie(Garantie garantie) => avalisteBLO.Find(x =>
            x.Garantie == garantie).FirstOrDefault();

        public IEnumerable<Avaliste> RechercherLesAvalistes(string valeur, bool checkIdentifiant, bool checkGarantie, bool
                checkMontantParMois, bool checkNomComplet, bool checkProfession, bool checkDescription) => avalisteBLO.Find(x => 
            (x.Id.ToString().ToLower().Contains(valeur.ToLower()) && checkIdentifiant)||
            (x.Garantie.ToString().ToLower().Contains(valeur.ToLower()) && checkGarantie) ||
            (x.MontantParMois.ToString().ToLower().Contains(valeur.ToLower()) && checkMontantParMois)  ||
            (x.NomComplet.ToString().Contains(valeur) && checkNomComplet) ||
            (x.Description.ToLower().Contains(valeur.ToLower()) && checkDescription)  ||
            (x.Profession.ToString().Contains(valeur) && checkProfession));

        public List<Avaliste> TousAvalistes => avalisteBLO.AllItems;

    }
}
