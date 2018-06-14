using Desktop.DTOs;
using Desktop.DTOManagers;
using Desktop.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class frmProdajVozilo : Form
    {
        public VoziloPregled vozilo { get; set; }
        public List<PredstavnikInfo> listaPredstavnika;

        public frmProdajVozilo()
        {
            InitializeComponent();
        }
        public frmProdajVozilo(VoziloPregled v,List<PredstavnikInfo> predstavnici)
        {
            this.vozilo = v;
            InitializeComponent();

            listaPredstavnika = predstavnici;

            txtFizickoJmbg.Enabled = false;
            txtFizickoIme.Enabled = false;
            txtFizickoPrezime.Enabled = false;
            txtFizickoAdresa.Enabled = false;
            txtFizickoTelefon.Enabled = false;

            txtPravnoPib.Enabled = false;
            txtPravnoIme.Enabled = false;
            txtPravnoPrezime.Enabled = false;
            txtPravnoTelefon.Enabled = false;

            txtPredstavnikHyundai.Enabled = false;
            txtPredstavnikKia.Enabled = false;
            rdbKia.Enabled = false;
            rdbHyundai.Enabled = false;
            if (predstavnici.Count == 0)
                return;

          

                if (predstavnici[0].TipZaposlenog.Equals("Predstavnik Za Kiu"))
                {
                    txtPredstavnikKia.Text = predstavnici[0].Mbr;
                    rdbKia.Enabled = true;
                    rdbKia.Checked = true;
                }
                else
                {
                    rdbHyundai.Enabled = true;
                    rdbHyundai.Checked = true;
                    txtPredstavnikHyundai.Text = predstavnici[0].Mbr;
                }

            
            if(predstavnici.Count>1)
            {
                if (txtPredstavnikHyundai.Text == "")
                {
                    rdbHyundai.Enabled = true;
                    txtPredstavnikHyundai.Text = predstavnici[1].Mbr;
                }
                else
                {
                    rdbKia.Enabled = true;
                    txtPredstavnikKia.Text = predstavnici[1].Mbr;
                }
            }


            
        }
       

        private void btnOK_Click(object sender, EventArgs e)
        {

            if(!rdbHyundai.Checked && !rdbKia.Checked)
            {
                MessageBox.Show("Izaberite prodavca!");
                return;
            }
            if(!radioFizicko.Checked && !radioPravno.Checked)
            {
                MessageBox.Show("Da li je kupac fizicko ili pravno lice? Cekirajte!");
                return;
            }
            //if(txtPredstavnikHyundai.Text=="" && txtPredstavnikKia.Text=="")
            //{
            //    MessageBox.Show("Popunite sva polja!");
            //    return;
            //}
            if(txtPopustiDelovi.Text=="" || txtPopustiServis.Text=="")
            {
                MessageBox.Show("Popunite sva polja!");
                return;
            }
            if (radioFizicko.Checked)
            {
                if (txtFizickoAdresa.Text == "" || txtFizickoIme.Text == "" || txtFizickoJmbg.Text == "" || txtFizickoPrezime.Text == "" || txtFizickoTelefon.Text == "")
                {
                    MessageBox.Show("Popunite sva polja!");
                    return;
                }
            }
            else if (radioPravno.Checked)
            {
                if (txtPravnoIme.Text == "" || txtPravnoPib.Text == "" || txtPravnoPrezime.Text == "" || txtPravnoTelefon.Text == "")
                {
                    MessageBox.Show("Popunite sva polja!");
                    return;
                }
            }

            FizickoLice f;
            PravnoLice p;


            //Vlasnik v;
            string pred= "";
            if (rdbHyundai.Checked)
                pred = txtPredstavnikHyundai.Text;
            else
                pred = txtPredstavnikKia.Text;

            
            DTOManager.SetPredstavnikAndPopustiInVozilo(pred, txtPopustiServis.Text, txtPopustiDelovi.Text, vozilo);
            //vozilo dobija predstavnikId da se zna da ga je taj predstavnik prodao i popuste koje taj predstavnik unese

          //  Kupac k = new Kupac();
            
          //  Vozilo voz = DTOManager.GetVoziloVozilo(vozilo.VoziloId); // vraca bas Vozilo a ne VoziloPregled
        //    k.Vozilo = voz;

            if (radioFizicko.Checked)
            {
                f = new FizickoLice();
                f.Jmbg = txtFizickoJmbg.Text;
                f.Ime = txtFizickoIme.Text;
                f.Prezime = txtFizickoPrezime.Text;
                f.Adresa = txtFizickoAdresa.Text;
                f.Telefon = txtFizickoTelefon.Text;
              //  f.Kupac = k;
              //  k.FLice = f;

                DTOManager.upisiFizickoLice(f, vozilo);
                
            }
            else if (radioPravno.Checked)
            {
                p = new PravnoLice();
                int pom;
                if (!int.TryParse(txtPravnoPib.Text, out pom))
                    return;
                p.Pib = pom;
                p.Ime = txtPravnoIme.Text;
                p.Prezime = txtPravnoPrezime.Text;
                p.Telefon = txtPravnoTelefon.Text;
                //  p.Kupac = k;
                //  k.PLice = p;

                DTOManager.upisiPravnoLice(p, vozilo);
            }

           // DTOManager.upisiKupca(k);
            DialogResult = System.Windows.Forms.DialogResult.OK;


        }

        private void radioPravno_CheckedChanged(object sender, EventArgs e)
        {
            txtFizickoJmbg.Enabled = false;
            txtFizickoIme.Enabled = false;
            txtFizickoPrezime.Enabled = false;
            txtFizickoAdresa.Enabled = false;
            txtFizickoTelefon.Enabled = false;

            txtPravnoPib.Enabled = true;
            txtPravnoIme.Enabled = true;
            txtPravnoPrezime.Enabled = true;
            txtPravnoTelefon.Enabled = true;

        }

        private void radioFizicko_CheckedChanged(object sender, EventArgs e)
        {
            txtFizickoJmbg.Enabled = true;
            txtFizickoIme.Enabled = true;
            txtFizickoPrezime.Enabled = true;
            txtFizickoAdresa.Enabled = true;
            txtFizickoTelefon.Enabled = true;

            txtPravnoPib.Enabled = false;
            txtPravnoIme.Enabled = false;
            txtPravnoPrezime.Enabled = false;
            txtPravnoTelefon.Enabled = false;
        }

        private void txtFizickoTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPravnoTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
