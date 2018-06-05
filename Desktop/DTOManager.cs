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

namespace Desktop
{
    public class DTOManager
    {
        public static List<PredstavnistvoPregled> GetPredstavnistvoInfos()
        {
            List<PredstavnistvoPregled> odInfos = new List<PredstavnistvoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predstavnistvo> predstavnistva = from p in s.Query<Predstavnistvo>()
                                                   select p;

                foreach (Predstavnistvo p in predstavnistva)
                {
                    string tip = "Greska";
                    string tipPredstavnistva = "Greska";

                    if (p is SalonHyundai)
                    {
                        tipPredstavnistva = "Salon za Hyundai";
                        tip = "SalonHyundai";
                    }
                    else if (p is SalonKia)
                    {
                        tipPredstavnistva = "Salon za Kiu";
                        tip = "SalonKia";
                    }
                    else if (p is SalonHyundaiKia)
                    {
                        tipPredstavnistva = "Salon za Hyundai i Kiu";
                        tip = "SalonHyundaiKia";
                    }
                    else if (p is ServisHyundai)
                    {
                        tipPredstavnistva = "Servis za Hyundai";
                        tip = "ServisHyundai";
                    }
                    else if (p is ServisKia)
                    {
                        tipPredstavnistva = "Servis za Kiu";
                        tip = "ServisKia";
                    }
                    else if (p is ServisHyundaiKia)
                    {
                        tipPredstavnistva = "Servis za Hyundai i Kiu";
                        tip = "ServisHyundaiKia";
                    }
                    else if (p is SalonServisHyundai)
                    {
                        tipPredstavnistva = "Salon i Servis za Hyundai";
                        tip = "SalonServisHyundai";
                    }
                    else if (p is SalonServisKia)
                    {
                        tipPredstavnistva = "Salon i Servis za Kiu";
                        tip = "SalonServisKia";
                    }
                    else if (p is SalonServisHyundaiKia)
                    {
                        tipPredstavnistva = "Salon i Servis za Hyundai i Kiu";
                        tip = "SalonServisHyundaiKia";
                    }
                    odInfos.Add(new PredstavnistvoPregled(p.Id, tip, p.Adresa, p.DatumOtvaranja, tipPredstavnistva));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return odInfos;
        }

        public static PredstavnistvoPregled GetPredstavnistvo(int id) {
            PredstavnistvoPregled pr=new PredstavnistvoPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnistvo p = s.Load<Predstavnistvo>(id);
                pr = new PredstavnistvoPregled(p.Id, p.Adresa, p.DatumOtvaranja);


                s.Close();

            }
            catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }
            return pr;
        }

        public static void UpdatePredstavnistvo(PredstavnistvoPregled p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predstavnistvo pre = s.Load<Predstavnistvo>(p.PredstavnistvoId);
                pre.Adresa = p.Adresa;
                pre.DatumOtvaranja = p.DatumOtvaranja;
                s.Update(pre);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static void DeletePredstavnistvo(PredstavnistvoPregled p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predstavnistvo pre = s.Load<Predstavnistvo>(p.PredstavnistvoId);
               
                s.Delete(pre);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static List<ZaposleniPregled> GetZaposleniInfos()
        {
            List<ZaposleniPregled> zapInfos = new List<ZaposleniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

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

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return zapInfos;
        }
    }
}
