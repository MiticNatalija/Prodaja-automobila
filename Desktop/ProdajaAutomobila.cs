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
    public partial class frmProdajaAutomobila : Form
    {
        public frmProdajaAutomobila()
        {
            InitializeComponent();
        }

        private void btnUcitajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Vozilo> r1 = s.QueryOver<Vozilo>().List<Vozilo>();
                foreach (Vozilo v in r1)
                {
                    if (v.GetType() == typeof(Putnicko))
                    {
                        Putnicko pu = (Putnicko)v;
                        MessageBox.Show("Id voizla: " + pu.Id + "- Tip vozila: Putnicko");
                    }
                    else if (v.GetType() == typeof(Teretno))
                    {
                        Teretno ter = (Teretno)v;
                        MessageBox.Show("Id voizla: " + ter.Id + "- Tip vozila: Teretno");
                    }

                }
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

                Kupac r = s.Load<Kupac>(2);
                FizickoLice f = r.FLice;
                PravnoLice p = r.PLice;
                string tip = "Kupac je: ";
                if (f != null)
                    tip += "fizicko lice ";
                else if (p != null)
                    tip += "pravno lice ";

                MessageBox.Show(tip + "Registracija vozila kupca: " + r.Vozilo.Registracija);
                s.Close();
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


                Vozilo v = s.Load<Vozilo>(2);
                Predstavnistvo p = s.Load<Predstavnistvo>(1);
                // p.Adresa = "Bulevar Pobede 45";
                SalonServisHyundaiKia sve = s.Load<SalonServisHyundaiKia>(1);
                MessageBox.Show(sve.Adresa);
                foreach (Vozilo voz in sve.Vozila) {
                    MessageBox.Show(voz.Gorivo);
                }

                MessageBox.Show(v.Salon.Adresa);


                Putnicko novo = new Putnicko() {
                    Registracija = "PI 123 PO",
                    Gorivo = "Dizel",
                    OznakaMotora = "127897897ff",
                    BrojMesta = 5
                };

                SalonHyundai novi= new SalonHyundai() {
                    Adresa="Uzicka 47",
                    DatumOtvaranja=new DateTime(2000,1,1),
                    DatumVazenjaLicence=new DateTime(2104,1,1)
                };

                novi.Vozila.Add(novo);
                novo.Salon = novi;
                s.SaveOrUpdate(novi);
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

                Vlasnik v = s.Get<Vlasnik>(2);
                MessageBox.Show(v.Telefon);
              
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)  // veza Testira
        {
            try
            {
                ISession s = DataLayer.GetSession();
               
                Testira t = new Testira();

                MehanicarHyundai mh = new MehanicarHyundai()
                {
                    Mbr = "2346993762615",
                    LicnoIme = "Krka",
                    ImeOca = "Krk",
                    Prezime = "Krkic",
                    DatumRodjenja = new DateTime(1993, 1, 2),
                    DatumZaposlenja = DateTime.Now,
                    Specijalnost = "motor"
                };
                s.Save(mh);
                s.Flush();

                PredstavnikHyundai ph = new PredstavnikHyundai()
                {
                    Mbr = "2566945562618",
                    LicnoIme = "Prka",
                    ImeOca = "Prk",
                    Prezime = "Prkic",
                    DatumRodjenja = new DateTime(1945, 1, 2),
                    DatumZaposlenja = DateTime.Now,
                    Adresa = "Njegoseva",
                    Telefon = "06328086"
                };

                s.Save(ph);
                s.Flush();

                
                // RADI I OVO DOLE, SVEJEDNO KOJI NACIN IZABEREMO
                /////////////////////////////////////////////////////////////////////////
            
                //IQuery q = s.CreateQuery("from Zaposleni as p where p.Id=5");

                //Zaposleni z1 = q.UniqueResult<Zaposleni>();

                //IQuery q1 = s.CreateQuery("from Zaposleni as p where p.Id=1");

                //Zaposleni z2 = q1.UniqueResult<Zaposleni>();

                //if (z1.GetType() == typeof(MehanicarHyundai))
                //{
                //    MehanicarHyundai m = (MehanicarHyundai)z1;
                //    t.Mehanicar = m;
                //}
                //else
                //{
                //    MessageBox.Show("Treba ucitati MehanicarHyundai");
                //}

                //if (z2.GetType() == typeof(PredstavnikHyundai))
                //{
                //    PredstavnikHyundai p = (PredstavnikHyundai)z2;
                //    t.Predstavnik = p;
                //}
                //else
                //{
                //    MessageBox.Show("Treba ucitati PredstavnikHyundai");
                //}

                t.Mehanicar = mh; 
                t.Predstavnik = ph;
                t.DatumTestiranja = DateTime.Now;
                t.Ocena = 3;

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

                //ServisHyundai ser = s.Load<ServisHyundai>(15);
                //foreach (Knjizica kj in ser.Knjizice)
                //MessageBox.Show(kj.CenaUsluge.ToString());


                Vozilo v = s.Load<Vozilo>(2);

                PredstavnikHyundai ph = new PredstavnikHyundai
                {
                    LicnoIme = "Logan",
                    Prezime = "Kocic",
                    ImeOca = "Igor",
                    Mbr = "0100000000001",
                    DatumRodjenja = new DateTime(1980, 1, 2),
                    DatumZaposlenja = new DateTime(2017, 2, 3),
                    Adresa = "Solidna adresa 10",
                    Telefon = "066555444",
                };

                s.Save(ph);
                s.Flush();

                ServisHyundai sh = new ServisHyundai()
                {
                    Adresa = "moja adresa",
                    DatumOtvaranja = new DateTime(2017, 1, 1),
                    PredstavnikHyundai = ph,
                };

                s.Save(sh);
                s.Flush();


                //RADI I OVO ISPOD
                //////////////////////////////////////////////////////////////////////
                //IQuery q = s.CreateQuery("from Predstavnistvo as p where p.Id=3");

                //Predstavnistvo p = q.UniqueResult<Predstavnistvo>();


                //if (p.GetType() == typeof(ServisKia))
                //{
                //    ServisKia sk = (ServisKia)p;
                //}
                //else if (p.GetType() == typeof(ServisHyundai))
                //{
                //    ServisHyundai sh = (ServisHyundai)p;
                //}
                //else if (p.GetType() == typeof(ServisHyundaiKia))
                //{
                //     ServisHyundaiKia shk = (ServisHyundaiKia)p;
                //}
                //else
                //{
                //    MessageBox.Show("Treba uneti servis.");
                   
                //}
                Knjizica k = new Knjizica()
                {
                    DatumIntervencije = DateTime.Now,
                    CenaUsluge = 3333,
                    Radovi = "Pregled",
                    Vozilo= v,
                    //Servis= p
                    Servis=sh
                };


                s.Save(k);
                s.Flush();

                MessageBox.Show("Podaci o novoj knjizici su uneti.");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void vezaAngazuje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Angazuje t = new Angazuje();

                t.DatumPocetka = new DateTime(2018, 1, 1);
                t.KrajRada = DateTime.Now;
                t.Ocena = 2;

                IQuery q = s.CreateQuery("from Predstavnistvo as p where p.Id=3");

                Predstavnistvo z1 = q.UniqueResult<Predstavnistvo>();

                IQuery q1 = s.CreateQuery("from Zaposleni as p where p.Id=5");

                Zaposleni z2 = q1.UniqueResult<Zaposleni>();

              
                if (z1.GetType() == typeof(ServisKia))
                {
                    ServisKia m = (ServisKia)z1;
                    t.Servis = m;
                }
                else if (z1.GetType() == typeof(ServisHyundai))
                {
                    ServisHyundai m = (ServisHyundai)z1;
                    t.Servis = m;
                }
                else if (z1.GetType() == typeof(ServisHyundaiKia))
                {
                    ServisHyundaiKia m = (ServisHyundaiKia)z1;
                    t.Servis = m;
                }
                else if (z1.GetType() == typeof(SalonServisKia))
                {
                    SalonServisKia m = (SalonServisKia)z1;
                    t.Servis = m;
                }
                else if (z1.GetType() == typeof(SalonServisHyundai))
                {
                    SalonServisHyundai m = (SalonServisHyundai)z1;
                    t.Servis = m;
                }
                else if (z1.GetType() == typeof(SalonServisHyundaiKia))
                {
                    SalonServisHyundaiKia m = (SalonServisHyundaiKia)z1;
                    t.Servis = m;
                }

                else
                {
                    MessageBox.Show("Treba ucitati servis.");
                }

                if (z2.GetType() == typeof(MehanicarKia))
                {
                    MehanicarKia p = (MehanicarKia)z2;
                    t.Mehanicar = p;
                }
                else if (z2.GetType() == typeof(MehanicarHyundai))
                {
                    MehanicarHyundai p = (MehanicarHyundai)z2;
                    t.Mehanicar = p;
                }
               

                else
                {
                    MessageBox.Show("Treba ucitati mehanicara.");
                }


               
                s.Save(t);

                s.Flush();

                s.Close();

                MessageBox.Show("Podaci o novoj vezi Angazuje su uneti.");

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void vezaSadrzi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Knjizica r1 = s.Load<Knjizica>(12);

                foreach (Zaposleni p1 in r1.Mehanicari)
                {
                    MessageBox.Show(p1.LicnoIme); 
                }

                MehanicarHyundai mh = new MehanicarHyundai()
                {
                    Mbr = "2346993762618",
                    LicnoIme = "Beka",
                    ImeOca = "Krk",
                    Prezime = "Bekic",
                    DatumRodjenja = new DateTime(1993, 1, 2),
                    DatumZaposlenja = DateTime.Now,
                    Specijalnost = "dizajn"
                };
                s.Save(mh);
                s.Flush();

                r1.Mehanicari.Add(mh);
                mh.Knjizice.Add(r1);

                foreach (Zaposleni p1 in r1.Mehanicari)
                {
                    MessageBox.Show(p1.LicnoIme);
                }

                s.SaveOrUpdate(r1);
                s.Flush();
                s.Close();
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
            try
            {
                ISession s = DataLayer.GetSession();

                PravnoLice f1 = new PravnoLice()
                {
                    Ime = "Ana",
                    Pib = 123456,
                    Prezime = "Savic",
                    Telefon = "065123456"
                };

                Kupac k1 = new Kupac();
                Vozilo v = s.Load<Vozilo>(2);
                k1.Vozilo = v;
                k1.PLice = f1;
                f1.Kupac = k1;
                s.SaveOrUpdate(f1);
          
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno kreirano pravno lice.");
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

                IQuery q = s.CreateQuery("select z from Zaposleni z where z.Mbr='1231231233211'");
                Zaposleni z = q.UniqueResult<Zaposleni>();
                PredstavnikHyundai ph = null;

                if (z == null)
                {
                    ph = new PredstavnikHyundai()
                    {
                        LicnoIme = "Marko",
                        Prezime = "Maric",
                        ImeOca = "Darko",
                        Mbr = "1231231233211",
                        DatumRodjenja = new DateTime(1970, 10, 11),
                        Adresa = "Maricka 20",
                        Telefon = "0601233211",
                        DatumZaposlenja = new DateTime(2018, 1, 1)
                    };
                    s.Save(ph);
                    s.Flush();
                }
                else
                    ph = (PredstavnikHyundai)z;

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
                MessageBox.Show("Predstavnistvo je dodato!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zaposleni z = s.Load<Zaposleni>(1);
                MessageBox.Show(z.Prezime);

               
                IQuery q = s.CreateQuery("select z from Zaposleni z where z.Id=5");
                Zaposleni z1 = q.UniqueResult<Zaposleni>();
                if (z1.GetType() == typeof(MehanicarHyundai))
                {
                    MehanicarHyundai m = (MehanicarHyundai)z1;
                }

                MehanicarHyundai meh = new MehanicarHyundai() {
                    DatumRodjenja=new DateTime(1970,1,1),
                    DatumZaposlenja=new DateTime(2009,4,4),
                    ImeOca="Srdjan",
                    LicnoIme="Marko",
                    Mbr="0404197045101",
                    Prezime="Matic",
                    Specijalnost="Hladnjak"
                    
                };

                s.Save(meh);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Putnicko p = new Putnicko()
                {
                    Registracija = "NI 789 PO",
                    Gorivo = "Dizel",
                    OznakaMotora = "127898456",
                    BrojMesta = 4
                };

                Vozilo r = s.Load<Vozilo>(2);

                r.Gorivo = "Benzin";
                MessageBox.Show(r.Gorivo + " " + " " + r.Registracija);

                s.Save(r);
                s.Save(p);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno dodavanje i promena vozila.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnBrisanjeVozila_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select v from Vozilo v where v.OznakaMotora='127898456'");
                IList<Vozilo> v = q.List<Vozilo>();
                if (v == null)
                    throw new Exception("Prvo morate dodati vozilo na dugme iznad!");
                s.Delete(v[0]);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno brisanje.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnKreirajFizickoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoLice f1 = new FizickoLice()
                {
                    Adresa = "Bulevar 14",
                    Ime = "Maja",
                    Jmbg = "2012965424580",
                    Prezime = "Tosic",
                    Telefon = "065127898"
                };
                Vozilo v = s.Load<Vozilo>(2);
                Kupac ku = new Kupac()
                {
                    Vozilo = v
                };
                f1.Kupac = ku;
                ku.FLice = f1;


                s.Save(ku);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno kreirano fizicko lice.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTestiraProvera_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MehanicarHyundai r1 = s.Load<MehanicarHyundai>(19);

                foreach (PredstavnikHyundai p1 in r1.Predstavnici)
                {
                    MessageBox.Show(p1.LicnoIme);
                }


                PredstavnikHyundai p2 = s.Load<PredstavnikHyundai>(20);

                foreach (MehanicarHyundai r2 in p2.Mehanicari)
                {
                    MessageBox.Show(r2.LicnoIme + " " + r2.Prezime);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnAngazujeProvera_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                ServisHyundaiKia shk = s.Load<ServisHyundaiKia>(3);

                foreach (Zaposleni p1 in shk.Mehanicari)
                {
                    MessageBox.Show(p1.LicnoIme);
                }


                MehanicarKia p2 = s.Load<MehanicarKia>(3);

                foreach (Predstavnistvo r2 in p2.Servisi)
                {
                    MessageBox.Show(r2.Adresa);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnKnjizicaCitanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Knjizica k = s.Load<Knjizica>(1);
                MessageBox.Show("Ucitali ste knjizicu u kojoj su zabelezeni radovi :\n"+ k.Radovi );

                foreach (Zaposleni p1 in k.Mehanicari)
                {
                    MessageBox.Show(p1.Id + "  "+ p1.LicnoIme);
                }

                
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnKnjizicaBrisanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


              //  Knjizica k = s.Load<Knjizica>(8);
                IQuery q = s.CreateQuery("from Knjizica as k where k.Id=10 ");
                Knjizica k = q.UniqueResult<Knjizica>();
                MessageBox.Show("Ucitali ste knjizicu u kojoj su zabelezeni radovi :\n" + k.Radovi);

                s.Delete(k);
                s.Flush();
                
                s.Close();

                MessageBox.Show("Uspesno brisanje knjizice.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnKnjizicaAzuriranje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Knjizica k = s.Load<Knjizica>(2);
                MessageBox.Show("Ucitali ste knjizicu u kojoj su zabelezeni radovi :\n" + k.Radovi);

                k.Radovi = "Pregled guma.";

                s.Update(k);
                s.Flush();

                s.Close();

                MessageBox.Show("Uspesno azuriranje knjizice.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnKreiranjeVlasnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select v from Vozilo v where v.Id=3");
                Vozilo v1 = q.UniqueResult<Vozilo>();
                if (v1.vlasnik == null)
                {
                    Vlasnik novi = new Vlasnik()
                    {
                        Adresa = "vlaska 15",
                        Telefon = "02515",
                        Vozilo = v1
                    };
                    v1.vlasnik = novi;
                    MessageBox.Show(v1.vlasnik.Telefon);
                    s.Save(novi);
                    s.SaveOrUpdate(v1);
                }


                Putnicko p = new Putnicko()
                {
                    BrojMesta = 5,
                    Gorivo = "Dizel",
                    OznakaMotora = "415641xc",
                    Registracija = "NI 744 KI"

                };

                Vlasnik novi1 = new Vlasnik()
                {
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

        private void btnBrisanjeVlasnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                //Vlasnik vl = s.Load<Vlasnik>(10);

                Vlasnik vl = s.Load<Vlasnik>(8);
                vl.Adresa = "adresa 5";
                s.SaveOrUpdate(vl);


                IQuery q = s.CreateQuery("select v from Vlasnik v where v.Id=11");
                Vlasnik v = q.UniqueResult<Vlasnik>();

                s.Delete(v);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno brisanje.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnObrisiFizickoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select fl from FizickoLice fl where fl.Jmbg='2012965424580'");
                FizickoLice fl = q.UniqueResult<FizickoLice>();
                if (fl == null)
                    throw new Exception("Prvo morate kreirati fizicko lice na dugme iznad.");

                s.Delete(fl);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno brisanje.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnObrisiPravnoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select pl from PravnoLice pl where pl.Pib=123456");
                IList<PravnoLice> pl = q.List<PravnoLice>();
                if (pl[0] == null)
                    throw new Exception("Prvo morate kreirati pravno lice na dugme iznad.");

                s.Delete(pl[0]);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno brisanje.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnBrisiPredstavnistvo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                //radi-nema vezu
                //ServisHyundai se = s.Load<ServisHyundai>(11);
                //s.Delete(se);

                //radi-ima vezu angazuje
                //Predstavnistvo pr = s.Load<Predstavnistvo>(1);
                //s.Delete(pr);

                IQuery q = s.CreateQuery("select p from Predstavnistvo p where p.Adresa='Nova 14'");
               IList< Predstavnistvo> p = q.List<Predstavnistvo>();
                s.Delete(p[0]);
                MessageBox.Show("Uspesno brisanje.");

                //SalonServisHyundai sa = s.Load<SalonServisHyundai>(5);
                //s.Delete(sa);

                //radi-ima vezu sa vozilom
                //ServisHyundai ser = s.Load<ServisHyundai>(17);
                //s.Delete(ser);

                //radi-ima vezu sa voziom
                //SalonHyundai sal = s.Load<SalonHyundai>(7);
                //s.Delete(sal);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnBrisanjeZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                IQuery q = s.CreateQuery("select z from Zaposleni z where z.Mbr='0404197045101'");
                Zaposleni z = q.UniqueResult<Zaposleni>();
                MessageBox.Show(z.Prezime);

                s.Delete(z);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno brisanje prethodno kreiranog zaposlenog radnika.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
