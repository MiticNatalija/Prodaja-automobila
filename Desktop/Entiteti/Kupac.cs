using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Kupac
    {
        public virtual int Id { get; set; }
        public virtual Vozilo Vozilo { get; set; }
        public virtual FizickoLice FLice { get; set; }
        public virtual PravnoLice PLice { get; set; }
    }
}
