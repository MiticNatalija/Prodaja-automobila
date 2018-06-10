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
                DTOManager.DeletePredstavnistvo(p.PredstavnistvoId);
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

        private void btnPredstavnik_Click(object sender, EventArgs e)
        {
            PredstavnistvoPregled tmp = (PredstavnistvoPregled)dgvPredstavnistvo.CurrentRow.DataBoundItem;
            List<PredstavnikInfo> predstavnici = DTOManager.GetPredstavniciForPredstavnistvo(tmp.PredstavnistvoId);
            //u ovoj gore fji baca exc jer nema predstavnika,mada msm da to nema veze jer cemo da sredimo bazu da svi moraju da imaju predstavnika
            if (predstavnici.Count == 0)
            {
                MessageBox.Show("Nema predstavnika!");
                return;
            }
            PredstavnikInfos frm = new PredstavnikInfos(predstavnici);
            frm.ShowDialog();
        }

        private void dgvPredstavnistvo_SelectionChanged(object sender, EventArgs e)
        {
            PredstavnistvoPregled tmp = (PredstavnistvoPregled)dgvPredstavnistvo.CurrentRow.DataBoundItem;
            if (tmp.Tip.Contains("Salon"))
                btnSalonAutomobili.Enabled = true;
            else
                btnSalonAutomobili.Enabled = false;

            if (tmp.Tip.Contains("Servis"))
                btnServisVozila.Enabled = true;
            else
                btnServisVozila.Enabled = false;
        }

        private void btnSalonAutomobili_Click(object sender, EventArgs e)
        {
            PredstavnistvoPregled tmp = (PredstavnistvoPregled)dgvPredstavnistvo.CurrentRow.DataBoundItem;
            VoziloPredstavnistvoPregled frm = new VoziloPredstavnistvoPregled(tmp);
            frm.ShowDialog();
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            DodajZaposlenog frm = new DodajZaposlenog();
            frm.ShowDialog();
        }

        private void btnIzmeniRadnika_Click(object sender, EventArgs e)
        {
            ZaposleniPregled tmp = (ZaposleniPregled)dgvPredstavnik.CurrentRow.DataBoundItem;
            ZaposleniIzmena p = DTOManager.GetZaposleni(tmp.ZaposleniId);

            IzmeniZaposlenog frm = new IzmeniZaposlenog(p);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
                InitZaposlnih();

        }

        private void btnObrisiRadnika_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da obrisete ovog radnika?", "Brisanje zaposlenog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
                return;
            ZaposleniPregled tmp = (ZaposleniPregled)dgvPredstavnik.CurrentRow.DataBoundItem;
            DTOManager.DeleteZaposleni(tmp.ZaposleniId);
            InitZaposlnih();
        }

        private void btnServisVozila_Click(object sender, EventArgs e)
        {
            // Ne radi deo kada treba da se lista mehanicara doda knjizici
            // i novokreirana knjizica da se doda u listu knjizica svakom mehanicaru 

            PredstavnistvoPregled tmp = (PredstavnistvoPregled)dgvPredstavnistvo.CurrentRow.DataBoundItem;
            frmServisVozila frm = new frmServisVozila(tmp);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Uneti su podaci o novom servisu vozila.");
            }
        }
    }
}
