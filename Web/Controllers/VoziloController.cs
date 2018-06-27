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


namespace Web.Controllers
{
    public class VoziloController : ApiController
    {
        //GET: api/Vozilo
        public IEnumerable<VoziloPregled> Get()
        {

            DataProvider provider = new DataProvider();

            IEnumerable<VoziloPregled> vozila = provider.GetVozila();

            return vozila;
        }
        // GET: api/Vozilo/5
        public VoziloPregled Get(int id)
        {
            //return DTOManager.GetVozilo(43);

            DataProvider provider = new DataProvider();

            return provider.GetVozilo(id);
        }
        //POST: api/Vozilo
        public int Post([FromBody]Vozilo v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddVozilo(v);
        }
        //PUT: api/Vozilo/5
        public int Put(int id, [FromBody]Vozilo v)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateVozilo(id, v);
        }

        // DELETE api/Vozilo/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveVozilo(id);
        }
    }
}