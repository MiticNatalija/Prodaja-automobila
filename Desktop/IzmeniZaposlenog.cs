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
        private ZaposleniIzmena zaposleni;
        public IzmeniZaposlenog()
        {
            InitializeComponent();
        }
        public IzmeniZaposlenog(ZaposleniIzmena z)
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
            fill();
            
        }

        private void fill()
        {
            txtIme.Text = zaposleni.LicnoIme;
            txtImeOca.Text = zaposleni.ImeOca;
            txtPrezime.Text = zaposleni.Prezime;
            txtMbr.Text = zaposleni.Mbr;
            dtpRodjenje.Value = zaposleni.DatumRodjenja;
            dtpZaposlenje.Value = zaposleni.DatumZaposlenja;
            if (zaposleni.Tip.Equals("MehanicarKia") || zaposleni.Tip.Equals("MehanicarHyundai"))
            {
                txtSpecijalnost.Text = zaposleni.Specijalnost;
            }
            else
            {
                txtAdresa.Text = zaposleni.Adresa;
                txtTelefon.Text = zaposleni.Telefon;
            }


            }
        private void btn_Click(object sender, EventArgs e)
        {
            if (txtMbr.Text == "" || txtIme.Text == "" || txtPrezime.Text == "" || txtImeOca.Text == "" || (txtSpecijalnost.Text == "" && (txtAdresa.Text == "" || txtTelefon.Text == "")))
                {
                MessageBox.Show("Popunite sva polja!");
                return;
            }
            if (txtMbr.Text.Length != 13)
            { MessageBox.Show("JMBG mora imati 13 cifara!"); }
            else
            {
                zaposleni.LicnoIme = txtIme.Text;
                zaposleni.ImeOca = txtImeOca.Text;
                zaposleni.Prezime = txtPrezime.Text;
                zaposleni.Mbr = txtMbr.Text;
                zaposleni.DatumRodjenja = dtpRodjenje.Value;
                zaposleni.DatumZaposlenja = dtpZaposlenje.Value;
                zaposleni.Specijalnost = txtSpecijalnost.Text;
                zaposleni.Adresa = txtAdresa.Text;
                zaposleni.Telefon = txtTelefon.Text;
                DTOManager.UpdateZaposleni(zaposleni);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }


        private void txtMbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtImeOca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtIme_Leave(object sender, EventArgs e)
        {
            if (txtIme.Text.Length >= 1)
                txtIme.Text = txtIme.Text.Substring(0, 1).ToUpper() + txtIme.Text.Substring(1);
        }

        private void txtImeOca_Leave(object sender, EventArgs e)
        {
            if (txtImeOca.Text.Length >= 1)
                txtImeOca.Text = txtImeOca.Text.Substring(0, 1).ToUpper() + txtImeOca.Text.Substring(1);
        }

        private void txtPrezime_Leave(object sender, EventArgs e)
        {
            if (txtPrezime.Text.Length >= 1)
                txtPrezime.Text = txtPrezime.Text.Substring(0, 1).ToUpper() + txtPrezime.Text.Substring(1);
        }

        private void txtAdresa_Leave(object sender, EventArgs e)
        {
            if (txtAdresa.Text.Length >= 1)
                txtAdresa.Text = txtAdresa.Text.Substring(0, 1).ToUpper() + txtAdresa.Text.Substring(1);
        }
    }
}
