using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;

namespace Desktop.Web_DTOs
{
   public class VoziloView
    {
       
        public int VoziloId { get; protected set; }

        public string Tip { get; set; }  


        public string Registracija { get; set; }
        public string Gorivo { get; set; }

        public string OznakaMotora { get; set; }

        
        public int? BrojMesta { get; set; }
        public int? Nosivost { get; set; }
  

        public VoziloView()
        { }
        public VoziloView(int id, string tip, string reg, string gor, string om,int? br )
        {
            VoziloId = id;
            Tip = tip;
            Registracija = reg;
            Gorivo = gor;
            OznakaMotora = om;
            if (tip == "Putnicko")
                BrojMesta = br;
            else
                Nosivost = br;
        }
       
        public VoziloView(int id, string tip, string reg, string gor, string om)
        {
            VoziloId = id;
            Tip = tip;
            Registracija = reg;
            Gorivo = gor;
            OznakaMotora = om;
        }

        public VoziloView(Vozilo v)
        {
            VoziloId = v.Id;
            Tip = v.GetType().ToString();
            if (Tip.Contains("Putnicko"))
                Tip = "Putnicko";
            else
                Tip = "Teretno";
            Registracija = v.Registracija;
            Gorivo = v.Gorivo;
            OznakaMotora = v.OznakaMotora;
          
        }

    }
}
