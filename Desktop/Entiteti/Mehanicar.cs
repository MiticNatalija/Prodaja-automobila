using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Mehanicar:Zaposleni
    {
        public virtual string Specijalnost { get; set; }
        public virtual int FKia { get; set; }
        public virtual int FHyundai { get; set; }
    }
}
