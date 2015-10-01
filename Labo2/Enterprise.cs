using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public class Enterprise
    {
        public String Name { get; set; }
        public String HQ { get; set; }

        public override string ToString()
        {
            return Name + " " + HQ;
        }

        public Enterprise(String name, String hq)
        {
            Name = name;
            HQ = hq;
        }
    }
}
