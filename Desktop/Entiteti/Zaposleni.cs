using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Zaposleni
    {
        public virtual long Id { get; protected set; }
        public virtual string Mbr { get; set; }
        public virtual string LicnoIme { get; set; }
        public virtual string ImeOca { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual DateTime DatumZaposlenja { get; set; }
    }
}
