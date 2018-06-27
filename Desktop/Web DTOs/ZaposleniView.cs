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

        public string Tip { get; protected set; }
     
        public string Mbr { get; set; }
      
        public string LicnoIme { get; set; }

        public string ImeOca { get; set; }
        public string Prezime { get; set; }
       
        public DateTime DatumRodjenja { get; set; }
       
        public DateTime DatumZaposlenja { get; set; }
    

        public ZaposleniView(Zaposleni z)
        {
            this.ZaposleniId = z.Id;
            this.Tip = z.GetType().ToString();
            this.Mbr =z.Mbr;
            this.LicnoIme = z.LicnoIme;
            this.ImeOca =z.ImeOca;
            this.Prezime = z.Prezime;
            this.DatumRodjenja = z.DatumRodjenja;
            this.DatumZaposlenja = z.DatumZaposlenja;
            
        }
    }
}
