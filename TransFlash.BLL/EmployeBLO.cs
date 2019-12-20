using Multicouche.DAL;
using Multicouche.DAL.Cryptographie;
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

        private OperationBLO operationBLO = null;

        private CrypterMD5 crypterMD5 = new CrypterMD5();

        private FichierStockeBLO fichierStockeBLO = null;

        public EmployeBLO()
        {
            employeBLO = new RepositoireDAOFile<Employe>();
            fichierStockeBLO = new FichierStockeBLO();
            if(employeBLO.Count == 0)
            {

                // Creation du compte chef d'agence
                AjouterEmploye(StatutEmploye.Chef_Agence.ToString(), null, string.Empty, null, "000000000", " ", " ", new Pays("Indefini"), 
                    new Ville("Indefini"), string.Empty, string.Empty, "1234", StatutEmploye.Chef_Agence, new Employe("Indefini"));

                // Creation du compte chef de credit
                AjouterEmploye(StatutEmploye.Chef_Credit.ToString(), null, string.Empty, null, "000000000", " ", " ", new Pays("Indefini"), 
                    new Ville("Indefini"), string.Empty, string.Empty, "1234", StatutEmploye.Chef_Credit, new Employe("Indefini"));

                // Creation du compte comptable
                AjouterEmploye(StatutEmploye.Comptable.ToString(), null, string.Empty, null, "000000000", " ", " ", new Pays("Indefini"), 
                    new Ville("Indefini"), string.Empty, string.Empty,"1234", StatutEmploye.Comptable, new Employe("Indefini"));

                // Creation du compte secretaire comptable
                AjouterEmploye(StatutEmploye.Secretaire_Comptable.ToString(), null, string.Empty, null, "000000000", " ", " ", new Pays("Indefini"), 
                    new Ville("Indefini"), string.Empty, string.Empty,"1234", StatutEmploye.Secretaire_Comptable, new Employe("Indefini"));

                // Creation du compte caissier
                AjouterEmploye(StatutEmploye.Caissier.ToString(), null, string.Empty, null, "000000000", " ", " ", new Pays("Indefini"), 
                    new Ville("Indefini"), string.Empty, string.Empty,"1234", StatutEmploye.Caissier, new Employe("Indefini"));
            }
        }

        public Employe SeConnecter(string nomUtilisateur, string motDePasse) => employeBLO.Find(x => 
            (x.NomUtilisateur.ToLower() == nomUtilisateur.ToLower() || x.CodeEmploye.ToLower() == nomUtilisateur.ToLower()) &&
            x.MotDePasse.ToLower() == crypterMD5.GetMd5Hash(MD5.Create(), motDePasse.ToLower()).ToLower()).FirstOrDefault();

        public void AjouterEmploye(string nomComplet, DateTime? dateNaissance, string lieuNaissance, StatutSexe? sexe, string numeroCNI, 
            string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, string motDePasse, 
            StatutEmploye statutEmploye, Employe employe)
        {
            operationBLO = new OperationBLO();
            employeBLO.Add(new Employe(CodeEmploye(statutEmploye), nomComplet, dateNaissance, lieuNaissance, sexe, numeroCNI, numeroTelephone1,
            numeroTelephone2, pays, ville, adresse, photoProfil, DateTime.Now, NomUtilisateur(nomComplet, CodeEmploye(statutEmploye)), crypterMD5.GetMd5Hash(MD5.Create(), motDePasse.ToLower()), statutEmploye));

            operationBLO.AjouterOperation(TypeOperation.Embauche, employe, new Client("Indefini"), new CompteClient("Indefini"), 0, "mdp : " + motDePasse);
            if (photoProfil != string.Empty)
            {
                fichierStockeBLO.AjouterFichierStocke($"Photo de l'employe {CodeEmploye(statutEmploye)}", photoProfil, new Client("Indefini"),
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
            operationBLO = new OperationBLO();

            int index = employeBLO.IndexOf(employeModifie);

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
                fichierStockeBLO.AjouterFichierStocke($"Photo de l'employe {employeModifie.CodeEmploye}", photoProfil, new Client("Indefini"), new Garantie(0),
                    StatutStockage.Image_des_employés, employeModifieur);
            }
            employeBLO[index] = employeModifie;

            operationBLO.AjouterOperation(TypeOperation.Modification, employeModifieur, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
        }

        public void ModifierEmploye(Employe employeModifie, string motDePasse, StatutEmploye statutEmploye, Employe employeModifieur)
        {
            operationBLO = new OperationBLO();

            int index = employeBLO.IndexOf(employeModifie);

            employeModifie.MotDePasse = crypterMD5.GetMd5Hash(MD5.Create(), motDePasse.ToLower());

            employeModifie.StatutEmploye = statutEmploye;

            employeModifie.CodeEmploye = CodeEmploye(statutEmploye).Split('-')[0] + "-" + employeModifie.CodeEmploye.Split('-')[1];

            employeBLO[index] = employeModifie;

            operationBLO.AjouterOperation(TypeOperation.Modification, employeModifieur, new Client("Indefini"), new CompteClient("Indefini"), 0,
                 "mdp : " + motDePasse);
        }

        public void SupprimerEmploye(Employe employeSupprime, Employe employeSupprimeur)
        {
            operationBLO = new OperationBLO();

            employeBLO.Remove(employeSupprime);

            operationBLO.AjouterOperation(TypeOperation.Embauche, employeSupprimeur, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
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
