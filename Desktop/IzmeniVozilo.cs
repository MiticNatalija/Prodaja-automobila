using Desktop.DTOs;
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
    public partial class frmIzmeniVozilo : Form
    {
        public VoziloPregled v;
        public frmIzmeniVozilo()
        {
            InitializeComponent();
        }
        public frmIzmeniVozilo(VoziloPregled v)
        {
            this.v = v;
            InitializeComponent();
            fill();
        }

        private void fill()
        {
            txtRegistracija.Text = v.Registracija;
            txtGorivo.Text = v.Gorivo;
            txtTipVozila.Text = v.TipVozila;
            txtTipVozila.Enabled = false;

            if (v.TipVozila == "Putnicko vozilo")
            {
                txtBrojMesta.Text = v.BrojMesta.ToString();
                txtNosivost.Enabled = false;
            }
            else if (v.TipVozila == "Teretno vozilo")
            {
                txtBrojMesta.Enabled = false ;
                txtNosivost.Text=v.Nosivost.ToString();
            }

            txtOznakaMotora.Text = v.OznakaMotora;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtGorivo.Text == "" || txtRegistracija.Text=="" || txtOznakaMotora.Text=="")
            {
                MessageBox.Show("Popunite sva polja!");
                return;
            }
            if (txtTipVozila.Text == "Putnicko vozilo")
            {

                if ( txtBrojMesta.Text=="" || int.Parse(txtBrojMesta.Text) > 9 )
                {
                    MessageBox.Show("Broj mesta mora biti manji od 9!");
                    return;
                }
                v.BrojMesta = Convert.ToInt32(txtBrojMesta.Text);
                v.Nosivost = null;
            }
            else if (txtTipVozila.Text == "Teretno vozilo")
            {
                if (txtNosivost.Text == "")
                {
                    MessageBox.Show("Popunite sva polja!");
                    return;
                }
                v.Nosivost = Convert.ToInt32(txtNosivost.Text);
                v.BrojMesta = null;
            }
            
            v.Registracija = txtRegistracija.Text;
            v.Gorivo = txtGorivo.Text;
            v.TipVozila = txtTipVozila.Text;
           

            v.OznakaMotora = txtOznakaMotora.Text;

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void txtBrojMesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNosivost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGorivo_Leave(object sender, EventArgs e)
        {
            if (txtGorivo.Text.Length >= 1)
                txtGorivo.Text = txtGorivo.Text.Substring(0, 1).ToUpper() + txtGorivo.Text.Substring(1);
        }
    }
}
