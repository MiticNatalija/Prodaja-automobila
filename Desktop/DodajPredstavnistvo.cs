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
    public partial class frmDodajPredstavnistvo : Form
    {
        public PredstavnistvoAdd Predstavnistvo { get; set; }
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
           if(txtAdresa.Text=="" || dtpDatum.Value == null )//|| (cbxPredstavnikKia.SelectedItem == null && cbxPredstavnikHyundai.SelectedItem == null))
            {
                MessageBox.Show("Popunite sva polja!");
                return;
            }
            Predstavnistvo = new PredstavnistvoAdd(txtAdresa.Text, dtpDatum.Value, cbxTip.SelectedItem.ToString());
            if (cbxTip.SelectedIndex == 0 || cbxTip.SelectedIndex == 1 || cbxTip.SelectedIndex == 2 || cbxTip.SelectedIndex == 3)
            {
                Predstavnistvo.DatumLicence = dtpLicenca.Value;
            }
            if(cbxTip.SelectedIndex == 0 || cbxTip.SelectedIndex == 3 || cbxTip.SelectedIndex == 5)
            {
                if (cbxPredstavnikHyundai.Items.Count == 0)
                {
                    MessageBox.Show("Zao nam je,nema slobodnih predstavnika!");
                    return;
                }
                Predstavnistvo.PredstavnikHyundaiId = ((PredstavnikPick)cbxPredstavnikHyundai.SelectedValue).PredstavnikId;
            }
            else if(cbxTip.SelectedIndex == 4 || cbxTip.SelectedIndex == 7 || cbxTip.SelectedIndex == 8)
            {
                if (cbxPredstavnikKia.Items.Count == 0)
                {
                    MessageBox.Show("Zao nam je,nema slobodnih predstavnika!");
                    return;
                }
                Predstavnistvo.PredstavnikKiaId = ((PredstavnikPick)cbxPredstavnikKia.SelectedValue).PredstavnikId;
            }
            else
            {
                if (cbxPredstavnikKia.Items.Count == 0 || cbxPredstavnikHyundai.Items.Count==0)
                {
                    MessageBox.Show("Zao nam je,nema slobodnih predstavnika!");
                    return;
                }
                Predstavnistvo.PredstavnikHyundaiId = ((PredstavnikPick)cbxPredstavnikHyundai.SelectedValue).PredstavnikId;
                Predstavnistvo.PredstavnikKiaId = ((PredstavnikPick)cbxPredstavnikKia.SelectedValue).PredstavnikId;
            }
                DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void cbxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTip.SelectedIndex == 0 || cbxTip.SelectedIndex == 3)
            {
                dtpLicenca.Enabled = true;
                cbxPredstavnikHyundai.Enabled = true;
                cbxPredstavnikKia.Enabled = false;
                cbxPredstavnikHyundai.DataSource = DTOManager.GetFreeHyundaiPredstavnik();
            }
            else if(cbxTip.SelectedIndex == 5)
            {
                dtpLicenca.Enabled = true;
                cbxPredstavnikHyundai.Enabled = true;
                cbxPredstavnikKia.Enabled = false;
                cbxPredstavnikHyundai.DataSource = DTOManager.GetFreeHyundaiPredstavnik();
            }
            else if(cbxTip.SelectedIndex == 1 || cbxTip.SelectedIndex == 2)
            {
                dtpLicenca.Enabled = true;
                cbxPredstavnikHyundai.Enabled = true;
                cbxPredstavnikKia.Enabled = true;
                cbxPredstavnikHyundai.DataSource = DTOManager.GetFreeHyundaiPredstavnik();
                cbxPredstavnikKia.DataSource = DTOManager.GetFreeKiaPredstavnik();
            }
            else if(cbxTip.SelectedIndex == 6)
            {
                dtpLicenca.Enabled = false;
                cbxPredstavnikHyundai.Enabled = true;
                cbxPredstavnikKia.Enabled = true;
                cbxPredstavnikHyundai.DataSource = DTOManager.GetFreeHyundaiPredstavnik();
                cbxPredstavnikKia.DataSource = DTOManager.GetFreeKiaPredstavnik();
            }
            else
            {
                dtpLicenca.Enabled = false;
                cbxPredstavnikHyundai.Enabled = false;
                cbxPredstavnikKia.Enabled = true;
                cbxPredstavnikKia.DataSource = DTOManager.GetFreeKiaPredstavnik();
            }
        }

        private void txtAdresa_Leave(object sender, EventArgs e)
        {
            if (txtAdresa.Text.Length >= 1)
                txtAdresa.Text = txtAdresa.Text.Substring(0, 1).ToUpper() + txtAdresa.Text.Substring(1);
        }
    }
}
