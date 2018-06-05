using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    public class PredstavnistvoPregled
    {
        [BrowsableAttribute(false)]
        public int PredstavnistvoId { get; protected set; }
        [BrowsableAttribute(false)]
        public string Tip { get; protected set; }
        public string Adresa { get; set; }
        [DisplayName("Datum otvaranja")]
        public DateTime DatumOtvaranja { get; set; }
        [DisplayName("Tip predstavnistva")]
        public string TipPredstavnistva { get; set; }

        public PredstavnistvoPregled()
        {
        }

        public PredstavnistvoPregled(int predstavnistvoId, string adresa, DateTime datumOtvaranja)
        {
            this.PredstavnistvoId = predstavnistvoId;
            this.Adresa = adresa;
            this.DatumOtvaranja = datumOtvaranja;
        }

        public PredstavnistvoPregled(int predstavnistvoId, string tip, string adresa, DateTime datumOtvaranja, string tipPredstavnistva)
        {
            this.PredstavnistvoId = predstavnistvoId;
            this.Tip = tip;
            this.Adresa = adresa;
            this.DatumOtvaranja = datumOtvaranja;
            this.TipPredstavnistva = tipPredstavnistva;
        }
    }

    public class ZaposleniPregled
    {
        [BrowsableAttribute(false)]
        public int ZaposleniId { get; protected set; }
        [BrowsableAttribute(false)]
        public string Tip { get; protected set; }
        [DisplayName("JMBG")]
        public string Mbr { get; set; }
        [DisplayName("Licno ime")]
        public string LicnoIme { get; set; }
        [DisplayName("Ime oca")]
        public string ImeOca { get; set; }
        public string Prezime { get; set; }
        [DisplayName("Datum rodjenja")]
        public DateTime DatumRodjenja { get; set; }
        [DisplayName("Datum zaposlenja")]
        public DateTime DatumZaposlenja { get; set; }
        [DisplayName("Tip zaposlenog")]
        public string TipZaposlenog { get; set; }

        public ZaposleniPregled(int zaposleniId, string tip, string mbr, string licnoIme, string imeOca, string prezime, DateTime datumRodjenja, DateTime datumZaposlenja, string tipZaposlenog)
        {
            this.ZaposleniId = zaposleniId;
            this.Tip = tip;
            this.Mbr = mbr;
            this.LicnoIme = licnoIme;
            this.ImeOca = imeOca;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
            this.DatumZaposlenja = datumZaposlenja;
            this.TipZaposlenog = tipZaposlenog;
        }
    }
}
