using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;

namespace Desktop.Web_DTOs
{
    public class PredstavnistvoView
    {
        public int PredstavnistvoId { get; protected set; }
    
        public string Tip { get; set; }  //ne moze protected set zbog post 
        public string Adresa { get; set; }
    
        public DateTime DatumOtvaranja { get; set; }

        public PredstavnistvoView()
        { }
        public PredstavnistvoView(int id, string tip, string adresa, DateTime datumOtvaranja)
        {
            PredstavnistvoId = id;
            Tip = tip;
            Adresa = adresa;
            DatumOtvaranja = datumOtvaranja;
        }
        public PredstavnistvoView(Predstavnistvo p)
        {
            this.PredstavnistvoId = p.Id;
            this.Adresa = p.Adresa;
            this.DatumOtvaranja = p.DatumOtvaranja;

            if (p is SalonHyundai)
            {
                this.Tip = "Salon Hyundai";
            }
            else if (p is SalonKia)
            {
                this.Tip = "Salon Kia";
            }
            else if (p is SalonHyundaiKia)
            {
                this.Tip = "Salon Hyundai i Kia";
            }
            else if (p is ServisHyundai)
            {
                this.Tip = "Servis Hyundai";
            }
            else if (p is ServisKia)
            {
                this.Tip = "Servis Kia";
            }
            else if (p is ServisHyundaiKia)
            {
                this.Tip = "Servis Hyundai i Kia";
            }
            else if (p is SalonServisHyundai)
            {
                this.Tip = "Salon i Servis Hyundai";
            }
            else if (p is SalonServisKia)
            {
                this.Tip = "Salon i Servis Kia";
            }
            else if (p is SalonServisHyundaiKia)
            {
                this.Tip = "Salon i Servis Hyundai i Kia";
            }

        }
    }
}
