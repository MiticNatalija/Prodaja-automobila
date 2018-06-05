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
    public partial class frmPredstavnistvo : Form
    {
        public frmPredstavnistvo()
        {
            InitializeComponent();
            InitPredstavnistava();
        }

        private void tabPrikaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabPrikaz.SelectedIndex)
            {
                case 0:
                    InitPredstavnistava();
                    break;
                case 1:
                    InitZaposlnih();
                    break;
            }
        }

        private void InitPredstavnistava()
        {
            dgvPredstavnistvo.DataSource = DTOManager.GetPredstavnistvoInfos();
            dgvPredstavnistvo.Columns[1].DefaultCellStyle.Format = "dd.MM.yyyy";
        }

        private void InitZaposlnih()
        {
            dgvPredstavnik.DataSource = DTOManager.GetZaposleniInfos();
            dgvPredstavnik.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvPredstavnik.Columns[5].DefaultCellStyle.Format = "dd.MM.yyyy";
        }
    }
}
