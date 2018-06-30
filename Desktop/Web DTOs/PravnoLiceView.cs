using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;

namespace Desktop.Web_DTOs
{
    public class PravnoLiceView
    {
        public int Pib { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }

        public PravnoLiceView()
        { }

        public PravnoLiceView(int pib, string ime, string prezime, string telefon)
        {
            Pib = pib;
            Ime = ime;
            Prezime = prezime;
            Telefon = telefon;
        }

        public PravnoLiceView(PravnoLice p)
        {
            Pib = p.Pib;
            Ime = p.Ime;
            Prezime = p.Prezime;
            Telefon = p.Telefon;
        }
    }
}
