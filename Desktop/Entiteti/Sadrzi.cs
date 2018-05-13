using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Sadrzi
    {
        public virtual int Id { get; set; }
        public virtual Knjizica Knjizica { get; set; }
        public virtual Zaposleni Mehanicar { get; set; }

        public Sadrzi()
        { }
    }
}
