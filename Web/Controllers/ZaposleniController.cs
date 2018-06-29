using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Desktop.DTOManagers;
using Desktop.DTOs;
using Desktop.DataProviders;
using Desktop.Entiteti;
using Desktop.Web_DTOs;

namespace Web.Controllers
{
    public class ZaposleniController : ApiController
    {
        // GET: api/Zaposleni
        public List<ZaposleniView> Get()
        {
            DataProvider provider = new DataProvider();
            List<ZaposleniView> lista = provider.GetZaposleni();
            return lista;

        }

        // GET: api/Zaposleni/5
        public ZaposleniView Get(int id)
        {
            DataProvider provider = new DataProvider();
             return provider.GetZaposleni(id);

        }

        // POST: api/Zaposleni
    public int Post([FromBody]ZaposleniView value)
        {
            DataProvider provider = new DataProvider();
           return provider.AddZaposleni(value);
        }

        // PUT: api/Zaposleni/5
        public int Put(int id, [FromBody]ZaposleniView value)
        {

            DataProvider provider = new DataProvider();
           return provider.UpdateZaposleni(id, value);
        }

        // DELETE: api/Zaposleni/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveZaposleni(id);
        }
    }
}
