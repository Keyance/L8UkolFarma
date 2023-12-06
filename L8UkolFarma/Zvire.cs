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
        public string Druh;
        public string OzviSe()
        {
            return "Ahoj, já jsem " + Jmeno;
        }

        protected Zvire(string jmeno, string druh)
        {
            Jmeno = jmeno;
            Druh = druh;
        }
    }
}
