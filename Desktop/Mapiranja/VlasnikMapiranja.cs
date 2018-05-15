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

            //KeyColumn("VOZILO_ID");
            // Ovo bi bilo dobro kad bi moglo referenca na Vozilo da se postavi za primary key ali mrk 

            
            Id(x => x.Id).Column("ID"); // treba izmeniti relacioni i sql naredbe ako radimo ovako

            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Telefon, "TELEFON");
            
            References(x => x.Vozilo).Column("VOZILO_ID");

        }
    }
}
