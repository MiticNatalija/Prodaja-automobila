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
                //radi lepo
                IQuery q = s.CreateQuery("from Vozilo as vo where vo.Id=1");

               Vozilo v1 = q.UniqueResult<Vozilo>();
                MessageBox.Show(v1.GetType().ToString());


                //ovo radi-koriscen query
                IList<Vozilo> r1 = s.QueryOver<Vozilo>().List<Vozilo>();
                foreach (Vozilo v in r1)
                {
                    if (v.GetType() == typeof(Putnicko))
                    {
                        Putnicko pu = (Putnicko)v;
                    }
                    else if (v.GetType() == typeof(Teretno))
                    {
                        Teretno ter = (Teretno)v;
                    }

                }


                Vozilo r = s.Load<Vozilo>(1);
              //Putnicko r1 = s.Load<Putnicko>(1);

                MessageBox.Show(r.Gorivo + " "  + " " + r.Registracija);

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
                FizickoLice f = r.FLice;
                PravnoLice p = r.PLice;

                MessageBox.Show(r.Vozilo.Registracija);

                FizickoLice f1 = new FizickoLice()
                {
                    Adresa = "Bulevar 14",
                    Ime = "Maja",
                    Jmbg = "2012965424580",
                    Prezime = "Tosic",
                    Telefon = "065127898"
                };
                Vozilo v = s.Load<Vozilo>(5);
                Kupac ku = new Kupac()
                {
                    Vozilo = v
                };
                f1.Kupac = ku;
                ku.FLice = f1;


                s.Save(ku);
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

                MessageBox.Show(f.Ime + " "+ f.Kupac.Vozilo.Registracija );

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

                //foreach (Vozilo vo in p.Vozila)
                //{
                //    MessageBox.Show(vo.Registracija);
                //}

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

                Vozilo j = s.Load<Vozilo>(2);


                Vlasnik v = s.Get<Vlasnik>(2);
                MessageBox.Show(v.Telefon);


                Vozilo v1 = s.Load<Vozilo>(1);
                Vlasnik novi = new Vlasnik()
                {
                    Adresa = "fd",
                    Telefon = "02515",
                    Vozilo = v1
                };
                s.Save(novi);
                s.SaveOrUpdate(v1);

                Putnicko p = new Putnicko() {
                    BrojMesta=5,
                    Gorivo="Dizel",
                    OznakaMotora="415641xc",
                    Registracija="NI 744 KI"

                };

                Vlasnik novi1 = new Vlasnik() {
                    Adresa = "ftre",
                    Telefon = "01878946",
                    Vozilo = p
                };
                
                s.Save(novi1);
               

              
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
                Testira t = new Testira();

                MehanicarHyundai m = s.Load<MehanicarHyundai>(5);
                PredstavnikHyundai p = s.Load<PredstavnikHyundai>(1);

                // Maruska:
                // Ovo ispod ne radi, upada u else granu.

                //MehanicarHyundai m=new MehanicarHyundai();
                //PredstavnikHyundai p=new PredstavnikHyundai();

                //Zaposleni z1 = s.Load<Zaposleni>(5);
                //Zaposleni z2 = s.Load<Zaposleni>(1);

                //if (z1.GetType() == typeof(MehanicarHyundai))
                //{
                //    m = (MehanicarHyundai)z1;
                //}
                //else
                //{
                //    MessageBox.Show("Treba ucitati MehanicarHyundai");
                //}

                //if (z2.GetType() == typeof(PredstavnikHyundai))
                //{
                //    p = (PredstavnikHyundai)z2;
                //}
                //else
                //{
                //    MessageBox.Show("Treba ucitati PredstavnikHyundai");
                //}

                t.Mehanicar = m;
                t.Predstavnik = p;
                t.DatumTestiranja = DateTime.Now;
                t.Ocena = 4;


                m.Predstavnici.Add(p);
                m.TestiraPredstavnici.Add(t);
                p.Mehanicari.Add(m);
                p.TestiraMehanicari.Add(t);
                //ovo radi ispravno, proveri dal tako treba da se radi 

                s.Save(p); 
                //ovo valjda ne treba, ne menja se zapravo nista u bazi


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
                else if (p is ServisHyundaiKia)
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

                //knjizica treba da se menja,ali ovako bi islo
                IQuery q = s.CreateQuery("from Zaposleni as z where z.Id=5 ");
                IQuery q1 = s.CreateQuery("from Knjizica as k where k.Id=1 ");
                Zaposleni z = q.UniqueResult<Zaposleni>();
                Knjizica p = q1.UniqueResult<Knjizica>();

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

        private void btnPredstavnistvo_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                IList<Predstavnistvo> p = s.QueryOver<Predstavnistvo>().List<Predstavnistvo>();
                foreach (Predstavnistvo pre in p)
                {
                    if (pre.GetType() == typeof(SalonServisHyundaiKia))
                        MessageBox.Show("SalonServisHyundaiKia");

                    if (pre.GetType() == typeof(SalonServisHyundai))
                        MessageBox.Show("SalonServisHyundai");

                    if (pre.GetType() == typeof(SalonServisKia))
                        MessageBox.Show("SalonServisKia");

                }

                IQuery q = s.CreateQuery("from Predstavnistvo as p where p.Id=1");

                Predstavnistvo pr = q.UniqueResult<Predstavnistvo>();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUpisiFizicko_Click(object sender, EventArgs e)
        {
            try {
                ISession s = DataLayer.GetSession();

                FizickoLice f1 = new FizickoLice()
            {
                Adresa = "Bulevar 14",
                Ime = "Ana",
                Jmbg = "2012987124580",
                Prezime = "Savic",
                Telefon = "065123456"
            };

            Kupac k1 = s.Load<Kupac>(1);
            f1.Kupac = k1;
            s.SaveOrUpdate(f1);
          
            s.Flush();
            s.Close();
        }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
}

        private void btnDodavanjePredstavnistva_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PredstavnikHyundai ph = new PredstavnikHyundai()
                {
                    LicnoIme = "Marko",
                    Prezime = "Maric",
                    ImeOca = "Darko",
                    Mbr = "1231231233211",
                    DatumRodjenja = new DateTime(1970, 10, 11),
                    Adresa = "Maricka 20",
                    Telefon = "0601233211",
                    DatumZaposlenja = new DateTime(2018,1,1)
                };

                s.Save(ph);
                s.Flush();

                SalonHyundai sh = new SalonHyundai()
                {
                    Adresa = "Nova 14",
                    DatumOtvaranja = new DateTime(),
                    DatumVazenjaLicence = new DateTime(2020, 2, 2),
                    PredstavnikHyundai = ph
                };

                s.Save(sh);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
