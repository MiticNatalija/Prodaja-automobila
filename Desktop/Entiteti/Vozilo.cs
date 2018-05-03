using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public abstract class Vozilo
    {
        public virtual int Id { get; set; }
        public virtual string Registracija { get; set; }
        public virtual string Gorivo { get; set; }
        public virtual string OznakaMotora { get; set; }
        public virtual string TipVozila { get; set; }


        //salonId
        //predstavnikID
        //popustiServis
        //popustiDelovi

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
