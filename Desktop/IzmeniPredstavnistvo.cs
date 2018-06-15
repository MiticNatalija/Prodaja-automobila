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


namespace Desktop
{
    public partial class frmIzmeniPredstavnistvo : Form
    {
        public PredstavnistvoPregled Predstavnistvo { get; set; }

        public frmIzmeniPredstavnistvo()
        {
            InitializeComponent();
        }
        public frmIzmeniPredstavnistvo(PredstavnistvoPregled p)
        {
            Predstavnistvo = p;
            InitializeComponent();
            
            if (p.Tip.Equals("SalonHyundai") || p.Tip.Equals("SalonServisHyundai") || p.Tip.Equals("SalonHyundaiKia") || p.Tip.Equals("SalonServisHyundaiKia"))
                dtpLicenca.Enabled = true;
            else dtpLicenca.Enabled = false;

            fill();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtAdresa.Text == "")
            {
                MessageBox.Show("Unesite adresu!");
                return;
            }
            Predstavnistvo.Adresa = txtAdresa.Text;
            Predstavnistvo.DatumOtvaranja = dtpDatum.Value;
            if (dtpDatum.Enabled)
                Predstavnistvo.DatumLicence = dtpLicenca.Value;
            
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void fill()
        {
            txtAdresa.Text = Predstavnistvo.Adresa;
            dtpDatum.Value = Predstavnistvo.DatumOtvaranja;
            if (dtpLicenca.Enabled)
                dtpLicenca.Value =(DateTime)Predstavnistvo.DatumLicence;

        }

        private void txtAdresa_Leave(object sender, EventArgs e)
        {
            if (txtAdresa.Text.Length >= 1)
                txtAdresa.Text = txtAdresa.Text.Substring(0, 1).ToUpper() + txtAdresa.Text.Substring(1);
        }
    }
}
