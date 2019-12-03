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

        public ClientBLO()
        {
            clientBLO = new RepositoireDAOFile<Client>();
        }

        public void AjouterClient(string codeClient, string nomComplet, DateTime dateNaissance, string lieuNaissance, string sexe, string numeroCNI, 
            string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, 
            string profession,  string codeCompte, TypeCompte typeCompte, TypeAppartenantCompteEpargne? typeAppartenantCompteEpargne, 
            string nomStructure)
        {
            compteClientBLO = new CompteClientBLO();

            Client client = new Client(codeClient, nomComplet, dateNaissance, lieuNaissance, sexe, numeroCNI, numeroTelephone1,
                                                            numeroTelephone2, pays, ville, adresse, photoProfil, DateTime.Now, profession, StatutClient.Desactivé);

            clientBLO.Add(client);

            compteClientBLO.AjouterCompteClient(codeCompte, client, typeCompte, typeAppartenantCompteEpargne, nomStructure);
        }

        public void EditerClient(Client client, string nomComplet, DateTime dateNaissance, string lieuNaissance, string sexe, 
            string numeroCNI, string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse,
            string photoProfil, string profession, StatutClient statutClient)
        {
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
            client.StatutClient = statutClient;

            clientBLO[clientBLO.IndexOf(oldClient)] = client;
        }

        public void SupprimerClient(Client Client)
        {
            clientBLO.Remove(Client);
        }

        public IEnumerable<Client> RechercherDesClients(string valeur) => clientBLO.Find(x => x.NomComplet.ToLower().Contains(valeur.ToLower()) || 
                x.CodeClient.ToLower().Contains(valeur.ToLower()) || x.NumeroCNI.ToLower().Contains(valeur.ToLower()));

        public Client RechercherCNIExist(string numeroCNI) => clientBLO.Find(x => x.NumeroCNI.ToLower() == numeroCNI.ToLower()).FirstOrDefault();

        public List<Client> TousClients => clientBLO.AllItems;

    }
}
