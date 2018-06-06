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
            fill();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Predstavnistvo.Adresa = txtAdresa.Text;
            Predstavnistvo.DatumOtvaranja = dtpDatum.Value;
            
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void fill()
        {
            txtAdresa.Text = Predstavnistvo.Adresa;
            dtpDatum.Value = Predstavnistvo.DatumOtvaranja;
        }
    }
}
