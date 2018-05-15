using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;


namespace Desktop.Mapiranja
{
    public class PravnoLiceMapiranja : ClassMap<PravnoLice>
    {
        public PravnoLiceMapiranja()
        {
            Table("PRAVNO_LICE");


             Id(x => x.Pib).Column("PIB").GeneratedBy.Assigned();
            //  Id(x => x.Id).GeneratedBy.TriggerIdentity();
            //KeyColumn("KUPAC_ID");

         //   Map(x => x.Pib, "PIB");
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Telefon, "TELEFON");
            //123
            References(x => x.Kupac).Column("KUPAC_ID").Unique();
        }
    }
}
