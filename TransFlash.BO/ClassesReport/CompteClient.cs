using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO.ClassesReport
{
    [Serializable]
    public class CompteClient
    {
        public string CodeCompte { get; set; }
        public string Client { get; set; }
        public string TypeCompte { get; set; }
        public string TypeAppartenantCompteEpargne { get; set; }
        public string NomStructure { get; set; }
        public double Solde { get; set; }
        public string StatutCompte { get; set; }
        public DateTime DateEnregistrement { get; set; }

        public CompteClient()
        {
        }

        public CompteClient(string codeCompte)
        {
            CodeCompte = codeCompte;
        }

        public CompteClient(string codeCompte, string client, string typeCompte,
            string typeAppartenantCompteEpargne, string nomStructure, double solde, 
            string statutCompte, DateTime dateEnregistrement) : this(codeCompte)
        {
            Client = client;
            TypeCompte = typeCompte;
            TypeAppartenantCompteEpargne = typeAppartenantCompteEpargne;
            NomStructure = nomStructure;
            Solde = solde;
            StatutCompte = statutCompte;
            DateEnregistrement = dateEnregistrement;
        }

        public override bool Equals(object obj)
        {
            return obj is CompteClient client &&
                   CodeCompte == client.CodeCompte;
        }

        public override int GetHashCode()
        {
            return CodeCompte.GetHashCode();
        }

        public override string ToString()
        {
            return CodeCompte;
        }
    }
}
