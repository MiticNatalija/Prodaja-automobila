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
        public PravnoLiceView PravnoLice { get; set; }
        public FizickoLiceView FizickoLice { get; set; }

        public KupacView()
        { }

        public KupacView(int id, int voziloId, PravnoLiceView pl, FizickoLiceView fl)
        {
            KupacId = id;
            VoziloId = voziloId;
            PravnoLice = pl;
            FizickoLice = fl;
        }

        public KupacView(Kupac k)
        {
            KupacId = k.Id;
            VoziloId = k.Vozilo.Id;
            if(k.PLice != null)
            {
                PravnoLice = new PravnoLiceView(k.PLice);
                FizickoLice = null;
            }
            else
            {
                FizickoLice = new FizickoLiceView(k.FLice);
                PravnoLice = null;
            }
        }
    }
}
