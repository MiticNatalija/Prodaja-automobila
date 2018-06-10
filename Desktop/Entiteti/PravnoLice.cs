using System;
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


        public PravnoLice()
        { }
        public PravnoLice(int pib, string ime, string prezime, string telefon)
        {
            this.Pib = pib;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Telefon = telefon;
        }
    }
}
