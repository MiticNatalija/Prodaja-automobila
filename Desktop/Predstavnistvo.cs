using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.DTOManagers;
using Desktop.DTOs;

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
            dgvPredstavnistvo.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
        }

        private void InitZaposlnih()
        {
            dgvPredstavnik.DataSource = DTOManager.GetZaposleniInfos();
            dgvPredstavnik.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvPredstavnik.Columns[5].DefaultCellStyle.Format = "dd.MM.yyyy";
        }

        private void btnIzmeniPredstavnistvo_Click(object sender, EventArgs e)
        {
            PredstavnistvoPregled tmp = (PredstavnistvoPregled)dgvPredstavnistvo.CurrentRow.DataBoundItem;

            PredstavnistvoPregled p = DTOManager.GetPredstavnistvo(tmp.PredstavnistvoId);

            frmIzmeniPredstavnistvo dlg = new frmIzmeniPredstavnistvo(p);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PredstavnistvoPregled pr = dlg.Predstavnistvo;
                DTOManager.UpdatePredstavnistvo(pr);
                InitPredstavnistava();
            }
        }

        private void btnObrisiPredstavnistvo_Click(object sender, EventArgs e)
        {
            PredstavnistvoPregled tmp = (PredstavnistvoPregled)dgvPredstavnistvo.CurrentRow.DataBoundItem;
            DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da obriste izabrano predstavnistvo?", "Brisanje predstavnistva", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                PredstavnistvoPregled p = DTOManager.GetPredstavnistvo(tmp.PredstavnistvoId);
                DTOManager.DeletePredstavnistvo(p);
                InitPredstavnistava();
            }
        }

        private void btnDodajPredstavnistvo_Click(object sender, EventArgs e)
        {
            frmDodajPredstavnistvo dlg = new frmDodajPredstavnistvo();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PredstavnistvoPregled p = dlg.p;
                DTOManager.AddPredstavnistvo(p);
                InitPredstavnistava();
            }
        }
    }
}
