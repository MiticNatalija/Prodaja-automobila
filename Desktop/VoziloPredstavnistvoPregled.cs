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
using Desktop.Entiteti;

namespace Desktop
{
    public partial class VoziloPredstavnistvoPregled : Form
    {
        private PredstavnistvoPregled Predstavnistvo { get; set; }
        //private Predstavnistvo p { get; set; }
        private List<VoziloPregled> Vozila { get; set; }

        public VoziloPredstavnistvoPregled(PredstavnistvoPregled predstavnistvoPregled)
        {
            InitializeComponent();
            Predstavnistvo = predstavnistvoPregled;
            
            Vozila = DTOManager.GetVozilaForSalon(Predstavnistvo.PredstavnistvoId);
            dgvAutomobili.DataSource = Vozila;
           // InitVozila();
        }
        public void InitVozila()
        {
           // Vozila = DTOManager.GetVozilaForSalon(Predstavnistvo.PredstavnistvoId);
            dgvAutomobili.DataSource =DTOManager.GetVozilaForSalon(Predstavnistvo.PredstavnistvoId) ;
        }
        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            frmDodajVozilo dlg = new frmDodajVozilo(Predstavnistvo);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                VoziloPregled v = dlg.v;
                
                DTOManager.AddVozilo(v);
                InitVozila();
            }
        }

        private void btnIzmeniVozilo_Click(object sender, EventArgs e)
        {
            VoziloPregled tmp = (VoziloPregled)dgvAutomobili.CurrentRow.DataBoundItem;

            VoziloPregled p = DTOManager.GetVozilo(tmp.VoziloId); 

            frmIzmeniVozilo dlg = new frmIzmeniVozilo(p);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                VoziloPregled pr = dlg.v;
                DTOManager.UpdateVozilo(pr);
                InitVozila();
            }
        }

        private void btnIzbrisiVozilo_Click(object sender, EventArgs e)
        {
            VoziloPregled tmp = (VoziloPregled)dgvAutomobili.CurrentRow.DataBoundItem;
            DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da obriste izabrano vozilo?", "Brisanje vozila", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                VoziloPregled p = DTOManager.GetVozilo(tmp.VoziloId);
                DTOManager.DeleteVozilo(p.VoziloId);
                InitVozila();
            }
        }

        private void btnProdajVozilo_Click(object sender, EventArgs e)
        {
            VoziloPregled tmp = (VoziloPregled)dgvAutomobili.CurrentRow.DataBoundItem;
            VoziloPregled p = DTOManager.GetVozilo(tmp.VoziloId);

            frmProdajVozilo dlg = new frmProdajVozilo(p);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Podaci o prodaji vozila su uneseni.");
                InitVozila();
            }
        }
    }
}
