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
using Desktop.DTOs;

namespace Desktop.DTOManagers
{
    public partial class DTOManager
    {
        public static List<ZaposleniPregled> GetZaposleniInfos()
        {
            List<ZaposleniPregled> zapInfos = new List<ZaposleniPregled>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                IEnumerable<Zaposleni> zaposleni = from z in s.Query<Zaposleni>()
                                                   select z;

                foreach (Zaposleni z in zaposleni)
                {
                    string tip = "Greska";
                    string tipZaposlenog = "Greska";

                    if (z is PredstavnikKia)
                    {
                        tipZaposlenog = "Predstavnik za Kiu";
                        tip = "PredstavnikKia";
                    }
                    else if (z is PredstavnikHyundai)
                    {
                        tipZaposlenog = "Predstavnik za Hyundai";
                        tip = "PredstavnikHyundai";
                    }
                    else if (z is MehanicarKia)
                    {
                        tipZaposlenog = "Mehanicar za Kiu";
                        tip = "MehanicarKia";
                    }
                    else if (z is MehanicarHyundai)
                    {
                        tipZaposlenog = "Mehanicar za Hyundai";
                        tip = "MehanicarHyundai";
                    }
                    else if (z is MehanicarKiaHyundai)
                    {
                        tipZaposlenog = "Mehanicar za Kiu i Hyundai";
                        tip = "MehanicarKiaHyundai";
                    }
                    zapInfos.Add(new ZaposleniPregled(z.Id, tip, z.Mbr, z.LicnoIme, z.ImeOca, z.Prezime, z.DatumRodjenja, z.DatumZaposlenja, tipZaposlenog));
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                s.Close();
            }

            return zapInfos;
        }
    }
}
