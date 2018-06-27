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
        public IEnumerable<ZaposleniPregled> GetZaposleni()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ZaposleniPregled> zaposleni = s.Query<ZaposleniPregled>().Select(p => p);
                s.Close();

                return zaposleni;
              
            }
            catch (Exception ec)
            {
                // ec.Message;
                // return -1;
                return null;
            }

        }
        public ZaposleniPregled GetZaposleni(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZaposleniPregled z = (from t in s.Query<ZaposleniPregled>() where t.ZaposleniId == id select t).Single<ZaposleniPregled>();
                s.Close();
                return z;
            }
            catch (Exception ec)
            {
                // ec.Message;
                // return -1;
                return null;
            }

        }
        public int AddZaposleni(Zaposleni z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(z);

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
        public int UpdateZaposleni(int id, Zaposleni v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(id);
                z = v;

                s.Update(z);

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
