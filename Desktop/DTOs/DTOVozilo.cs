using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.DTOs
{
    public class VoziloPregled
    {
        [BrowsableAttribute(false)]
        public int VoziloId { get; protected set; }
        [BrowsableAttribute(false)]
        public string Tip { get; protected set; }


        public string Registracija { get; set; }
        public string Gorivo { get; set; }

       // [BrowsableAttribute(false)]
        public string OznakaMotora { get; set; }

        [DisplayName("Broj mesta")]
        public int? BrojMesta { get; set; }
        public int? Nosivost { get; set; }
        [DisplayName("Tip vozila")]
        public string TipVozila { get; set; }

        [BrowsableAttribute(false)]
        public PredstavnistvoPregled PredstavnistvoPregled { get; set; }
       // public int PredstavnistvoId { get; set; }

        
        public VoziloPregled()
        { }
        public VoziloPregled(int voziloId, string tip, string registracija, string gorivo, string oznakaMotora, int? brojMesta, int? nosivost, string tipVozila)
        {
            VoziloId = voziloId;
            Tip = tip;
            Registracija = registracija;
            Gorivo = gorivo;
            OznakaMotora = oznakaMotora;
            BrojMesta = brojMesta;
            Nosivost = nosivost;
            TipVozila = tipVozila;
        }
        public VoziloPregled(string registracija, string gorivo, string tipVozila, string oznakaMotora)
        {
            this.Registracija = registracija;
            this.Gorivo = gorivo;
            this.TipVozila = tipVozila;
            this.OznakaMotora = oznakaMotora;
        }
        public VoziloPregled(int voziloId, string registracija, string gorivo)
        {
            this.VoziloId = voziloId;
            this.Registracija = registracija;
            this.Gorivo = gorivo;
        }

    }
}
