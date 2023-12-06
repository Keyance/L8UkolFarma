using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8UkolFarma
{
    public class Slepice : Zvire, ISnasiVejce
    {
        public int DenniNosnost;
        public int VajecVHnizde = 0;
        public Slepice(string jmeno, string druh) : base(jmeno, druh)
        {

        }

        public void SbirameVejce()
        {
            Console.WriteLine("Počet vajec v hnizde je teď: " + VajecVHnizde);
            Console.Write("Kolik vajec chcete vzít?");
            int vzato = Convert.ToInt32(Console.ReadLine());
            if (vzato < VajecVHnizde)
            {
                Console.WriteLine("V hnízdě není dost vajec.");
            }
            else
            {
                VajecVHnizde -= vzato;
                Console.WriteLine("V hnízdě nyní zůstalo " + VajecVHnizde + " vajec.");
            }
        }

        public int SnasiVejce(int pocetDni)
        {
            int sneseno = pocetDni * DenniNosnost;
            VajecVHnizde += sneseno;
            return sneseno;
        }
    }
}
