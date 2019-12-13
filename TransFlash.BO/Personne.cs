using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO
{
    [Serializable]
    public class Personne
    {
        public string NomComplet { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public StatutSexe? Sexe { get; set; }
        public string NumeroCNI { get; set; }
        public string NumeroTelephone1 { get; set; }
        public string NumeroTelephone2 { get; set; }
        public Pays Pays { get; set; }
        public Ville Ville { get; set; }
        public string Adresse { get; set; }
        public string PhotoProfil { get; set; }
        public DateTime? DateEnregistrement { get; set; }

        public Personne()
        {
        }

        public Personne(string numeroCNI)
        {
            NumeroCNI = numeroCNI;
        }

        public Personne(string nomComplet, DateTime? dateNaissance, string lieuNaissance, StatutSexe? sexe, string numeroCNI, 
            string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, 
            DateTime? dateEnregistrement) : this(nomComplet)
        {
            DateNaissance = dateNaissance;
            LieuNaissance = lieuNaissance;
            Sexe = sexe;
            NumeroCNI = numeroCNI;
            NumeroTelephone1 = numeroTelephone1;
            NumeroTelephone2 = numeroTelephone2;
            Pays = pays;
            Ville = ville;
            Adresse = adresse;
            PhotoProfil = photoProfil;
            DateEnregistrement = dateEnregistrement;
        }

        public override bool Equals(object obj)
        {
            return obj is Personne personne &&
                   NumeroCNI == personne.NumeroCNI;
        }

        public override int GetHashCode()
        {
            return NumeroCNI.GetHashCode();
        }

        public override string ToString()
        {
            return NomComplet;
        }
    }
}
