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

        public List<VlasnikView> GetVlasnici() {
            List<VlasnikView> vlasnici=new List<VlasnikView>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Vlasnik> lista= (from p in s.Query<Vlasnik>()
                                     select p).ToList<Vlasnik>();

                foreach(Vlasnik v in lista)
                {
                    vlasnici.Add(new VlasnikView(v));
                }
                s.Close();
                return vlasnici;
            }
            catch (Exception ec)
            {
                // ec.Message;
                // return -1;
                return null;
            }
        }
        public List<object> GetVlasnik(int id)
        {
            List<object> lista = new List<object>();
            try
            {
                ISession s = DataLayer.GetSession();

                Vlasnik vlasnik = s.Get<Vlasnik>(id);
                VlasnikView vlasnikv = null;
                if (vlasnik != null)
                {
                   vlasnikv = new VlasnikView(vlasnik);
                    lista.Add(vlasnikv);
                }
                Vozilo v = s.Get<Vozilo>(id);
                if(v!=null)
                {
                    VoziloView vo = new VoziloView(v);
                    lista.Add(vo);
                }
                s.Close();
                return lista;
            }
            catch (Exception ec)
            {
                // ec.Message;
                // return -1;
                return null;
            }
        }
        public int RemoveVlasnik(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vlasnik v = s.Load<Vlasnik>(id);

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
        public int AddVlasnik(int id,VlasnikView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Vlasnik vl = new Vlasnik(v.Telefon,v.Adresa);

                Vozilo vo = s.Get<Vozilo>(id);
                if(vo!= null)
                {
                    vl.Vozilo = vo;
                    vo.vlasnik = vl;
                }

                s.Save(vl);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateVlasnik(int id,VlasnikView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vlasnik vlasnik = s.Get<Vlasnik>(id);
                if(v.Adresa!=null)
                vlasnik.Adresa = v.Adresa;
                if(v.Telefon!=null)
                vlasnik.Telefon = v.Telefon;
                s.Update(vlasnik);
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
