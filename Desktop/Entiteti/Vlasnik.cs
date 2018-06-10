using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Vlasnik
    {
        public virtual int Id { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Adresa { get; set; }
        public virtual Vozilo Vozilo { get; set; }
       

        public Vlasnik()
        { }
        public Vlasnik(string telefon, string adresa)
        {
            this.Telefon = telefon;
            this.Adresa = adresa;

        }
       
    }
}
