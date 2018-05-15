using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;

namespace Desktop.Mapiranja
{
   public class KupacMapiranja: ClassMap<Kupac>
    {
        public KupacMapiranja()
        {
            Table("KUPAC");

            //DiscriminateSubClassesOnColumn("TIP_VOZILA");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            //  Id(x => x.Id).Column("ID").GeneratedBy.SequenceIdentity("S15794.KUPAC_ID_SEQ");


            //123
            References(x => x.Vozilo).Column("VOZILO_ID").LazyLoad();//.Unique();  //ovo treba,nego samo zbog probe je pod komentarom
            HasOne(x => x.FLice).PropertyRef(x => x.Kupac).Cascade.All();
            HasOne(x => x.PLice).PropertyRef(x => x.Kupac).Cascade.All();

        }

    }
}
