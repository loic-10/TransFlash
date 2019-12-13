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
    public class ClientBLO
    {
        private IDAL<Client> clientBLO = null;

        private CompteClientBLO compteClientBLO = null;

        private OperationBLO operationBLO = null;

        private FichierStockeBLO fichierStockeBLO = null;

        public ClientBLO()
        {
            clientBLO = new RepositoireDAOFile<Client>();
        }

        public void AjouterClient(string nomComplet, DateTime? dateNaissance, string lieuNaissance, StatutSexe? sexe, string numeroCNI, 
            string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, 
            string profession, TypeCompte typeCompte, TypeAppartenantCompteEpargne? typeAppartenantCompteEpargne, 
            string nomStructure, Employe employe, int nombreMois, double montant)
        {
            operationBLO = new OperationBLO();

            fichierStockeBLO = new FichierStockeBLO();

            compteClientBLO = new CompteClientBLO();

            Client client = new Client(CodeClient, nomComplet, dateNaissance, lieuNaissance, sexe, numeroCNI, numeroTelephone1,
                                                            numeroTelephone2, pays, ville, adresse, photoProfil, DateTime.Now, profession, StatutClient.Desactivé);

            clientBLO.Add(client);

            compteClientBLO.AjouterCompteClient(client, typeCompte, typeAppartenantCompteEpargne, nomStructure, nombreMois, montant, employe);

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, client, 
                compteClientBLO.RechercherUnCompte(compteClientBLO.CodeCompteClient(typeCompte, typeAppartenantCompteEpargne)), 0, "toto tata");

            if (photoProfil != string.Empty)
                fichierStockeBLO.AjouterFichierStocke($"Photo du client {CodeClient}", photoProfil, client, new Garantie(0), StatutStockage.Image_des_clients, employe);

            new IdentifiantBLO().AddIdClient();
        }

        public void EditerClient(Client client, string nomComplet, DateTime dateNaissance, string lieuNaissance, StatutSexe sexe, string numeroCNI, 
            string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, string profession, Employe employe)
        {
            operationBLO = new OperationBLO();
            fichierStockeBLO = new FichierStockeBLO();
            Client oldClient = client;
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
            if (photoProfil != oldClient.PhotoProfil)
                fichierStockeBLO.AjouterFichierStocke($"Photo du client {client.CodeClient}", photoProfil, client, new Garantie(0), StatutStockage.Image_des_clients, employe);

            clientBLO[clientBLO.IndexOf(oldClient)] = client;

            operationBLO.AjouterOperation(TypeOperation.Ajout, employe, client, new CompteClient("Indefini"), 0, "toto tata");
        }

        public string CodeClient => "cli-" + new IdentifiantBLO().IdClient.ToString().PadLeft(8, '0');

        public void SupprimerClient(Client client, Employe employe)
        {
            operationBLO = new OperationBLO();
            clientBLO.Remove(client);

            operationBLO.AjouterOperation(TypeOperation.Suppression, employe, client, new CompteClient("Indefini"), 0, "toto tata");
        }

        public void ActiverClient(Client client, Employe employe)
        {
            operationBLO = new OperationBLO();

            Client oldClient = client;
            client.StatutClient = StatutClient.Activé;
            clientBLO[clientBLO.IndexOf(oldClient)] = client;

            operationBLO.AjouterOperation(TypeOperation.Activation, employe, client, new CompteClient("Indefini"), 0, "toto tata");
        }

        public void DesactiverClient(Client client, Employe employe)
        {
            operationBLO = new OperationBLO();

            Client oldClient = client;
            client.StatutClient = StatutClient.Desactivé;
            clientBLO[clientBLO.IndexOf(oldClient)] = client;

            operationBLO.AjouterOperation(TypeOperation.Désactivation, employe, client, new CompteClient("Indefini"), 0, "toto tata");
        }

        public IEnumerable<Client> RechercherDesClients(string valeur) => clientBLO.Find(x => 
            x.NomComplet.ToLower().Contains(valeur.ToLower()) || 
            x.CodeClient.ToLower().Contains(valeur.ToLower()) || 
            x.NumeroCNI.ToLower().Contains(valeur.ToLower()));

        public Client RechercherCNIExist(string numeroCNI) => clientBLO.Find(x => 
            x.NumeroCNI.ToLower() == numeroCNI.ToLower()).FirstOrDefault();

        public List<Client> TousClients => clientBLO.AllItems;

    }
}
