using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;
using FluentNHibernate.Mapping;

namespace Desktop.Mapiranja
{
    class ZaposleniMapiranja : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            Table("ZAPOSLENI");

            Id(x => x.Id).GeneratedBy.TriggerIdentity();

            DiscriminateSubClassesOnColumn("TIP");

            Map(x => x.Mbr, "MBR");
            Map(x => x.LicnoIme, "LICNO_IME");
            Map(x => x.ImeOca, "IME_OCA");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.DatumZaposlenja, "DATUM_ZAPOSLENJA");
         
        }
    }

    class PredstavnikKiaMapiranja : SubclassMap<PredstavnikKia>
    {
        public PredstavnikKiaMapiranja()
        {
            DiscriminatorValue("PredstavnikKia");

            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Telefon, "TELEFON");
            //promenjeno su
            HasMany(x => x.Vozila).KeyColumn("PREDSTAVNIK_ID").LazyLoad().Cascade.SaveUpdate().Inverse();
            //promenjeno su
            HasMany(x => x.Predstavnistva).KeyColumn("P_KIA_ID").LazyLoad().Cascade.SaveUpdate().Inverse();
            
        }
    }

    class PredstavnikHyundaiMapiranja : SubclassMap<PredstavnikHyundai>
    {
        public PredstavnikHyundaiMapiranja()
        {
            DiscriminatorValue("PredstavnikHyundai");

            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Telefon, "TELEFON");
            HasMany(x => x.Vozila).KeyColumn("PREDSTAVNIK_ID").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.Mehanicari)
                .Table("TESTIRA")
                .ParentKeyColumn("PREDSTAVNIK_ID")
                .ChildKeyColumn("MEHANICAR_ID")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.TestiraMehanicari).KeyColumn("PREDSTAVNIK_ID").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Predstavnistva).KeyColumn("P_HYUNDAI_ID").LazyLoad().Cascade.SaveUpdate().Inverse();
        }
    }

    class MehanicarKiaMapiranja : SubclassMap<MehanicarKia>
    {
        public MehanicarKiaMapiranja()
        {
            DiscriminatorValue("MehanicarKia");

            Map(x => x.Specijalnost, "SPECIJALNOST");
            HasManyToMany(x => x.Servisi)
                .Table("ANGAZUJE")
                .ParentKeyColumn("MEHANICAR_ID")
                .ChildKeyColumn("SERVIS_ID");
               // .Inverse()             //dodato
              //  .Cascade.All();

            HasMany(x => x.AngazujeServisi).KeyColumn("MEHANICAR_ID").LazyLoad().Cascade.SaveUpdate().Inverse();

            HasManyToMany(x => x.Knjizice)
                .Table("SADRZI")
                .ParentKeyColumn("MEHANICAR_ID")
                .ChildKeyColumn("KNJIZICA_ID")
                .Inverse()          //dodato
                .Cascade.All(); 

           
        }
    }

    class MehanicarHyundaiMapiranja : SubclassMap<MehanicarHyundai>
    {
        public MehanicarHyundaiMapiranja()
        {
            DiscriminatorValue("MehanicarHyundai");

            Map(x => x.Specijalnost, "SPECIJALNOST");

            HasManyToMany(x => x.Predstavnici)
                .Table("TESTIRA")
                .ParentKeyColumn("MEHANICAR_ID")
                .ChildKeyColumn("PREDSTAVNIK_ID")
                .Cascade.All();

            HasMany(x => x.TestiraPredstavnici).KeyColumn("MEHANICAR_ID").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.Servisi)
               .Table("ANGAZUJE")
               .ParentKeyColumn("MEHANICAR_ID")
               .ChildKeyColumn("SERVIS_ID");
             //  .Inverse()   //dodato
             //  .Cascade.All();
             //promena su
            HasMany(x => x.AngazujeServisi).KeyColumn("MEHANICAR_ID").LazyLoad().Cascade.SaveUpdate().Inverse();

            HasManyToMany(x => x.Knjizice)
              .Table("SADRZI")
              .ParentKeyColumn("MEHANICAR_ID")
              .ChildKeyColumn("KNJIZICA_ID")
              .Inverse()    //dodato
              .Cascade.All();

        }
    }

    class MehanicarKiaHyundaiMapiranja : SubclassMap<MehanicarKiaHyundai>
    {
        public MehanicarKiaHyundaiMapiranja()
        {
            DiscriminatorValue("MehanicarKiaHyundai");

            Map(x => x.Specijalnost, "SPECIJALNOST");
            HasManyToMany(x => x.Servisi)
               .Table("ANGAZUJE")
               .ParentKeyColumn("MEHANICAR_ID")
               .ChildKeyColumn("SERVIS_ID")
               .Cascade.All();

            HasMany(x => x.AngazujeServisi).KeyColumn("MEHANICAR_ID").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.Knjizice)
              .Table("SADRZI")
              .ParentKeyColumn("MEHANICAR_ID")
              .ChildKeyColumn("KNJIZICA_ID")
              .Cascade.All();

        }
    }
}
