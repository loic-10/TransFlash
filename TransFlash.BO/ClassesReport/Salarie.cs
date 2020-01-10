using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO.ClassesReport
{
    [Serializable]
    public class Salarie
    {
        public int Id { get; set; }
        public string CompteClientEmploye { get; set; }
        public string CompteClientEntreprise { get; set; }
        public double MontantSalaire { get; set; }
        public DateTime DateEmbauche { get; set; }
        public DateTime DateEnregistrement { get; set; }
        public string StatutSalarie { get; set; }
        public DateTime? DatePayementMoisEnCours { get; set; }
        public DateTime? DatePayementProchainMois { get; set; }
        public int NombreJourPourPayement { get; set; }
        

        public Salarie()
        {
        }

        public Salarie(int id)
        {
            Id = id;
        }

        public Salarie(int id, string compteClientEmploye, string compteClientEntreprise, double montantSalaire,
            DateTime dateEmbauche, DateTime dateEnregistrement, string statutSalarie, DateTime? datePayementMoisEnCours,
            DateTime? datePayementProchainMois, int nombreJourPourPayement) : this(id)
        {
            CompteClientEmploye = compteClientEmploye;
            CompteClientEntreprise = compteClientEntreprise;
            MontantSalaire = montantSalaire;
            DateEmbauche = dateEmbauche;
            DateEnregistrement = dateEnregistrement;
            StatutSalarie = statutSalarie;
            DatePayementMoisEnCours = datePayementMoisEnCours;
            DatePayementProchainMois = datePayementProchainMois;
            NombreJourPourPayement = nombreJourPourPayement;
        }

        public override bool Equals(object obj)
        {
            return obj is Salarie salarie &&
                   Id == salarie.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
