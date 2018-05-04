using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Vlasnik
    {
       //slabi tip entiteta


       // public virtual int IdVozila { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Adresa { get; set; }
        //pripada vozilu
        public virtual Vozilo vozilo { get; set; }
        //ili da se napravi mapiranje ili da se ovi atributi stave u vozilo

    }
}
