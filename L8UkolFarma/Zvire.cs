using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8UkolFarma
{
    public abstract class Zvire
    {
        public string Jmeno;
        public string OzviSe(string Jmeno)
        {
            return "Ahoj, já jsem " + Jmeno;
        }

        public Zvire(string jmeno)
        {
            Jmeno = jmeno;
        }
    }
}
