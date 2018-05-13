using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Desktop.Entiteti;

namespace Desktop
{
    public partial class btnVezaSeNalazi : Form
    {
        public btnVezaSeNalazi()
        {
            InitializeComponent();
        }

        private void btnUcitajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
             
                Entiteti.Putnicko p = new Entiteti.Putnicko()

                {
                    Registracija = "NI 789 PO",
                    Gorivo = "Dizel",
                    OznakaMotora = "127898456",
                    BrojMesta = 4
                };

                //Teretno t = new Teretno()
                //{
                //    Gorivo = "Dizel",
                //    OznakaMotora = "123456789",
                //    Registracija = "BG 445 KJ",
                //    TipVozila = "Teretno",
                //    Nosivost = 1500
                //};


                Vozilo r = s.Load<Vozilo>(1);
             //   Putnicko r1 = s.Load<Putnicko>(1);

                MessageBox.Show(r.Gorivo + " "  + " " + r.Registracija);

                //  s.SaveOrUpdate(t);
                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajKupca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

               

                Kupac r = s.Load<Kupac>(2);//FIZICKO LICE
            

                MessageBox.Show(r.Vozilo.Registracija);
            

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdFizickoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoLice f = s.Load<FizickoLice>("2007987457810");

                MessageBox.Show(f.Ime + " "+ f.kupac.Vozilo.Registracija );

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }


        }

       

        private void btnVezaSe_nalazi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

              
                Vozilo v = s.Load<Vozilo>(1);
                Predstavnistvo p = s.Load<Predstavnistvo>(1);
                p.Adresa = "Bulevar Pobede 45";

                MessageBox.Show(v.Salon.Adresa);

                foreach(Vozilo vo in p.Vozila)
                {
                    MessageBox.Show(vo.Registracija);
                }

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVlasnik_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo j = s.Load<Vozilo>(1);
                Vlasnik v = s.Load<Vlasnik>("060789456");
                MessageBox.Show(v.vozilo.Registracija);
                Vlasnik v1 = new Vlasnik()
                {
                    Adresa = "sadsad",
                    Telefon = "024156151",
                    vozilo = j
                };
                s.SaveOrUpdate(v1);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MehanicarHyundai m = s.Load<MehanicarHyundai>(5);
                PredstavnikHyundai p = s.Load<PredstavnikHyundai>(22);

                //foreach (PredstavnikHyundai pr in m.Predstavnici)
                //{
                //    MessageBox.Show(p.Adresa);
                //}
                //foreach (MehanicarHyundai me in p.Mehanicari)
                //{
                //    MessageBox.Show(me.Specijalnost);
                //}



                //MehanicarHyundai m1 = new MehanicarHyundai()
                //{
                //    DatumRodjenja = new DateTime(1984,5,15),
                //    DatumZaposlenja = new DateTime(2014,4,21),
                //    Specijalnost = "motor",
                //    ImeOca = "Goran",
                //    LicnoIme = "Dragan",
                //    Mbr = "2012980736589",
                //    Prezime = "Ilic"


                //};

                //PredstavnikHyundai h1 = new PredstavnikHyundai()
                //{
                //    DatumRodjenja = new DateTime(1970,10,10),
                //    DatumZaposlenja = new DateTime(2010, 10, 10),
                //    Adresa = "Novosadska 15",
                //    ImeOca = "Zoran",
                //    LicnoIme = "Dejan",
                //    Mbr = "1010970401548",
                //    Prezime = "Ilic",
                //    Telefon = "064789456"
                //};
                //dodavanje-mora i ocena i datum da ide u tabelu testira
                //m1.Predstavnici.Add(h1);
                //h1.Mehanicari.Add(m1);
                //s.Save(h1);

                Testira t = new Testira();
                //prethodno treba proveriri dal su ucitani bas MehanicarHyundai 
                //i bas PredstavnikHyundai 

                t.Mehanicar = m;
                t.Predstavnik = p;
                t.DatumTestiranja = DateTime.Now;
                t.Ocena = 2;


                s.Save(t);

                s.Flush();
                s.Close();

                MessageBox.Show("Podaci o novom testiranju su uneti.");

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void createKnjizica_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Load<Vozilo>(1);
                MessageBox.Show(v.Registracija);

                Predstavnistvo p = s.Load<Predstavnistvo>(3);

                if (p.GetType() == typeof(ServisKia))
                {
                    ServisKia o5 = (ServisKia)p;
                }
                else if (p.GetType() == typeof(ServisHyundai))
                {
                    ServisHyundai o5 = (ServisHyundai)p;
                }
                else if (p.FHyundai ==1 && p.FKia==1 && p.FServis==1)
                {
                    //kad probamo ovako sa flegovima,
                    //upadne ovde ali ne moze da castuje PredstavnistvoProxy u ServisHyundaiKia
                    ServisHyundaiKia o5 = (ServisHyundaiKia)p;
                }
                else
                {
                    MessageBox.Show("");
                    //Upada nam ovde kad radimo samo sa GetType, bez flegova,
                    //iako odaberemo Predstavnistvo koje je ServisHyundaiKia
                    // Julije, proveri flegove da l rade
                }
                Knjizica k = new Knjizica()
                {
                    DatumIntervencije = DateTime.Now,
                    CenaUsluge = 1500,
                    Radovi = "Pregled",
                    Vozilo= v,
                    Servis= p
                };


                s.Save(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void vezaAngazuje_Click(object sender, EventArgs e)
        {
            //nismo probale zbog gorenavedenog problema sa Predstavnistvom

            // kreiraj mehanicara i servis (tj Predstavnistvo pa TypeOf i proveri dal je servis)

            // napravi Angazuje i dodaj atribute

            // upisi Angazuje 

            // procitaj Angazuje
        }

        private void vezaSadrzi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(5);
                Knjizica p = s.Load<Knjizica>(1);

                Sadrzi t = new Sadrzi();

                if ( z.GetType() == typeof(MehanicarKia))
                {
                    MehanicarKia mk = (MehanicarKia)z;
                }
                else if (z.GetType() == typeof(MehanicarHyundai))
                {
                    MehanicarHyundai mh = (MehanicarHyundai)z;
                }
                else if (z.GetType() == typeof(MehanicarKiaHyundai))
                {
                    MehanicarKiaHyundai mkh = (MehanicarKiaHyundai)z;
                }
                else
                {
                    
                    MessageBox.Show("");
                }

                t.Mehanicar = z;
                t.Knjizica = p;


                s.Save(t);

                //Ucitace se podaci lepo ali ovi GetType ne rade opet,
                //opet upada u else granu

                s.Flush();
                s.Close();

                MessageBox.Show("Podaci o novom testiranju su uneti.");

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
