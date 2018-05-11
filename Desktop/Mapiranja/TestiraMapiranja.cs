using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;

namespace Desktop.Mapiranja
{
    class TestiraMapiranja : ClassMap<Testira>
    {
        public TestiraMapiranja()
        {
            Table("TESTIRA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ocena).Column("OCENA");
            Map(x => x.DatumTestiranja).Column("DATUM_TESTIRANJA");

            References(x => x.Predstavnik).Column("PREDSTAVNIK_ID").LazyLoad();

            References(x => x.Mehanicar).Column("MEHANICAR_ID").LazyLoad();
        }
    }
}
