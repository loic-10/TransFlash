using TransFlash.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransFlash.BO;

namespace TransFlash.BLL
{
    public class IdentifiantBLO
    {
        private IDAL<Identifiant> identifiantBLO = null;

        public IdentifiantBLO()
        {
            identifiantBLO = new RepositoireDAOFile<Identifiant>();
            if(identifiantBLO.Count == 0)
            {
                identifiantBLO.Add(new Identifiant(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1));
            }
        }

        public int IdAvaliste => TousIdentifiants[0].IdAvaliste;

        public void AddIdAvaliste()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdAvaliste++;
            identifiantBLO[0] = Identifiant;
        }

        public int IdBeneficier => TousIdentifiants[0].IdBeneficier;

        public void AddIdBeneficier()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdBeneficier++;
            identifiantBLO[0] = Identifiant;
        }

        public int IdClient => TousIdentifiants[0].IdClient;

        public void AddIdClient()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdClient++;
            identifiantBLO[0] = Identifiant;
        }

        public int IdCompteClient => TousIdentifiants[0].IdCompteClient;

        public void AddIdCompteClient()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdCompteClient++;
            identifiantBLO[0] = Identifiant;
        }

        public int IdCredit => TousIdentifiants[0].IdCredit;

        public void AddIdCredit()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdCredit++;
            identifiantBLO[0] = Identifiant;
        }

        public int IdEmploye => TousIdentifiants[0].IdEmploye;

        public void AddIdEmploye()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdEmploye++;
            identifiantBLO[0] = Identifiant;
        }

        public int IdEpargne => TousIdentifiants[0].IdEpargne;

        public void AddIdEpargne()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdEpargne++;
            identifiantBLO[0] = Identifiant;
        }

        public int IdFichierStocke => TousIdentifiants[0].IdFichierStocke;

        public void AddIdFichierStocke()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdFichierStocke++;
            identifiantBLO[0] = Identifiant;
        }

        public int IdFond => TousIdentifiants[0].IdFond;

        public void AddIdFond()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdFond++;
            identifiantBLO[0] = Identifiant;
        }

        public int IdGarantie => TousIdentifiants[0].IdGarantie;

        public void AddIdGarantie()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdGarantie++;
            identifiantBLO[0] = Identifiant;
        }

        public int IdOperation => TousIdentifiants[0].IdOperation;

        public void AddIdOperation()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdOperation++;
            identifiantBLO[0] = Identifiant;
        }

        public int IdRemboursement => TousIdentifiants[0].IdRemboursement;

        public void AddIdRemboursement()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdRemboursement++;
            identifiantBLO[0] = Identifiant;
        }

        public int IdSalarie => TousIdentifiants[0].IdSalarie;

        public void AddIdSalarie()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdSalarie++;
            identifiantBLO[0] = Identifiant;
        }

        public int IdTransaction => TousIdentifiants[0].IdTransaction;

        public void AddIdTransaction()
        {
            Identifiant Identifiant = TousIdentifiants[0];
            Identifiant.IdTransaction++;
            identifiantBLO[0] = Identifiant;
        }

        public List<Identifiant> TousIdentifiants => identifiantBLO.AllItems;
    }
}
