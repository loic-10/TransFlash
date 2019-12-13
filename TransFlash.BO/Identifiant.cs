using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransFlash.BO
{ 
    [Serializable]
    public class Identifiant
    {
        public int IdAvaliste { get; set; }
        public int IdBeneficier { get; set; }
        public int IdClient { get; set; }
        public int IdCompteClient { get; set; }
        public int IdCredit { get; set; }
        public int IdEmploye { get; set; }
        public int IdEpargne { get; set; }
        public int IdFichierStocke { get; set; }
        public int IdFond { get; set; }
        public int IdGarantie { get; set; }
        public int IdOperation { get; set; }
        public int IdRemboursement { get; set; }
        public int IdSalarie { get; set; }
        public int IdTransaction { get; set; }

        public Identifiant(int idAvaliste, int idBeneficier, int idClient, int idCompteClient, int idCredit, int idEmploye, int idEpargne, int idFichierStocke, 
            int idFond, int idGarantie, int idOperation, int idRemboursement, int idSalarie, int idTransaction)
        {
            IdAvaliste = idAvaliste;
            IdBeneficier = idBeneficier;
            IdClient = idClient;
            IdCompteClient = idCompteClient;
            IdCredit = idCredit;
            IdEmploye = idEmploye;
            IdEpargne = idEpargne;
            IdFichierStocke = idFichierStocke;
            IdFond = idFond;
            IdGarantie = idGarantie;
            IdOperation = idOperation;
            IdRemboursement = idRemboursement;
            IdSalarie = idSalarie;
            IdTransaction = idTransaction;
        }
    }
}
