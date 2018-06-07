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
        public static List<VoziloPregled> GetVozilaForSalon(int salonId)
        {
            List<VoziloPregled> vozInfos = new List<VoziloPregled>();
            ISession s = null;

            try
            {
                s = DataLayer.GetSession();
                Predstavnistvo predstavnistvo = (from p in s.Query<Predstavnistvo>()
                                      where p.Id == salonId
                                      select p).Single<Predstavnistvo>();

                IList<Vozilo> vozila = null;
                if(predstavnistvo is SalonHyundai)
                {
                    vozila = ((SalonHyundai)predstavnistvo).Vozila;
                }
                else if(predstavnistvo is SalonHyundaiKia)
                {
                    vozila = ((SalonHyundaiKia)predstavnistvo).Vozila;
                }
                else if (predstavnistvo is SalonKia)
                {
                    vozila = ((SalonKia)predstavnistvo).Vozila;
                }
                else if (predstavnistvo is SalonServisHyundai)
                {
                    vozila = ((SalonServisHyundai)predstavnistvo).Vozila;
                }
                else if (predstavnistvo is SalonServisKia)
                {
                    vozila = ((SalonServisKia)predstavnistvo).Vozila;
                }
                else if (predstavnistvo is SalonServisHyundaiKia)
                {
                    vozila = ((SalonServisHyundaiKia)predstavnistvo).Vozila;
                }

                foreach(Vozilo v in vozila)
                {
                    if(v is Putnicko)
                    {
                        vozInfos.Add(new VoziloPregled(v.Id, "Putnicko", v.Registracija, v.Gorivo, v.OznakaMotora, ((Putnicko)v).BrojMesta, null, "Putnicko vozilo"));
                    }
                    else
                    {
                        vozInfos.Add(new VoziloPregled(v.Id, "Teretno", v.Registracija, v.Gorivo, v.OznakaMotora, null, ((Teretno)v).Nosivost, "Teretno vozilo"));
                    }
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

            return vozInfos;
        }
    }
}
