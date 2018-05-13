using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;

namespace Desktop.Mapiranja
{
    class SadrziMapiranja : ClassMap<Sadrzi>
    {
        public SadrziMapiranja()
        {
            Table("SADRZI");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.Knjizica).Column("KNJIZICA_ID").LazyLoad();

            References(x => x.Mehanicar).Column("MEHANICAR_ID").LazyLoad();

        }
    }
}
