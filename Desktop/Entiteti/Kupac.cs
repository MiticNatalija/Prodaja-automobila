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
        // ID vozila
        public virtual Vozilo vozilo { get; set; }
    }
}
