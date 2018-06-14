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
    public partial class frmServisiranjePregled : Form
    {
        List<ServisPregled> servisi = new List<ServisPregled>();
        public frmServisiranjePregled()
        {
            InitializeComponent();
        }
        public frmServisiranjePregled(List<ServisPregled> servisi)
        {
            InitializeComponent();
            this.servisi = servisi;

            dgvServisi.DataSource = servisi;
            dgvServisi.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvServisi.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void frmServisiranjePregled_Leave(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void dgvServisi_DoubleClick(object sender, EventArgs e)
        {

            ServisPregled ser =(ServisPregled) dgvServisi.CurrentRow.DataBoundItem;
            int id = ser.IdKnjizice;

           List<MehanicarPlain> lista= DTOManager.GetMehanicariUKnjizici(id);
            string prikaz = "";
            foreach(MehanicarPlain m in lista)
            {
                prikaz += m.Mbr + " " + m.LicnoIme + " " + m.ImeOca + " " + m.Prezime;
                prikaz += "\n";
               // MessageBox.Show(m.Mbr + " " + m.LicnoIme + " " + m.ImeOca + " " + m.Prezime);
            }
            MessageBox.Show(prikaz);
        }
    }
}
