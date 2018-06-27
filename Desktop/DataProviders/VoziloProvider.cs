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


namespace Desktop.DataProviders
{
    public partial class DataProvider
    {

        public IEnumerable<VoziloPregled> GetVozila()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VoziloPregled> vozila = s.Query<VoziloPregled>().Select(p => p);
                s.Close();
                return vozila;

            }
            catch (Exception ec)
            {
                // ec.Message;
                // return -1;
                return null;
            }
        }
        public VoziloPregled GetVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                VoziloPregled v = (from t in s.Query<VoziloPregled>() where t.VoziloId == id select t).Single<VoziloPregled>();
                s.Close();
                return v;
            }
            catch (Exception ec)
            {
                // ec.Message;
                // return -1;
                return null;
            }
        }
        public int AddVozilo(Vozilo v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(v);

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
        public int UpdateVozilo(int id, Vozilo v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo voz = s.Load<Vozilo>(id);
                voz = v;

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
