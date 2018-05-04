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
                    TipVozila = "Putnicko",
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


                Vozilo r = s.Load<Vozilo>(22);
             //   Putnicko r1 = s.Load<Putnicko>(1);

                MessageBox.Show(r.Gorivo + " " + r.TipVozila + " " + r.Registracija);

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
            

                MessageBox.Show(r.vozilo.Registracija);
            

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

                MessageBox.Show(f.Ime + " "+ f.kupac.vozilo.Registracija );

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

                MessageBox.Show(v.salon.Adresa);

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
    }
}
