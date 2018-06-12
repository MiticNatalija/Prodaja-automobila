﻿using Desktop.DTOManagers;
using Desktop.DTOs;
using Desktop.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class frmServisVozila : Form
    {
        public PredstavnistvoPregled predstavnistvo;
    

        public List<MehanicarPrikaz> dodmehanicari = new List<MehanicarPrikaz>();

        public frmServisVozila()
        {
            InitializeComponent();
        }
        public frmServisVozila(PredstavnistvoPregled p)
        {
            this.predstavnistvo = p;
          
            InitializeComponent();
            InitMehanicari();
            this.Width = 500;
            this.Height = 110;
            


        }
        public void InitMehanicari()
        {
            dgvMehanicari.DataSource = DTOManager.GetMehanicari(predstavnistvo.PredstavnistvoId);
            
          
        }
        private void btnDodajMehanicara_Click(object sender, EventArgs e)
        {

     
            MehanicarPrikaz m = (MehanicarPrikaz)dgvMehanicari.CurrentRow.DataBoundItem;
       

            dodmehanicari.Add(m);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dodmehanicari.Count == 0)
            {
                MessageBox.Show("Dodajte mehanicare!");
                return;
            }
            if(txtCenaUsluge.Text=="" || txtRadovi.Text=="" || txtRegistracija.Text=="")
            {
               
                MessageBox.Show("Popunite sva polja!");
                return;
            }
            if (txtAdresaVlasnika.Visible)
            {
                if(txtAdresaVlasnika.Text=="" || txtTelefonVlasnika.Text == "")
                {
                    MessageBox.Show("Popunite sva polja!");
                    return;
                }

            }
           
             Vozilo vozilo = DTOManager.GetVoziloPrekoRegistracije(txtRegistracija.Text);
            if (vozilo.vlasnik == null)
            {
                Vlasnik vlasnik = new Vlasnik(txtTelefonVlasnika.Text, txtAdresaVlasnika.Text);
                vlasnik.Vozilo = vozilo;
                DTOManager.upisiVlasnika(vlasnik);
            }


            Knjizica knjizica = new Knjizica(dtpDatumIntervencije.Value, Convert.ToInt32(txtCenaUsluge.Text), txtRadovi.Text );
            knjizica.Vozilo = vozilo;
            knjizica.Servis = DTOManager.GetPredstavnistvo(predstavnistvo);

            List<Zaposleni> lista = new List<Zaposleni>();
            foreach(MehanicarPrikaz z in dodmehanicari)
            {
                Zaposleni zap = DTOManager.GetZaposleni(z.Mbr);
                lista.Add(zap);
                knjizica.Mehanicari.Add(zap);
            }

            DTOManager.UpisiKnjizicu(knjizica);


            DialogResult = System.Windows.Forms.DialogResult.OK;


        }

        private void btnPopusti_Click(object sender, EventArgs e)
        {
            if (txtRegistracija.Text == "")
                return;

            bool ind = DTOManager.CheckRegistracija(txtRegistracija.Text);
            if (ind)
            {

                VoziloPopust v = DTOManager.GetPopust(txtRegistracija.Text);

                txtRegistracija.Enabled = false;
                txtAdresaVlasnika.Visible = false;
                txtTelefonVlasnika.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                btnOK.Location = new Point(143, 423);

                this.Height = 500;
                if (v.PopustiServis == null && v.PopustiDelovi == null)
                    return;

                txtPopusti.Text = "";
                txtPopusti.AppendText("Popusti na delove:");
                txtPopusti.AppendText(Environment.NewLine);
                if(v.PopustiDelovi!=null)
                txtPopusti.AppendText(v.PopustiDelovi);
                txtPopusti.AppendText(Environment.NewLine);
                txtPopusti.AppendText("Popusti na servis:");
                if(v.PopustiServis!=null)
                txtPopusti.AppendText(Environment.NewLine);
                txtPopusti.AppendText(v.PopustiServis);

            }
            else
            {
                frmDodajVozilo frm = new frmDodajVozilo(txtRegistracija.Text);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    VoziloPregled v = frm.v;
                    DTOManager.NewVozilo(v);
                    MessageBox.Show("Vozilo je dodato!");
                   
                }

                foreach(Control c in this.Controls)
                {
                    c.Visible = true;

                }
                this.Height = 576;
                btnOK.Location = new Point(143, 492);
                btnPopusti.Enabled = false;
            }
        }
    }
}
