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
    public partial class frmTestiraj : Form
    {
        public int ocena;
        public DateTime datum;
        public frmTestiraj()
        {
            InitializeComponent();
            cbxOcena.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
            ocena =int.Parse( cbxOcena.SelectedItem.ToString());
            datum = dtpDatum.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
