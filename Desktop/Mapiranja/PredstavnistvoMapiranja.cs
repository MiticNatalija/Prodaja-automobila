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

            DiscriminateSubClassesOnColumn("TIP");

            Id(x => x.Id).GeneratedBy.TriggerIdentity();

            Map(x => x.Adresa, "ADRESA");
            Map(x => x.DatumOtvaranja, "DATUM_OTVARANJA");

            //VEZA N:1 SE_NALAZI
            //HasMany(x => x.Vozila).KeyColumn("SALON_ID").LazyLoad().Cascade.All().Inverse();

        }
    }

    public class ServisKiaMapiranje:SubclassMap<ServisKia>
    {
        public ServisKiaMapiranje()
        {
            DiscriminatorValue("ServisKia");

            References(x => x.PredstavnikKia).Column("P_KIA_ID").LazyLoad();
            //HasMany(x => x.Knjizice).KeyColumn("SERVIS_ID");
        }
    }

    public class ServisHyundaiMapiranje : SubclassMap<ServisHyundai>
    {
        public ServisHyundaiMapiranje()
        {
            DiscriminatorValue("ServisHyundai");

            References(x => x.PredstavnikHyundai).Column("P_HYUNDAI_ID").LazyLoad();
            //HasMany(x => x.Knjizice).KeyColumn("SERVIS_ID");
        }
    }

    public class ServisHyundaiKiaMapiranje : SubclassMap<ServisHyundaiKia>
    {
        public ServisHyundaiKiaMapiranje()
        {
            DiscriminatorValue("ServisHyundaiKia");

            References(x => x.PredstavnikKia).Column("P_KIA_ID").LazyLoad();
            References(x => x.PredstavnikHyundai).Column("P_HYUNDAI_ID").LazyLoad();
            //HasMany(x => x.Knjizice).KeyColumn("SERVIS_ID");
        }
    }

    public class SalonKiaMapiranje : SubclassMap<SalonKia>
    {
        public SalonKiaMapiranje()
        {
            DiscriminatorValue("SalonKia");

            References(x => x.PredstavnikKia).Column("P_KIA_ID").LazyLoad();
            //HasMany(x => x.Vozila).KeyColumn("SALON_ID");
        }
    }

    public class SalonHyundaiMapiranje : SubclassMap<SalonHyundai>
    {
        public SalonHyundaiMapiranje()
        {
            DiscriminatorValue("SalonHyundai");

            Map(x => x.DatumVazenjaLicence, "DATUM_VAZENJA_LICENCE");

            References(x => x.PredstavnikHyundai).Column("P_HYUNDAI_ID").LazyLoad();
            //HasMany(x => x.Vozila).KeyColumn("SALON_ID");
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
            //HasMany(x => x.Vozila).KeyColumn("SALON_ID");
        }
    }

    public class SalonServisKiaMapiranje : SubclassMap<SalonServisKia>
    {
        public SalonServisKiaMapiranje()
        {
            DiscriminatorValue("SalonServisKia");

            References(x => x.PredstavnikKia).Column("P_KIA_ID").LazyLoad();
            //HasMany(x => x.Knjizice).KeyColumn("SERVIS_ID");
            //HasMany(x => x.Vozila).KeyColumn("SALON_ID");
        }
    }

    public class SalonServisHyundaiMapiranje : SubclassMap<SalonServisHyundai>
    {
        public SalonServisHyundaiMapiranje()
        {
            DiscriminatorValue("SalonServisHyundai");

            Map(x => x.DatumVazenjaLicence, "DATUM_VAZENJA_LICENCE");

            References(x => x.PredstavnikHyundai).Column("P_HYUNDAI_ID").LazyLoad();
            //HasMany(x => x.Knjizice).KeyColumn("SERVIS_ID");
            //HasMany(x => x.Vozila).KeyColumn("SALON_ID");
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
            //HasMany(x => x.Knjizice).KeyColumn("SERVIS_ID");
            //HasMany(x => x.Vozila).KeyColumn("SALON_ID");
        }
    }
}
