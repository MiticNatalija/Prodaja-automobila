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

namespace Desktop
{
    public partial class PredstavnikInfos : Form
    {
        private List<PredstavnikInfo> Predstavnici { get; set; }

        public PredstavnikInfos()
        {
            InitializeComponent();
        }

        public PredstavnikInfos(List<PredstavnikInfo> predstavnici)
        {
            InitializeComponent();
            Predstavnici = predstavnici;
            foreach(PredstavnikInfo tmp in Predstavnici)
            {
                if(tmp.Tip == "PredstavnikHyundai")
                {
                    txtIme1.Text = tmp.LicnoIme;
                    txtImeOca1.Text = tmp.ImeOca;
                    txtPrezime1.Text = tmp.Prezime;
                }
                else if(tmp.Tip == "PredstavnikKia")
                {
                    txtIme2.Text = tmp.LicnoIme;
                    txtImeOca2.Text = tmp.ImeOca;
                    txtPrezime2.Text = tmp.Prezime;
                }
            }
        }
    }
}
