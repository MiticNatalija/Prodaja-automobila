using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using Desktop.DataProviders;
using Desktop.Entiteti;
using Desktop.Web_DTOs;

namespace Web.Controllers
{
    public class KnjizicaController:ApiController
    {
        // GET: api/Knjizica
        public List<KnjizicaView> Get()
        {

            DataProvider provider = new DataProvider();
            List<KnjizicaView> knjizice = provider.GetKnjizice();
            return knjizice;
        }

        // GET: api/Knjizica/22
        //ispisuje knjizice za vozilo sa zadatim id-em
        public List<KnjizicaView> Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetKnjizica(id);

        }

        // POST: api/Knjizica
        //kreira knjizicu jedino ako postoji vozilo i servis sa id-evima navedenim u body
        public int Post([FromBody]KnjizicaView value)
        {
            DataProvider provider = new DataProvider();
            return provider.AddKnjizica(value);
        }

        // PUT: api/Knjizica/10
        public int Put(int id, [FromBody]KnjizicaView value)
        {

            DataProvider provider = new DataProvider();
            return provider.UpdateKnjizica(id, value);
        }

        // DELETE: api/Knjizica/10
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveKnjizica(id);
        }
    }
}