﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8UkolFarma
{
    public class Kun : Zvire, INechaSePohladit
    {
        public Kun(string jmeno, string druh) : base(jmeno, druh)
        {
        }

        public void PohladimeZvire()
        {
            Console.WriteLine("Čmuf, čmuf, rád bych i pamlsek.");
        }
    }
}
