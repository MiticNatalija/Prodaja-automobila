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
        public List<KupacView> GetKupci()
        {
            List<KupacView> kupciView = new List<KupacView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Kupac> kupci = from k in s.Query<Kupac>()
                                                 select k;
                foreach (Kupac k in kupci)
                {
                    kupciView.Add(new KupacView(k));
                }

                s.Close();

                return kupciView;

            }
            catch (Exception ec)
            {
                return null;
            }

        }

        public KupacView GetKupac(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kupac k = s.Get<Kupac>(id);
                KupacView kv = null;
                if (k != null)
                {
                    kv = new KupacView(k);
                }
                s.Close();

                return kv;
            }
            catch (Exception ec)
            {
                return null;
            }

        }
        public int AddKupac(KupacView k)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kupac kt = new Kupac();

                kt.Vozilo = s.Get<Vozilo>(k.VoziloId);

                s.Save(kt);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int RemoveKupac(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kupac k = s.Load<Kupac>(id);

                s.Delete(k);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }

        }

        public int UpdateKupac(int id, KupacView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kupac k = s.Load<Kupac>(id);

                k.Vozilo = s.Get<Vozilo>(v.VoziloId);

                s.Update(k);

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
