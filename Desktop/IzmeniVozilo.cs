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
            v.Registracija = txtRegistracija.Text;
            v.Gorivo = txtGorivo.Text;
            v.TipVozila = txtTipVozila.Text;
            if (txtTipVozila.Text == "Putnicko vozilo")
            {
                v.BrojMesta = Convert.ToInt32(txtBrojMesta.Text);
                v.Nosivost = null;
            }
            else if (txtTipVozila.Text == "Teretno vozilo")
            {
                v.Nosivost = Convert.ToInt32(txtNosivost.Text);
                v.BrojMesta = null;
            }
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
    }
}
