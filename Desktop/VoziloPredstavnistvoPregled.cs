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

namespace Desktop
{
    public partial class VoziloPredstavnistvoPregled : Form
    {
        private PredstavnistvoPregled Predstavnistvo { get; set; }
        private List<VoziloPregled> Vozila { get; set; }

        public VoziloPredstavnistvoPregled(PredstavnistvoPregled predstavnistvoPregled)
        {
            InitializeComponent();
            Predstavnistvo = predstavnistvoPregled;
            Vozila = DTOManager.GetVozilaForSalon(Predstavnistvo.PredstavnistvoId);
            dgvAutomobili.DataSource = Vozila;
        }
    }
}
