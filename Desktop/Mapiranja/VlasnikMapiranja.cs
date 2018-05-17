using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;

namespace Desktop.Mapiranja
{
   public class VlasnikMapiranja:ClassMap<Vlasnik>
    {
        public VlasnikMapiranja()
        {
            Table("VLASNIK");

            Id(x => x.Id).Column("VOZILO_ID").GeneratedBy.Foreign("Vozilo");
            HasOne(x => x.Vozilo).Constrained();

            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Telefon, "TELEFON");
        }
    }
}
