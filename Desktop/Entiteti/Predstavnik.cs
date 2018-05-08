using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Predstavnik : Zaposleni
    {
        
        public virtual string Adresa { get; set; }
        public virtual string Telefon { get; set; }
        public virtual int FKia { get; set; }
        public virtual int FHyundai { get; set; }

    }
}
