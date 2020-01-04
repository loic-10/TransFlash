using TransFlash.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransFlash.BO;
using static TransFlash.BO.Statut;

namespace TransFlash.BLL
{
    public class ClientBLO
    {
        private IDAL<Client> clientBLO = null;

        public ClientBLO()
        {
            clientBLO = new RepositoireDAOFile<Client>();
        }

        public void AjouterClient(string nomComplet, DateTime? dateNaissance, string lieuNaissance, StatutSexe? sexe, string numeroCNI, 
            string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, 
            string profession, TypeCompte typeCompte, TypeAppartenantCompteEpargne? typeAppartenantCompteEpargne, 
            string nomStructure, Employe employe, int nombreMois, double montant)
        {

            Client client = new Client(CodeClient, nomComplet, dateNaissance, lieuNaissance, sexe, numeroCNI, numeroTelephone1,
                                                            numeroTelephone2, pays, ville, adresse, photoProfil, DateTime.Now, profession, StatutClient.Activé);

            clientBLO.Add(client);

            new CompteClientBLO().AjouterCompteClient(client, typeCompte, typeAppartenantCompteEpargne, nomStructure, nombreMois, montant, employe);

            new OperationBLO().AjouterOperation(TypeOperation.Ajout, employe, client, new CompteClient("/"), 0, $"Ajout du client {nomComplet}");

            if (photoProfil != string.Empty)
                new FichierStockeBLO().AjouterFichierStocke($"Photo du client {CodeClient}", photoProfil, client, new Garantie(0), StatutStockage.Image_des_clients, employe);

            new IdentifiantBLO().AddIdClient();
        }

        public void EditerClient(Client client, string nomComplet, DateTime dateNaissance, string lieuNaissance, StatutSexe? sexe, string numeroCNI, 
            string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, string profession, Employe employe)
        {

            int index = clientBLO.IndexOf(client);

            string fileName = client.PhotoProfil;

            client.NomComplet = nomComplet;
            client.DateNaissance = dateNaissance;
            client.LieuNaissance = lieuNaissance;
            client.Sexe = sexe;
            client.NumeroCNI = numeroCNI;
            client.NumeroTelephone1 = numeroTelephone1;
            client.NumeroTelephone2 = numeroTelephone2;
            client.Pays = pays;
            client.Ville = ville;
            client.Adresse = adresse;
            client.PhotoProfil = photoProfil;
            client.Profession = profession;

            if (photoProfil != fileName)
                new FichierStockeBLO().AjouterFichierStocke($"Photo du client {client.CodeClient}", photoProfil, client, new Garantie(0), StatutStockage.Image_des_clients, employe);

            clientBLO[index] = client;

            new OperationBLO().AjouterOperation(TypeOperation.Modification, employe, client, new CompteClient("/"), 0, 
                $"Modification du client {nomComplet}");
        }

        public string CodeClient => "cli-" + new IdentifiantBLO().IdClient.ToString().PadLeft(8, '0');

        public void SupprimerClient(Client client, Employe employe)
        {

            clientBLO.Remove(client);

            new OperationBLO().AjouterOperation(TypeOperation.Suppression, employe, client, new CompteClient("/"), 0, 
                $"Suppression du client {client.NomComplet}");
        }

        public void ActiverClient(Client client, Employe employe)
        {

            Client oldClient = client;
            client.StatutClient = StatutClient.Activé;
            clientBLO[clientBLO.IndexOf(oldClient)] = client;

            new OperationBLO().AjouterOperation(TypeOperation.Activation, employe, client, new CompteClient("/"), 0, 
                $"Activation du client {client.NomComplet}");
        }

        public void DesactiverClient(Client client, Employe employe)
        {

            Client oldClient = client;
            client.StatutClient = StatutClient.Desactivé;
            clientBLO[clientBLO.IndexOf(oldClient)] = client;

            new OperationBLO().AjouterOperation(TypeOperation.Désactivation, employe, client, new CompteClient("/"), 0,
                $"Desactivation du client {client.NomComplet}");
        }

        public IEnumerable<Client> RechercherDesClients(string valeur, bool checkCode, bool checkDateEnregistrement, bool checkDateNaissance,
            bool checkLieuNaissance, bool checkNomComplet, bool checkProfession, bool checkNumeroCNI, bool checkNumeroTelephone,
            bool checkPays, bool checkSexe, bool checkStatutClient, bool checkVille) => clientBLO.Find(x =>
            (x.CodeClient.ToLower().Contains(valeur.ToLower()) && checkCode) ||
            (x.DateNaissance.ToString().ToLower().Contains(valeur.ToLower()) && checkDateNaissance) ||
            (x.LieuNaissance.ToLower().Contains(valeur.ToLower()) && checkLieuNaissance) ||
            ((x.NomComplet.ToLower().Contains(valeur.ToLower()) && x.NomComplet != null) && checkNomComplet) ||
            (x.NumeroCNI.ToLower().Contains(valeur.ToLower()) && checkNumeroCNI) ||
            (x.NumeroTelephone1.ToLower().Contains(valeur.ToLower()) && checkNumeroTelephone) ||
            (x.Pays.ToString().ToLower().Contains(valeur.ToLower()) && checkPays) ||
            (x.Sexe.ToString().ToLower().Contains(valeur.ToLower()) && checkSexe) ||
            (x.DateEnregistrement.ToString().ToLower().Contains(valeur.ToLower()) && checkDateEnregistrement) ||
            (x.Profession.ToString().ToLower().Contains(valeur.ToLower()) && checkProfession) ||
            (x.StatutClient.ToString().ToLower().Contains(valeur.ToLower()) && checkStatutClient) ||
            (x.Ville.ToString().ToLower().Contains(valeur.ToLower()) && checkVille));

        public Client RechercherCNIExist(string numeroCNI, Client client) => clientBLO.Find(x => 
            x.NumeroCNI.ToLower() == numeroCNI.ToLower() && x.CodeClient != client.CodeClient).FirstOrDefault();

        public Client RechercherUnClient(string valeur) => clientBLO.Find(x => 
            x.StatutClient == StatutClient.Activé &&
            (x.NumeroCNI.ToLower() == valeur.ToLower() ||
            x.CodeClient.ToLower() == valeur.ToLower())).FirstOrDefault();

        public List<Client> TousClients => clientBLO.AllItems;

    }
}
