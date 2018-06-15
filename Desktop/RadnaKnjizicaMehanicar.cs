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
    public partial class RadnaKnjizicaMehanicar : Form
    {
        public ZaposleniPregled Mehanicar { get; set; }

        private List<AngazovanjeMehanicaraPregled> Lista { get; set; }

        public RadnaKnjizicaMehanicar(ZaposleniPregled mehanicar)
        {
            InitializeComponent();
            Mehanicar = mehanicar;
            txtIme.Text = Mehanicar.LicnoIme;
            txtJmbg.Text = Mehanicar.Mbr;
            txtPrezime.Text = Mehanicar.Prezime;
            Lista = DTOManager.GetAngazovanjaMehanicara(Mehanicar.ZaposleniId);
            InitData();
        }

        private void dgvRadnaKnjizica_SelectionChanged(object sender, EventArgs e)
        {
            AngazovanjeMehanicaraPregled tmp = (AngazovanjeMehanicaraPregled)dgvRadnaKnjizica.CurrentRow.DataBoundItem;
            if(tmp.KrajRada == null || tmp.KrajRada > DateTime.Today)
            {
                btnZavrsiRadniOdnos.Enabled = true;
            }
            else
            {
                btnZavrsiRadniOdnos.Enabled = false;
            }
        }

        private void btnZavrsiRadniOdnos_Click(object sender, EventArgs e)
        {
            AngazovanjeMehanicaraPregled tmp = (AngazovanjeMehanicaraPregled)dgvRadnaKnjizica.CurrentRow.DataBoundItem;
            ZavrsiRadniOdnos frm = new ZavrsiRadniOdnos(tmp);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                InitData();
            }
        }

        private void InitData()
        {
            dgvRadnaKnjizica.DataSource = typeof(List<>);
            dgvRadnaKnjizica.DataSource = Lista;
            bool zaposli = true;
            foreach(AngazovanjeMehanicaraPregled a in Lista)
                if(a.KrajRada == null ||DateTime.Today<a.KrajRada)
                {
                    zaposli = false;
                    return;
                }

            btnAngazuj.Enabled = zaposli;
        }

        private void btnAngazuj_Click(object sender, EventArgs e)
        {
            AngazaujMehanicaraServis frm = new AngazaujMehanicaraServis(Mehanicar);
            DialogResult dr = frm.ShowDialog();
            if(dr == DialogResult.OK)
            {
                Lista.Add(frm.Angazovanje);
                InitData();
            }
        }
    }
}
