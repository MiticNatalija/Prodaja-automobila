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
        public static List<VoziloPregled> GetVozilaForSalon(int salonId)
        {
            List<VoziloPregled> vozInfos = new List<VoziloPregled>();
            ISession s = null;

            try
            {
                s = DataLayer.GetSession();
                Predstavnistvo predstavnistvo = (from p in s.Query<Predstavnistvo>()
                                      where p.Id == salonId
                                      select p).Single<Predstavnistvo>();

                IList<Vozilo> vozila = null;
                if(predstavnistvo is SalonHyundai)
                {
                    vozila = ((SalonHyundai)predstavnistvo).Vozila;
                }
                else if(predstavnistvo is SalonHyundaiKia)
                {
                    vozila = ((SalonHyundaiKia)predstavnistvo).Vozila;
                }
                else if (predstavnistvo is SalonKia)
                {
                    vozila = ((SalonKia)predstavnistvo).Vozila;
                }
                else if (predstavnistvo is SalonServisHyundai)
                {
                    vozila = ((SalonServisHyundai)predstavnistvo).Vozila;
                }
                else if (predstavnistvo is SalonServisKia)
                {
                    vozila = ((SalonServisKia)predstavnistvo).Vozila;
                }
                else if (predstavnistvo is SalonServisHyundaiKia)
                {
                    vozila = ((SalonServisHyundaiKia)predstavnistvo).Vozila;
                }

                foreach(Vozilo v in vozila)
                {
                    if((v is Putnicko) && v.Predstavnik == null)
                    {
                        vozInfos.Add(new VoziloPregled(v.Id, "Putnicko", v.Registracija, v.Gorivo, v.OznakaMotora, ((Putnicko)v).BrojMesta, null, "Putnicko vozilo"));
                    }
                    else if((v is Teretno) && v.Predstavnik==null)
                    {
                        vozInfos.Add(new VoziloPregled(v.Id, "Teretno", v.Registracija, v.Gorivo, v.OznakaMotora, null, ((Teretno)v).Nosivost, "Teretno vozilo"));
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

            return vozInfos;
        }

        public static void AddVozilo(VoziloPregled p)  // p ima i PredstavnistvoPregled atribut
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                Vozilo v = null;

                Predstavnistvo predstavnistvo = (from pr in s.Query<Predstavnistvo>()
                                                 where pr.Id == p.PredstavnistvoPregled.PredstavnistvoId
                                                 select pr).Single<Predstavnistvo>();

                string tip = p.TipVozila;
                if (tip.CompareTo("Putnicko vozilo") == 0)
                {
                    v = new Putnicko()
                    {
                        Registracija = p.Registracija,
                        Gorivo = p.Gorivo,
                        OznakaMotora = p.OznakaMotora,
                        BrojMesta = p.BrojMesta,
                        Salon = predstavnistvo
                        
                        
                    };
                }
                else if (tip.CompareTo("Teretno vozilo") == 0)
                {
                    v = new Teretno()
                    {
                        Registracija = p.Registracija,
                        Gorivo = p.Gorivo,
                        OznakaMotora = p.OznakaMotora,
                        Nosivost = p.Nosivost,
                        Salon= predstavnistvo
                    };
                }
               
                s.Save(v);
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

        public static VoziloPregled GetVozilo(int id)
        {
            VoziloPregled pr = null;
            ISession s = null;

            try
            {
                s = DataLayer.GetSession();

                // Vozilo p = s.Load<Vozilo>(id);
                Vozilo p = (from pv in s.Query<Vozilo>()
                                      where pv.Id == id
                                      select pv).Single<Vozilo>();

                if (p.GetType() == typeof(Putnicko))
                {
                    Putnicko pp = (Putnicko)p;
                    
                    pr = new VoziloPregled(pp.Id, "Putnicko", pp.Registracija, pp.Gorivo, pp.OznakaMotora, pp.BrojMesta, null, "Putnicko vozilo");

                }
                else if (p.GetType() == typeof(Teretno))
                {
                    Teretno pp = (Teretno)p;

                    pr = new VoziloPregled(pp.Id, "Teretno", pp.Registracija, pp.Gorivo, pp.OznakaMotora, null, pp.Nosivost, "Teretno vozilo");

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

        public static Vozilo GetVoziloVozilo(int id)
        {
            ISession s = null;
            Vozilo p = null;

            try
            {
                s = DataLayer.GetSession();

                // Vozilo p = s.Load<Vozilo>(id);
                p = (from pv in s.Query<Vozilo>()
                            where pv.Id == id
                            select pv).Single<Vozilo>();

               
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

        public static Vozilo GetVoziloPrekoRegistracije(string registracija)
        {
            ISession s = null;
            Vozilo p = null;

            try
            {
                s = DataLayer.GetSession();

                // Vozilo p = s.Load<Vozilo>(id);
                p = (from pv in s.Query<Vozilo>()
                     where pv.Registracija == registracija
                     select pv).Single<Vozilo>();


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

        public static void UpdateVozilo(VoziloPregled p)
        {
            ISession s = null;

            try
            {

                s = DataLayer.GetSession();
                // Vozilo pre = s.Load<Vozilo>(p.VoziloId);

                Vozilo pre = (from pv in s.Query<Vozilo>()
                            where pv.Id == p.VoziloId
                            select pv).Single<Vozilo>();

                if (pre.GetType() == typeof(Putnicko))
                {
                    Putnicko v = (Putnicko)pre;
                    v.Registracija = p.Registracija;
                    v.Gorivo = p.Gorivo;
                    v.BrojMesta = p.BrojMesta;
                    v.OznakaMotora = p.OznakaMotora;
                    s.Update(v);
                    s.Flush();
                }
                else if (pre.GetType() == typeof(Teretno))
                {
                    Teretno v = (Teretno)pre;
                    v.Registracija = p.Registracija;
                    v.Gorivo = p.Gorivo;
                    v.Nosivost = p.Nosivost;
                    v.OznakaMotora = p.OznakaMotora;
                    s.Update(v);
                    s.Flush();
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
        }

        public static void DeleteVozilo(int id)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                Vozilo pre = (from pv in s.Query<Vozilo>()
                              where pv.Id == id
                              select pv).Single<Vozilo>();

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

        public static void SetPredstavnikAndPopustiInVozilo(string mbr, string popustiServis, string popustiDelovi, VoziloPregled vozilo)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                //VoziloPregled vp = new VoziloPregled();
                //vp = vozilo;

                Zaposleni z = (from za in s.Query<Zaposleni>()
                               where za.Mbr == mbr
                               select za).Single<Zaposleni>();

                Vozilo v = (from va in s.Query<Vozilo>()
                               where va.Id == vozilo.VoziloId
                               select va).Single<Vozilo>();

                v.Predstavnik = z;
                v.PopustiServis = popustiServis;
                v.PopustiDelovi = popustiDelovi;

                s.Update(v);
                s.Flush();

               // return vp;
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

        public static void upisiKupca(Kupac k)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                PravnoLice p = new PravnoLice();
                p = k.PLice;

                FizickoLice f = new FizickoLice();
                f = k.FLice;

                if (p != null)
                {
                    s.Save(p);
                    s.Flush();
                }
                else if (f != null)
                {
                    s.Save(f);
                    s.Flush();
                }

                s.Save(k);
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

        public static void upisiVlasnika(Vlasnik k)
        {
            ISession s = DataLayer.GetSession();
            try
            {
               
                s.Save(k);
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
        public static void UpisiKnjizicu(Knjizica k)
        {
            ISession s = DataLayer.GetSession();
            try
            {

                s.Save(k);
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
