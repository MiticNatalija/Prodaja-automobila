using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using Desktop.DataProviders;
using Desktop.Entiteti;
using Desktop.Web_DTOs;

namespace Web.Controllers
{
    public class VlasnikController : ApiController
    {
        // GET: api/Vlasnik
        public List<VlasnikView> Get()
        {

            DataProvider provider = new DataProvider();
            List<VlasnikView> lista = provider.GetVlasnici(); 
            return lista;

        }

        // GET: api/Vlasnik/22
        public List<object> Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetVlasnik(id);

        }

        // POST: api/Vlasnik/5
        //kreira vlasnika jedino ako postoji vozilo sa zadatim id-em
        public int Post(int id,[FromBody]VlasnikView value)
        {
            DataProvider provider = new DataProvider();
            return provider.AddVlasnik(id,value);
        }

        // PUT: api/Vlasnik/5
        public int Put(int id, [FromBody]VlasnikView value)
        {

            DataProvider provider = new DataProvider();
            return provider.UpdateVlasnik(id, value);
        }

        // DELETE: api/Vlasnik/63
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveVlasnik(id);
        }
    }
}
