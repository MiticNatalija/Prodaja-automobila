using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;


namespace Desktop.Mapiranja
{
    public class PravnoLiceMapiranja : SubclassMap<PravnoLice>
    {
        public PravnoLiceMapiranja()
        {
            Table("PRAVNO_LICE");


            // Id(x => x.Pib).GeneratedBy.Assigned().Column("PIB");
            //  Id(x => x.Id).GeneratedBy.TriggerIdentity();

            KeyColumn("KUPAC_ID");

            Map(x => x.Pib, "PIB");
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Telefon, "TELEFON");

           // References(x => x.kupac).Column("KUPAC_ID");
        }
    }
}
