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

            DiscriminateSubClassesOnColumn("").Formula("CASE WHEN(F_SALON = 0 AND F_SERVIS = 1 AND F_HYUNDAI = 0 AND F_KIA = 1) THEN 'ServisKia'WHEN(F_SALON = 0 AND F_SERVIS = 1 AND F_HYUNDAI = 1 AND F_KIA = 0) THEN 'ServisHyundai'WHEN(F_SALON = 0 AND F_SERVIS = 1 AND F_HYUNDAI = 1 AND F_KIA = 1) THEN 'ServisHyundaiKia'WHEN(F_SALON = 1 AND F_SERVIS = 0 AND F_HYUNDAI = 0 AND F_KIA = 1) THEN 'SalonKia'WHEN(F_SALON = 1 AND F_SERVIS = 0 AND F_HYUNDAI = 1 AND F_KIA = 0) THEN 'SalonHyundai'WHEN(F_SALON = 1 AND F_SERVIS = 0 AND F_HYUNDAI = 1 AND F_KIA = 1) THEN 'SalonHyundaiKia'WHEN(F_SALON = 1 AND F_SERVIS = 1 AND F_HYUNDAI = 0 AND F_KIA = 1) THEN 'SalonServisKia'WHEN(F_SALON = 1 AND F_SERVIS = 1 AND F_HYUNDAI = 1 AND F_KIA = 0) THEN 'SalonServisHyundai'WHEN(F_SALON = 1 AND F_SERVIS = 1 AND F_HYUNDAI = 1 AND F_KIA = 1) THEN 'SalonServisHyundaiKia'ELSE 'Nepoznato'END");

        }
    }

    public class ServisKiaMapiranje:SubclassMap<ServisKia>
    {
        public ServisKiaMapiranje()
        {
            DiscriminatorValue("ServisKia");
            //PredstavnikKia ne adresa
            Map(x => x.Adresa, "ADRESA");
        }
    }

    public class ServisHyundaiMapiranje : SubclassMap<ServisKia>
    {
        public ServisHyundaiMapiranje()
        {
            DiscriminatorValue("ServisHyundai");
        }
    }
}
