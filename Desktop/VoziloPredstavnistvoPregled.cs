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
        private List<PredstavnikInfo> Predstavnici { get; set; }
        private List<ProdatoVozilo> prodataVozila { get; set; }

        public VoziloPredstavnistvoPregled(PredstavnistvoPregled predstavnistvoPregled)
        {
            InitializeComponent();
            dgvProdataVozila.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvProdataVozila.DefaultCellStyle.SelectionForeColor = Color.Black;
            Predstavnistvo = predstavnistvoPregled;
            
            Vozila = DTOManager.GetVozilaForSalon(Predstavnistvo.PredstavnistvoId);
            dgvAutomobili.DataSource = Vozila;

            
            prodataVozila = DTOManager.GetProdataVozila(Predstavnistvo.PredstavnistvoId);

            dgvProdataVozila.DataSource = prodataVozila;

             Predstavnici = DTOManager.GetPredstavniciForPredstavnistvo(predstavnistvoPregled.PredstavnistvoId);
           

        }
        public void InitVozila()
        {
         
            dgvAutomobili.DataSource =DTOManager.GetVozilaForSalon(Predstavnistvo.PredstavnistvoId) ;
            dgvProdataVozila.DataSource= DTOManager.GetProdataVozila(Predstavnistvo.PredstavnistvoId);
          
        }
        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
           
            frmDodajVozilo dlg = new frmDodajVozilo(Predstavnistvo);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                VoziloPregled v = dlg.v;
                Vozilo novo = DTOManager.GetVoziloPrekoRegistracije(v.Registracija);
                if (novo == null)
                {
                    DTOManager.AddVozilo(v);
                    InitVozila();
                }
                else
                    MessageBox.Show("Vozilo vec postoji u bazi!");
            }
        }

        private void btnIzmeniVozilo_Click(object sender, EventArgs e)
        {
            if (dgvAutomobili.RowCount == 0)
            {
                MessageBox.Show("Nije selektovano nijedno vozilo!");
                return;
            }
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
            if (dgvAutomobili.RowCount == 0)
            {
                MessageBox.Show("Nije selektovano nijedno vozilo!");
                return;
            }
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
            if(dgvAutomobili.RowCount==0)
            {
                MessageBox.Show("Nije selektovano nijedno vozilo!");
                return;
            }
            VoziloPregled tmp = (VoziloPregled)dgvAutomobili.CurrentRow.DataBoundItem;
           
            VoziloPregled p = DTOManager.GetVozilo(tmp.VoziloId);

            frmProdajVozilo dlg = new frmProdajVozilo(p,Predstavnici);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Podaci o prodaji vozila su uneseni.");
                InitVozila();
            }
        }
    }
}
