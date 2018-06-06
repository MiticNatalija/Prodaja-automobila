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
        public static List<PredstavnistvoPregled> GetPredstavnistvoInfos()
        {
            List<PredstavnistvoPregled> prInfos = new List<PredstavnistvoPregled>();
            ISession s = null;

            try
            {
                s = DataLayer.GetSession();
                IEnumerable<Predstavnistvo> predstavnistva = from p in s.Query<Predstavnistvo>()
                                                             select p;

                foreach (Predstavnistvo p in predstavnistva)
                {
                    string tip = "Greska";
                    string tipPredstavnistva = "Greska";
                    DateTime? datumVazenjaLicence = null;

                    if (p is SalonHyundai)
                    {
                        tipPredstavnistva = "Salon za Hyundai";
                        tip = "SalonHyundai";
                        datumVazenjaLicence = ((SalonHyundai)p).DatumVazenjaLicence;
                    }
                    else if (p is SalonKia)
                    {
                        tipPredstavnistva = "Salon za Kiu";
                        tip = "SalonKia";
                    }
                    else if (p is SalonHyundaiKia)
                    {
                        tipPredstavnistva = "Salon za Hyundai i Kiu";
                        tip = "SalonHyundaiKia";
                        datumVazenjaLicence = ((SalonHyundaiKia)p).DatumVazenjaLicence;
                    }
                    else if (p is ServisHyundai)
                    {
                        tipPredstavnistva = "Servis za Hyundai";
                        tip = "ServisHyundai";
                    }
                    else if (p is ServisKia)
                    {
                        tipPredstavnistva = "Servis za Kiu";
                        tip = "ServisKia";
                    }
                    else if (p is ServisHyundaiKia)
                    {
                        tipPredstavnistva = "Servis za Hyundai i Kiu";
                        tip = "ServisHyundaiKia";
                    }
                    else if (p is SalonServisHyundai)
                    {
                        tipPredstavnistva = "Salon i Servis za Hyundai";
                        tip = "SalonServisHyundai";
                        datumVazenjaLicence = ((SalonServisHyundai)p).DatumVazenjaLicence;
                    }
                    else if (p is SalonServisKia)
                    {
                        tipPredstavnistva = "Salon i Servis za Kiu";
                        tip = "SalonServisKia";
                    }
                    else if (p is SalonServisHyundaiKia)
                    {
                        tipPredstavnistva = "Salon i Servis za Hyundai i Kiu";
                        tip = "SalonServisHyundaiKia";
                        datumVazenjaLicence = ((SalonServisHyundaiKia)p).DatumVazenjaLicence;
                    }
                    prInfos.Add(new PredstavnistvoPregled(p.Id, tip, p.Adresa, p.DatumOtvaranja, tipPredstavnistva, datumVazenjaLicence));
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

            return prInfos;
        }

        public static PredstavnistvoPregled GetPredstavnistvo(int id)
        {
            PredstavnistvoPregled pr = null;
            ISession s = null;

            try
            {
                s = DataLayer.GetSession();

                Predstavnistvo p = s.Load<Predstavnistvo>(id);
                pr = new PredstavnistvoPregled(p.Id, p.Adresa, p.DatumOtvaranja);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                s.Close();
            }

            return pr;
        }

        public static void UpdatePredstavnistvo(PredstavnistvoPregled p)
        {
            ISession s = null;

            try
            {
                s = DataLayer.GetSession();
                Predstavnistvo pre = s.Load<Predstavnistvo>(p.PredstavnistvoId);
                pre.Adresa = p.Adresa;
                pre.DatumOtvaranja = p.DatumOtvaranja;
                s.Update(pre);
                s.Flush();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                s.Close();
            }
        }
        public static void AddPredstavnistvo(PredstavnistvoPregled p)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                Predstavnistvo sh = null;

                string tip = p.TipPredstavnistva;
                if (tip.CompareTo("Salon za Hyundai") == 0)
                {
                    sh = new SalonHyundai()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja,
                        DatumVazenjaLicence = (DateTime)p.DatumLicence

                    };
                }
                else if (tip.CompareTo("Salon za Kiu") == 0)
                {
                    sh = new SalonKia()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja

                    };
                }
                else if (tip.CompareTo("Salon za Hyundai i Kiu") == 0)
                {
                    sh = new SalonHyundaiKia()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja,
                        DatumVazenjaLicence = (DateTime)p.DatumLicence

                    };
                }
                else if (tip.CompareTo("Servis za Hyundai") == 0)
                {
                    sh = new ServisHyundai()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja

                    };
                }
                else if (tip.CompareTo("Servis za Kiu") == 0)
                {
                    sh = new ServisKia()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja

                    };
                }
                else if (tip.CompareTo("Servis za Hyundai i Kiu") == 0)
                {
                    sh = new ServisHyundaiKia()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja

                    };
                }
                else if (tip.CompareTo("Salon i Servis za Kiu") == 0)
                {
                    sh = new SalonServisKia()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja

                    };
                }
                else if (tip.CompareTo("Salon i Servis za Hyundai i Kiu") == 0)
                {
                    sh = new SalonServisHyundaiKia()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja,
                        DatumVazenjaLicence = (DateTime)p.DatumLicence

                    };
                }
                else if (tip.CompareTo("Salon i Servis za Hyundai") == 0)
                {
                    sh = new SalonServisHyundai()
                    {
                        Adresa = p.Adresa,
                        DatumOtvaranja = p.DatumOtvaranja,
                        DatumVazenjaLicence = (DateTime)p.DatumLicence

                    };
                }
                s.Save(sh);
                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }
        public static void DeletePredstavnistvo(PredstavnistvoPregled p)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                Predstavnistvo pre = s.Load<Predstavnistvo>(p.PredstavnistvoId);

                s.Delete(pre);
                s.Flush();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                s.Close();
            }
        }
    }
}
