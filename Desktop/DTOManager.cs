using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NHibernate;
using Desktop.Entiteti;

namespace Desktop
{
    public class DTOManager
    {
        public static List<PredstavnistvoPregled> GetPredstavnistvoInfos()
        {
            List<PredstavnistvoPregled> odInfos = new List<PredstavnistvoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predstavnistvo> predstavnistva = from p in s.Query<Predstavnistvo>()
                                                   select p;

                foreach (Predstavnistvo p in predstavnistva)
                {
                    string tip = "Greska";

                    if (p is SalonHyundai)
                    {
                        tip = "Salon za Hyundai";
                    }
                    else if (p is SalonKia)
                    {
                        tip = "Salon za Kia";
                    }
                    else if (p is SalonHyundaiKia)
                    {
                        tip = "Salon za Hyundai i Kiu";
                    }
                    else if (p is ServisHyundai)
                    {
                        tip = "Servis za Hyundai";
                    }
                    else if (p is ServisKia)
                    {
                        tip = "Servis za Kia";
                    }
                    else if (p is ServisHyundaiKia)
                    {
                        tip = "Servis za Hyundai i Kiu";
                    }
                    else if (p is SalonServisHyundai)
                    {
                        tip = "Salon i Servis za Hyundai";
                    }
                    else if (p is SalonServisKia)
                    {
                        tip = "Salon i Servis za Kiu";
                    }
                    else if (p is SalonServisHyundaiKia)
                    {
                        tip = "Salon i Servis za Hyundai i Kiu";
                    }
                    odInfos.Add(new PredstavnistvoPregled(p.Id, p.Adresa, p.DatumOtvaranja, tip));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return odInfos;
        }
    }
}
