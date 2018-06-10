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
        //public int PredstavnistvoId;

        public frmDodajVozilo()
        {
            InitializeComponent();
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
        }


        private void label1_Click(object sender, EventArgs e)
        {}

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
            if (txtRegistracija.Text == "" || txtGorivo.Text== "")
            {
                MessageBox.Show("Popunite sva polja!");
            }
            v = new VoziloPregled(txtRegistracija.Text, txtGorivo.Text, cbxTipVozila.SelectedItem.ToString(), txtOznakaMotora.Text);
            if (cbxTipVozila.SelectedIndex == 0)
            {
                v.BrojMesta = Convert.ToInt32(txtBrojMesta.Text);
            }
            else  if (cbxTipVozila.SelectedIndex == 1)
            {
                v.Nosivost = Convert.ToInt32(txtNosivost.Text);
            }

            v.PredstavnistvoPregled = p;

            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void txtGorivo_TextChanged(object sender, EventArgs e)
        { }
    }
}
