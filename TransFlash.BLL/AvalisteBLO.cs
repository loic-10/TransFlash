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
    public class AvalisteBLO
    {
        private IDAL<Avaliste> avalisteBLO = null;

        public AvalisteBLO()
        {
            avalisteBLO = new RepositoireDAOFile<Avaliste>();
        }

        public void AjouterAvaliste(int id, Garantie garantie, string nomComplet, string profession, string description, double montantParMois)
        {
            avalisteBLO.Add(new Avaliste(id, garantie, nomComplet, profession, description, montantParMois));
        }

        public void ModifierAvaliste(Avaliste avaliste, string nomComplet, string profession, string description, double montantParMois)
        {
            Avaliste oldAvaliste = avaliste;
            avaliste.NomComplet = nomComplet;
            avaliste.Profession = profession;
            avaliste.Description = description;
            avaliste.MontantParMois = montantParMois;
            avalisteBLO[avalisteBLO.IndexOf(oldAvaliste)] = avaliste;
        }

        public void SupprimerAvaliste(Avaliste avaliste)
        {
            avalisteBLO.Remove(avaliste);
        }

        public Avaliste RechercherAvalistesCompte(Garantie garantie)
        {
            var reqAvalistes = from avaliste in TousAvalistes
                                 where (avaliste.Garantie == garantie)
                                 select avaliste;
            return reqAvalistes.FirstOrDefault();
        }

        public List<Avaliste> RechercherLesAvalistes(string valeur)
        {
            var reqAvalistes = avalisteBLO.Find(x => x.NomComplet.ToLower().Contains(valeur.ToLower()) ||
                                                                                x.Profession.ToLower().Contains(valeur.ToLower()) ||
                                                                                x.Description.ToLower().Contains(valeur.ToLower()) ||
                                                                                x.MontantParMois.ToString().Contains(valeur));
            return reqAvalistes as List<Avaliste>;
        }

        public List<Avaliste> TousAvalistes => avalisteBLO.AllItems;

    }
}
