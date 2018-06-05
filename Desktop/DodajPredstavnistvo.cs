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
    public partial class frmDodajPredstavnistvo : Form
    {
        public PredstavnistvoPregled p ;
        public frmDodajPredstavnistvo()
        {
            InitializeComponent();
          
            cbxTip.Items.Add("Salon za Hyundai");
            cbxTip.Items.Add("Salon za Hyundai i Kiu");
            cbxTip.Items.Add("Salon i Servis za Hyundai i Kiu");
            cbxTip.Items.Add("Salon i Servis za Hyundai");
            cbxTip.Items.Add("Servis za Kiu");
            cbxTip.Items.Add("Servis za Hyundai");
            cbxTip.Items.Add("Servis za Hyundai i Kiu");
            cbxTip.Items.Add("Salon za Kiu");
            cbxTip.Items.Add("Salon i Servis za Kiu");
            

            cbxTip.SelectedIndex = 0;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           if(txtAdresa.Text=="" || dtpDatum.Value == null)
            {
                MessageBox.Show("Popunite sva polja!");
            }
            p = new PredstavnistvoPregled(txtAdresa.Text, dtpDatum.Value, cbxTip.SelectedItem.ToString());
            if (cbxTip.SelectedIndex == 0 || cbxTip.SelectedIndex == 1 || cbxTip.SelectedIndex == 2 || cbxTip.SelectedIndex == 3)
            {
                p.DatumLicence = dtpLicenca.Value;
            }
                DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void cbxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTip.SelectedIndex==0 || cbxTip.SelectedIndex==1 || cbxTip.SelectedIndex == 2 || cbxTip.SelectedIndex == 3)
            {
                
                dtpLicenca.Enabled = true;
            }
            else
                dtpLicenca.Enabled = false;
        }
    }
}
