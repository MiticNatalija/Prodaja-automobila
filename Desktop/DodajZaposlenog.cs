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
    public partial class DodajZaposlenog : Form
    {
        public DodajZaposlenog()
        {
            InitializeComponent();
            //videti za treci tip mehanicara
            cbxTip.Items.Add("Mehanicar za Kiu");
            cbxTip.Items.Add("Mehanicar za Hyundai");
            cbxTip.Items.Add("Predstavnik za Kiu");
            cbxTip.Items.Add("Predstavnik za Hyundai");
            cbxTip.SelectedIndex = 0;
            txtAdresa.Enabled = false;
            txtTelefon.Enabled = false;
            txtSpecijalnost.Enabled = true;
        }

        private void cbxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTip.SelectedIndex == 0)
            {
                txtAdresa.Enabled = false;
                txtTelefon.Enabled = false;
                txtSpecijalnost.Enabled = true;
            }
            else if(cbxTip.SelectedIndex==1)
            {
                txtAdresa.Enabled = false;
                txtTelefon.Enabled = false;
                txtSpecijalnost.Enabled = true;
            }
            else if (cbxTip.SelectedIndex == 2)
            {
                txtAdresa.Enabled = true;
                txtTelefon.Enabled = true;
                txtSpecijalnost.Enabled = false;
            }
            else if (cbxTip.SelectedIndex == 3)
            {
                txtAdresa.Enabled = true;
                txtTelefon.Enabled = true;
                txtSpecijalnost.Enabled = false;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (dtpRodjenje.Value >= DateTime.Today)
            {
                MessageBox.Show("Nevalidan datum rodjenja!");
                return;
            }
            if (txtIme.Text != "" && txtPrezime.Text != "" && txtImeOca.Text != "" && txtMbr.Text != "")
            {
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                string imeOca = txtImeOca.Text;
                string jmbg = txtMbr.Text;
                DateTime r = dtpRodjenje.Value;
                DateTime z = dtpZaposlenje.Value;
                if (jmbg.Length != 13)
                    MessageBox.Show("JMBG treba imati 13 cifara!");
                else
                {
                    //mehanicar
                    if (cbxTip.SelectedIndex == 0 || cbxTip.SelectedIndex == 1)
                    {
                        if (txtSpecijalnost.Text != "")
                        {
                            string tip;
                            if (cbxTip.SelectedIndex == 0)
                                tip = "MehanicarKia";
                            else
                                tip = "MehanicarHyundai";
                            MehanicarAdd novi = new MehanicarAdd(tip, jmbg, ime, imeOca, prezime, r, z, txtSpecijalnost.Text);
                            DTOManager.AddMehanicar(novi);
                            DialogResult = System.Windows.Forms.DialogResult.OK;
                        }
                        else
                            MessageBox.Show("Popunite sva polja!");

                    }
                    //predstavnik
                    else
                    {
                        if (txtAdresa.Text != "" && txtTelefon.Text != "")
                        {
                            string tip;
                            if (cbxTip.SelectedIndex == 2)
                                tip = "PredstavnikKia";
                            else
                                tip = "PredstavnikHyundai";

                            PredstavnikAdd novi = new PredstavnikAdd(tip, jmbg, ime, imeOca, prezime, r, z, txtAdresa.Text, txtTelefon.Text);
                            DTOManager.AddPredstavnik(novi);
                            DialogResult = System.Windows.Forms.DialogResult.OK;
                        }
                        else MessageBox.Show("Popunite sva polja!");
                    }
                }
            }
            else
                MessageBox.Show("Popunite sva polja!");
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

        private void txtMbr_TextChanged(object sender, EventArgs e)
        {
            if (txtMbr.Text.Length > 13)
                return;
        }
    }
}
