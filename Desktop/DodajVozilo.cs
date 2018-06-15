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
    public partial class frmDodajVozilo : Form
    {
        public VoziloPregled v;
        public PredstavnistvoPregled p;
        int kojaForma;
        //public int PredstavnistvoId;

        public frmDodajVozilo(string reg)
        {
            InitializeComponent();
            kojaForma = 0;
            cbxTipVozila.Items.Add("Putnicko vozilo");
            cbxTipVozila.Items.Add("Teretno vozilo");
            txtBrojMesta.Enabled = false;
            txtNosivost.Enabled = false;
            txtRegistracija.Text = reg;
            txtRegistracija.Enabled = false;
        }
        public frmDodajVozilo(PredstavnistvoPregled p)
        {
            InitializeComponent();
            cbxTipVozila.Items.Add("Putnicko vozilo");
            cbxTipVozila.Items.Add("Teretno vozilo");
            //cbxTipVozila.SelectedIndex = 0;
            txtBrojMesta.Enabled = false;
            txtNosivost.Enabled = false;
            // this.PredstavnistvoId = predstavnistvoId;
            this.p = p;
            kojaForma = 1;
        }


        

        private void cbxTipVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipVozila.SelectedIndex == 0)
            {
                txtBrojMesta.Enabled = true;
                txtNosivost.Enabled = false;
            }
            else if (cbxTipVozila.SelectedIndex == 1)
            {
                txtNosivost.Enabled = true;
                txtBrojMesta.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (kojaForma == 1)
            {
                if (txtRegistracija.Text == "" || txtGorivo.Text == "" || txtOznakaMotora.Text=="")
                {
                    MessageBox.Show("Popunite sva polja!");
                    return;
                }
                if (cbxTipVozila.SelectedItem == null)
                {
                    MessageBox.Show("Unesite tip vozila!");
                    return;
                }
                if (cbxTipVozila.SelectedIndex == 0)
                {
                    if(txtBrojMesta.Text=="" || int.Parse(txtBrojMesta.Text) > 9)
                    {
                        MessageBox.Show("Broj mesta je neodgovarajuci!");
                        return;
                    }
                }
                else
                {
                    if (txtNosivost.Text == "")
                    {
                        MessageBox.Show("Unesite nosivost!");
                        return;
                    }
                }
                v = new VoziloPregled(txtRegistracija.Text, txtGorivo.Text, cbxTipVozila.SelectedItem.ToString(), txtOznakaMotora.Text);
                if (cbxTipVozila.SelectedIndex == 0)
                {
                    v.BrojMesta = Convert.ToInt32(txtBrojMesta.Text);
                }
                else if (cbxTipVozila.SelectedIndex == 1)
                {
                    v.Nosivost = Convert.ToInt32(txtNosivost.Text);
                }

                v.PredstavnistvoPregled = p;

                DialogResult = System.Windows.Forms.DialogResult.OK;

            }
            else
            {
                if (txtGorivo.Text == "" || txtOznakaMotora.Text == "")
                {
                    MessageBox.Show("Popunite sva polja!");
                    return;
                }
                if (cbxTipVozila.SelectedItem == null)
                {
                    MessageBox.Show("Unesite tip vozila!");
                    return;
                }
                if (cbxTipVozila.SelectedIndex == 0)
                {
                    if (txtBrojMesta.Text == "" || int.Parse(txtBrojMesta.Text) > 9)
                    {
                        MessageBox.Show("Broj mesta je neodgovarajuci!");
                        return;
                    }
                }
                else
                {
                    if (txtNosivost.Text == "")
                    {
                        MessageBox.Show("Unesite nosivost!");
                        return;
                    }
                }
                v = new VoziloPregled(txtRegistracija.Text, txtGorivo.Text, cbxTipVozila.SelectedItem.ToString(), txtOznakaMotora.Text);
                if (cbxTipVozila.SelectedIndex == 0)
                {
                    v.BrojMesta = Convert.ToInt32(txtBrojMesta.Text);
                }
                else if (cbxTipVozila.SelectedIndex == 1)
                {
                    v.Nosivost = Convert.ToInt32(txtNosivost.Text);
                }
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

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
