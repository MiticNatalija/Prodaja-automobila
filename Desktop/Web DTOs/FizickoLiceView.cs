using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;

namespace Desktop.Web_DTOs
{
    public class FizickoLiceView
    {
        public string Jmbg { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }

        public FizickoLiceView()
        { }

        public FizickoLiceView(string jmbg, string ime, string prezime, string adresa, string telefon)
        {
            Jmbg = jmbg;
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
            Telefon = telefon;
        }

        public FizickoLiceView(FizickoLice f)
        {
            Jmbg = f.Jmbg;
            Ime = f.Ime;
            Prezime = f.Prezime;
            Adresa = f.Adresa;
            Telefon = f.Telefon;
        }
    }
}
