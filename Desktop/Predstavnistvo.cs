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

        private void btnImeni_Click(object sender, EventArgs e)
        {
            //uzimamo id predstavnistva
            int id = 4;
            // string g=  dgvPredstavnistvo.SelectedCells.ToString();
            //  int.TryParse(g, out id);
            if (id == 0)
                MessageBox.Show("nece mrrk");
            //ucitaj pred
            PredstavnistvoPregled p = DTOManager.GetPredstavnistvo(id);
            frmIzmeniPredstavnistvo dlg = new frmIzmeniPredstavnistvo(p);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PredstavnistvoPregled pr = dlg.pred;
                //snimi
                DTOManager.UpdatePredstavnistvo(pr);
                //Poziv InitPredstavnistva() za refresh DGV-a
            }
        }

        private void btnObrisiPredstavnistvo_Click(object sender, EventArgs e)
        {
            //uzimamo id predstavnistva
            int id = 3;
            //treba da se doda uzimanje indeksa iz dgv
            // string g=  dgvPredstavnistvo.SelectedCells.ToString();
            PredstavnistvoPregled p = DTOManager.GetPredstavnistvo(id);
            DTOManager.DeletePredstavnistvo(p);
        }

        private void btnDodajPredstavnistvo_Click(object sender, EventArgs e)
        {
            frmDodajPredstavnistvo dlg = new frmDodajPredstavnistvo();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PredstavnistvoPregled p = dlg.p;
                DTOManager.AddPredstavnistvo(p);
            }
        }
    }
}
