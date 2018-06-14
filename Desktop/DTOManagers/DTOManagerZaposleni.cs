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

                IList < Zaposleni > mehanicari = (from a in s.Query<Angazuje>() where a.Servis == p &&(a.KrajRada==null || a.KrajRada>DateTime.Today ) select a.Mehanicar).ToList<Zaposleni>();

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
           

        public static List<MehanicarPrikaz> GetMehanicari(int id)
        {
            List<MehanicarPrikaz> zapInfos = new List<MehanicarPrikaz>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();


                List<Zaposleni> mehanicari = new List<Zaposleni>();


                IList<Angazuje> lista = (from a in s.Query<Angazuje>() where a.Servis.Id == id select a).ToList<Angazuje>();
                foreach (Angazuje a in lista)
                {
                    Zaposleni novi = (from g in s.Query<Zaposleni>() where g.Id == a.Mehanicar.Id select g).Single<Zaposleni>();
                    if(novi.Tip=="MehanicarKia")
                    {
                        
                    }
                    mehanicari.Add(novi);
                }



                foreach (Zaposleni z in mehanicari)
                {
                    string tip = "Greska";
                    string tipZaposlenog = "Greska";


                    if (z is MehanicarKia)
                    {
                        tipZaposlenog = "Mehanicar za Kiu";
                        tip = "MehanicarKia";
                        zapInfos.Add(new MehanicarPrikaz(z.Mbr, z.LicnoIme, z.ImeOca, z.Prezime,tip,tipZaposlenog));

                    }
                    else if (z is MehanicarHyundai)
                    {
                        tipZaposlenog = "Mehanicar za Hyundai";
                        tip = "MehanicarHyundai";
                        zapInfos.Add(new MehanicarPrikaz(z.Mbr, z.LicnoIme, z.ImeOca, z.Prezime, tip, tipZaposlenog));

                    }
                    else if (z is MehanicarKiaHyundai)
                    {
                        tipZaposlenog = "Mehanicar za Kiu i Hyundai";
                        tip = "MehanicarKiaHyundai";
                        zapInfos.Add(new MehanicarPrikaz(z.Mbr, z.LicnoIme, z.ImeOca, z.Prezime, tip, tipZaposlenog));

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
                    if (ph == null)
                        return preInfos;
                    preInfos.Add(new PredstavnikInfo(ph.Id, "PredstavnikHyundai", ph.Mbr, ph.LicnoIme, ph.ImeOca, ph.Prezime, ph.DatumRodjenja, ph.DatumZaposlenja, ph.Adresa, ph.Telefon, "Predstavnik za Hyundai", ph.Vozila.Count));
                }
                else if(pom is ServisHyundai)
                {
                    PredstavnikHyundai ph = ((ServisHyundai)pom).PredstavnikHyundai;
                    if (ph == null)
                        return preInfos;
                    preInfos.Add(new PredstavnikInfo(ph.Id, "PredstavnikHyundai", ph.Mbr, ph.LicnoIme, ph.ImeOca, ph.Prezime, ph.DatumRodjenja, ph.DatumZaposlenja, ph.Adresa, ph.Telefon, "Predstavnik za Hyundai", ph.Vozila.Count));
                }
                else if(pom is SalonServisHyundai)
                {
                    PredstavnikHyundai ph = ((SalonServisHyundai)pom).PredstavnikHyundai;
                    if (ph == null)
                        return preInfos;
                    preInfos.Add(new PredstavnikInfo(ph.Id, "PredstavnikHyundai", ph.Mbr, ph.LicnoIme, ph.ImeOca, ph.Prezime, ph.DatumRodjenja, ph.DatumZaposlenja, ph.Adresa, ph.Telefon, "Predstavnik za Hyundai", ph.Vozila.Count));
                }
                else if(pom is SalonKia)
                {
                    PredstavnikKia pk = ((SalonKia)pom).PredstavnikKia;
                    if (pk == null)
                        return preInfos;
                    preInfos.Add(new PredstavnikInfo(pk.Id, "PredstavnikKia", pk.Mbr, pk.LicnoIme, pk.ImeOca, pk.Prezime, pk.DatumRodjenja, pk.DatumZaposlenja, pk.Adresa, pk.Telefon, "Predstavnik za Kiu", pk.Vozila.Count));
                }
                else if (pom is ServisKia)
                {
                    PredstavnikKia pk = ((ServisKia)pom).PredstavnikKia;
                    if (pk == null)
                        return preInfos;
                    preInfos.Add(new PredstavnikInfo(pk.Id, "PredstavnikKia", pk.Mbr, pk.LicnoIme, pk.ImeOca, pk.Prezime, pk.DatumRodjenja, pk.DatumZaposlenja, pk.Adresa, pk.Telefon, "Predstavnik za Kiu", pk.Vozila.Count));
                }
                else if (pom is SalonServisKia)
                {
                    PredstavnikKia pk = ((SalonServisKia)pom).PredstavnikKia;
                    if (pk == null)
                        return preInfos;
                    preInfos.Add(new PredstavnikInfo(pk.Id, "PredstavnikKia", pk.Mbr, pk.LicnoIme, pk.ImeOca, pk.Prezime, pk.DatumRodjenja, pk.DatumZaposlenja, pk.Adresa, pk.Telefon, "Predstavnik za Kiu", pk.Vozila.Count));
                }
                else if (pom is SalonHyundaiKia)
                {
                    PredstavnikHyundai ph = ((SalonHyundaiKia)pom).PredstavnikHyundai;
                    PredstavnikKia pk = ((SalonHyundaiKia)pom).PredstavnikKia;
                    if (pk==null && ph == null)
                        return preInfos;

                    preInfos.Add(new PredstavnikInfo(pk.Id, "PredstavnikKia", pk.Mbr, pk.LicnoIme, pk.ImeOca, pk.Prezime, pk.DatumRodjenja, pk.DatumZaposlenja, pk.Adresa, pk.Telefon, "Predstavnik za Kiu", pk.Vozila.Count));
                    preInfos.Add(new PredstavnikInfo(ph.Id, "PredstavnikHyundai", ph.Mbr, ph.LicnoIme, ph.ImeOca, ph.Prezime, ph.DatumRodjenja, ph.DatumZaposlenja, ph.Adresa, ph.Telefon, "Predstavnik za Hyundai", ph.Vozila.Count));
                }
                else if (pom is ServisHyundaiKia)
                {
                    PredstavnikHyundai ph = ((ServisHyundaiKia)pom).PredstavnikHyundai;
                    PredstavnikKia pk = ((ServisHyundaiKia)pom).PredstavnikKia;
                    if (pk == null && ph == null)
                        return preInfos;
                    preInfos.Add(new PredstavnikInfo(pk.Id, "PredstavnikKia", pk.Mbr, pk.LicnoIme, pk.ImeOca, pk.Prezime, pk.DatumRodjenja, pk.DatumZaposlenja, pk.Adresa, pk.Telefon, "Predstavnik za Kiu", pk.Vozila.Count));
                    preInfos.Add(new PredstavnikInfo(ph.Id, "PredstavnikHyundai", ph.Mbr, ph.LicnoIme, ph.ImeOca, ph.Prezime, ph.DatumRodjenja, ph.DatumZaposlenja, ph.Adresa, ph.Telefon, "Predstavnik za Hyundai", ph.Vozila.Count));
                }
                else if (pom is SalonServisHyundaiKia)
                {
                    PredstavnikHyundai ph = ((SalonServisHyundaiKia)pom).PredstavnikHyundai;
                    PredstavnikKia pk = ((SalonServisHyundaiKia)pom).PredstavnikKia;
                    if (pk == null && ph == null)
                        return preInfos;
                    preInfos.Add(new PredstavnikInfo(pk.Id, "PredstavnikKia", pk.Mbr, pk.LicnoIme, pk.ImeOca, pk.Prezime, pk.DatumRodjenja, pk.DatumZaposlenja, pk.Adresa, pk.Telefon, "Predstavnik za Kiu", pk.Vozila.Count));
                    preInfos.Add(new PredstavnikInfo(ph.Id, "PredstavnikHyundai", ph.Mbr, ph.LicnoIme, ph.ImeOca, ph.Prezime, ph.DatumRodjenja, ph.DatumZaposlenja, ph.Adresa, ph.Telefon, "Predstavnik za Hyundai", ph.Vozila.Count));
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

        public static List<PredstavnikPick> GetFreeHyundaiPredstavnik()
        {
            ISession s = null;
            List<PredstavnikPick> pp = new List<PredstavnikPick>();
            try
            {
                s = DataLayer.GetSession();

                IEnumerable<PredstavnikHyundai> lista = (from ph in s.Query<PredstavnikHyundai>() where ph.Predstavnistva.Count == 0 select ph);
                foreach (PredstavnikHyundai ph in lista)
                {
                    pp.Add(new PredstavnikPick(ph.Id, ph.LicnoIme, ph.ImeOca, ph.Prezime));
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
            return pp;
        }

        public static List<PredstavnikPick> GetFreeKiaPredstavnik()
        {
            ISession s = null;
            List<PredstavnikPick> pp = new List<PredstavnikPick>();
            try
            {
                s = DataLayer.GetSession();

                IEnumerable<PredstavnikKia> lista = (from pk in s.Query<PredstavnikKia>() where pk.Predstavnistva.Count == 0 select pk);
                foreach (PredstavnikKia pk in lista)
                {
                    pp.Add(new PredstavnikPick(pk.Id, pk.LicnoIme, pk.ImeOca, pk.Prezime));
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
            return pp;
        }
        
        public static List<MehanicarOcenaPregled> GetOceneMehanicara(int predstavnikId)
        {
            ISession s = null;
            List<MehanicarOcenaPregled> mo = new List<MehanicarOcenaPregled>();
            try
            {
                s = DataLayer.GetSession();

                Zaposleni pom = (from z in s.Query<Zaposleni>()
                                      where z.Id == predstavnikId
                                 select z).Single<Zaposleni>();

                if(pom is PredstavnikHyundai)
                {
                    PredstavnikHyundai tmp = (PredstavnikHyundai)pom;
                    foreach(Testira t in tmp.TestiraMehanicari)
                    {
                        MehanicarHyundai m = (MehanicarHyundai)t.Mehanicar;
                        mo.Add(new MehanicarOcenaPregled(m.Id, m.LicnoIme, m.Prezime, "MehanicarHyundai", m.DatumRodjenja, m.DatumZaposlenja, m.Specijalnost, t.DatumTestiranja, t.Ocena));
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
            return mo;
        }
      

        public static List<MehanicarOceni> GetMehanicariForOcenjivanje(int zaposleniId)
        {
            ISession s = null;
            List<MehanicarOceni> mo = new List<MehanicarOceni>();
            try
            {
                s = DataLayer.GetSession();

                Predstavnistvo pom = (from ph in s.Query<PredstavnikHyundai>()
                                 where ph.Id == zaposleniId && ph.Predstavnistva.Count > 0
                                      select ph.Predstavnistva[0]).Single<Predstavnistvo>();

                IEnumerable<Angazuje> lista = (from a in s.Query<Angazuje>()
                                               where a.Servis.Id == pom.Id && a.KrajRada>DateTime.Today && a.Mehanicar is MehanicarHyundai
                                               select a);
                foreach(Angazuje a in lista)
                {
                    //Rad sa bazom u foreach?!
                    //Nece cast preko a.Mehanicar nego moram ovo da radim
                    MehanicarHyundai mh = (from m in s.Query<MehanicarHyundai>() where m.Id == a.Mehanicar.Id select m).Single<MehanicarHyundai>();
                    mo.Add(new MehanicarOceni(mh.Id, mh.LicnoIme, mh.Prezime, "MehanicarHyundai", mh.DatumRodjenja, mh.DatumZaposlenja, mh.Specijalnost));
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
            return mo;
        }
        public static List<MehanicarPlain> GetMehanicariUKnjizici(int id)
        {
            ISession s = null;
            List<MehanicarPlain> mehanicari=new List<MehanicarPlain>();
            try
            {
                s = DataLayer.GetSession();

                Knjizica knjizica = (from k in s.Query<Knjizica>()
                                     where k.Id == id select k).Single<Knjizica>();

                foreach(Zaposleni z in knjizica.Mehanicari)
                {
                    mehanicari.Add(new MehanicarPlain(z.Mbr, z.LicnoIme, z.ImeOca, z.Prezime));
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
            return mehanicari;
        }

        public static List<AngazovanjeMehanicaraPregled> GetAngazovanjaMehanicara(int mehanicarId)
        {
            ISession s = null;
            List<AngazovanjeMehanicaraPregled> am = new List<AngazovanjeMehanicaraPregled>();
            try
            {
                s = DataLayer.GetSession();

                IEnumerable<Angazuje> lista = (from a in s.Query<Angazuje>()
                                               where a.Mehanicar.Id == mehanicarId
                                               select a);
                foreach (Angazuje a in lista)
                {
                    am.Add(new AngazovanjeMehanicaraPregled(a.Id, a.Servis.Adresa, a.DatumPocetka, a.KrajRada, a.Ocena));
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
            return am;
        }

        public static void UpdataAngazuje(AngazovanjeMehanicaraPregled angazuje)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                Angazuje ang = (from a in s.Query<Angazuje>()
                                 where a.Id == angazuje.AngazovanjeId
                                 select a).Single<Angazuje>();

                ang.KrajRada = angazuje.KrajRada;
                ang.Ocena = angazuje.Ocena;

                s.Update(ang);
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

        public static void CreateAngazuje(int servisId, int mehanicarId, DateTime datumPocetka)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                Predstavnistvo p = (from pr in s.Query<Predstavnistvo>()
                                    where pr.Id == servisId
                                    select pr).Single<Predstavnistvo>();

                Zaposleni z = (from zp in s.Query<Zaposleni>()
                                    where zp.Id == mehanicarId
                                    select zp).Single<Zaposleni>();

                Angazuje ang = new Angazuje(datumPocetka, p, z);

                s.Save(ang);
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

        public static MehanicarOcenaPregled AddTest(int idPredstavnika,int idMehanicara,int ocena,DateTime datum)
        {
            ISession s = null;
            MehanicarOcenaPregled ocenjen = null;
            try
            {
                s = DataLayer.GetSession();
                Testira test = new Testira()
                {
                    DatumTestiranja = datum,
                    Ocena = ocena,

                };

                Zaposleni za= (from zp in s.Query<Zaposleni>()
                               where zp.Id == idMehanicara
                               select zp).Single<Zaposleni>();

           
                
                MehanicarHyundai mh=null;
                if(za is MehanicarHyundai)
                {
                    mh = (MehanicarHyundai)za;
                    test.Mehanicar = mh;
                }
               
              PredstavnikHyundai  pr= (from zp in s.Query<PredstavnikHyundai>()
                     where zp.Id == idPredstavnika
                     select zp).Single<PredstavnikHyundai>();

                test.Predstavnik = pr;

                if (test.Predstavnik == null || test.Mehanicar == null)
                    return null;

                s.Save(test);
                s.Flush();
                ocenjen = new MehanicarOcenaPregled(mh.Id,mh.LicnoIme,mh.Prezime,"MehanicarHyundai",mh.DatumRodjenja,mh.DatumZaposlenja,mh.Specijalnost,test.DatumTestiranja,test.Ocena);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                s.Close();
            }
            return ocenjen;
        }
    }
}
