using System;
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

        public ZaposleniPregled(string mbr, string licnoIme, string imeOca, string prezime, DateTime datumRodjenja, DateTime datumZaposlenja)
        {

            this.Mbr = mbr;
            this.LicnoIme = licnoIme;
            this.ImeOca = imeOca;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
            this.DatumZaposlenja = datumZaposlenja;

        }
        public ZaposleniPregled(string mbr, string licnoIme, string prezime, string tipZaposlenog)
        {
            this.Mbr = mbr;
            this.LicnoIme = licnoIme;
            this.Prezime = prezime;
            this.TipZaposlenog = tipZaposlenog;
        }




    }
    public class ZaposleniIzmena
    {
        public int PredstavnikId { get; protected set; }
        public string Tip { get; protected set; }
        public string Mbr { get; set; }
        public string LicnoIme { get; set; }
        public string ImeOca { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public DateTime KrajRada { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Specijalnost { get; set; }


        public ZaposleniIzmena(int predstavnikId, string tip, string mbr, string licnoIme, string imeOca, string prezime, DateTime datumRodjenja, DateTime datumZaposlenja, string adresa, string telefon, string specijalnost)
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
            this.Specijalnost = specijalnost;

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
        public int BrojProdatihVozila { get; set; }

        public PredstavnikInfo(int predstavnikId, string tip, string mbr, string licnoIme, string imeOca, string prezime, DateTime datumRodjenja, DateTime datumZaposlenja, string adresa, string telefon, string tipZaposlenog, int brojProdatihVozila)
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
            this.BrojProdatihVozila = brojProdatihVozila;
        }
    }
    public class MehanicarAdd
    {

        public string Tip { get; protected set; }
        public string Mbr { get; set; }
        public string LicnoIme { get; set; }
        public string ImeOca { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string Specijalnost { get; set; }
        public MehanicarAdd(string tip, string mbr, string licnoIme, string imeOca, string prezime, DateTime datumRodjenja, DateTime datumZaposlenja, string specijalnost)
        {
            this.Tip = tip;
            this.Mbr = mbr;
            this.LicnoIme = licnoIme;
            this.ImeOca = imeOca;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
            this.DatumZaposlenja = datumZaposlenja;
            this.Specijalnost = specijalnost;
        }


    }
    public class PredstavnikAdd
    {

        public string Tip { get; protected set; }
        public string Mbr { get; set; }
        public string LicnoIme { get; set; }
        public string ImeOca { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }

        public PredstavnikAdd(string tip, string mbr, string licnoIme, string imeOca, string prezime, DateTime datumRodjenja, DateTime datumZaposlenja, string adresa, string telefon)
        {

            this.Tip = tip;
            this.Mbr = mbr;
            this.LicnoIme = licnoIme;
            this.ImeOca = imeOca;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
            this.DatumZaposlenja = datumZaposlenja;
            this.Adresa = adresa;
            this.Telefon = telefon;

        }


    }
    public class MehanicarPlain
    {
        public string Mbr { get; set; }
        [DisplayName("Ime")]
        public string LicnoIme { get; set; }
        [DisplayName("Ime oca")]
        public string ImeOca { get; set; }
        public string Prezime { get; set; }
        public MehanicarPlain(string mbr, string licnoIme, string imeOca, string prezime)
        {
            this.Mbr = mbr;
            this.LicnoIme = licnoIme;
            this.ImeOca = imeOca;
            this.Prezime = prezime;
           
        }

    }
    public class MehanicarPrikaz
    {
        public string Mbr { get; set; }
        [DisplayName("Ime")]
        public string LicnoIme { get; set; }
        [DisplayName("Ime oca")]
        public string ImeOca { get; set; }
        public string Prezime { get; set; }
        [BrowsableAttribute(false)]
        public string Tip { get; protected set; }
        [DisplayName("Tip zaposlenog")]
        public string TipZaposlenog { get; set; }

        public MehanicarPrikaz(string mbr, string licnoIme, string imeOca, string prezime, string tip, string tipZaposlenog)
        {
            this.Mbr = mbr;
            this.LicnoIme = licnoIme;
            this.ImeOca = imeOca;
            this.Prezime = prezime;
            this.Tip = tip;
            this.TipZaposlenog = tipZaposlenog;
        }
    }

    public class PredstavnikPick
    {
        public int PredstavnikId { get; set; }
        public string LicnoIme { get; set; }
        public string ImeOca { get; set; }
        public string Prezime { get; set; }

        public PredstavnikPick(int predstavnikId, string licnoIme, string imeOca, string prezime)
        {
            PredstavnikId = predstavnikId;
            LicnoIme = licnoIme;
            ImeOca = imeOca;
            Prezime = prezime;
        }

        public override string ToString()
        {
            return LicnoIme + ", " + ImeOca + " " + Prezime;
        }
    }

    public class MehanicarOcenaPregled
    {
        [BrowsableAttribute(false)]
        public int MehanicarId { get; set; }
        [DisplayName("Ime")]
        public string LicnoIme { get; set; }
        public string Prezime { get; set; }
        [DisplayName("Tip")]
        public string TipMehanicara { get; set; }
        [BrowsableAttribute(false)]
        public string Tip { get; set; }
        [DisplayName("Datum rodjenja")]
        public DateTime DatumRodjenja { get; set; }
        [DisplayName("Datum zaposlenja")]
        public DateTime DatumZaposlenja { get; set; }
        public string Specijalnost { get; set; }
        [DisplayName("Datum testiranja")]
        public DateTime DatumTestiranja { get; set; }
        public int Ocena { get; set; }

        public MehanicarOcenaPregled(int mehanicarId, string licnoIme, string prezime, string tip, DateTime datumRodjenja, DateTime datumZaposlenja, string specijalnost, DateTime datumTestiranja, int ocena)
        {
            MehanicarId = mehanicarId;
            LicnoIme = licnoIme;
            Prezime = prezime;
            Tip = tip;
            if (Tip.CompareTo("MehanicarKiaHyundai") == 0)
                TipMehanicara = "Mehanicar za Kiu i Hyundai";
            else if (Tip.CompareTo("MehanicarKia") == 0)
                TipMehanicara = "Mehanicar za Kiu";
            else
            {
                TipMehanicara = "Mehanicar za Hyundai";
            }
            DatumRodjenja = datumRodjenja;
            DatumZaposlenja = datumZaposlenja;
            Specijalnost = specijalnost;
            DatumTestiranja = datumTestiranja;
            Ocena = ocena;
        }
    }

    public class MehanicarOceni
    {
        [BrowsableAttribute(false)]
        public int MehanicarId { get; set; }
        [DisplayName("Ime")]
        public string LicnoIme { get; set; }
        public string Prezime { get; set; }
        [DisplayName("Tip")]
        public string TipMehanicara { get; set; }
        [BrowsableAttribute(false)]
        public string Tip { get; set; }
        [DisplayName("Datum rodjenja")]
        public DateTime DatumRodjenja { get; set; }
        [DisplayName("Datum zaposlenja")]
        public DateTime DatumZaposlenja { get; set; }
        public string Specijalnost { get; set; }

        public MehanicarOceni(int mehanicarId, string licnoIme, string prezime, string tip, DateTime datumRodjenja, DateTime datumZaposlenja, string specijalnost)
        {
            MehanicarId = mehanicarId;
            LicnoIme = licnoIme;
            Prezime = prezime;
            Tip = tip;
            if (Tip.CompareTo("MehanicarKiaHyundai") == 0)
                TipMehanicara = "Mehanicar za Kiu i Hyundai";
            else if (Tip.CompareTo("MehanicarKia") == 0)
                TipMehanicara = "Mehanicar za Kiu";
            else
            {
                TipMehanicara = "Mehanicar za Hyundai";
            }
            DatumRodjenja = datumRodjenja;
            DatumZaposlenja = datumZaposlenja;
            Specijalnost = specijalnost;
        }
    }

    public class AngazovanjeMehanicaraPregled
    {
        [BrowsableAttribute(false)]
        public int AngazovanjeId { get; set; }
        [DisplayName("Adresa predstavnistva")]
        public string AdresaPredstavnistva { get; set; }
        [DisplayName("Datum pocetka rada")]
        public DateTime DatumPocetka { get; set; }
        [DisplayName("Datum kraja rada")]
        public DateTime? KrajRada { get; set; }
        public int Ocena { get; set; }

        public AngazovanjeMehanicaraPregled(int angazovanjeId, string adresaPredstavnistva, DateTime datumPocetka, DateTime? krajRada, int ocena)
        {
            AngazovanjeId = angazovanjeId;
            AdresaPredstavnistva = adresaPredstavnistva;
            DatumPocetka = datumPocetka;
            KrajRada = krajRada;
            Ocena = ocena;
        }
    }
}
