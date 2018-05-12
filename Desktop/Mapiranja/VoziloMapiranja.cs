﻿using System;
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
            Map(x => x.Gorivo, "GORIVO");
            Map(x => x.PopustiDelovi, "POPUSTI_DELOVI");
            Map(x => x.PopustiServis, "POPUSTI_SERVIS");

            //VEZA N:1 SE_NALAZI
            References(x => x.Salon).Column("SALON_ID").LazyLoad();
            //VEZA N:1 PRODAJE
            References(x => x.Predstavnik).Column("PREDSTAVNIK_ID").LazyLoad();

        }
    }


      class TeretnoMapiranja : SubclassMap<Teretno>
        {
            public TeretnoMapiranja()
            {
                DiscriminatorValue("Teretno");
            Map(x => x.Nosivost, "NOSIVOST");
        }
        }

    class PutnickoMapiranja : SubclassMap<Putnicko>
    {
        public PutnickoMapiranja()
        {
            DiscriminatorValue("Putnicko");
            Map(x => x.BrojMesta, "BROJ_MESTA");
        }
    }


}
