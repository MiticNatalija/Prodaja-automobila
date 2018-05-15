using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Knjizica
    {
        // Deluje okej ali je Bogdanovic rekao da za slabe tipove treba da idu kompozitni kljucevi, evo ne znam..

        public virtual int Id { get; protected set;}
        public virtual DateTime DatumIntervencije { get; set; }
        public virtual int CenaUsluge { get; set; }
        public virtual string Radovi { get; set; }
        public virtual Vozilo Vozilo { get; set;}
        public virtual Predstavnistvo Servis { get; set; }


        public Knjizica()
        {
        }
    }
}
