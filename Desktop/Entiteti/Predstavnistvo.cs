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
        public virtual string Tip { get; set; }
    }

    public class ServisKia : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikKia { get; set; }
        public virtual IList<Knjizica> Knjizice { get; set; }
        public virtual IList<Zaposleni> Mehanicari { get; set; }

        public virtual IList<Angazuje> AngazujeMehanicari { get; set; }
        
        public ServisKia()
        {
            Mehanicari = new List<Zaposleni>();
            AngazujeMehanicari = new List<Angazuje>();
            Knjizice = new List<Knjizica>(); 
        }

    }

    public class ServisHyundai : Predstavnistvo
    {
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual IList<Knjizica> Knjizice { get; set; }
        public virtual IList<Zaposleni> Mehanicari { get; set; }

        public virtual IList<Angazuje> AngazujeMehanicari { get; set; }

        public ServisHyundai()
        {
            Mehanicari = new List<Zaposleni>();
            AngazujeMehanicari = new List<Angazuje>();
            Knjizice = new List<Knjizica>();
        }
    }

    public class ServisHyundaiKia : Predstavnistvo
    {
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual PredstavnikKia PredstavnikKia { get; set; }
        public virtual IList<Knjizica> Knjizice { get; set; }
        public virtual IList<Zaposleni> Mehanicari { get; set; }

        public virtual IList<Angazuje> AngazujeMehanicari { get; set; }

        public ServisHyundaiKia()
        {
            Mehanicari = new List<Zaposleni>();
            AngazujeMehanicari = new List<Angazuje>();
            Knjizice = new List<Knjizica>();
        }
    }

    public class SalonKia : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikKia { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }

        public SalonKia()
        {
            Vozila = new List<Vozilo>();
        }
    }

    public class SalonHyundai : Predstavnistvo
    {
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual DateTime DatumVazenjaLicence { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }

        public SalonHyundai()
        {
            Vozila = new List<Vozilo>();
         
        }
    }

    public class SalonHyundaiKia : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikKia { get; set; }
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual DateTime DatumVazenjaLicence { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }
        public SalonHyundaiKia()
        {
            Vozila = new List<Vozilo>();
        }
    }

    public class SalonServisKia : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikKia { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }
        public virtual IList<Knjizica> Knjizice { get; set; }
        public virtual IList<Zaposleni> Mehanicari { get; set; }

        public virtual IList<Angazuje> AngazujeMehanicari { get; set; }

        
        public SalonServisKia()
        {
            Vozila = new List<Vozilo>();
            Mehanicari = new List<Zaposleni>();
            AngazujeMehanicari = new List<Angazuje>();
            Knjizice = new List<Knjizica>();
        }
    }

    public class SalonServisHyundai : Predstavnistvo
    {
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual DateTime DatumVazenjaLicence { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }
        public virtual IList<Knjizica> Knjizice { get; set; }
        public virtual IList<Zaposleni> Mehanicari { get; set; }

        public virtual IList<Angazuje> AngazujeMehanicari { get; set; }
        public SalonServisHyundai()
        {
            Vozila = new List<Vozilo>();
            Mehanicari = new List<Zaposleni>();
            AngazujeMehanicari = new List<Angazuje>();
            Knjizice = new List<Knjizica>();
        }
    }

    public class SalonServisHyundaiKia : Predstavnistvo
    {
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual DateTime DatumVazenjaLicence { get; set; }
        public virtual PredstavnikKia PredstavnikKia { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }
        public virtual IList<Knjizica> Knjizice { get; set; }

        public virtual IList<Zaposleni> Mehanicari { get; set; }

        public virtual IList<Angazuje> AngazujeMehanicari { get; set; }
        public SalonServisHyundaiKia()
        {
            Vozila = new List<Vozilo>();
            Mehanicari = new List<Zaposleni>();
            AngazujeMehanicari = new List<Angazuje>();
            Knjizice = new List<Knjizica>();
        }
    }
}
