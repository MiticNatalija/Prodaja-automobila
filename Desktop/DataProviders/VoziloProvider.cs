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

        //public IEnumerable<Vozilo> GetVozila()
        //{
        //    try
        //    {
        //        ISession s = DataLayer.GetSession();

        //        IEnumerable<Vozilo> vozila = s.Query<Vozilo>().Select(p => p);

        //        s.Close();


        //        return vozila;

        //    }
        //    catch (Exception ec)
        //    {
        //        // ec.Message;
        //        // return -1;
        //        return null;
        //    }
        //}
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
                    if(v is Putnicko)
                        vozilaView.Add(new VoziloView(v.Id, "Putnicko", v.Registracija, v.Gorivo, v.OznakaMotora));
                    else if (v is Teretno)
                        vozilaView.Add(new VoziloView(v.Id, "Teretno", v.Registracija, v.Gorivo, v.OznakaMotora));

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

                Vozilo voz = null;
                if (v.Tip.CompareTo("Putnicko") == 0)
                    voz = new Putnicko(v.Registracija, v.Gorivo, v.OznakaMotora);
                else if (v.Tip.CompareTo("Teretno") == 0)
                    voz = new Teretno(v.Registracija, v.Gorivo, v.OznakaMotora);

                s.Save(voz);

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
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo voz = s.Load<Vozilo>(id);

                if (v.Registracija != null)
                    voz.Registracija = v.Registracija;

                if (v.Gorivo != null)
                    voz.Gorivo = v.Gorivo;

                if (v.OznakaMotora != null)
                    voz.OznakaMotora = v.OznakaMotora;

                s.Update(voz);

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
