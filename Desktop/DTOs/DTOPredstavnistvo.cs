using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.DTOs
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
        [DisplayName("Datum važenja licence")]
        public DateTime? DatumLicence { get; set; }

        public PredstavnistvoPregled()
        {
        }

        public PredstavnistvoPregled(int predstavnistvoId, string adresa, DateTime datumOtvaranja,string tip)
        {
            this.PredstavnistvoId = predstavnistvoId;
            this.Adresa = adresa;
            this.DatumOtvaranja = datumOtvaranja;
            this.Tip = tip;
           
        }
        public PredstavnistvoPregled(int predstavnistvoId, string adresa, DateTime datumOtvaranja, string tip,DateTime licenca)
        {
            this.PredstavnistvoId = predstavnistvoId;
            this.Adresa = adresa;
            this.DatumOtvaranja = datumOtvaranja;
            this.Tip = tip;
            this.DatumLicence = licenca;
        }


        public PredstavnistvoPregled(int predstavnistvoId, string tip, string adresa, DateTime datumOtvaranja, string tipPredstavnistva, DateTime? datumVazenjaLicence)
        {
            this.PredstavnistvoId = predstavnistvoId;
            this.Tip = tip;
            this.Adresa = adresa;
            this.DatumOtvaranja = datumOtvaranja;
            this.TipPredstavnistva = tipPredstavnistva;
            this.DatumLicence = datumVazenjaLicence;
        }

        public PredstavnistvoPregled(string adresa, DateTime datumOtvaranja, string tipPredstavnistva)
        {
            this.Adresa = adresa;
            this.DatumOtvaranja = datumOtvaranja;
            this.TipPredstavnistva = tipPredstavnistva;
        }
    }

    public class ServisPregled
    {
        public string Registracija { get; set; }
        public string Radovi { get; set; }
        public int Cena { get; set; }
        [DisplayName("Datum servisa")]
        public DateTime DatumServisa { get; set; }

        public ServisPregled(string reg,string radovi,int cena,DateTime datum)
        {
            Registracija = reg;
            Radovi = radovi;
            Cena = cena;
            DatumServisa = datum;
        }

    }
}
