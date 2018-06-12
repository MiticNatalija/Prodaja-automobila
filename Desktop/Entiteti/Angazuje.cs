using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Angazuje
    {
        public virtual int Id {get;set;}
        public virtual DateTime DatumPocetka { get; set; }
        public virtual DateTime? KrajRada { get; set; }
        public virtual int Ocena { get; set; }
        public virtual Predstavnistvo Servis { get; set; }
        public virtual Zaposleni Mehanicar { get; set; }

        public Angazuje()
        { }
    }
    
}
