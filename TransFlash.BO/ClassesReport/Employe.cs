using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO.ClassesReport
{
    [Serializable]
    public class Employe : Personne
    {
        public string CodeEmploye { get; set; }
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public string StatutEmploye { get; set; }

        public Employe()
        {
        }

        public Employe(string codeEmploye)
        {
            CodeEmploye = codeEmploye;
        }

        public Employe(string nomUtilisateur, string motDePasse)
        {
            NomUtilisateur = nomUtilisateur;
            MotDePasse = motDePasse;
        }

        public Employe(string codeEmploye, string nomComplet, DateTime? dateNaissance, string lieuNaissance, string sexe, 
            string numeroCNI, string numeroTelephone1, string numeroTelephone2, string pays, string ville, string adresse, 
            string photoProfil, DateTime? dateEnregistrement, string nomUtilisateur, string motDePasse, string statutEmploye) 
                : base(nomComplet, dateNaissance, lieuNaissance, sexe, numeroCNI, numeroTelephone1, numeroTelephone2, pays, ville, 
                      adresse, photoProfil, dateEnregistrement)
        {
            CodeEmploye = codeEmploye;
            NomUtilisateur = nomUtilisateur;
            MotDePasse = motDePasse;
            StatutEmploye = statutEmploye;
        }

        public override bool Equals(object obj)
        {
            return obj is Employe employe &&
                   base.Equals(obj) &&
                   CodeEmploye == employe.CodeEmploye;
        }

        public override int GetHashCode()
        {
            return CodeEmploye.GetHashCode();
        }

        public override string ToString()
        {
            return CodeEmploye;
        }
    }
}
