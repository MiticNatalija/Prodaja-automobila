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
    public partial class frmPromeniPredstavnika : Form
    {
        string tip;
        int idPredstavnistva;
        public frmPromeniPredstavnika(int id,string tip)
        {
            InitializeComponent();
            if (tip.Equals("Kia"))
                cbxPredstavnici.DataSource = DTOManager.GetFreeKiaPredstavnik();
            else if(tip.Equals("Hyundai"))
                cbxPredstavnici.DataSource = DTOManager.GetFreeHyundaiPredstavnik();
            this.tip = tip;
            idPredstavnistva = id;
        }

        private void buttbtnOk_Click(object sender, EventArgs e)
        {
            if (cbxPredstavnici.SelectedItem == null)
            {
                MessageBox.Show("Nije selektovan nijedan predstavnik.");
                return;
            }
            PredstavnikPick pom = (PredstavnikPick)cbxPredstavnici.SelectedItem;
            if (tip.Equals("Kia"))
                DTOManager.ChangePredstavnikKia(idPredstavnistva, pom.PredstavnikId);

            else if (tip.Equals("Hyundai"))
                DTOManager.ChangePredstavnikHyundai(idPredstavnistva, pom.PredstavnikId);

            DialogResult = DialogResult.OK;
        }
    }
}
