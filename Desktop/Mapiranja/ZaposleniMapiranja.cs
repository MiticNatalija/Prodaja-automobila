using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;

namespace Desktop.Mapiranja
{
    class ZaposleniMapiranja : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            Table("ZAPOSLENI");

            Id(x => x.Id).GeneratedBy.TriggerIdentity();

            DiscriminateSubClassesOnColumn("TIP");

            Map(x => x.Mbr, "MBR");
            Map(x => x.LicnoIme, "LICNO_IME");
            Map(x => x.ImeOca, "IME_OCA");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.DatumZaposlenja, "DATUM_ZAPOSLENJA");
        }
    }

    class PredstavnikKiaMapiranja : SubclassMap<PredstavnikKia>
    {
        public PredstavnikKiaMapiranja()
        {
            DiscriminatorValue("PredstavnikKia");

            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Telefon, "TELEFON");
        }
    }

    class PredstavnikHyundaiMapiranja : SubclassMap<PredstavnikHyundai>
    {
        public PredstavnikHyundaiMapiranja()
        {
            DiscriminatorValue("PredstavnikHyundai");

            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Telefon, "TELEFON");
        }
    }

    class MehanicarKiaMapiranja : SubclassMap<MehanicarKia>
    {
        public MehanicarKiaMapiranja()
        {
            DiscriminatorValue("MehanciarKia");

            Map(x => x.Specijalnost, "SPECIJALNOST");
        }
    }

    class MehanicarHyundaiMapiranja : SubclassMap<MehanicarHyundai>
    {
        public MehanicarHyundaiMapiranja()
        {
            DiscriminatorValue("MehanicarHyundai");

            Map(x => x.Specijalnost, "SPECIJALNOST");
        }
    }

    class MehanicarKiaHyundaiMapiranja : SubclassMap<MehanicarKiaHyundai>
    {
        public MehanicarKiaHyundaiMapiranja()
        {
            DiscriminatorValue("MehanicarKiaHyundai");

            Map(x => x.Specijalnost, "SPECIJALNOST");
        }
    }
}
