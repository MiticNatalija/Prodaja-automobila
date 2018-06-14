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
    public partial class ZavrsiRadniOdnos : Form
    {
        private AngazovanjeMehanicaraPregled Angazuje { get; set; }

        public ZavrsiRadniOdnos(AngazovanjeMehanicaraPregled angazuje)
        {
            InitializeComponent();
            Angazuje = angazuje;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Angazuje.KrajRada = dtpKrajRada.Value;
            Angazuje.Ocena = (int)numOcena.Value;
            DTOManager.UpdataAngazuje(Angazuje);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
