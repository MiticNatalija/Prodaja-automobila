using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;

namespace Desktop.Web_DTOs
{
    public class KupacView
    {
        public int KupacId { get; protected set; }
        public int VoziloId { get; set; }

        public KupacView()
        { }

        public KupacView(int id, int voziloId)
        {
            KupacId = id;
            VoziloId = voziloId;
        }

        public KupacView(Kupac k)
        {
            KupacId = k.Id;
            VoziloId = k.Vozilo.Id;
        }
    }
}
