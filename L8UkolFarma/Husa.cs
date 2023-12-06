using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace L8UkolFarma
{
    public class Husa : Zvire, ISnasiVejce, INechaSePohladit
    {
        public int MesicniNosnost;
        public int VajecVHnizde = 0;
        public Husa(string jmeno, string druh, int mesicniNosnost) : base(jmeno, druh)
        {
            MesicniNosnost = mesicniNosnost;
        }

        public void PohladimeZvire()
        {
            Console.WriteLine("Opatrně, občas klovu.");
        }

        public void SbirameVejce()
        {
            Console.WriteLine("Počet vajec v hnizde je teď: " + VajecVHnizde);
            Console.Write("Kolik vajec chcete vzít?");
            int vzato = Convert.ToInt32(Console.ReadLine());
            if (vzato > VajecVHnizde)
            {
                Console.WriteLine("V hnízdě není dost vajec.");
            } else
            {
                VajecVHnizde -= vzato;
                Console.WriteLine("V hnízdě nyní zůstalo " + VajecVHnizde + " vajec.");
            }
        }

        public int SnasiVejce(int pocetDni)
        {
            double sneseno = pocetDni * (MesicniNosnost/30.0);
            VajecVHnizde += (int)sneseno;
            return (int)sneseno;
        }
    }
}
