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
            //return DTOManager.GetVozilo(43);

            DataProvider provider = new DataProvider();
            
            return provider.GetVozilo(id);

        }
        //POST: api/Vozilo
    //        {
    //	"Tip": "Putnicko",
    //	"Registracija": "nekaREG",
    //	"Gorivo": "nekoGorivo",
    //	"OznakaMotora": "nekaOznaka"
    //}
    public int Post([FromBody]VoziloView v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddVozilo(v);
        }
        //PUT: api/Vozilo/5
    // {
    //	"Registracija": "novaREG18",
    //	"OznakaMotora": "novaOznaka"
    // }
    // bilo koji od atributa registracija, gorivo, oznakaMotora
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