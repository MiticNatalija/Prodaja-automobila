using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;

namespace Desktop.Mapiranja
{
    class AngazujeMapiranja : ClassMap<Angazuje>
    {
        public AngazujeMapiranja()
        {
            Table("ANGAZUJE");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ocena).Column("OCENA");
            Map(x => x.DatumPocetka).Column("DATUM_POCETKA");
            Map(x => x.KrajRada).Column("KRAJ_RADA");

            //dodato su
            References(x => x.Servis).Column("SERVIS_ID").LazyLoad().Cascade.SaveUpdate();
            //dodato su
            References(x => x.Mehanicar).Column("MEHANICAR_ID").LazyLoad().Cascade.SaveUpdate();

        }
    }
}
