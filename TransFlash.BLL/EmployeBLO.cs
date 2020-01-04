using TransFlash.DAL;
using TransFlash.DAL.Cryptographie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

                // Creation du compte chef d'agence
                AjouterEmploye(StatutEmploye.Chef_Agence.ToString(), null, string.Empty, null, "000000000", " ", " ", new Pays("/"), 
                    new Ville("/"), string.Empty, string.Empty, "1234", StatutEmploye.Chef_Agence, new Employe("/"));

                // Creation du compte chef de credit
                AjouterEmploye(StatutEmploye.Chef_Credit.ToString(), null, string.Empty, null, "000000000", " ", " ", new Pays("/"), 
                    new Ville("/"), string.Empty, string.Empty, "1234", StatutEmploye.Chef_Credit, new Employe("/"));

                // Creation du compte comptable
                AjouterEmploye(StatutEmploye.Comptable.ToString(), null, string.Empty, null, "000000000", " ", " ", new Pays("/"), 
                    new Ville("/"), string.Empty, string.Empty,"1234", StatutEmploye.Comptable, new Employe("/"));

                // Creation du compte secretaire comptable
                AjouterEmploye(StatutEmploye.Secretaire_Comptable.ToString(), null, string.Empty, null, "000000000", " ", " ", new Pays("/"), 
                    new Ville("/"), string.Empty, string.Empty,"1234", StatutEmploye.Secretaire_Comptable, new Employe("/"));

                // Creation du compte caissier
                AjouterEmploye(StatutEmploye.Caissier.ToString(), null, string.Empty, null, "000000000", " ", " ", new Pays("/"), 
                    new Ville("/"), string.Empty, string.Empty,"1234", StatutEmploye.Caissier, new Employe("/"));
            }
        }

        public Employe SeConnecter(string nomUtilisateur, string motDePasse) => employeBLO.Find(x => 
            (x.NomUtilisateur.ToLower() == nomUtilisateur.ToLower() || x.CodeEmploye.ToLower() == nomUtilisateur.ToLower()) &&
            x.MotDePasse.ToLower() == new CrypterMD5().GetMd5Hash(MD5.Create(), motDePasse.ToLower()).ToLower()).FirstOrDefault();

        public void AjouterEmploye(string nomComplet, DateTime? dateNaissance, string lieuNaissance, StatutSexe? sexe, string numeroCNI, 
            string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, string motDePasse, 
            StatutEmploye statutEmploye, Employe employe)
        {

            employeBLO.Add(new Employe(CodeEmploye(statutEmploye), nomComplet, dateNaissance, lieuNaissance, sexe, numeroCNI, numeroTelephone1,
            numeroTelephone2, pays, ville, adresse, photoProfil, DateTime.Now, NomUtilisateur(nomComplet, CodeEmploye(statutEmploye)), new CrypterMD5().GetMd5Hash(MD5.Create(), motDePasse.ToLower()), statutEmploye));

            new OperationBLO().AjouterOperation(TypeOperation.Embauche, employe, new Client("/"), new CompteClient("/"), 0, 
                $"Ajout de l'employe {CodeEmploye(statutEmploye)} ayant pour mdp :  {motDePasse}");
            if (photoProfil != string.Empty)
            {
                new FichierStockeBLO().AjouterFichierStocke($"Photo de l'employe {CodeEmploye(statutEmploye)}", photoProfil, new Client("/"),
                    new Garantie(0), StatutStockage.Image_des_employés, employe);
            }

            new IdentifiantBLO().AddIdEmploye();
        }

        public string CodeEmploye(StatutEmploye statutEmploye) =>
            ((statutEmploye == StatutEmploye.Caissier) ? "cai-" : (statutEmploye == StatutEmploye.Chef_Agence) ? "cag-" :
            (statutEmploye == StatutEmploye.Chef_Credit) ? "ccr-" : (statutEmploye == StatutEmploye.Comptable) ? "com-" : "sec-" ) +
            new IdentifiantBLO().IdEmploye.ToString().PadLeft(5, '0');

        public string NomUtilisateur(string nomComplet, string codeEmploye) =>
            ((nomComplet.Split(' ').Count() > 0) ? nomComplet.Split(' ')[0] : nomComplet) + "-" + 
            ((codeEmploye.Split('-').Count() > 0 && codeEmploye != string.Empty) ? codeEmploye.Split('-')[1] : string.Empty);

        public void ModifierEmploye(Employe employeModifie, string nomComplet, DateTime? dateNaissance, string lieuNaissance, StatutSexe? sexe, 
            string numeroCNI, string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, Employe employeModifieur)
        {

            int index = employeBLO.IndexOf(employeModifie);

            string aMDP = employeModifie.MotDePasse;

            string fileName = employeModifie.PhotoProfil;

            employeModifie.NomComplet = nomComplet;
            employeModifie.DateNaissance = dateNaissance;
            employeModifie.LieuNaissance = lieuNaissance;
            employeModifie.Sexe = sexe;
            employeModifie.NumeroCNI = numeroCNI;
            employeModifie.NumeroTelephone1 = numeroTelephone1;
            employeModifie.NumeroTelephone2 = numeroTelephone2;
            employeModifie.Pays = pays;
            employeModifie.Ville = ville;
            employeModifie.NomUtilisateur = NomUtilisateur(nomComplet, employeModifie.CodeEmploye);
            employeModifie.Adresse = adresse;
            employeModifie.PhotoProfil = photoProfil;
            if (photoProfil != fileName)
            {
                new FichierStockeBLO().AjouterFichierStocke($"Photo de l'employe {employeModifie.CodeEmploye}", photoProfil, new Client("/"), new Garantie(0),
                    StatutStockage.Image_des_employés, employeModifieur);
            }
            employeBLO[index] = employeModifie;

            new OperationBLO().AjouterOperation(TypeOperation.Modification, employeModifieur, new Client("/"), new CompteClient("/"), 0,
                $"Modification de l'employe {employeModifie}");
        }

        public void ModifierEmploye(Employe employeModifie, string motDePasse, StatutEmploye statutEmploye, Employe employeModifieur)
        {

            int index = employeBLO.IndexOf(employeModifie);

            employeModifie.MotDePasse = new CrypterMD5().GetMd5Hash(MD5.Create(), motDePasse.ToLower());

            employeModifie.StatutEmploye = statutEmploye;

            employeModifie.CodeEmploye = CodeEmploye(statutEmploye).Split('-')[0] + "-" + employeModifie.CodeEmploye.Split('-')[1];

            employeBLO[index] = employeModifie;

            new OperationBLO().AjouterOperation(TypeOperation.Modification, employeModifieur, new Client("/"), new CompteClient("/"), 0,
                 $"Modification du compte de l'employe {employeModifie} ayant pour mdp : " + motDePasse);
        }

        public void SupprimerEmploye(Employe employeSupprime, Employe employeSupprimeur)
        {

            employeBLO.Remove(employeSupprime);

            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employeSupprimeur, new Client("/"), new CompteClient("/"), 0, 
                $"Suppression de l'employe {employeSupprime}");
        }

        public IEnumerable<Employe> RechercherDesEmployesMemeStatut(StatutEmploye statutEmploye) => employeBLO.Find(x => 
           x.StatutEmploye == statutEmploye);

        public IEnumerable<Employe> RechercherDesEmployes(string valeur, bool checkCode, bool checkDateEnregistrement, bool checkDateNaissance,
            bool checkLieuNaissance, bool checkNomComplet, bool checkNomUtilisateur, bool checkNumeroCNI, bool checkNumeroTelephone,
            bool checkPays, bool checkSexe, bool checkStatutEmploye, bool checkVille) => employeBLO.Find(x =>
            (x.StatutEmploye != StatutEmploye.Chef_Agence) &&
            ((x.CodeEmploye.ToLower().Contains(valeur.ToLower()) && checkCode) ||
            (x.DateNaissance.ToString().ToLower().Contains(valeur.ToLower()) && checkDateNaissance) ||
            (x.LieuNaissance.ToLower().Contains(valeur.ToLower()) && checkLieuNaissance) || 
            ((x.NomComplet.ToLower().Contains(valeur.ToLower()) && x.NomComplet != null) && checkNomComplet) ||
            (x.NumeroCNI.ToLower().Contains(valeur.ToLower()) && checkNumeroCNI) ||
            (x.NumeroTelephone1.ToLower().Contains(valeur.ToLower()) && checkNumeroTelephone) || 
            (x.Pays.ToString().ToLower().Contains(valeur.ToLower()) && checkPays) ||
            (x.Sexe.ToString().ToLower().Contains(valeur.ToLower()) && checkSexe) ||
            (x.DateEnregistrement.ToString().ToLower().Contains(valeur.ToLower()) && checkDateEnregistrement) ||
            (x.NomUtilisateur.ToString().ToLower().Contains(valeur.ToLower()) && checkNomUtilisateur) || 
            (x.StatutEmploye.ToString().ToLower() .Contains(valeur.ToLower()) && checkStatutEmploye) || 
            (x.Ville.ToString().ToLower().Contains(valeur.ToLower()) && checkVille)));

        public Employe RechercherCNIExist(string numeroCNI, Employe employe) => employeBLO.Find(x => 
            x.NumeroCNI.ToLower() == numeroCNI.ToLower() && x.CodeEmploye != employe.CodeEmploye).FirstOrDefault();

        public IEnumerable<Employe> TousEmployes => employeBLO.Find(x =>
            x.StatutEmploye != StatutEmploye.Chef_Agence);

        public Employe ChefAgence => employeBLO.Find(x =>
            x.StatutEmploye == StatutEmploye.Chef_Agence).FirstOrDefault();

    }
}
