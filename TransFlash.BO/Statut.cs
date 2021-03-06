﻿using System;
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
            A_court_terme,
            A_moyen_terme,
            A_long_terme
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
            Document_de_la_microfinance,
            Image_des_clients,
            Image_des_employés
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
            Désactivation

        }

        public enum StatutSexe
        {
            Masculin,
            Féminin
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
