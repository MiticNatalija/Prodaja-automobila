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
        public static List<PredstavnistvoPregled> GetPredstavnistvoInfos()
        {
            List<PredstavnistvoPregled> prInfos = new List<PredstavnistvoPregled>();
            ISession s = null;

            try
            {
                s = DataLayer.GetSession();
                IEnumerable<Predstavnistvo> predstavnistva = from p in s.Query<Predstavnistvo>()
                                                             select p;

                foreach (Predstavnistvo p in predstavnistva)
                {
                    string tip = "Greska";
                    string tipPredstavnistva = "Greska";
                    DateTime? datumVazenjaLicence = null;

                    if (p is SalonHyundai)
                    {
                        tipPredstavnistva = "Salon za Hyundai";
                        tip = "SalonHyundai";
                        datumVazenjaLicence = ((SalonHyundai)p).DatumVazenjaLicence;
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
                        datumVazenjaLicence = ((SalonHyundaiKia)p).DatumVazenjaLicence;
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
                        datumVazenjaLicence = ((SalonServisHyundai)p).DatumVazenjaLicence;
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
                        datumVazenjaLicence = ((SalonServisHyundaiKia)p).DatumVazenjaLicence;
                    }
                    prInfos.Add(new PredstavnistvoPregled(p.Id, tip, p.Adresa, p.DatumOtvaranja, tipPredstavnistva, datumVazenjaLicence));
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

            return prInfos;
        }

        public static PredstavnistvoPregled GetPredstavnistvo(int id)
        {
            PredstavnistvoPregled pr = null;
            ISession s = null;

            try
            {
                s = DataLayer.GetSession();

                Predstavnistvo p = (from za in s.Query<Predstavnistvo>()
                     where za.Id == id
                     select za).Single<Predstavnistvo>();
                DateTime? d=null;
                if(p.GetType()==typeof(SalonHyundai))
                {
                    SalonHyundai sa = (SalonHyundai)p;
                    d = sa.DatumVazenjaLicence;
                   
                }
                else if (p.GetType() == typeof(SalonHyundaiKia))
                {
                    SalonHyundaiKia sa = (SalonHyundaiKia)p;
                    d = sa.DatumVazenjaLicence;
                }
                else if (p.GetType() == typeof(SalonServisHyundai))
                {
                    SalonServisHyundai sa = (SalonServisHyundai)p;
                    d = sa.DatumVazenjaLicence;
                }
                else if (p.GetType() == typeof(SalonServisHyundaiKia))
                {
                    SalonServisHyundaiKia sa = (SalonServisHyundaiKia)p;
                    d = sa.DatumVazenjaLicence;
                }


                string novi = p.GetType().ToString();
                string[] niz;
                niz = novi.Split('.');
                string tip = niz[niz.Count() - 1];
                if (d != null)
                {
                    //obrada sa
                   
                 //   if (tip.Equals("SalonHyundai") || tip.Equals("SalonServisHyundai") || tip.Equals("SalonHyundaiKia") || tip.Equals("SalonServisHyundaiKia"))
                        pr = new PredstavnistvoPregled(p.Id, p.Adresa, p.DatumOtvaranja,tip,(DateTime)d);

                }

                //obrada bez
                else {

                    pr = new PredstavnistvoPregled(p.Id, p.Adresa, p.DatumOtvaranja, tip);
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

            return pr;
        }

        public static void UpdatePredstavnistvo(PredstavnistvoPregled p)
        {
            ISession s = null;

            try
            {
                s = DataLayer.GetSession();
                if (p.DatumLicence.HasValue)
                {
                    if (p.Tip.Equals("SalonHyundai"))
                    {
                        SalonHyundai sh = s.Load<SalonHyundai>(p.PredstavnistvoId);
                        sh.Adresa = p.Adresa;
                        sh.DatumOtvaranja = p.DatumOtvaranja;
                        sh.DatumVazenjaLicence = (DateTime)p.DatumLicence;
                        s.Update(sh);
                    }
                    else if (p.Tip.Equals("SalonHyundaiKia"))
                    {
                        SalonHyundaiKia sh = s.Load<SalonHyundaiKia>(p.PredstavnistvoId);
                        sh.Adresa = p.Adresa;
                        sh.DatumOtvaranja = p.DatumOtvaranja;
                        sh.DatumVazenjaLicence = (DateTime)p.DatumLicence;
                        s.Update(sh);
                    }
                    else if (p.Tip.Equals("SalonServisHyundai"))
                    {
                        SalonServisHyundai sh = s.Load<SalonServisHyundai>(p.PredstavnistvoId);
                        sh.Adresa = p.Adresa;
                        sh.DatumOtvaranja = p.DatumOtvaranja;
                        sh.DatumVazenjaLicence = (DateTime)p.DatumLicence;
                        s.Update(sh);
                    }
                    else if (p.Tip.Equals("SalonServisHyundaiKia"))
                    {
                        SalonServisHyundaiKia sh = s.Load<SalonServisHyundaiKia>(p.PredstavnistvoId);
                        sh.Adresa = p.Adresa;
                        sh.DatumOtvaranja = p.DatumOtvaranja;
                        sh.DatumVazenjaLicence = (DateTime)p.DatumLicence;
                        s.Update(sh);
                    }

                }
                else
                {
                    Predstavnistvo pre = s.Load<Predstavnistvo>(p.PredstavnistvoId);
                    pre.Adresa = p.Adresa;
                    pre.DatumOtvaranja = p.DatumOtvaranja;

                    s.Update(pre);
                }
                s.Flush();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                s.Close();
            }
        }
        public static void AddPredstavnistvo(PredstavnistvoAdd p)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                Predstavnistvo sh = null;
                
                string tip = p.TipPredstavnistva;
                if (tip.CompareTo("Salon za Hyundai") == 0)
                {
                    sh = new SalonHyundai()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja,
                        DatumVazenjaLicence = (DateTime)p.DatumLicence,
                        PredstavnikHyundai = s.Load<PredstavnikHyundai>(p.PredstavnikHyundaiId)
                    };
                }
                else if (tip.CompareTo("Salon za Kiu") == 0)
                {
                    sh = new SalonKia()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja,
                        PredstavnikKia = s.Load<PredstavnikKia>(p.PredstavnikKiaId)
                    };
                }
                else if (tip.CompareTo("Salon za Hyundai i Kiu") == 0)
                {
                    sh = new SalonHyundaiKia()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja,
                        DatumVazenjaLicence = (DateTime)p.DatumLicence,
                        PredstavnikHyundai = s.Load<PredstavnikHyundai>(p.PredstavnikHyundaiId),
                        PredstavnikKia = s.Load<PredstavnikKia>(p.PredstavnikKiaId)
                    };
                }
                else if (tip.CompareTo("Servis za Hyundai") == 0)
                {
                    sh = new ServisHyundai()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja,
                        PredstavnikHyundai = s.Load<PredstavnikHyundai>(p.PredstavnikHyundaiId)
                    };
                }
                else if (tip.CompareTo("Servis za Kiu") == 0)
                {
                    sh = new ServisKia()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja,
                        PredstavnikKia = s.Load<PredstavnikKia>(p.PredstavnikKiaId)
                    };
                }
                else if (tip.CompareTo("Servis za Hyundai i Kiu") == 0)
                {
                    sh = new ServisHyundaiKia()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja,
                        PredstavnikHyundai = s.Load<PredstavnikHyundai>(p.PredstavnikHyundaiId),
                        PredstavnikKia = s.Load<PredstavnikKia>(p.PredstavnikKiaId)
                    };
                }
                else if (tip.CompareTo("Salon i Servis za Kiu") == 0)
                {
                    sh = new SalonServisKia()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja,
                        PredstavnikKia = s.Load<PredstavnikKia>(p.PredstavnikKiaId)
                    };
                }
                else if (tip.CompareTo("Salon i Servis za Hyundai i Kiu") == 0)
                {
                    sh = new SalonServisHyundaiKia()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja,
                        DatumVazenjaLicence = (DateTime)p.DatumLicence,
                        PredstavnikHyundai = s.Load<PredstavnikHyundai>(p.PredstavnikHyundaiId),
                        PredstavnikKia = s.Load<PredstavnikKia>(p.PredstavnikKiaId)
                    };
                }
                else if (tip.CompareTo("Salon i Servis za Hyundai") == 0)
                {
                    sh = new SalonServisHyundai()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja,
                        DatumVazenjaLicence = (DateTime)p.DatumLicence,
                        PredstavnikHyundai = s.Load<PredstavnikHyundai>(p.PredstavnikHyundaiId),
                    };
                }
                s.Save(sh);
                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }
        public static void DeletePredstavnistvo(int id)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                Predstavnistvo pre = s.Load<Predstavnistvo>(id);

                s.Delete(pre);
                s.Flush();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                s.Close();
            }
        }
        public static Predstavnistvo GetPredstavnistvo(PredstavnistvoPregled pp)
        {
            ISession s = null;
            Predstavnistvo p=null;
            try
            {
                s = DataLayer.GetSession();

                 p = (from za in s.Query<Predstavnistvo>()
                               where za.Id == pp.PredstavnistvoId
                               select za).Single<Predstavnistvo>();
                //p = s.Load<Predstavnistvo>(pp.PredstavnistvoId);
                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                s.Close();
            }
            return p;
        }

        public static List<ServisPregled> GetServisi(int id)
        {
            ISession s = null;
            
            List<ServisPregled> servisi=new List<ServisPregled>();
            try
            {
                s = DataLayer.GetSession();

             List<Knjizica> k = (from kn in s.Query<Knjizica>()
                              where kn.Servis.Id == id
                              select kn).ToList<Knjizica>();
                foreach(Knjizica d in k)
                {
                    ServisPregled ser = new ServisPregled(d.Vozilo.Registracija, d.Radovi, d.CenaUsluge, d.DatumIntervencije);
                    servisi.Add(ser);
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
            return servisi;
        }

    
    }
}
