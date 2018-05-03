using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;

namespace Desktop.Mapiranja
{
    public class VoziloMapiranja : ClassMap<Vozilo>
    {
        public VoziloMapiranja()
        {
            Table("VOZILO");

            DiscriminateSubClassesOnColumn("TIP_VOZILA");

            Id(x => x.Id).GeneratedBy.TriggerIdentity();

            Map(x => x.Registracija, "REGISTRACIJA");
            Map(x => x.OznakaMotora, "OZNAKA_MOTORA");
            Map(x => x.TipVozila, "TIP_VOZILA");
            Map(x => x.Gorivo, "GORIVO");

        }
    }


      class TeretnoMapiranja : SubclassMap<Teretno>
        {
            public TeretnoMapiranja()
            {
                DiscriminatorValue("Teretno");
            }
        }

    class PutnickoMapiranja : SubclassMap<Putnicko>
    {
        public PutnickoMapiranja()
        {
            DiscriminatorValue("Putnicko");
        }
    }


}
