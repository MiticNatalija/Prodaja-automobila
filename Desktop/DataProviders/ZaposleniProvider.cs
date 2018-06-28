using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop;
using Desktop.Entiteti;
using Desktop.DTOs;
using Desktop.DTOManagers;
using NHibernate;
using NHibernate.Linq;
using Desktop.Web_DTOs;


namespace Desktop.DataProviders
{
    public partial class DataProvider
    {
        public List<ZaposleniView> GetZaposleni()
        {
            List<ZaposleniView> zaposleniView = new List<ZaposleniView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Zaposleni> zaposleni = from p in s.Query<Zaposleni>()
                                                             select p;
                foreach (Zaposleni p in zaposleni)
                {
                    string tip = "Greska";

                    if (p is PredstavnikHyundai)
                    {
                        tip = "Predstavnik Hyundai";
                    }
                    else if (p is PredstavnikKia)
                    {
                        tip = "Predstavnik Kia";
                    }
                    else if (p is MehanicarHyundai)
                    {
                        tip = "Mehanicar Hyundai";
                    }
                    else if (p is MehanicarKia)
                    {
                        tip = "Mehanicar Kia";
                    }
                    
                    
                    zaposleniView.Add(new ZaposleniView(p.Id, tip, p.Mbr, p.LicnoIme, p.ImeOca, p.Prezime, p.DatumRodjenja,p.DatumZaposlenja));
                }



                s.Close();

                return zaposleniView;

            }
            catch (Exception ec)
            {
                // ec.Message;
                // return -1;
                return null;
            }

        }

        public ZaposleniView GetZaposleni(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                //  Zaposleni z = (from t in s.Query<Zaposleni>() where t.Id == id select t).Single<Zaposleni>();
                Zaposleni z = s.Get<Zaposleni>(id);
                s.Close();
                ZaposleniView zap = null;
                if (z != null)
                {
                    zap = new ZaposleniView(z);
                }

                return zap;
            }
            catch (Exception ec)
            {
                // ec.Message;
                // return -1;
                return null;
            }

        }
        public int AddZaposleni(ZaposleniView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni pr = null;

                if (p.Tip.CompareTo("Predstavnik Hyundai") == 0)
                {
                    pr = new PredstavnikHyundai();
                }
                else if (p.Tip.Equals("Predstavnik Kia"))
                {
                    pr = new PredstavnikKia();
                }
                else if (p.Tip.Equals("Mehanicar Hyundai"))
                {
                    pr = new MehanicarHyundai();
                }
                else if (p.Tip.Equals("Mehanicar Kia"))
                {
                    pr = new MehanicarKia();
                }
               
                pr.Mbr = p.Mbr;
                pr.LicnoIme = p.LicnoIme;
                pr.ImeOca = p.ImeOca;
                pr.Prezime = p.Prezime;
                pr.DatumRodjenja = p.DatumRodjenja;
                pr.DatumZaposlenja = p.DatumZaposlenja;

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
        public int RemoveZaposleni(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(id);

                s.Delete(z);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }

        }
        public int UpdateZaposleni(int id, ZaposleniView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                DateTime d = new DateTime(0001, 1, 1, 0, 0, 0);

                Zaposleni p = s.Load<Zaposleni>(id);

                if (v.Mbr != null)
                    p.Mbr = v.Mbr;
                if (v.LicnoIme != null)
                    p.LicnoIme = v.LicnoIme;
                if (v.ImeOca != null)
                    p.ImeOca = v.ImeOca;
                if (v.Prezime != null)
                    p.Prezime = v.Prezime;

                if (DateTime.Compare(v.DatumRodjenja, d) != 0)
                    p.DatumRodjenja = v.DatumRodjenja;

                if (DateTime.Compare(v.DatumZaposlenja, d) != 0)
                    p.DatumZaposlenja = v.DatumZaposlenja;

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
