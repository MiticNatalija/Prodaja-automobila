using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    public class PredstavnistvoPregled
    {
        public int PredstavnistvoId { get; set; }
        public string Adresa { get; set; }
        public DateTime DatumOtvaranja { get; set; }
        public string Tip { get; set; }

        public PredstavnistvoPregled(int predstavnistvoId, string adresa, DateTime datumOtvaranja, string tip)
        {
            this.PredstavnistvoId = predstavnistvoId;
            this.Adresa = adresa;
            this.DatumOtvaranja = datumOtvaranja;
            this.Tip = tip;
        }
    }
}
