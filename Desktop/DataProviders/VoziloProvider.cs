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

      
        public List<VoziloView> GetVozila()
        {
            List<VoziloView> vozilaView = new List<VoziloView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozilo> vozila = from p in s.Query<Vozilo>()
                                                             select p;
                foreach (Vozilo v in vozila)
                {
                    if (v is Putnicko)
                    {
                        Putnicko pom = (Putnicko)v;
                        VoziloView vo = new VoziloView(v.Id, "Putnicko", v.Registracija, v.Gorivo, v.OznakaMotora);
                        vo.BrojMesta = pom.BrojMesta;
                        vozilaView.Add(vo);
                    }
                    else if (v is Teretno)
                    {
                        Teretno pom = (Teretno)v;
                        vozilaView.Add(new VoziloView(v.Id, "Teretno", v.Registracija, v.Gorivo, v.OznakaMotora,pom.Nosivost));
                    }

                }
                s.Close();


                return vozilaView;

            }
            catch (Exception ec)
            {
                // ec.Message;
                // return -1;
                return null;
            }
        }
        public VoziloView GetVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
              //  Vozilo v = (from t in s.Query<Vozilo>() where t.Id == id select t).Single<Vozilo>();
                Vozilo v = s.Get<Vozilo>(id);
                s.Close();
                VoziloView toret = null;
                if (v != null)
                {
                    toret = new VoziloView(v);
                    if (v is Teretno)
                    {
                        Teretno pom = (Teretno)v;
                        toret.Nosivost = pom.Nosivost;
                    }
                    else if(v is Putnicko)
                    {
                        Putnicko pom = (Putnicko)v;
                        toret.BrojMesta = pom.BrojMesta;
                    }
                }
                return toret;
            }
            catch (Exception ec)
            {
                // ec.Message;
                // return -1;
                return null;
            }
        }
        public int AddVozilo(VoziloView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                if (v.Tip.CompareTo("Putnicko") == 0)
                {
                    Putnicko pu = new Putnicko(v.Registracija, v.Gorivo, v.OznakaMotora, v.BrojMesta);
                    s.Save(pu);

                }

                else if (v.Tip.CompareTo("Teretno") == 0)
                {

                    Teretno te = new Teretno(v.Registracija, v.Gorivo, v.OznakaMotora, v.Nosivost);
                    s.Save(te);
                   // voz = new Teretno(v.Registracija, v.Gorivo, v.OznakaMotora);
                }

              //  s.Save(voz);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int RemoveVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Load<Vozilo>(id);

                s.Delete(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }

        }
        public int UpdateVozilo(int id, VoziloView v)
        {
            int pov = -1;
            try
            {
                ISession s = DataLayer.GetSession();

                //   Vozilo voz = s.Load<Vozilo>(id);
                Vozilo voz = (from t in s.Query<Vozilo>() where t.Id == id select t).Single<Vozilo>();
                if (voz is Putnicko)
                {
                   
                    Putnicko pu = (Putnicko)voz;
                    if (v.Registracija != null)
                        pu.Registracija = v.Registracija;
                    if (v.Gorivo != null)
                        pu.Gorivo = v.Gorivo;
                    if (v.OznakaMotora != null)
                        pu.OznakaMotora = v.OznakaMotora;
                    if (v.BrojMesta != null)
                        pu.BrojMesta = v.BrojMesta;
                    s.Update(pu);
                    pov = 1;
       
                }
                else if(voz is Teretno)
                {
                    Teretno te = (Teretno)voz;
                    if (v.Registracija != null)
                        te.Registracija = v.Registracija;

                    if (v.Gorivo != null)
                        te.Gorivo = v.Gorivo;

                    if (v.OznakaMotora != null)
                        te.OznakaMotora = v.OznakaMotora;

                    if (v.Nosivost != null)
                        te.Nosivost = v.Nosivost;
                    s.Update(te);
                    pov = 1;
                }

              //  s.Update(voz);

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
