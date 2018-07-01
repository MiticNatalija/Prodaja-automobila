using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using Desktop.Web_DTOs;
using NHibernate;

namespace Desktop.DataProviders
{
    public partial class DataProvider
    {
        public List<PredstavnistvoView> GetPredstavnistva()
        {
            List<PredstavnistvoView> predstavnistvaView = new List<PredstavnistvoView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Predstavnistvo> predstavnistva = from p in s.Query<Predstavnistvo>()
                                                             select p;
                foreach (Predstavnistvo p in predstavnistva)
                {
                    predstavnistvaView.Add(new PredstavnistvoView(p));
                }

                s.Close();

                return predstavnistvaView;

            }
            catch (Exception ec)
            {
                // ec.Message;
                // return -1;
                return null;
            }

        }

        public PredstavnistvoView GetPredstavnistvo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnistvo p = s.Get<Predstavnistvo>(id);
                s.Close();
                PredstavnistvoView pv = null;
                if (p != null)
                {
                    pv = new PredstavnistvoView(p);
                }

                return pv;
            }
            catch (Exception ec)
            {
                // ec.Message;
                // return -1;
                return null;
            }

        }
        public int AddPredstavnistvo(PredstavnistvoView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
               
                Predstavnistvo pr = null;
                Zaposleni zapKia = null;
                Zaposleni zapHyundai = null;
                if(p.PKiaId!=null)
                zapKia = s.Get<Zaposleni>((int)p.PKiaId);
                if(p.PHyundaiId!=null)
                zapHyundai = s.Get<Zaposleni>((int)p.PHyundaiId);

                if (p.Tip.CompareTo( "Salon Hyundai") == 0)
                {
                    pr = new SalonHyundai();
                    ((SalonHyundai)pr).DatumVazenjaLicence = (DateTime)p.DatumVazenjaLicence;
                    if (zapHyundai != null)
                    {
                        if (zapHyundai is PredstavnikHyundai)
                        {
                            ((SalonHyundai)pr).PredstavnikHyundai = (PredstavnikHyundai)zapHyundai;
                            ((PredstavnikHyundai)zapHyundai).Predstavnistva.Add(pr);
                        }
                    }
                    else ((SalonHyundai)pr).PredstavnikHyundai = null;
                }

                else if (p.Tip.Equals("Salon Kia"))
                {
                    pr = new SalonKia();
                    if (zapKia != null)
                    {
                        if (zapKia is PredstavnikKia)
                        {
                            ((SalonKia)pr).PredstavnikKia = (PredstavnikKia)zapKia;
                            ((PredstavnikKia)zapKia).Predstavnistva.Add(pr);
                        }
                    }
                    else ((SalonKia)pr).PredstavnikKia = null;
                }

                else if (p.Tip.Equals("Salon Hyundai i Kia"))
                {
                    pr = new SalonHyundaiKia();
                    ((SalonHyundaiKia)pr).DatumVazenjaLicence = (DateTime)p.DatumVazenjaLicence;
                    if (zapHyundai != null)
                    {
                        if (zapHyundai is PredstavnikHyundai)
                        {
                            ((SalonHyundaiKia)pr).PredstavnikHyundai = (PredstavnikHyundai)zapHyundai;
                            ((PredstavnikHyundai)zapHyundai).Predstavnistva.Add(pr);
                        }
                    }
                    else ((SalonHyundaiKia)pr).PredstavnikHyundai = null;

                    if (zapKia != null)
                    {
                        if (zapKia is PredstavnikKia)
                        {
                            ((SalonHyundaiKia)pr).PredstavnikKia = (PredstavnikKia)zapKia;
                            ((PredstavnikKia)zapKia).Predstavnistva.Add(pr);
                        }
                    }
                    else ((SalonHyundaiKia)pr).PredstavnikKia = null;
                }
                else if (p.Tip.Equals("Servis Hyundai"))
                {
                    pr = new ServisHyundai();
                    if (zapHyundai != null)
                    {
                        if (zapHyundai is PredstavnikHyundai)
                        {
                            ((ServisHyundai)pr).PredstavnikHyundai = (PredstavnikHyundai)zapHyundai;
                            ((PredstavnikHyundai)zapHyundai).Predstavnistva.Add(pr);
                        }
                    }
                    else ((ServisHyundai)pr).PredstavnikHyundai = null;
                }

                else if (p.Tip.Equals("Servis Kia"))
                {
                    pr = new ServisKia();
                    if (zapKia != null)
                    {
                        if (zapKia is PredstavnikKia)
                        {
                            ((ServisKia)pr).PredstavnikKia = (PredstavnikKia)zapKia;
                            ((PredstavnikKia)zapKia).Predstavnistva.Add(pr);
                        }
                    }
                    else ((ServisKia)pr).PredstavnikKia = null;
                }
                else if (p.Tip.Equals("Servis Hyundai i Kia"))
                {
                    pr = new ServisHyundaiKia();
                    if (zapHyundai != null)
                    {
                        if (zapHyundai is PredstavnikHyundai)
                        {
                            ((ServisHyundaiKia)pr).PredstavnikHyundai = (PredstavnikHyundai)zapHyundai;
                            ((PredstavnikHyundai)zapHyundai).Predstavnistva.Add(pr);
                        }
                    }
                    else ((ServisHyundaiKia)pr).PredstavnikHyundai = null;

                    if (zapKia != null)
                    {
                        if (zapKia is PredstavnikKia)
                        {
                            ((ServisHyundaiKia)pr).PredstavnikKia = (PredstavnikKia)zapKia;
                            ((PredstavnikKia)zapKia).Predstavnistva.Add(pr);
                        }
                    }
                    else ((ServisHyundaiKia)pr).PredstavnikKia = null;
                }
                else if (p.Tip.CompareTo("Salon i Servis Hyundai") == 0)
                {
                    pr = new SalonServisHyundai();
                    ((SalonServisHyundai)pr).DatumVazenjaLicence = (DateTime)p.DatumVazenjaLicence;
                }
                else if (p.Tip.Equals("Salon i Servis Kia"))
                {
                    pr = new SalonServisKia();
                    if (zapKia != null)
                    {
                        if (zapKia is PredstavnikKia)
                        {
                            ((SalonServisKia)pr).PredstavnikKia = (PredstavnikKia)zapKia;
                            ((PredstavnikKia)zapKia).Predstavnistva.Add(pr);
                        }
                    }
                    else ((SalonServisKia)pr).PredstavnikKia = null;
                }
                else if (p.Tip.Equals("Salon i Servis Hyundai i Kia"))
                {
                    pr = new SalonServisHyundaiKia();
                    ((SalonServisHyundaiKia)pr).DatumVazenjaLicence = (DateTime)p.DatumVazenjaLicence;
                    if (zapHyundai != null)
                    {
                        if (zapHyundai is PredstavnikHyundai)
                        {
                            ((SalonServisHyundaiKia)pr).PredstavnikHyundai = (PredstavnikHyundai)zapHyundai;
                            ((PredstavnikHyundai)zapHyundai).Predstavnistva.Add(pr);
                        }
                    }
                    else ((SalonServisHyundaiKia)pr).PredstavnikHyundai = null;

                    if (zapKia != null)
                    {
                        if (zapKia is PredstavnikKia)
                        {
                            ((SalonServisHyundaiKia)pr).PredstavnikKia = (PredstavnikKia)zapKia;
                            ((PredstavnikKia)zapKia).Predstavnistva.Add(pr);
                        }
                    }
                    else ((SalonServisHyundaiKia)pr).PredstavnikKia = null;
                }

                pr.Adresa = p.Adresa;
                pr.DatumOtvaranja = p.DatumOtvaranja;

                s.Save(pr);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int RemovePredstavnistvo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnistvo p = s.Load<Predstavnistvo>(id);

                s.Delete(p);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }

        }
       
        public int UpdatePredstavnistvo(int id, PredstavnistvoView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                DateTime d = new DateTime(0001,1,1,0,0,0);

                Predstavnistvo p = s.Load<Predstavnistvo>(id);

                if(v.Adresa != null)
                    p.Adresa = v.Adresa;

                if(DateTime.Compare(v.DatumOtvaranja, d) != 0)
                    p.DatumOtvaranja = v.DatumOtvaranja;

                s.Update(p);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }

        }
    }
}
