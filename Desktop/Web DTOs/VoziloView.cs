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
      
        public string Tip { get; protected set; }


        public string Registracija { get; set; }
        public string Gorivo { get; set; }

        public string OznakaMotora { get; set; }

        
        public int? BrojMesta { get; set; }
        public int? Nosivost { get; set; }
  

        public VoziloView()
        { }
        public VoziloView(Vozilo v)
        {
            VoziloId = v.Id;
            Tip = v.GetType().ToString();
            Registracija = v.Registracija;
            Gorivo = v.Gorivo;
            OznakaMotora = v.OznakaMotora;
            //BrojMesta = v.BrojMesta;
            //Nosivost = nosivost;
            
        }

    }
}
