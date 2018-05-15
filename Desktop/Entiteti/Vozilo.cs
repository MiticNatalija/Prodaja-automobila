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


        // Izmena: Svako vozilo ima listu knjizica.
        public virtual IList<Knjizica> Knjizice { get; set; }


    }
        public class Putnicko :Vozilo
        {
            public virtual int BrojMesta { get; set; }
        }

        public class Teretno:Vozilo
        {
            public virtual int Nosivost { get; set; }
        }








    
}
