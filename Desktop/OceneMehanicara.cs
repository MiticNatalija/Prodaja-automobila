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
using Desktop.Entiteti;

namespace Desktop
{
    public partial class OceneMehanicara : Form
    {
        public ZaposleniPregled Predstavnik { get; set; }
        List<MehanicarOcenaPregled> tesirani;
        List<MehanicarOceni> zaTestiranje;
        public OceneMehanicara(ZaposleniPregled zaposleniPregled)
        {
            InitializeComponent();
            Predstavnik = zaposleniPregled;
            zaTestiranje = DTOManager.GetMehanicariForOcenjivanje(Predstavnik.ZaposleniId);
            tesirani = DTOManager.GetOceneMehanicara(Predstavnik.ZaposleniId);
            init();
            dgvOceneMehanicara.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvOceneMehanicara.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void init()
        {
            dgvOceneMehanicara.DataSource = tesirani;
            dgvMehanicari.DataSource = zaTestiranje;
        }

        private void btnOceniMehanicara_Click(object sender, EventArgs e)
        {
            MehanicarOceni m = (MehanicarOceni)dgvMehanicari.CurrentRow.DataBoundItem;

            frmTestiraj frm = new frmTestiraj();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                tesirani.Add(DTOManager.AddTest(Predstavnik.ZaposleniId, m.MehanicarId, frm.ocena, frm.datum));
               
            }
            init();

        }
    }
}
