using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicouche.DAL.Langue
{
    public class Langue
    {
        public string Code { get; set; }       
        public string Name { get; set; }

        public Langue(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
