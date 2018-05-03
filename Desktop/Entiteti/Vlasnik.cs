using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Vlasnik
    {
        //pripada vozilu
        public virtual int IdVozila { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Adresa { get; set; }



    }
}
