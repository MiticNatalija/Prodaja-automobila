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
        public virtual string Tip { get; set; }
        
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
        public PredstavnikKia(string mbr,string ime,string imeOca,string prezime,DateTime dr,DateTime dz,string adresa,string tel)
        {
           
            Mbr = mbr;
            LicnoIme = ime;
            ImeOca = imeOca;
            Prezime = prezime;
            DatumRodjenja = dr;
            DatumZaposlenja = dz;
            Adresa = adresa;
            Telefon = tel;
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
        public PredstavnikHyundai(string mbr, string ime, string imeOca, string prezime, DateTime dr, DateTime dz, string adresa, string tel)
        {
         
            Mbr = mbr;
            LicnoIme = ime;
            ImeOca = imeOca;
            Prezime = prezime;
            DatumRodjenja = dr;
            DatumZaposlenja = dz;
            Adresa = adresa;
            Telefon = tel;
        }
    }

    public class MehanicarKia : Zaposleni
    {
        public virtual string Specijalnost { get; set; }
        public virtual IList<Predstavnistvo> Servisi { get; set; }

        public virtual IList<Angazuje> AngazujeServisi { get; set; }
        public virtual IList<Knjizica> Knjizice { get; set; }

        
       
        public MehanicarKia()
        {
            Servisi = new List<Predstavnistvo>();
            AngazujeServisi = new List<Angazuje>();
            Knjizice = new List<Knjizica>();
        }
        public MehanicarKia(string mbr, string ime, string imeOca, string prezime, DateTime dr, DateTime dz, string spec)
        {
           
            Mbr = mbr;
            LicnoIme = ime;
            ImeOca = imeOca;
            Prezime = prezime;
            DatumRodjenja = dr;
            DatumZaposlenja = dz;
            Specijalnost = spec;
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
        

        public MehanicarHyundai()
        {
            Predstavnici = new List<PredstavnikHyundai>();
            TestiraPredstavnici = new List<Testira>();
            Servisi = new List<Predstavnistvo>();
            AngazujeServisi = new List<Angazuje>();
            Knjizice = new List<Knjizica>();
        }
        public MehanicarHyundai(string mbr, string ime, string imeOca, string prezime, DateTime dr, DateTime dz, string spec)
        {
            
            Mbr = mbr;
            LicnoIme = ime;
            ImeOca = imeOca;
            Prezime = prezime;
            DatumRodjenja = dr;
            DatumZaposlenja = dz;
            Specijalnost = spec;
        }
    }

   
}
