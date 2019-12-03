using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransFlash.BO.Statut;

namespace TransFlash.BO
{
    [Serializable]
    public class Garantie
    {
        public int Id { get; set; }
        public string ElementEnGarantie { get; set; }
        public Avaliste Avaliste { get; set; }
        public StatutGarantie StatutGarantie { get; set; }

        public Garantie()
        {
        }

        public Garantie(int id)
        {
            Id = id;
        }

        public Garantie(int id, string elementEnGarantie, Avaliste avaliste, StatutGarantie statutGarantie) : this(id)
        {
            ElementEnGarantie = elementEnGarantie;
            Avaliste = avaliste;
            StatutGarantie = statutGarantie;
        }

        public override bool Equals(object obj)
        {
            return obj is Garantie graantie &&
                   Id == graantie.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
