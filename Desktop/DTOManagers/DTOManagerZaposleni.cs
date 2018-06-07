using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NHibernate;
using Desktop.Entiteti;
using Desktop.DTOs;

namespace Desktop.DTOManagers
{
    public partial class DTOManager
    {
        public static List<ZaposleniPregled> GetZaposleniInfos()
        {
            List<ZaposleniPregled> zapInfos = new List<ZaposleniPregled>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                IEnumerable<Zaposleni> zaposleni = from z in s.Query<Zaposleni>()
                                                   select z;

                foreach (Zaposleni z in zaposleni)
                {
                    string tip = "Greska";
                    string tipZaposlenog = "Greska";

                    if (z is PredstavnikKia)
                    {
                        tipZaposlenog = "Predstavnik za Kiu";
                        tip = "PredstavnikKia";
                    }
                    else if (z is PredstavnikHyundai)
                    {
                        tipZaposlenog = "Predstavnik za Hyundai";
                        tip = "PredstavnikHyundai";
                    }
                    else if (z is MehanicarKia)
                    {
                        tipZaposlenog = "Mehanicar za Kiu";
                        tip = "MehanicarKia";
                    }
                    else if (z is MehanicarHyundai)
                    {
                        tipZaposlenog = "Mehanicar za Hyundai";
                        tip = "MehanicarHyundai";
                    }
                    else if (z is MehanicarKiaHyundai)
                    {
                        tipZaposlenog = "Mehanicar za Kiu i Hyundai";
                        tip = "MehanicarKiaHyundai";
                    }
                    zapInfos.Add(new ZaposleniPregled(z.Id, tip, z.Mbr, z.LicnoIme, z.ImeOca, z.Prezime, z.DatumRodjenja, z.DatumZaposlenja, tipZaposlenog));
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                s.Close();
            }

            return zapInfos;
        }

