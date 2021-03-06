using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class FizickoLice
    {
        public virtual string Jmbg { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Telefon { get; set; }
        public virtual Kupac Kupac { get; set; }

        public FizickoLice()
        { }
        public FizickoLice(string jmbg, string ime, string prezime, string adresa, string telefon)
        {
            this.Jmbg = jmbg;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Adresa = adresa;
            this.Telefon = telefon;
        }
    }
}
