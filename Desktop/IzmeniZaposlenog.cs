using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.DTOs;
using Desktop.DTOManagers;

namespace Desktop
{
    public partial class IzmeniZaposlenog : Form
    {
        private ZaposleniPregled zaposleni;
        public IzmeniZaposlenog()
        {
            InitializeComponent();
        }
        public IzmeniZaposlenog(ZaposleniPregled z)
        {
            InitializeComponent();
            zaposleni = z;
            if(z.Tip.Equals("MehanicarKia") || z.Tip.Equals("MehanicarHyundai"))
            {
                txtAdresa.Enabled = false;
                txtTelefon.Enabled = false;
                txtSpecijalnost.Enabled = true;
            }
            else
            {
                txtAdresa.Enabled = true;
                txtTelefon.Enabled =true;
                txtSpecijalnost.Enabled = false;

            }
        }


        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            zaposleni.LicnoIme = txtIme.Text;
        }

        private void txtImeOca_TextChanged(object sender, EventArgs e)
        {
            zaposleni.ImeOca = txtImeOca.Text;
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            zaposleni.Prezime = txtPrezime.Text;
        }

        private void txtMbr_TextChanged(object sender, EventArgs e)
        {
            zaposleni.Mbr = txtMbr.Text;
        }

        private void dtpRodjenje_ValueChanged(object sender, EventArgs e)
        {
            zaposleni.DatumRodjenja = dtpRodjenje.Value;
        }

        private void dtpZaposlenje_ValueChanged(object sender, EventArgs e)
        {
            zaposleni.DatumZaposlenja = dtpZaposlenje.Value;
        }

        private void txtSpecijalnost_TextChanged(object sender, EventArgs e)
        {
            zaposleni.Specijalnost = txtSpecijalnost.Text;
        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {
           
            zaposleni.Adresa = txtAdresa.Text;
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            zaposleni.Telefon = txtTelefon.Text;
        }
    }
}
