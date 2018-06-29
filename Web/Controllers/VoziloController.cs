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
    public class VoziloController : ApiController
    {
        //GET: api/Vozilo
        public List<VoziloView> Get()
        {

            DataProvider provider = new DataProvider();

            List<VoziloView> vozila = provider.GetVozila();

            return vozila;
            
        }
        // GET: api/Vozilo/5
        public VoziloView Get(int id)
        {
            DataProvider provider = new DataProvider();
            
            return provider.GetVozilo(id);

        }
        //POST: api/Vozilo
    public int Post([FromBody]VoziloView v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddVozilo(v);
        }
        //PUT: api/Vozilo/5
    public int Put(int id, [FromBody]VoziloView v)
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