using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Knjizica
    {
        public virtual int Id { get; protected set;}
        public virtual DateTime DatumIntervencije { get; set; }
        public virtual int CenaUsluge { get; set; }
        public virtual string Radovi { get; set; }
        public virtual Vozilo Vozilo { get; set;}
        public virtual Predstavnistvo Servis { get; set; }

        public virtual IList<Zaposleni> Mehanicari { get; set; }


        public Knjizica()
        {
            Mehanicari = new List<Zaposleni>();
        }
    }
}
