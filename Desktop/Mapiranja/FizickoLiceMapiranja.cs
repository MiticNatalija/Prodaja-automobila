using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;

namespace Desktop.Mapiranja
{
    public class FizickoLiceMapiranja:ClassMap<FizickoLice> 
    {
        public FizickoLiceMapiranja()
        {
            Table("FIZICKO_LICE");

            Id(x => x.Jmbg).Column("JMBG").GeneratedBy.Assigned();

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Telefon, "TELEFON");

            References(x => x.Kupac).Column("KUPAC_ID").Unique().Cascade.All(); 
        }
    }
}
