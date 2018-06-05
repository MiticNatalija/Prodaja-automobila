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
    public partial class frmIzmeniPredstavnistvo : Form
    {
        public PredstavnistvoPregled pred;
        public frmIzmeniPredstavnistvo()
        {
            InitializeComponent();
        }
        public frmIzmeniPredstavnistvo(PredstavnistvoPregled p)
        {
            pred = p;
            InitializeComponent();
            fill();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            pred.Adresa = txtAdresa.Text;
            pred.DatumOtvaranja = dtpDatum.Value;
            
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void fill() {
            txtAdresa.Text = pred.Adresa;
            dtpDatum.Value = pred.DatumOtvaranja;
        }
    }
}
