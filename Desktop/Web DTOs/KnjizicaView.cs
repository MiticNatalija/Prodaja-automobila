using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;

namespace Desktop.Web_DTOs
{
    public class KnjizicaView
    {
        public int Id { get; protected set; }
        public DateTime DatumIntervencije { get; set; }
        public int CenaUsluge { get; set; }
        public string Radovi { get; set; }
        public int IdVozila { get; set; }
        public int IdServisa { get; set; }

        public KnjizicaView() { }
        public KnjizicaView(int id, DateTime datumIntervencije, int cenaUsluge, string radovi)
        {
            this.Id = id;
            this.DatumIntervencije = datumIntervencije;
            this.CenaUsluge = cenaUsluge;
            this.Radovi = radovi;
        }
        public KnjizicaView(int id, DateTime datumIntervencije, int cenaUsluge, string radovi, int idVozila, int idServisa)
        {
            this.Id = id;
            this.DatumIntervencije = datumIntervencije;
            this.CenaUsluge = cenaUsluge;
            this.Radovi = radovi;
            this.IdVozila = idVozila;
            this.IdServisa = idServisa;
        }
        public KnjizicaView(Knjizica k)
        {
            Id = k.Id;
            DatumIntervencije = k.DatumIntervencije;
            CenaUsluge = k.CenaUsluge;
            Radovi = k.Radovi;
            IdVozila = k.Vozilo.Id;
            IdServisa = k.Servis.Id;
        }
    }
}
