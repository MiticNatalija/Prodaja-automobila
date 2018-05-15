﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class PravnoLice
    {
        public virtual int Pib { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Telefon { get; set; }
        public virtual Kupac Kupac { get; set; }

        // Maruska:
        // Nisam sigurna da je PravnoLice : Kupac okej, 
        // cekamo da javi Bogdanovic kako se radi s kategorijom






    }
}
