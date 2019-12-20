using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO
{
    [Serializable]
    public class Salarie
    {
        public int Id { get; set; }
        public CompteClient CompteClientEmploye { get; set; }
        public CompteClient CompteClientEntreprise { get; set; }
        public double MontantSalaire { get; set; }
        public DateTime DateEmbauche { get; set; }
        public DateTime DateEnregistrement { get; set; }
        public StatutSalarie StatutSalarie { get; set; }
        public StatutPayementSalarie StatutPayementSalarie { get; set; }
        public int JourDePaye { get; set; }
        

        public Salarie()
        {
        }

        public Salarie(int id)
        {
            Id = id;
        }

        public Salarie(int id, CompteClient compteClientEmploye, CompteClient compteClientEntreprise, double montantSalaire, 
            DateTime dateEmbauche, DateTime dateEnregistrement, StatutSalarie statutSalarie, StatutPayementSalarie statutPayementSalarie, 
            int jourDePaye) : this(id)
        {
            CompteClientEmploye = compteClientEmploye;
            CompteClientEntreprise = compteClientEntreprise;
            MontantSalaire = montantSalaire;
            DateEmbauche = dateEmbauche;
            DateEnregistrement = dateEnregistrement;
            StatutSalarie = statutSalarie;
            StatutPayementSalarie = statutPayementSalarie;
            JourDePaye = jourDePaye;
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
