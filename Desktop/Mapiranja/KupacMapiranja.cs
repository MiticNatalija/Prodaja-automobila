using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;

namespace Desktop.Mapiranja
{
   public class KupacMapiranja: ClassMap<Kupac>
    {
        public KupacMapiranja()
        {
            Table("KUPAC");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            References(x => x.Vozilo).Column("VOZILO_ID").LazyLoad().Unique();
            HasOne(x => x.FLice).PropertyRef(x => x.Kupac).Cascade.All();
            HasOne(x => x.PLice).PropertyRef(x => x.Kupac).Cascade.All();

        }

    }
}
