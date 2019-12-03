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
    public class EmployeBLO
    {
        private IDAL<Employe> employeBLO = null;

        public EmployeBLO()
        {
            employeBLO = new RepositoireDAOFile<Employe>();
            if(employeBLO.Count == 0)
            {
            }
        }

        public Employe SeConnecter(string nomUtilisateur, string motDePasse)
        {
            var employe = employeBLO.Find(x => x.NomUtilisateur.ToLower() == nomUtilisateur.ToLower() &&
                                                                    x.MotDePasse.ToLower() == motDePasse);

            return employe.FirstOrDefault();
        }

        public void AjouterEmploye(string codeEmploye, string nomComplet, DateTime dateNaissance, string lieuNaissance, string sexe, string numeroCNI, 
            string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, 
            string nomUtilisateur, string motDePasse, StatutEmploye statutEmploye)
        {
            employeBLO.Add(new Employe(codeEmploye, nomComplet, dateNaissance, lieuNaissance, sexe, numeroCNI, numeroTelephone1,
            numeroTelephone2, pays, ville, adresse, photoProfil, DateTime.Now, nomUtilisateur, motDePasse, statutEmploye));
        }

        public void ModifierEmploye(Employe Employe, string nomComplet, DateTime dateNaissance, string lieuNaissance, string sexe, 
            string numeroCNI, string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, 
            string nomUtilisateur, string motDePasse, StatutEmploye statutEmploye)
        {
            Employe oldEmploye = Employe;
            Employe.NomComplet = nomComplet;
            Employe.DateNaissance = dateNaissance;
            Employe.LieuNaissance = lieuNaissance;
            Employe.Sexe = sexe;
            Employe.NumeroCNI = numeroCNI;
            Employe.NumeroTelephone1 = numeroTelephone1;
            Employe.NumeroTelephone2 = numeroTelephone2;
            Employe.Pays = pays;
            Employe.Ville = ville;
            Employe.Adresse = adresse;
            Employe.PhotoProfil = photoProfil;
            Employe.NomUtilisateur = nomUtilisateur;
            Employe.MotDePasse = motDePasse;
            Employe.StatutEmploye = statutEmploye;
            employeBLO[employeBLO.IndexOf(oldEmploye)] = Employe;
        }

        public void SupprimerEmploye(Employe Employe)
        {
            employeBLO.Remove(Employe);
        }

        public bool VerifieSuppression(Employe employe, StatutEmploye statutEmploye)
        {
            var reqEmploye = from _employe in TousEmployes 
                             where (_employe.StatutEmploye == statutEmploye && _employe == employe) 
                             select _employe;
            if (reqEmploye.Count() > 1)
                return true;

            return false;
        }

        public IEnumerable<Employe> RechercherDesEmployes(string valeur) => employeBLO.Find(x => x.NomComplet.ToLower().Contains(valeur.ToLower()) ||
                x.CodeEmploye.ToLower().Contains(valeur.ToLower()) || x.NumeroCNI.ToLower() .Contains(valeur.ToLower()));

        public Employe RechercherCNIExist(string numeroCNI) => employeBLO.Find(x => x.NumeroCNI.ToLower() == numeroCNI.ToLower()).FirstOrDefault();

        public List<Employe> TousEmployes => employeBLO.AllItems;

    }
}
