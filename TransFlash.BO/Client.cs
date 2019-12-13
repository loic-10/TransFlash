using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO
{
    [Serializable]
    public class Client : Personne
    {
        public string CodeClient { get; set; }
        public string Profession { get; set; }
        public StatutClient StatutClient { get; set; }

        public Client()
        {
        }

        public Client(string codeClient)
        {
            CodeClient = codeClient;
        }

        public Client(string codeClient, string nomComplet, DateTime? dateNaissance, string lieuNaissance, StatutSexe? sexe, string numeroCNI, 
            string numeroTelephone1, string numeroTelephone2, Pays pays, Ville ville, string adresse, string photoProfil, 
            DateTime? dateEnregistrement, string profession, StatutClient statutClient) 
                : base(nomComplet, dateNaissance, lieuNaissance, sexe, numeroCNI, numeroTelephone1, 
                      numeroTelephone2, pays, ville, adresse, photoProfil, dateEnregistrement)
        {
            CodeClient = codeClient;
            Profession = profession;
            StatutClient = statutClient;
        }

        public override bool Equals(object obj)
        {
            return obj is Client Client &&
                   base.Equals(obj) &&
                   CodeClient == Client.CodeClient;
        }

        public override int GetHashCode()
        {
            return CodeClient.GetHashCode();
        }

        public override string ToString()
        {
            return CodeClient;
        }
    }
}
