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

        public static StatutEmploye RetourStatutEmploye(string statutEmploye)
        {
            string[] valeurs = Enum.GetNames(typeof(StatutEmploye));

            if (valeurs[0] == statutEmploye)
                return StatutEmploye.Chef_Agence;
            else if (valeurs[1] == statutEmploye)
                return StatutEmploye.Chef_Credit;
            else if (valeurs[2] == statutEmploye)
                return StatutEmploye.Secretaire_Comptable;
            else if (valeurs[3] == statutEmploye)
                return StatutEmploye.Caissier;

            return StatutEmploye.Comptable;
        }

        public enum StatutConnexion
        {
            Connecté,
            Deconnecté
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
            Programmé,
            Annulé,
            Ouverture_du_dossier
        }

        public enum StatutRemboursement
        {
            En_attente_de_validité,
            Annulé,
            Validé,
            Planifié
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

        public static TypeCompte RetourTypeCompte(string typeCompte)
        {
            string[] valeurs = Enum.GetNames(typeof(TypeCompte));

            if (valeurs[0] == typeCompte)
                return TypeCompte.Epargne;
            else if (valeurs[1] == typeCompte)
                return TypeCompte.Courant;

            return new TypeCompte();
        }

        public enum TypeCredit
        {
            Credit_normal,
            Decouvert
        }

        public static TypeCredit RetourTypeCredit(string typeCredit)
        {
            string[] valeurs = Enum.GetNames(typeof(TypeCredit));

            if (valeurs[0] == typeCredit)
                return TypeCredit.Credit_normal;
            else if (valeurs[1] == typeCredit)
                return TypeCredit.Decouvert;

            return new TypeCredit();
        }

        public enum TypeAppartenantCompteEpargne
        {
            Entreprise,
            Particulier
        }

        public static TypeAppartenantCompteEpargne? RetourTypeAppartenantCompteEpargne(string typeAppartenantCompteEpargne)
        {
            string[] valeurs = Enum.GetNames(typeof(TypeAppartenantCompteEpargne));

            if (valeurs[0] == typeAppartenantCompteEpargne)
                return TypeAppartenantCompteEpargne.Entreprise;
            else if (valeurs[1] == typeAppartenantCompteEpargne)
                return TypeAppartenantCompteEpargne.Particulier;

            return null;
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
            En_service,
            Renvoyé
        }

        public enum StatutPayementSalarie
        {
            Payé,
            Jour_de_paie,
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
            Document_de_la_microfinance,
            Image_des_clients,
            Image_des_employés
        }

        public static StatutStockage? RetourStatutStockage(string statutStockage)
        {
            string[] valeurs = Enum.GetNames(typeof(StatutStockage));

            if (valeurs[0] == statutStockage)
                return StatutStockage.Garantie;
            else if (valeurs[1] == statutStockage)
                return StatutStockage.Demande_de_stage;
            else if (valeurs[2] == statutStockage)
                return StatutStockage.Document_de_la_microfinance;
            else if (valeurs[3] == statutStockage)
                return StatutStockage.Image_des_clients;
            else if (valeurs[4] == statutStockage)
                return StatutStockage.Image_des_employés;

            return null;
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
            Sortie,
            Avis_de_retrait,
            Annulation, 
            Embauche,
            Retour_de_garantie,
            Reduction_du_montant_de_la_part_sociale,
            Validation, 
            Virement,
            Activation,
            Désactivation,
            Payement

        }

        public enum StatutSexe
        {
            Masculin,
            Féminin
        };

        public enum StatutPossibilite
        {
            Possible,
            Impossible,
            Risqué
        };

        public static StatutSexe? RetourSexe(string sexe)
        {
            string[] valeurs = Enum.GetNames(typeof(StatutSexe));

            if (valeurs[0] == sexe)
                return StatutSexe.Masculin;
            else if (valeurs[1] == sexe)
                return StatutSexe.Féminin;

            return null;
        }

    }
}
