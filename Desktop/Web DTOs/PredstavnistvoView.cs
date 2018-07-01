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
        public DateTime? DatumVazenjaLicence { get; set; }
        public int? PKiaId { get; set; }
        public int? PHyundaiId { get; set; }

        public PredstavnistvoView()
        { }
        public PredstavnistvoView(int id, string tip, string adresa, DateTime datumOtvaranja, DateTime? datumVazenjaLicence, int? pKiaId, int? pHyundaiId)
        {
            PredstavnistvoId = id;
            Tip = tip;
            Adresa = adresa;
            DatumOtvaranja = datumOtvaranja;
            DatumVazenjaLicence = datumVazenjaLicence;
            PKiaId = pKiaId;
            PHyundaiId = pHyundaiId;
        }
        public PredstavnistvoView(Predstavnistvo p)
        {
            this.PredstavnistvoId = p.Id;
            this.Adresa = p.Adresa;
            this.DatumOtvaranja = p.DatumOtvaranja;

            if (p is SalonHyundai)
            {
                this.Tip = "Salon Hyundai";
                DatumVazenjaLicence = ((SalonHyundai)p).DatumVazenjaLicence;
                if (((SalonHyundai)p).PredstavnikHyundai != null)
                PHyundaiId = (int)((SalonHyundai)p).PredstavnikHyundai.Id;
            }
            else if (p is SalonKia)
            {
                this.Tip = "Salon Kia";
                if(((SalonKia)p).PredstavnikKia != null)
                PKiaId = (int)((SalonKia)p).PredstavnikKia.Id;
            }
            else if (p is SalonHyundaiKia)
            {
                this.Tip = "Salon Hyundai i Kia";
                DatumVazenjaLicence = ((SalonHyundaiKia)p).DatumVazenjaLicence;
                if (((SalonHyundaiKia)p).PredstavnikKia != null)
                    PKiaId = (int)((SalonHyundaiKia)p).PredstavnikKia.Id;
                if (((SalonHyundaiKia)p).PredstavnikHyundai != null)
                    PHyundaiId = (int)((SalonHyundaiKia)p).PredstavnikHyundai.Id;
            }
            else if (p is ServisHyundai)
            {
                this.Tip = "Servis Hyundai";
                if(((ServisHyundai)p).PredstavnikHyundai != null)
                PHyundaiId = (int)((ServisHyundai)p).PredstavnikHyundai.Id;
            }
            else if (p is ServisKia)
            {
                this.Tip = "Servis Kia";
                if(((ServisKia)p).PredstavnikKia != null)
                PKiaId = (int)((ServisKia)p).PredstavnikKia.Id;
            }
            else if (p is ServisHyundaiKia)
            {
                this.Tip = "Servis Hyundai i Kia";
                if(((ServisHyundaiKia)p).PredstavnikKia != null)
                PKiaId = (int)((ServisHyundaiKia)p).PredstavnikKia.Id;
                if (((ServisHyundaiKia)p).PredstavnikHyundai != null)
                    PHyundaiId = (int)((ServisHyundaiKia)p).PredstavnikHyundai.Id;
            }
            else if (p is SalonServisHyundai)
            {
                this.Tip = "Salon i Servis Hyundai";
                DatumVazenjaLicence = ((SalonServisHyundai)p).DatumVazenjaLicence;
                if (((SalonServisHyundai)p).PredstavnikHyundai != null)
                    PHyundaiId = (int)((SalonServisHyundai)p).PredstavnikHyundai.Id;
            }
            else if (p is SalonServisKia)
            {
                this.Tip = "Salon i Servis Kia";
                if (((SalonServisKia)p).PredstavnikKia != null)
                    PKiaId = (int)((SalonServisKia)p).PredstavnikKia.Id;
            }
            else if (p is SalonServisHyundaiKia)
            {
                this.Tip = "Salon i Servis Hyundai i Kia";
                DatumVazenjaLicence = ((SalonServisHyundaiKia)p).DatumVazenjaLicence;
                if (((SalonServisHyundaiKia)p).PredstavnikKia != null)
                    PKiaId = (int)((SalonServisHyundaiKia)p).PredstavnikKia.Id;
                if (((SalonServisHyundaiKia)p).PredstavnikHyundai != null)
                    PHyundaiId = (int)((SalonServisHyundaiKia)p).PredstavnikHyundai.Id;
            }

        }
    }
}
