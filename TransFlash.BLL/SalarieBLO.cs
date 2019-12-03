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
    public class SalarieBLO
    {
        private IDAL<Salarie> salarieBLO = null;

        private CompteClientBLO compteClientBLO = null;

        public SalarieBLO()
        {
            salarieBLO = new RepositoireDAOFile<Salarie>();
        }

        public void AjouterSalarie(int id, CompteClient compteClientEmploye, CompteClient compteClientEntreprise, double montantSalaire, 
            int jourDePaye)
        {
            salarieBLO.Add(new Salarie(id, compteClientEmploye, compteClientEntreprise, montantSalaire,DateTime.Now,
                                                    StatutSalarie.En_règle,  StatutPayementSalarie.Non_payé, jourDePaye));
        }

        public void ModifierSalarie(Salarie Salarie, double montantSalaire, StatutSalarie statutSalarie, StatutPayementSalarie statutPayementSalarie,
            int jourDePaye)
        {
            Salarie oldSalarie = Salarie;
            Salarie.MontantSalaire = montantSalaire;
            Salarie.StatutSalarie = statutSalarie;
            Salarie.StatutPayementSalarie = statutPayementSalarie;
            Salarie.JourDePaye = jourDePaye;
            salarieBLO[salarieBLO.IndexOf(oldSalarie)] = Salarie;
        }

        public void SupprimerSalarie(Salarie Salarie)
        {
            salarieBLO.Remove(Salarie);
        }

        public void PayerSalaire(Salarie salarie, double montant)
        {
            compteClientBLO = new CompteClientBLO();

        }

        public IEnumerable<Salarie> RechercherSalariesCompte(CompteClient compte) => salarieBLO.Find(x => x.CompteClientEntreprise == compte);

        public IEnumerable<Salarie> RechercherLesSalaries(string valeur) => salarieBLO.Find(x =>
                x.CompteClientEntreprise.ToString().ToLower().Contains(valeur.ToLower()) ||
                x.CompteClientEmploye.ToString().ToLower().Contains(valeur.ToLower()) ||
                x.StatutPayementSalarie.ToString().ToLower().Contains(valeur.ToLower()) ||
                x.DateEnregistrement.ToString().ToLower().Contains(valeur.ToLower()) ||
                x.StatutSalarie.ToString().ToLower().Contains(valeur.ToLower()));

        public List<Salarie> TousSalaries => salarieBLO.AllItems;

    }
}
