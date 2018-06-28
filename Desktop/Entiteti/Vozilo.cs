using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public abstract class Vozilo
    {
        public virtual int Id { get; protected set; }
        public virtual string Registracija { get; set; }
        public virtual string Gorivo { get; set; }
        public virtual string OznakaMotora { get; set; }
        public virtual string PopustiServis { get; set; }
        public virtual string PopustiDelovi { get; set; }

        public virtual Predstavnistvo Salon { get; set; }

        public virtual Zaposleni Predstavnik { get; set; }

        public virtual IList<Knjizica> Knjizice { get; set; }

        public virtual Kupac kupac { get; set; }

        public virtual Vlasnik vlasnik { get; set; }

        public Vozilo()
        {
            Knjizice = new List<Knjizica>();
        }

    }

    public class Putnicko : Vozilo
    {
        public virtual int? BrojMesta { get; set; }

        public Putnicko()
        { }
        public Putnicko(string r, string g, string o)
        {
            Registracija = r;
            Gorivo = g;
            OznakaMotora = o;
        }

    }

    public class Teretno : Vozilo
    {
        public virtual int? Nosivost { get; set; }
        public Teretno()
        { }
        public Teretno(string r, string g, string o)
        {
            Registracija = r;
            Gorivo = g;
            OznakaMotora = o;
        }

    }
}
