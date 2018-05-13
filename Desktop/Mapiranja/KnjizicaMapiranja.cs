using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;

namespace Desktop.Mapiranja
{
    public class KnjizicaMapiranja :ClassMap<Knjizica>
    {
        public KnjizicaMapiranja()
        {
            Table("KNJIZICA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();


            Map(x => x.DatumIntervencije, "DATUM_INTERVENCIJE");
            Map(x => x.CenaUsluge, "CENA_USLUGE");
            Map(x => x.Radovi, "RADOVI");

            References(x => x.Servis).Column("SERVIS_ID").LazyLoad();
            References(x => x.Vozilo).Column("VOZILO_ID").LazyLoad();
        }
    }
}
