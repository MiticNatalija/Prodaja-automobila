using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public abstract class Zaposleni
    {
        public virtual long Id { get; protected set; }
        public virtual string Mbr { get; set; }
        public virtual string LicnoIme { get; set; }
        public virtual string ImeOca { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual DateTime DatumZaposlenja { get; set; }
    }

    public class PredstavnikKia : Zaposleni
    {
        public virtual string Adresa { get; set; }
        public virtual string Telefon { get; set; }
    }

    public class PredstavnikHyundai : Zaposleni
    {
        public virtual string Adresa { get; set; }
        public virtual string Telefon { get; set; }
    }

    public class MehanicarKia : Zaposleni
    {
        public virtual string Specijalnost { get; set; }
    }

    public class MehanicarHyundai : Zaposleni
    {
        public virtual string Specijalnost { get; set; }
    }

    public class MehanicarKiaHyundai : Zaposleni
    {
        public virtual string Specijalnost { get; set; }
    }
}
