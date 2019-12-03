using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransFlash.BO
{
    public class Statut
    {

        public enum StatutEmploye
        {
            Chef_Agence,
            Chef_Credit,
            Secretaire_Comptable,
            Caissier,
            Comptable
        }

        public enum StatutCompte
        {
            En_attente_de_validité,
            Activé,
            Bloqué
        }

        public enum StatutClient
        {
            Desactivé,
            Activé
        }

        public enum StatutCredit
        {
            En_attente_de_validité,
            Remboursé,
            Non_remboursé,
            Annulé
        }

        public enum StatutRemboursement
        {
            En_attente_de_validité,
            Annulé,
            Validé
        }

        public enum StatutPayementRemboursement
        {
            A_temps,
            En_retard
        }

        public enum StatutTransaction
        {
            En_cours_de_validité,
            Annulé,
            Validé,
            Avisé
        }

        public enum TypeTransaction
        {
            Dépot,
            Retrait,
            Transfert_inter_compte
        }

        public enum TypeCompte
        {
            Epargne,
            Courant
        }

        public enum TypeCredit
        {
            A_court_terme,
            A_moyen_terme,
            A_long_terme
            }

        public enum TypeAppartenantCompteEpargne
        {
            Entreprise,
            Particulier
        }

        public enum StatutNumeroComptable
        {
            Débit,
            Crédit
        }

        public enum StatutGarantie
        {
            En_gage,
            Retourné
        }

        public enum StatutPartSociale
        {
            Complete,
            Incomplete
        }

        public enum StatutSalarie
        {
            Endetté,
            En_règle,
            Renvoyé
        }

        public enum StatutPayementSalarie
        {
            Payé,
            Non_payé
        }

        public enum StatutEpargne
        {
            Terminé,
            En_cours
        }

        public enum StatutStockage
        {
            Garantie,
            Demande_de_stage,
            Document_de_la_microfinance
        }

        public enum TypeActionFond
        {
            Entrée,
            Sortie
        }

        public enum TypeOperation
        {
            Dépot,
            Retrait,
            Transfert_inter_compte,
            Credit,
            Remboursement,
            Enregistrement,
            Ajout,
            Edition,
            Modification,
            Suppression,
            Entrée,
            Sortie
        }

        public static List<string> StatutSexe = new List<string>()
        {
            "Maxculin",
            "Féminin"
        };

    }
}
