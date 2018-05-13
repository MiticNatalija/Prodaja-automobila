using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public abstract class Predstavnistvo
    {
        public virtual int Id { get; protected set; }
        public virtual string Adresa { get; set; }
        public virtual DateTime DatumOtvaranja { get; set; }
        public virtual int FHyundai { get; set; }
        public virtual int FKia { get; set; }
        public virtual int FSalon { get; set; }
        public virtual int FServis { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }
    }

    //public abstract class Salon : Predstavnistvo { }
    //public abstract class Servis : Predstavnistvo { }
    //public abstract class SalonServis : Predstavnistvo { }

    public class ServisKia : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikKia { get; set; }
    }

    public class ServisHyundai : Predstavnistvo
    {
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
    }

    public class ServisHyundaiKia : Predstavnistvo
    {
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual PredstavnikKia PredstavnikKia { get; set; }
    }

    public class SalonKia : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikKia { get; set; }
    }

    public class SalonHyundai : Predstavnistvo
    {
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual DateTime DatumVazenjaLicence { get; set; }
    }

    public class SalonHyundaiKia : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikKia { get; set; }
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual DateTime DatumVazenjaLicence { get; set; }
    }

    public class SalonServisKia : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikKia { get; set; }
    }

    public class SalonServisHyundai : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikHyundai { get; set; }
        public virtual DateTime DatumVazenjaLicence { get; set; }
    }

    public class SalonServisHyundaiKia : Predstavnistvo
    {
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual DateTime DatumVazenjaLicence { get; set; }
        public virtual PredstavnikKia PredstavnikKia { get; set; }
    }
}
