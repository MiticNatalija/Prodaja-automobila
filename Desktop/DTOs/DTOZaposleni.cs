﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.DTOs
{
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

    public class PredstavnikInfo
    {
        public int PredstavnikId { get; protected set; }
        public string Tip { get; protected set; }
        public string Mbr { get; set; }
        public string LicnoIme { get; set; }
        public string ImeOca { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string TipZaposlenog { get; set; }

        public PredstavnikInfo(int predstavnikId, string tip, string mbr, string licnoIme, string imeOca, string prezime, DateTime datumRodjenja, DateTime datumZaposlenja, string adresa, string telefon, string tipZaposlenog)
        {
            this.PredstavnikId = predstavnikId;
            this.Tip = tip;
            this.Mbr = mbr;
            this.LicnoIme = licnoIme;
            this.ImeOca = imeOca;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
            this.DatumZaposlenja = datumZaposlenja;
            this.Adresa = adresa;
            this.Telefon = telefon;
            this.TipZaposlenog = tipZaposlenog;
        }
    }
}