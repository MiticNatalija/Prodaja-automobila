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
        private int idPredstavnistva;
        public PredstavnikInfos()
        {
            InitializeComponent();
        }

        public PredstavnikInfos(List<PredstavnikInfo> predstavnici,int id)
        {
            InitializeComponent();
            idPredstavnistva = id;
            btnPromeniHyundai.Enabled = false;
            btnPromeniKia.Enabled = false;
            Predstavnici = predstavnici;
            foreach(PredstavnikInfo tmp in Predstavnici)
            {
                if(tmp.Tip == "PredstavnikHyundai")
                {
                    initHyundai(tmp);
                    //txtIme1.Text = tmp.LicnoIme;
                    //txtImeOca1.Text = tmp.ImeOca;
                    //txtPrezime1.Text = tmp.Prezime;
                    //txtJmbg1.Text = tmp.Mbr;
                    //txtDatumRodjenja1.Text = tmp.DatumRodjenja.ToString("dd.MM.yyyy");
                    //txtDatumZaposlenja1.Text = tmp.DatumZaposlenja.ToString("dd.MM.yyyy");
                    //txtAdresa1.Text = tmp.Adresa;
                    //txtTelefon1.Text = tmp.Telefon;
                    //txtBrojProdatihVozila1.Text = tmp.BrojProdatihVozila.ToString();
                    //btnPromeniHyundai.Enabled = true;
                }
                else if(tmp.Tip == "PredstavnikKia")
                {
                    initKia(tmp);
                    //txtIme2.Text = tmp.LicnoIme;
                    //txtImeOca2.Text = tmp.ImeOca;
                    //txtPrezime2.Text = tmp.Prezime;
                    //txtJmbg2.Text = tmp.Mbr;
                    //txtDatumRodjenja2.Text = tmp.DatumRodjenja.ToString("dd.MM.yyyy");
                    //txtDatumZaposlenja2.Text = tmp.DatumZaposlenja.ToString("dd.MM.yyyy");
                    //txtAdresa2.Text = tmp.Adresa;
                    //txtTelefon2.Text = tmp.Telefon;
                    //txtBrojProdatihVozila2.Text = tmp.BrojProdatihVozila.ToString();
                    //btnPromeniKia.Enabled = true;
                }
            }
        }
        private void initKia(PredstavnikInfo tmp)
        {
            txtIme2.Text = tmp.LicnoIme;
            txtImeOca2.Text = tmp.ImeOca;
            txtPrezime2.Text = tmp.Prezime;
            txtJmbg2.Text = tmp.Mbr;
            txtDatumRodjenja2.Text = tmp.DatumRodjenja.ToString("dd.MM.yyyy");
            txtDatumZaposlenja2.Text = tmp.DatumZaposlenja.ToString("dd.MM.yyyy");
            txtAdresa2.Text = tmp.Adresa;
            txtTelefon2.Text = tmp.Telefon;
            txtBrojProdatihVozila2.Text = tmp.BrojProdatihVozila.ToString();
            btnPromeniKia.Enabled = true;
        }
        private void initHyundai(PredstavnikInfo tmp)
        {
            txtIme1.Text = tmp.LicnoIme;
            txtImeOca1.Text = tmp.ImeOca;
            txtPrezime1.Text = tmp.Prezime;
            txtJmbg1.Text = tmp.Mbr;
            txtDatumRodjenja1.Text = tmp.DatumRodjenja.ToString("dd.MM.yyyy");
            txtDatumZaposlenja1.Text = tmp.DatumZaposlenja.ToString("dd.MM.yyyy");
            txtAdresa1.Text = tmp.Adresa;
            txtTelefon1.Text = tmp.Telefon;
            txtBrojProdatihVozila1.Text = tmp.BrojProdatihVozila.ToString();
            btnPromeniHyundai.Enabled = true;
        }

        private void btnPromeniHyundai_Click(object sender, EventArgs e)
        {
            frmPromeniPredstavnika frm = new frmPromeniPredstavnika(idPredstavnistva,"Hyundai");
          if(frm.ShowDialog() == DialogResult.OK)
            {
                if (Predstavnici[0].Tip == "PredstavnikHyundai")
                {
                    initHyundai(Predstavnici[0]);
                }
                else
                    initHyundai(Predstavnici[1]);
            }
            
        }

        private void btnPromeniKia_Click(object sender, EventArgs e)
        {
            frmPromeniPredstavnika frm = new frmPromeniPredstavnika(idPredstavnistva, "Kia");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (Predstavnici[0].Tip == "PredstavnikKia")
                {
                    initKia(Predstavnici[0]);
                }
                else
                    initKia(Predstavnici[1]);

            }
        }
    }
}
