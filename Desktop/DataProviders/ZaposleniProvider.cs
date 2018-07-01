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
                foreach (Zaposleni z in zaposleni)
                {
                 
                    ZaposleniView zap = new ZaposleniView(z);
                    if (z is PredstavnikKia)
                    {
                        PredstavnikKia pk = (PredstavnikKia)z;
                        zap.Adresa = pk.Adresa;
                        zap.Telefon = pk.Telefon;
                    }
                    else if (z is PredstavnikHyundai)
                    {
                        PredstavnikHyundai ph = (PredstavnikHyundai)z;
                        zap.Adresa = ph.Adresa;
                        zap.Telefon = ph.Telefon;

                    }
                    else if (z is MehanicarKia)
                    {
                        MehanicarKia mk = (MehanicarKia)z;
                        zap.Specijalnost = mk.Specijalnost;
                      
                    }
                    else if (z is MehanicarHyundai)
                    {
                        MehanicarHyundai mh = (MehanicarHyundai)z;
                        zap.Specijalnost = mh.Specijalnost;
                    }
                    zaposleniView.Add(zap);
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
                List<Vozilo> vozila = (from t in s.Query<Vozilo>() where t.Predstavnik.Id == z.Id select t).ToList<Vozilo>();
                List<Predstavnistvo> pred = (from p in s.Query<Predstavnistvo>()
                                             select p).ToList<Predstavnistvo>();
              
                ZaposleniView zap = null;
                if (z != null)
                {
                    zap = new ZaposleniView(z);
                    if (z is PredstavnikKia)
                    {
                        PredstavnikKia pk = (PredstavnikKia)z;
                        zap.Adresa = pk.Adresa;
                        zap.Telefon = pk.Telefon;
                    }
                    else if (z is PredstavnikHyundai)
                    {
                        PredstavnikHyundai ph = (PredstavnikHyundai)z;
                        zap.Adresa = ph.Adresa;
                        zap.Telefon = ph.Telefon;

                    }
                    else if (z is MehanicarKia)
                    {
                        MehanicarKia mk = (MehanicarKia)z;
                        zap.Specijalnost = mk.Specijalnost;

                    }
                    else if (z is MehanicarHyundai)
                    {
                        MehanicarHyundai mh = (MehanicarHyundai)z;
                        zap.Specijalnost = mh.Specijalnost;
                    }
                    foreach (Vozilo v in vozila)
                    {
                        zap.VozilaId.Add(v.Id);
                    }


                    foreach (Predstavnistvo p in pred)
                    {

                        if (p is SalonHyundai)
                        {
                            SalonHyundai sh = (SalonHyundai)p;
                            if (sh.PredstavnikHyundai != null)
                                if (sh.PredstavnikHyundai.Id == zap.ZaposleniId)
                                {
                                    zap.PredstavnistvoId = sh.Id;
                                    break;
                                }
                        }
                      else  if (p is SalonKia)
                        {
                            SalonKia sh = (SalonKia)p;
                            if (sh.PredstavnikKia != null)
                                if (sh.PredstavnikKia.Id == zap.ZaposleniId)
                                {
                                    zap.PredstavnistvoId = sh.Id;
                                    break;
                                }
                        }
                        else if (p is SalonHyundaiKia)
                        {

                            SalonHyundaiKia sh = (SalonHyundaiKia)p;
                            if (sh.PredstavnikKia != null)
                            {
                                if (sh.PredstavnikKia.Id == zap.ZaposleniId)
                                {
                                    zap.PredstavnistvoId = sh.Id;
                                    break;
                                }
                            }
                           
                            
                                if (sh.PredstavnikHyundai != null)
                                    if (sh.PredstavnikHyundai.Id == zap.ZaposleniId)
                                    {
                                        zap.PredstavnistvoId = sh.Id;
                                        break;
                                    }
                            


                        }
                        else if (p is ServisHyundai)
                        {

                            ServisHyundai sh = (ServisHyundai)p;
                            if (sh.PredstavnikHyundai != null)
                                if (sh.PredstavnikHyundai.Id == zap.ZaposleniId)
                                {
                                    zap.PredstavnistvoId = sh.Id;

                                    break;
                                }

                        }
                        else if (p is ServisKia)
                        {
                            ServisKia sh = (ServisKia)p;
                            if (sh.PredstavnikKia != null)
                                if (sh.PredstavnikKia.Id == zap.ZaposleniId)
                                {
                                    zap.PredstavnistvoId = sh.Id;
                                    break;
                                }
                        }
                        else if (p is ServisHyundaiKia)
                        {
                            ServisHyundaiKia sh = (ServisHyundaiKia)p;
                            if (sh.PredstavnikKia != null)
                            {
                                if (sh.PredstavnikKia.Id == zap.ZaposleniId)
                                {
                                    zap.PredstavnistvoId = sh.Id;
                                    break;
                                }
                            }
                            if (sh.PredstavnikHyundai != null)
                            
                                if (sh.PredstavnikHyundai.Id == zap.ZaposleniId)
                                {
                                    zap.PredstavnistvoId = sh.Id;
                                    break;
                                }
                            
                        }
                        else if (p is SalonServisHyundai)
                        {
                            SalonServisHyundai sh = (SalonServisHyundai)p;
                            if (sh.PredstavnikHyundai != null)
                                if (sh.PredstavnikHyundai.Id == zap.ZaposleniId)
                                {
                                    zap.PredstavnistvoId = sh.Id;
                                    break;
                                }
                        }
                        else if (p is SalonServisKia)
                        {
                            SalonServisKia sh = (SalonServisKia)p;
                            if (sh.PredstavnikKia != null)
                                if (sh.PredstavnikKia.Id == zap.ZaposleniId)
                                {
                                    zap.PredstavnistvoId = sh.Id;
                                    break;
                                }

                        }
                        else if (p is SalonServisHyundaiKia)
                        {
                            SalonServisHyundaiKia sh = (SalonServisHyundaiKia)p;
                            if (sh.PredstavnikKia != null)
                            {
                                if (sh.PredstavnikKia.Id == zap.ZaposleniId)
                                {
                                    zap.PredstavnistvoId = sh.Id;
                                    break;
                                }
                            }
                            if (sh.PredstavnikHyundai != null)
                            
                                if (sh.PredstavnikHyundai.Id == zap.ZaposleniId)
                                {
                                    zap.PredstavnistvoId = sh.Id;
                                    break;
                                }
                            
                        }
                       
                    }

                }
                s.Close();
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

       
                if (p.Tip.CompareTo("Predstavnik Hyundai") == 0)
                {
                    PredstavnikHyundai ph = new PredstavnikHyundai(p.Mbr,p.LicnoIme,p.ImeOca,p.Prezime,(DateTime)p.DatumRodjenja,(DateTime)p.DatumZaposlenja,p.Adresa,p.Telefon); 
                    s.Save(ph);
                    
                }
                else if (p.Tip.Equals("Predstavnik Kia"))
                {
                    PredstavnikKia pk = new PredstavnikKia(p.Mbr, p.LicnoIme, p.ImeOca, p.Prezime, (DateTime)p.DatumRodjenja, (DateTime)p.DatumZaposlenja, p.Adresa, p.Telefon);
                    s.Save(pk);
                }
                else if (p.Tip.Equals("Mehanicar Hyundai"))
                {
                    MehanicarHyundai mh = new MehanicarHyundai(p.Mbr, p.LicnoIme, p.ImeOca, p.Prezime, (DateTime)p.DatumRodjenja, (DateTime)p.DatumZaposlenja, p.Specijalnost);
                    s.Save(mh);
                }
                else if (p.Tip.Equals("Mehanicar Kia"))
                {
                    MehanicarKia mk = new MehanicarKia(p.Mbr, p.LicnoIme, p.ImeOca, p.Prezime, (DateTime)p.DatumRodjenja, (DateTime)p.DatumZaposlenja, p.Specijalnost);
                    s.Save(mk);
                }
               
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
            int pov = -1;
            try
            {
                ISession s = DataLayer.GetSession();
             //   DateTime d = new DateTime(0001, 1, 1, 0, 0, 0);

                Zaposleni p = s.Get<Zaposleni>(id);
              
                if (v.Mbr != null)
                    p.Mbr = v.Mbr;
                if (v.LicnoIme != null)
                    p.LicnoIme = v.LicnoIme;
                if (v.ImeOca != null)
                    p.ImeOca = v.ImeOca;
                if (v.Prezime != null)
                    p.Prezime = v.Prezime;

                //if (DateTime.Compare(v.DatumRodjenja, d) != 0)
                //    p.DatumRodjenja = v.DatumRodjenja;

                //if (DateTime.Compare(v.DatumZaposlenja, d) != 0)
                //    p.DatumZaposlenja = v.DatumZaposlenja;

                if (v.DatumRodjenja != null)
                    p.DatumRodjenja =(DateTime) v.DatumRodjenja;
                if (v.DatumZaposlenja != null)
                    p.DatumZaposlenja = (DateTime)v.DatumZaposlenja;


                if (p is PredstavnikKia)
                {
                    PredstavnikKia pk = (PredstavnikKia)p;
                    if(v.Adresa!=null)
                    pk.Adresa = v.Adresa;
                    if(v.Telefon!=null)
                    pk.Telefon = v.Telefon;
                    s.Update(pk);
                    pov = 1;
                }
                else if (p is PredstavnikHyundai)
                {
                    PredstavnikHyundai ph = (PredstavnikHyundai)p;
                    if(v.Adresa!= null)
                    ph.Adresa = v.Adresa;
                    ph.Telefon = v.Telefon;
                    s.Update(ph);
                    pov = 1;
                }
                else if (p is MehanicarKia)
                {
                    MehanicarKia mk = (MehanicarKia)p;
                    if(v.Specijalnost!=null)
                    mk.Specijalnost = v.Specijalnost;
                    s.Update(mk);
                    pov = 1;
                }
                else if (p is MehanicarHyundai)
                {
                    MehanicarHyundai mh = (MehanicarHyundai)p;
                    if(v.Specijalnost!=null)
                    mh.Specijalnost = v.Specijalnost;
                    s.Update(mh);
                    pov = 1;
                }


               // s.Update(p);

                s.Flush();
                s.Close();

                return pov;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
    }
}
