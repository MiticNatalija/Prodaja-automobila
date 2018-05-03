using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Predstavnistvo
    {
        public virtual int Id { get; set; }
        public virtual string Adresa { get; set; }
        public virtual DateTime DatumOtvaranja { get; set; }
        public virtual int FHyundai { get; set; }
        public virtual int PHyundaiId { get; set; }
        public virtual DateTime DatumVazenjaLicence { get; set; }
        public virtual int FKia { get; set; }
        public virtual int PKiaId { get; set; }
        public virtual int FSalon { get; set; }
        public virtual int FServis { get; set; }







    }
}
