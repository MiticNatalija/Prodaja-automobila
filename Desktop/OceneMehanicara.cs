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
    public partial class OceneMehanicara : Form
    {
        public ZaposleniPregled Predstavnik { get; set; }
        public OceneMehanicara(ZaposleniPregled zaposleniPregled)
        {
            InitializeComponent();
            Predstavnik = zaposleniPregled;
            dgvOceneMehanicara.DataSource = DTOManager.GetOceneMehanicara(Predstavnik.ZaposleniId);
            dgvMehanicari.DataSource = DTOManager.GetMehanicariForOcenjivanje(Predstavnik.ZaposleniId);
        }

        private void btnOceniMehanicara_Click(object sender, EventArgs e)
        {

        }
    }
}
