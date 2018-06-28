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
    public class PredstavnistvoController : ApiController
    {
        // GET: api/Predstavnistvo
        public List<PredstavnistvoView> Get()
        {
            //return new[]
            //{
            //    new ZaposleniPregled("1231231233211", "Proba", "Api", "MehanicarKia")
            //};
            DataProvider provider = new DataProvider();
            List<PredstavnistvoView> lista = provider.GetPredstavnistva();  // mozda ipak PredstavnistvoView ?
            return lista;

        }

        // GET: api/Predstavnistvo/22
        public PredstavnistvoView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetPredstavnistvo(id);

        }

        // POST: api/Predstavnistvo
    //   {
    //    "Tip": "Salon i Servis Hyundai",
    //    "Adresa": "Bulevar Djindjica 87",
    //    "DatumOtvaranja": "2018-06-28T00:00:00"
    //   }
    public int Post([FromBody]PredstavnistvoView value)
        {
            DataProvider provider = new DataProvider();
            return provider.AddPredstavnistvo(value);
        }

        // PUT: api/Predstavnistvo/5
        //   {
        //    "Adresa": "Bulevar Djindjica 87",
        //    "DatumOtvaranja": "2018-06-28T00:00:00"
        //   }
        // ili samo neki od ova 2 atributa
        public int Put(int id, [FromBody]PredstavnistvoView value)
        {

            DataProvider provider = new DataProvider();
            return provider.UpdatePredstavnistvo(id, value);
        }

        // DELETE: api/Predstavnistvo/63
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemovePredstavnistvo(id);
        }
    }
}