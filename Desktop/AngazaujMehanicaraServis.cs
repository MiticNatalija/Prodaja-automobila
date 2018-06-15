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
    public partial class AngazaujMehanicaraServis : Form
    {
        private ZaposleniPregled Mehanicar { get; set; }

        public AngazaujMehanicaraServis(ZaposleniPregled mehanicar)
        {
            InitializeComponent();
            Mehanicar = mehanicar;
            cbxServis.DataSource = DTOManager.GetServisiForAngazovanjeByTip(Mehanicar.Tip);
           
        }

        private void brnOk_Click(object sender, EventArgs e)
        {
            if(cbxServis.SelectedValue != null)
            {
                if (Mehanicar.DatumZaposlenja > dtpDatumPocetkaRada.Value) {
                    MessageBox.Show("Pogresan datum!"+Environment.NewLine+"Radnik je prvi put zaposljen: "+Mehanicar.DatumZaposlenja.ToShortDateString());
                }
                ServisAngazovanjePregled tmp = (ServisAngazovanjePregled)cbxServis.SelectedValue;
                DTOManager.CreateAngazuje(tmp.ServisId, Mehanicar.ZaposleniId, dtpDatumPocetkaRada.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
        }
    }
}
