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

            DiscriminateSubClassesOnColumn("").Formula("CASE WHEN(F_SALON = 0 AND F_SERVIS = 1 AND F_HYUNDAI = 0 AND F_KIA = 1) THEN 'ServisKia' WHEN(F_SALON = 0 AND F_SERVIS = 1 AND F_HYUNDAI = 1 AND F_KIA = 0) THEN 'ServisHyundai'WHEN(F_SALON = 0 AND F_SERVIS = 1 AND F_HYUNDAI = 1 AND F_KIA = 1) THEN 'ServisHyundaiKia'WHEN(F_SALON = 1 AND F_SERVIS = 0 AND F_HYUNDAI = 0 AND F_KIA = 1) THEN 'SalonKia'WHEN(F_SALON = 1 AND F_SERVIS = 0 AND F_HYUNDAI = 1 AND F_KIA = 0) THEN 'SalonHyundai'WHEN(F_SALON = 1 AND F_SERVIS = 0 AND F_HYUNDAI = 1 AND F_KIA = 1) THEN 'SalonHyundaiKia'WHEN(F_SALON = 1 AND F_SERVIS = 1 AND F_HYUNDAI = 0 AND F_KIA = 1) THEN 'SalonServisKia'WHEN(F_SALON = 1 AND F_SERVIS = 1 AND F_HYUNDAI = 1 AND F_KIA = 0) THEN 'SalonServisHyundai'WHEN(F_SALON = 1 AND F_SERVIS = 1 AND F_HYUNDAI = 1 AND F_KIA = 1) THEN 'SalonServisHyundaiKia'ELSE 'Nepoznato'END");

        }
    }

    public class ServisKiaMapiranje:SubclassMap<ServisKia>
    {
        public ServisKiaMapiranje()
        {
            DiscriminatorValue("ServisKia");

            References(x => x.PredstavnikKia).Column("P_KIA_ID").LazyLoad();
        }
    }

    public class ServisHyundaiMapiranje : SubclassMap<ServisHyundai>
    {
        public ServisHyundaiMapiranje()
        {
            DiscriminatorValue("ServisHyundai");

            References(x => x.PredstavnikHyundai).Column("P_HYUNDAI_ID").LazyLoad();
        }
    }

    public class ServisHyundaiKiaMapiranje : SubclassMap<ServisHyundaiKia>
    {
        public ServisHyundaiKiaMapiranje()
        {
            DiscriminatorValue("ServisHyundaiKia");

            References(x => x.PredstavnikKia).Column("P_KIA_ID").LazyLoad();
            References(x => x.PredstavnikHyundai).Column("P_HYUNDAI_ID").LazyLoad();
        }
    }

    public class SalonKiaMapiranje : SubclassMap<SalonKia>
    {
        public SalonKiaMapiranje()
        {
            DiscriminatorValue("SalonKia");

            References(x => x.PredstavnikKia).Column("P_KIA_ID").LazyLoad();
        }
    }

    public class SalonHyundaiMapiranje : SubclassMap<SalonHyundai>
    {
        public SalonHyundaiMapiranje()
        {
            DiscriminatorValue("SalonHyundai");

            Map(x => x.DatumVazenjaLicence, "DATUM_VAZENJA_LICENCE");

            References(x => x.PredstavnikHyundai).Column("P_HYUNDAI_ID").LazyLoad();
        }
    }

    public class SalonHyundaiKiaMapiranje : SubclassMap<SalonHyundaiKia>
    {
        public SalonHyundaiKiaMapiranje()
        {
            DiscriminatorValue("SalonHyundaiKia");

            Map(x => x.DatumVazenjaLicence, "DATUM_VAZENJA_LICENCE");

            References(x => x.PredstavnikKia).Column("P_KIA_ID").LazyLoad();
            References(x => x.PredstavnikHyundai).Column("P_HYUNDAI_ID").LazyLoad();
        }
    }

    public class SalonServisKiaMapiranje : SubclassMap<SalonServisKia>
    {
        public SalonServisKiaMapiranje()
        {
            DiscriminatorValue("SalonServisKia");

            References(x => x.PredstavnikKia).Column("P_KIA_ID").LazyLoad();
        }
    }

    public class SalonServisHyundaiMapiranje : SubclassMap<SalonServisHyundai>
    {
        public SalonServisHyundaiMapiranje()
        {
            DiscriminatorValue("SalonServisHyundai");

            Map(x => x.DatumVazenjaLicence, "DATUM_VAZENJA_LICENCE");

            References(x => x.PredstavnikHyundai).Column("P_HYUNDAI_ID").LazyLoad();
        }
    }

    public class SalonServisHyundaiKiaMapiranje : SubclassMap<SalonServisHyundaiKia>
    {
        public SalonServisHyundaiKiaMapiranje()
        {
            DiscriminatorValue("SalonServisHyundaiKia");

            Map(x => x.DatumVazenjaLicence, "DATUM_VAZENJA_LICENCE");

            References(x => x.PredstavnikHyundai).Column("P_HYUNDAI_ID").LazyLoad();
            References(x => x.PredstavnikKia).Column("P_KIA_ID").LazyLoad();
        }
    }
}
