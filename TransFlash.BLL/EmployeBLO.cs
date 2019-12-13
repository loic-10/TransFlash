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
                AjouterEmploye(StatutEmploye.Chef_Agence.ToString(), null, string.Empty, null, "000000000", string.Empty, string.Empty, new Pays("Indefini"), 
                    new Ville("Indefini"), string.Empty, string.Empty, string.Empty, "1234", StatutEmploye.Chef_Agence, new Employe("Indefini"));

                // Creation du compte chef de credit
                AjouterEmploye(StatutEmploye.Chef_Credit.ToString(), null, string.Empty, null, "000000000", string.Empty, string.Empty, new Pays("Indefini"), 
                    new Ville("Indefini"), string.Empty, string.Empty, string.Empty, "1234", StatutEmploye.Chef_Credit, new Employe("Indefini"));

                // Creation du compte comptable
                AjouterEmploye(StatutEmploye.Comptable.ToString(), null, string.Empty, null, "000000000", string.Empty, string.Empty, new Pays("Indefini"), 
                    new Ville("Indefini"), string.Empty, string.Empty, string.Empty, "1234", StatutEmploye.Comptable, new Employe("Indefini"));

                // Creation du compte secretaire comptable
                AjouterEmploye(StatutEmploye.Secretaire_Comptable.ToString(), null, string.Empty, null, "000000000", string.Empty, string.Empty, new Pays("Indefini"), 
                    new Ville("Indefini"), string.Empty, string.Empty, string.Empty, "1234", StatutEmploye.Secretaire_Comptable, new Employe("Indefini"));

                // Creation du compte caissier
                AjouterEmploye(StatutEmploye.Caissier.ToString(), null, string.Empty, null, "000000000", string.Empty, string.Empty, new Pays("Indefini"), 
                    new Ville("Indefini"), string.Empty, string.Empty, string.Empty, "1234", StatutEmploye.Caissier, new Employe("Indefini"));
            }
        }

        public Employe SeConnecter(string nomUtilisateur, string motDePasse) => employeBLO.Find(x => 
            x.NomUtilisateur.ToLower() == nomUtilisateur.ToLower() &&
            x.MotDePasse.ToLower() == crypterMD5.GetMd5Hash(MD5.Create(), motDePasse.ToLower()).ToLower()).FirstOrDefault();

        public void AjouterEmploye(string nomComplet, DateTime? dateNaissance, string lieuNaissance, StatutSexe? sexe, string numeroCNI, 
            string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, 
            string nomUtilisateur, string motDePasse, StatutEmploye statutEmploye, Employe employe)
        {
            operationBLO = new OperationBLO();
            employeBLO.Add(new Employe(CodeEmploye(statutEmploye), nomComplet, dateNaissance, lieuNaissance, sexe, numeroCNI, numeroTelephone1,
            numeroTelephone2, pays, ville, adresse, photoProfil, DateTime.Now, nomUtilisateur, crypterMD5.GetMd5Hash(MD5.Create(), motDePasse.ToLower()), statutEmploye));

            operationBLO.AjouterOperation(TypeOperation.Embauche, employe, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
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

        public void ModifierEmploye(Employe employeModifie, string nomComplet, DateTime? dateNaissance, string lieuNaissance, StatutSexe? sexe, 
            string numeroCNI, string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, 
            string nomUtilisateur, string motDePasse, Employe employeModifieur)
        {
            operationBLO = new OperationBLO();

            Employe oldEmploye = employeModifie;
            employeModifie.NomComplet = nomComplet;
            employeModifie.DateNaissance = dateNaissance;
            employeModifie.LieuNaissance = lieuNaissance;
            employeModifie.Sexe = sexe;
            employeModifie.NumeroCNI = numeroCNI;
            employeModifie.NumeroTelephone1 = numeroTelephone1;
            employeModifie.NumeroTelephone2 = numeroTelephone2;
            employeModifie.Pays = pays;
            employeModifie.Ville = ville;
            employeModifie.Adresse = adresse;
            employeModifie.PhotoProfil = photoProfil;
            employeModifie.NomUtilisateur = nomUtilisateur;
            employeModifie.MotDePasse = motDePasse;
            if (photoProfil != oldEmploye.PhotoProfil)
            {
                fichierStockeBLO.AjouterFichierStocke($"Photo de l'employe {oldEmploye.CodeEmploye}", photoProfil, new Client("Indefini"), new Garantie(0),
                    StatutStockage.Image_des_employés, employeModifieur);
            }
            employeBLO[employeBLO.IndexOf(oldEmploye)] = employeModifie;

            operationBLO.AjouterOperation(TypeOperation.Embauche, employeModifieur, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
        }

        public void SupprimerEmploye(Employe employeSupprime, Employe employeSupprimeur)
        {
            operationBLO = new OperationBLO();

            employeBLO.Remove(employeSupprime);

            operationBLO.AjouterOperation(TypeOperation.Embauche, employeSupprimeur, new Client("Indefini"), new CompteClient("Indefini"), 0, "toto tata");
        }

        public bool VerifieSuppression(Employe employe, StatutEmploye statutEmploye) => (RechercherDesEmployesMemeStatut(employe, statutEmploye).Count() > 1);

        public IEnumerable<Employe> RechercherDesEmployesMemeStatut(Employe employe, StatutEmploye statutEmploye) => employeBLO.Find(x => 
            x == employe && 
            x.StatutEmploye == statutEmploye);

        public IEnumerable<Employe> RechercherDesEmployes(string valeur) => employeBLO.Find(x => 
            x.NomComplet.ToLower().Contains(valeur.ToLower()) ||
            x.CodeEmploye.ToLower().Contains(valeur.ToLower()) || 
            x.NumeroCNI.ToLower() .Contains(valeur.ToLower()));

        public Employe RechercherCNIExist(string numeroCNI) => employeBLO.Find(x => 
            x.NumeroCNI.ToLower() == numeroCNI.ToLower()).FirstOrDefault();

        public IEnumerable<Employe> TousEmployes => employeBLO.AllItems;

    }
}
