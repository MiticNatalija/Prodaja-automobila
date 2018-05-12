using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Kupac
    {
        public virtual int Id { get; protected set; }
        // ID vozila
        public virtual Vozilo Vozilo { get; set; }
    }
}
