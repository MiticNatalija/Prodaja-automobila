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

           

            Id(x => x.Telefon,"TELEFON").GeneratedBy.Assigned();

            Map(x => x.Adresa, "ADRESA");
       

       
            References(x => x.vozilo).Column("VOZILO_ID");

        }
    }
}
