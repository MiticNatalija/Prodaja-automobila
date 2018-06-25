using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Desktop.DTOManagers;
using Desktop.DTOs;

namespace Web.Controllers
{
    public class ZaposleniController : ApiController
    {
        // GET: api/Zaposleni
        public IEnumerable<ZaposleniPregled> Get()
        {
            return new[]
            {
                new ZaposleniPregled("1231231233211", "Proba", "Api", "MehanicarKia")
            };
        }

        // GET: api/Zaposleni/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Zaposleni
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Zaposleni/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Zaposleni/5
        public void Delete(int id)
        {
        }
    }
}
