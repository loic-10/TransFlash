using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO
{
    [Serializable]
    public class CompteClient
    {
        public string CodeCompte { get; set; }
        public Client Client { get; set; }
        public TypeCompte TypeCompte { get; set; }
        public TypeAppartenantCompteEpargne? TypeAppartenantCompteEpargne { get; set; }
        public string NomStructure { get; set; }
        public double Solde { get; set; }
        public StatutCompte StatutCompte { get; set; }
        public DateTime DateEnregistrement { get; set; }

        public CompteClient()
        {
        }

        public CompteClient(string codeCompte)
        {
            CodeCompte = codeCompte;
        }

        public CompteClient(string codeCompte, Client client, TypeCompte typeCompte,
            TypeAppartenantCompteEpargne? typeAppartenantCompteEpargne, string nomStructure, double solde, 
            StatutCompte statutCompte, DateTime dateEnregistrement) : this(codeCompte)
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
