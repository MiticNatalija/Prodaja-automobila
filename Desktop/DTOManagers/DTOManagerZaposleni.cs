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
        public static List<ZaposleniPregled> GetMehanicariForServis(PredstavnistvoPregled pp)
        {
            List<ZaposleniPregled> zapInfos = new List<ZaposleniPregled>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
               
                Predstavnistvo p = DTOManager.GetPredstavnistvo(pp);

                IList<Zaposleni> mehanicari = (from a in s.Query<Angazuje>() where a.Servis == p select a.Mehanicar).ToList<Zaposleni>();
                
                foreach (Zaposleni z in mehanicari)
                {
                    string tip = "Greska";
                    string tipZaposlenog = "Greska";

                    
                    if (z is MehanicarKia)
                    {
                        tipZaposlenog = "Mehanicar za Kiu";
                        tip = "MehanicarKia";
                        zapInfos.Add(new ZaposleniPregled(z.Id, tip, z.Mbr, z.LicnoIme, z.ImeOca, z.Prezime, z.DatumRodjenja, z.DatumZaposlenja, tipZaposlenog));

                    }
                    else if (z is MehanicarHyundai)
                    {
                        tipZaposlenog = "Mehanicar za Hyundai";
                        tip = "MehanicarHyundai";
                        zapInfos.Add(new ZaposleniPregled(z.Id, tip, z.Mbr, z.LicnoIme, z.ImeOca, z.Prezime, z.DatumRodjenja, z.DatumZaposlenja, tipZaposlenog));

                    }
                    else if (z is MehanicarKiaHyundai)
                    {
                        tipZaposlenog = "Mehanicar za Kiu i Hyundai";
                        tip = "MehanicarKiaHyundai";
                        zapInfos.Add(new ZaposleniPregled(z.Id, tip, z.Mbr, z.LicnoIme, z.ImeOca, z.Prezime, z.DatumRodjenja, z.DatumZaposlenja, tipZaposlenog));

                    }
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

        public static ZaposleniIzmena GetZaposleni(int id)
        {
            ISession s = null;
            ZaposleniIzmena zap=null;
            try
            {
                s = DataLayer.GetSession();
               // Zaposleni z = s.Load<Zaposleni>(id);
                Zaposleni z = (from za in s.Query<Zaposleni>()
                                                     where za.Id == id
                                                     select za).Single<Zaposleni>();

                
                string tip="";
                string spec = "";
                string adr = "";
                string tel = "";
  
                    if (z is PredstavnikKia)
                    {
                    PredstavnikKia pk = (PredstavnikKia)z;
                        tip = "PredstavnikKia";
                    tel = pk.Telefon;
                    adr = pk.Adresa;
                    }
                    else if (z is PredstavnikHyundai)
                    {
                    PredstavnikHyundai ph = (PredstavnikHyundai)z;
                        tip = "PredstavnikHyundai";
                    tel = ph.Telefon;
                    adr = ph.Adresa;
                    }
                    else if (z is MehanicarKia)
                    {
                    MehanicarKia mk = (MehanicarKia)z;
                        tip = "MehanicarKia";
                    spec = mk.Specijalnost;
                    }
                    else if (z is MehanicarHyundai)
                    {
                    MehanicarHyundai mh = (MehanicarHyundai)z;
                        tip = "MehanicarHyundai";
                    spec = mh.Specijalnost;
                    }
                   

                    zap = new ZaposleniIzmena(z.Id,tip,z.Mbr,z.LicnoIme,z.ImeOca,z.Prezime,z.DatumRodjenja,z.DatumZaposlenja,adr,tel,spec);
        

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                s.Close();
            }
            return zap;

        }

        public static Zaposleni GetZaposleni(string mbr)
        {
            ISession s = null;
            Zaposleni zap = null;
            try
            {
                s = DataLayer.GetSession();


                zap = (from za in s.Query<Zaposleni>()
                               where za.Mbr == mbr
                               select za).Single<Zaposleni>();
                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                s.Close();
            }
            return zap;

        }

        public static void UpdateZaposleni(ZaposleniIzmena z)
        {
            ISession s = null;
            
            try
            {
                s = DataLayer.GetSession();
                Zaposleni zap = (from za in s.Query<Zaposleni>()
                               where za.Id == z.PredstavnikId
                               select za).Single<Zaposleni>();

                if (zap is PredstavnikKia)
                {
                    PredstavnikKia pk = (PredstavnikKia)zap;
                    pk.Adresa = z.Adresa;
                    pk.DatumRodjenja = z.DatumRodjenja;
                    pk.DatumZaposlenja = z.DatumZaposlenja;
                    pk.ImeOca = z.ImeOca;
                    pk.LicnoIme = z.LicnoIme;
                    pk.Mbr = z.Mbr;
                    pk.Prezime = z.Prezime;
                    pk.Telefon = z.Telefon;

                    s.Update(pk);
                }
                else if (zap is PredstavnikHyundai)
                {
                    PredstavnikHyundai pk = (PredstavnikHyundai)zap;
                    pk.Adresa = z.Adresa;
                    pk.DatumRodjenja = z.DatumRodjenja;
                    pk.DatumZaposlenja = z.DatumZaposlenja;
                    pk.ImeOca = z.ImeOca;
                    pk.LicnoIme = z.LicnoIme;
                    pk.Mbr = z.Mbr;
                    pk.Prezime = z.Prezime;
                    pk.Telefon = z.Telefon;
                    s.Update(pk);

                }
                else if (zap is MehanicarKia)
                {
                    MehanicarKia pk = (MehanicarKia)zap;
                   
                    pk.DatumRodjenja = z.DatumRodjenja;
                    pk.DatumZaposlenja = z.DatumZaposlenja;
                    pk.ImeOca = z.ImeOca;
                    pk.LicnoIme = z.LicnoIme;
                    pk.Mbr = z.Mbr;
                    pk.Prezime = z.Prezime;
                    pk.Specijalnost = z.Specijalnost;
                    s.Update(pk);

                }
                else if (zap is MehanicarHyundai)
                {
                    MehanicarHyundai pk = (MehanicarHyundai)zap;
                    
                    pk.DatumRodjenja = z.DatumRodjenja;
                    pk.DatumZaposlenja = z.DatumZaposlenja;
                    pk.ImeOca = z.ImeOca;
                    pk.LicnoIme = z.LicnoIme;
                    pk.Mbr = z.Mbr;
                    pk.Prezime = z.Prezime;
                    pk.Specijalnost = z.Specijalnost;

                    s.Update(pk);
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
       /* public static void UpdateMehanicarKia(MehanicarKia mk)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();


                MehanicarKia mehk = (MehanicarKia)(from za in s.Query<Zaposleni>()
                       where za.Id == mk.Id
                       select za).Single<Zaposleni>();

                mehk = mk;

                s.SaveOrUpdate(mehk);
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
        public static void UpdateMehanicarHyundai(MehanicarHyundai mh)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();


                MehanicarHyundai mehk = (MehanicarHyundai)(from za in s.Query<Zaposleni>()
                                                   where za.Id == mh.Id
                                                   select za).Single<Zaposleni>();

                mehk = mh;

                s.SaveOrUpdate(mehk);
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
        public static void UpdateMehanicarKiaHyundai(MehanicarKiaHyundai mkh)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();


                MehanicarKiaHyundai mehk = (MehanicarKiaHyundai)(from za in s.Query<Zaposleni>()
                                                   where za.Id == mkh.Id
                                                   select za).Single<Zaposleni>();

                mehk = mkh;

                s.SaveOrUpdate(mehk);
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
        */
        public static void DeleteZaposleni(int id)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                Zaposleni zap = s.Load<Zaposleni>(id);

                s.Delete(zap);
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
        public static void AddMehanicar(MehanicarAdd m)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                if (m.Tip == "MehanicarHyundai")
                {
                    MehanicarHyundai meh = new MehanicarHyundai()
                    {
                        ImeOca=m.ImeOca,
                        LicnoIme=m.LicnoIme,
                        Prezime=m.Prezime,
                        Mbr=m.Mbr,
                        DatumRodjenja=m.DatumRodjenja,
                        DatumZaposlenja=m.DatumZaposlenja,
                        Specijalnost=m.Specijalnost
                    };
                    s.Save(meh);
                }
                else
                {
                    MehanicarKia meh = new MehanicarKia()
                    {
                        ImeOca = m.ImeOca,
                        LicnoIme = m.LicnoIme,
                        Prezime = m.Prezime,
                        Mbr = m.Mbr,
                        DatumRodjenja = m.DatumRodjenja,
                        DatumZaposlenja = m.DatumZaposlenja,
                        Specijalnost = m.Specijalnost
                    };
                    s.Save(meh);
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
        public static void AddPredstavnik(PredstavnikAdd p)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                if (p.Tip.Equals("PredstavnikKia"))
                {
                    PredstavnikKia pre=new PredstavnikKia()
                    {
                        ImeOca = p.ImeOca,
                        LicnoIme = p.LicnoIme,
                        Prezime = p.Prezime,
                        Mbr = p.Mbr,
                        DatumRodjenja = p.DatumRodjenja,
                        DatumZaposlenja = p.DatumZaposlenja,
                        Adresa=p.Adresa,
                        Telefon=p.Telefon
                    };
                    s.Save(pre);
                }
                else
                {
                    PredstavnikHyundai pre = new PredstavnikHyundai()
                    {
                        ImeOca = p.ImeOca,
                        LicnoIme = p.LicnoIme,
                        Prezime = p.Prezime,
                        Mbr = p.Mbr,
                        DatumRodjenja = p.DatumRodjenja,
                        DatumZaposlenja = p.DatumZaposlenja,
                        Adresa = p.Adresa,
                        Telefon = p.Telefon
                    };
                    s.Save(pre);
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
    }
}
