using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;

namespace Desktop.Mapiranja
{
    public class PredstavnistvoMapiranja:ClassMap<Predstavnistvo>
    {

        public PredstavnistvoMapiranja()
        {
            Table("PREDSTAVNISTVO");

            

            Id(x => x.Id).GeneratedBy.TriggerIdentity();

            Map(x => x.Adresa, "ADRESA");
            Map(x => x.DatumOtvaranja, "DATUM_OTVARANJA");
            Map(x => x.FHyundai, "F_HYUNDAI");
            Map(x => x.FKia, "F_KIA");
            Map(x => x.FSalon, "F_SALON");
            Map(x => x.FServis, "F_SERVIS");


            //VEZA N:1 SE_NALAZI
            HasMany(x => x.Vozila).KeyColumn("SALON_ID").LazyLoad().Cascade.All().Inverse();
           

        }


    }
}
