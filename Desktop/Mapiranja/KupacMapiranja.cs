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

           // DiscriminateSubClassesOnColumn("TIP_VOZILA");

          //  Id(x => x.Id).GeneratedBy.TriggerIdentity();
            Id(x => x.Id).Column("ID").GeneratedBy.SequenceIdentity("S15764.KUPAC_ID_SEQ");

            References(x => x.Vozilo).Column("VOZILO_ID");//probaj .Unique()
            //ILI HASONE moze 
        }

    }
}
