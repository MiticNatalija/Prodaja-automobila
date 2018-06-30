using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using Desktop.Web_DTOs;
using Desktop;
using Desktop.DTOs;
using Desktop.DTOManagers;
using NHibernate;
using NHibernate.Linq;

namespace Desktop.DataProviders
{
    public partial class DataProvider
    {
        public List<KnjizicaView> GetKnjizice()
        {
            List<KnjizicaView> knjizice = new List<KnjizicaView>();
            try {
                ISession s = DataLayer.GetSession();

                List<Knjizica> lista = (from p in s.Query<Knjizica>()
                                       select p).ToList<Knjizica>();
                foreach(Knjizica k in lista)
                {
                    knjizice.Add(new KnjizicaView(k));
                }
                s.Close();
                return knjizice;
            }
            catch(Exception ec)
            { return null; }
        }

        public List<KnjizicaView> GetKnjizica(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<KnjizicaView> sveKnjizice = new List<KnjizicaView>();
                 List<Knjizica> knjiziceZaVozilo = (from p in s.Query<Knjizica>()
                                                    select p).ToList<Knjizica>();
                Knjizica k = s.Get<Knjizica>(id);
                s.Close();
                 foreach(Knjizica t in knjiziceZaVozilo)
                {
                    if (t.Vozilo.Id == id)
                    {
                        sveKnjizice.Add(new KnjizicaView(t));
                    }
                }
                return sveKnjizice;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddKnjizica(KnjizicaView k)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Knjizica knj = new Knjizica(k.DatumIntervencije, k.CenaUsluge, k.Radovi);
                Vozilo vo = s.Get<Vozilo>(k.IdVozila);
                Predstavnistvo pr = s.Get<Predstavnistvo>(k.IdServisa);
                if ((vo != null) && (pr!=null))
                {
                    knj.Vozilo = vo;
                    knj.Servis = pr;
                    vo.Knjizice.Add(knj);
                }

                s.Save(vo);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdateKnjizica(int id, KnjizicaView k)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Knjizica knjizica = s.Get<Knjizica>(id);
                if (k.DatumIntervencije != null)
                    knjizica.DatumIntervencije = k.DatumIntervencije;
                if (k.Radovi != null)
                    knjizica.Radovi = k.Radovi;
                knjizica.CenaUsluge = k.CenaUsluge;
                s.Update(knjizica);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveKnjizica(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Knjizica k = s.Load<Knjizica>(id);
          //      Vozilo v = s.Get<Vozilo>(k.Vozilo.Id);
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
    }
}
