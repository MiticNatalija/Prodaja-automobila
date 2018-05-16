using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public abstract class Zaposleni
    {
        public virtual int Id { get; protected set; }
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
        public virtual IList<Vozilo> Vozila { get; set; }
        public virtual IList<Predstavnistvo> Predstavnistva {get;set;}
        public PredstavnikKia()
        {
            Vozila = new List<Vozilo>();
            Predstavnistva = new List<Predstavnistvo>();
        }
    }

    public class PredstavnikHyundai : Zaposleni
    {
        public virtual string Adresa { get; set; }
        public virtual string Telefon { get; set; }

        public virtual IList<Vozilo> Vozila { get; set; }

        public virtual IList<Predstavnistvo> Predstavnistva { get; set; }

        public virtual IList<MehanicarHyundai> Mehanicari { get; set; }

        public virtual IList<Testira> TestiraMehanicari { get; set; }


        public PredstavnikHyundai()
        {
            Mehanicari = new List<MehanicarHyundai>();
            TestiraMehanicari = new List<Testira>();
            Vozila = new List<Vozilo>();
            Predstavnistva = new List<Predstavnistvo>();
        }
    }

    public class MehanicarKia : Zaposleni
    {
        public virtual string Specijalnost { get; set; }
        public virtual IList<Predstavnistvo> Servisi { get; set; }

        public virtual IList<Angazuje> AngazujeServisi { get; set; }
        public virtual IList<Knjizica> Knjizice { get; set; }

        public virtual IList<Sadrzi> SadrziKnjizice { get; set; }

       
        public MehanicarKia()
        {
            Servisi = new List<Predstavnistvo>();
            AngazujeServisi = new List<Angazuje>();
            Knjizice = new List<Knjizica>();
           SadrziKnjizice = new List<Sadrzi>();
        }
    }

    public class MehanicarHyundai : Zaposleni
    {
        public virtual string Specijalnost { get; set; }

        public virtual IList<PredstavnikHyundai> Predstavnici { get; set; }

        public virtual IList<Testira> TestiraPredstavnici { get; set; }

        public virtual IList<Predstavnistvo> Servisi { get; set; }

        public virtual IList<Angazuje> AngazujeServisi { get; set; }
        public virtual IList<Knjizica> Knjizice { get; set; }

       public virtual IList<Sadrzi> SadrziKnjizice { get; set; }

        public MehanicarHyundai()
        {
            Predstavnici = new List<PredstavnikHyundai>();
            TestiraPredstavnici = new List<Testira>();
            Servisi = new List<Predstavnistvo>();
            AngazujeServisi = new List<Angazuje>();
            Knjizice = new List<Knjizica>();
            SadrziKnjizice = new List<Sadrzi>();
        }
    }

    public class MehanicarKiaHyundai : Zaposleni
    {
        public virtual string Specijalnost { get; set; }
        public virtual IList<Predstavnistvo> Servisi { get; set; }

        public virtual IList<Angazuje> AngazujeServisi { get; set; }
        public virtual IList<Knjizica> Knjizice { get; set; }

       public virtual IList<Sadrzi> SadrziKnjizice { get; set; }

        public MehanicarKiaHyundai()
        {
            Servisi = new List<Predstavnistvo>();
            AngazujeServisi = new List<Angazuje>();
            Knjizice = new List<Knjizica>();
            SadrziKnjizice = new List<Sadrzi>();
        }
    }
}
