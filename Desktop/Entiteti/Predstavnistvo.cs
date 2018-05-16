﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public abstract class Predstavnistvo
    {
        public virtual int Id { get; protected set; }
        public virtual string Adresa { get; set; }
        public virtual DateTime DatumOtvaranja { get; set; }
        public virtual string Tip { get; set; }

        //public virtual IList<Vozilo> Vozila { get; set; }

        // Maruska: 
        // izmene: Lista vozila pripada samo salonu
        //         Lista knjizica pripada samo servisu
    }

    // Ovo dole u komentaru bi bilo zgodno kad bi moglo, treba proveriti da li moze.

    //public abstract class Salon : Predstavnistvo { }
    //public abstract class Servis : Predstavnistvo { }
    //public abstract class SalonServis : Predstavnistvo { }

    public class ServisKia : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikKia { get; set; }
        //public virtual IList<Knjizica> Knjizice { get; set; }
    }

    public class ServisHyundai : Predstavnistvo
    {
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        //public virtual IList<Knjizica> Knjizice { get; set; }
    }

    public class ServisHyundaiKia : Predstavnistvo
    {
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual PredstavnikKia PredstavnikKia { get; set; }
        //public virtual IList<Knjizica> Knjizice { get; set; }
    }

    public class SalonKia : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikKia { get; set; }
        //public virtual IList<Vozilo> Vozila { get; set; }
    }

    public class SalonHyundai : Predstavnistvo
    {
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual DateTime DatumVazenjaLicence { get; set; }
        //public virtual IList<Vozilo> Vozila { get; set; }
    }

    public class SalonHyundaiKia : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikKia { get; set; }
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual DateTime DatumVazenjaLicence { get; set; }
        //public virtual IList<Vozilo> Vozila { get; set; }
    }

    public class SalonServisKia : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikKia { get; set; }
        //public virtual IList<Vozilo> Vozila { get; set; }
        //public virtual IList<Knjizica> Knjizice { get; set; }
    }

    public class SalonServisHyundai : Predstavnistvo
    {
        public virtual PredstavnikKia PredstavnikHyundai { get; set; }
        public virtual DateTime DatumVazenjaLicence { get; set; }
        //public virtual IList<Vozilo> Vozila { get; set; }
        //public virtual IList<Knjizica> Knjizice { get; set; }
    }

    public class SalonServisHyundaiKia : Predstavnistvo
    {
        public virtual PredstavnikHyundai PredstavnikHyundai { get; set; }
        public virtual DateTime DatumVazenjaLicence { get; set; }
        public virtual PredstavnikKia PredstavnikKia { get; set; }
        //public virtual IList<Vozilo> Vozila { get; set; }
        //public virtual IList<Knjizica> Knjizice { get; set; }
    }
}
