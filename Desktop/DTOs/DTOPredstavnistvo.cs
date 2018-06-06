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

        public PredstavnistvoPregled(int predstavnistvoId, string adresa, DateTime datumOtvaranja)
        {
            this.PredstavnistvoId = predstavnistvoId;
            this.Adresa = adresa;
            this.DatumOtvaranja = datumOtvaranja;
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
}
