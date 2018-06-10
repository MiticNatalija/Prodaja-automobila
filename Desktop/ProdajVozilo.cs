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

        public frmProdajVozilo()
        {
            InitializeComponent();
        }
        public frmProdajVozilo(VoziloPregled v)
        {
            this.vozilo = v;
            InitializeComponent();

            txtFizickoJmbg.Enabled = false;
            txtFizickoIme.Enabled = false;
            txtFizickoPrezime.Enabled = false;
            txtFizickoAdresa.Enabled = false;
            txtFizickoTelefon.Enabled = false;

            txtPravnoPib.Enabled = false;
            txtPravnoIme.Enabled = false;
            txtPravnoPrezime.Enabled = false;
            txtPravnoTelefon.Enabled = false;

            


            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        { }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FizickoLice f;
            PravnoLice p;


            //Vlasnik v;

            DTOManager.SetPredstavnikAndPopustiInVozilo(txtPredstavnikMbr.Text, txtPopustiServis.Text, txtPopustiDelovi.Text, vozilo);
            //vozilo dobija predstavnikId da se zna da ga je taj predstavnik prodao i popuste koje taj predstavnik unese

            Kupac k = new Kupac();
            Vozilo voz = DTOManager.GetVoziloVozilo(vozilo.VoziloId); // vraca bas Vozilo a ne VoziloPregled
            k.Vozilo = voz;

            if (radioFizicko.Checked)
            {
                f = new FizickoLice();
                f.Jmbg = txtFizickoJmbg.Text;
                f.Ime = txtFizickoIme.Text;
                f.Prezime = txtFizickoPrezime.Text;
                f.Adresa = txtFizickoAdresa.Text;
                f.Telefon = txtFizickoTelefon.Text;
                f.Kupac = k;
                k.FLice = f;

                //v = new Vlasnik();
                //v.Telefon = txtFizickoTelefon.Text;
                //v.Adresa = txtFizickoAdresa.Text;
                //v.Vozilo = voz;
                
            }
            else if (radioPravno.Checked)
            {
                p = new PravnoLice();
                p.Pib = Convert.ToInt32(txtPravnoPib.Text);
                p.Ime = txtPravnoIme.Text;
                p.Prezime = txtPravnoPrezime.Text;
                p.Telefon = txtPravnoTelefon.Text;
                p.Kupac = k;
                k.PLice = p;

                //v = new Vlasnik();
                //v.Telefon = txtPravnoTelefon.Text;
                //v.Adresa = "Adresa vlasnika u bazi da sme da bude NULL";
                //v.Vozilo = voz;
            }

            DTOManager.upisiKupca(k);
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
    }
}
