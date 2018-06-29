using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;

namespace Desktop.Web_DTOs
{
   public class ZaposleniView
    {

   
        public int ZaposleniId { get; protected set; }

        public string Tip { get; set; }
     
        public string Mbr { get; set; }
      
        public string LicnoIme { get; set; }

        public string ImeOca { get; set; }
        public string Prezime { get; set; }
       
        public DateTime? DatumRodjenja { get; set; }
       
        public DateTime? DatumZaposlenja { get; set; }

        public string Specijalnost { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Telefon { get; set; }

        public ZaposleniView()
        { }
        public ZaposleniView(int id, string tip, string mbr, string lime, string ime, string prezime, DateTime r, DateTime z)
        {
            this.ZaposleniId = id;
            this.Tip =tip;
            this.Mbr = mbr;
            this.LicnoIme = lime;
            this.ImeOca = ime;
            this.Prezime = prezime;
            this.DatumRodjenja = r;
            this.DatumZaposlenja = z;
        }
        public ZaposleniView(string mbr, string lime, string ime, string prezime, DateTime r, DateTime z)
        {
            
            this.Mbr = mbr;
            this.LicnoIme = lime;
            this.ImeOca = ime;
            this.Prezime = prezime;
            this.DatumRodjenja = r;
            this.DatumZaposlenja = z;
        }

        public ZaposleniView(Zaposleni z)
        {
            this.ZaposleniId = z.Id;
            //this.Tip = z.GetType().ToString();
            if (z is PredstavnikKia)
                this.Tip = "Predstavnik Kia";
            else if (z is PredstavnikHyundai)
                this.Tip = "Predstavnik Hyundai";
            else if (z is MehanicarHyundai)
                this.Tip = "Mehanicar Hyundai";
            else if (z is MehanicarKia)
                this.Tip = "Mehanicar Kia";
            this.Mbr =z.Mbr;
            this.LicnoIme = z.LicnoIme;
            this.ImeOca =z.ImeOca;
            this.Prezime = z.Prezime;
            this.DatumRodjenja = z.DatumRodjenja;
            this.DatumZaposlenja = z.DatumZaposlenja;
            
        }
    }
}
