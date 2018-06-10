using Desktop.DTOManagers;
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
        public frmServisVozila()
        {
            InitializeComponent();
        }
        public frmServisVozila(PredstavnistvoPregled p)
        {
            this.predstavnistvo = p;
          
            InitializeComponent();
            InitMehanicari();
            
        }
        public void InitMehanicari()
        {
            dgvMehanicari.DataSource = DTOManager.GetMehanicariForServis(predstavnistvo);
            // prikazuje sve mehanicare koji rade u izabranom servisu, ali bolje bi bilo da
            // je dgv prazan pa na dugme Dodaj mehanicare da se otvori forma sa tom listom i onda da se cekiraju oni koji
            // su ucestvovaliu u servisiranju i samo oni da se ispisu u ovom dgv

            // Trenutno ce se ispisati svi mehanicari iz izabranog servisa, 
            // na dugme Dodaj mehanicare ne desava se nista
            // i nakon OK, ovaj dgv se skroz preskoci jer postoji neki problem u tom delu, trenutno zakomentarisan
            // sto znaci da se napravljenoj servisnoj knjizici ne dodaje lista mehanicara, niti se 
            // mehanicarima doda ta nova knjizica u listu knjizica
        }
        private void btnDodajMehanicara_Click(object sender, EventArgs e)
        {
           
            /*frmDodajMehanicare dlg = new frmDodajMehanicare();
           
            if (dlg.ShowDialog() == DialogResult.OK)
            {
              
            }*/
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
            Vozilo vozilo = DTOManager.GetVoziloPrekoRegistracije(txtRegistracija.Text);

            Vlasnik vlasnik = new Vlasnik(txtTelefonVlasnika.Text, txtAdresaVlasnika.Text);
            vlasnik.Vozilo = vozilo;

            DTOManager.upisiVlasnika(vlasnik);

            Knjizica knjizica = new Knjizica(dtpDatumIntervencije.Value, Convert.ToInt32(txtCenaUsluge.Text), txtRadovi.Text );
            knjizica.Vozilo = vozilo;
            knjizica.Servis = DTOManager.GetPredstavnistvo(predstavnistvo);

            /*
            foreach (DataGridViewRow row in dgvMehanicari.Rows)
            {
                // hm ?
                ZaposleniPregled tmp = (ZaposleniPregled)dgvMehanicari.CurrentRow.DataBoundItem;
                
                string mbr = tmp.Mbr;
                Zaposleni mehanicar = DTOManager.GetZaposleni(mbr);
                //Zaposleni m = null ;
                
                if (mehanicar.GetType() == typeof(MehanicarKia))
                {
                    MehanicarKia m = (MehanicarKia)mehanicar;
                    m.Knjizice.Add(knjizica);
                    knjizica.Mehanicari.Add(m);
                   
                    
                }
                else if (mehanicar.GetType() == typeof(MehanicarHyundai))
                {
                    MehanicarHyundai mh = new MehanicarHyundai();
                    mh = (MehanicarHyundai)mehanicar;
                    mh.Knjizice.Add(knjizica);
                    knjizica.Mehanicari.Add(mh);

                   
                }
                else if (mehanicar.GetType() == typeof(MehanicarKiaHyundai))
                {
                    MehanicarKiaHyundai mkh = new MehanicarKiaHyundai();
                    mkh = (MehanicarKiaHyundai)mehanicar;
                    mkh.Knjizice.Add(knjizica);
                    knjizica.Mehanicari.Add(mkh);

                    
                }




            }*/

            DTOManager.UpisiKnjizicu(knjizica);

            DialogResult = System.Windows.Forms.DialogResult.OK;


        }
    }
}
