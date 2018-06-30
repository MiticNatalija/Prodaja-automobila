using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Desktop.DataProviders;
using Desktop.Entiteti;
using Desktop.Web_DTOs;
using System.Web.Http;

namespace Web.Controllers
{
    public class KupacController : ApiController
    {
        // GET: api/Kupac
        public List<KupacView> Get()
        {
            DataProvider provider = new DataProvider();
            List<KupacView> lista = provider.GetKupci();
            return lista;
        }

        // GET: api/Kupac/5
        public KupacView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetKupac(id);
        }

        // POST: api/Kupac
        public int Post([FromBody]KupacView value)
        {
            DataProvider provider = new DataProvider();
            return provider.AddKupac(value);
        }

        // PUT: api/Kupac/5
        public int Put(int id, [FromBody]KupacView value)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateKupac(id, value);
        }

        // DELETE: api/Kupac/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveKupac(id);
        }
    }
}