        public static List<PredstavnikInfo> GetPredstavniciForPredstavnistvo(int id)
        {
            List<PredstavnikInfo> preInfos = new List<PredstavnikInfo>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                Predstavnistvo  pom = (from p in s.Query<Predstavnistvo>()
                                     where p.Id == id
                                     select p).Single<Predstavnistvo>();
                
                if(pom is SalonHyundai)
                {
                    PredstavnikHyundai ph = ((SalonHyundai)pom).PredstavnikHyundai;
                    preInfos.Add(new PredstavnikInfo(ph.Id, "PredstavnikHyundai", ph.Mbr, ph.LicnoIme, ph.ImeOca, ph.Prezime, ph.DatumRodjenja, ph.DatumZaposlenja, ph.Adresa, ph.Telefon, "Predstavnik za Hyundai"));
                }
                else if(pom is ServisHyundai)
                {
                    PredstavnikHyundai ph = ((ServisHyundai)pom).PredstavnikHyundai;
                    preInfos.Add(new PredstavnikInfo(ph.Id, "PredstavnikHyundai", ph.Mbr, ph.LicnoIme, ph.ImeOca, ph.Prezime, ph.DatumRodjenja, ph.DatumZaposlenja, ph.Adresa, ph.Telefon, "Predstavnik za Hyundai"));
                }
                else if(pom is SalonServisHyundai)
                {
                    PredstavnikHyundai ph = ((SalonServisHyundai)pom).PredstavnikHyundai;
                    preInfos.Add(new PredstavnikInfo(ph.Id, "PredstavnikHyundai", ph.Mbr, ph.LicnoIme, ph.ImeOca, ph.Prezime, ph.DatumRodjenja, ph.DatumZaposlenja, ph.Adresa, ph.Telefon, "Predstavnik za Hyundai"));
                }
                else if(pom is SalonKia)
                {
                    PredstavnikKia pk = ((SalonKia)pom).PredstavnikKia;
                    preInfos.Add(new PredstavnikInfo(pk.Id, "PredstavnikKia", pk.Mbr, pk.LicnoIme, pk.ImeOca, pk.Prezime, pk.DatumRodjenja, pk.DatumZaposlenja, pk.Adresa, pk.Telefon, "Predstavnik za Kiu"));
                }
                else if (pom is ServisKia)
                {
                    PredstavnikKia pk = ((ServisKia)pom).PredstavnikKia;
                    preInfos.Add(new PredstavnikInfo(pk.Id, "PredstavnikKia", pk.Mbr, pk.LicnoIme, pk.ImeOca, pk.Prezime, pk.DatumRodjenja, pk.DatumZaposlenja, pk.Adresa, pk.Telefon, "Predstavnik za Kiu"));
                }
                else if (pom is SalonServisKia)
                {
                    PredstavnikKia pk = ((SalonServisKia)pom).PredstavnikKia;
                    preInfos.Add(new PredstavnikInfo(pk.Id, "PredstavnikKia", pk.Mbr, pk.LicnoIme, pk.ImeOca, pk.Prezime, pk.DatumRodjenja, pk.DatumZaposlenja, pk.Adresa, pk.Telefon, "Predstavnik za Kiu"));
                }
                else if (pom is SalonHyundaiKia)
                {
                    PredstavnikHyundai ph = ((SalonHyundaiKia)pom).PredstavnikHyundai;
                    PredstavnikKia pk = ((SalonHyundaiKia)pom).PredstavnikKia;
                    preInfos.Add(new PredstavnikInfo(pk.Id, "PredstavnikKia", pk.Mbr, pk.LicnoIme, pk.ImeOca, pk.Prezime, pk.DatumRodjenja, pk.DatumZaposlenja, pk.Adresa, pk.Telefon, "Predstavnik za Kiu"));
                    preInfos.Add(new PredstavnikInfo(ph.Id, "PredstavnikHyundai", ph.Mbr, ph.LicnoIme, ph.ImeOca, ph.Prezime, ph.DatumRodjenja, ph.DatumZaposlenja, ph.Adresa, ph.Telefon, "Predstavnik za Hyundai"));
                }
                else if (pom is ServisHyundaiKia)
                {
                    PredstavnikHyundai ph = ((ServisHyundaiKia)pom).PredstavnikHyundai;
                    PredstavnikKia pk = ((ServisHyundaiKia)pom).PredstavnikKia;
                    preInfos.Add(new PredstavnikInfo(pk.Id, "PredstavnikKia", pk.Mbr, pk.LicnoIme, pk.ImeOca, pk.Prezime, pk.DatumRodjenja, pk.DatumZaposlenja, pk.Adresa, pk.Telefon, "Predstavnik za Kiu"));
                    preInfos.Add(new PredstavnikInfo(ph.Id, "PredstavnikHyundai", ph.Mbr, ph.LicnoIme, ph.ImeOca, ph.Prezime, ph.DatumRodjenja, ph.DatumZaposlenja, ph.Adresa, ph.Telefon, "Predstavnik za Hyundai"));
                }
                else if (pom is SalonServisHyundaiKia)
                {
                    PredstavnikHyundai ph = ((SalonServisHyundaiKia)pom).PredstavnikHyundai;
                    PredstavnikKia pk = ((SalonServisHyundaiKia)pom).PredstavnikKia;
                    preInfos.Add(new PredstavnikInfo(pk.Id, "PredstavnikKia", pk.Mbr, pk.LicnoIme, pk.ImeOca, pk.Prezime, pk.DatumRodjenja, pk.DatumZaposlenja, pk.Adresa, pk.Telefon, "Predstavnik za Kiu"));
                    preInfos.Add(new PredstavnikInfo(ph.Id, "PredstavnikHyundai", ph.Mbr, ph.LicnoIme, ph.ImeOca, ph.Prezime, ph.DatumRodjenja, ph.DatumZaposlenja, ph.Adresa, ph.Telefon, "Predstavnik za Hyundai"));
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                s.Close();
            }
            return preInfos;
        }
    }
}
