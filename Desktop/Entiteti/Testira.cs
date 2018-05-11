using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Testira
    {
        public virtual long Id { get; protected set; }
        public virtual int Ocena { get; set; }
        public virtual DateTime DatumTestiranja { get; set; }
        public virtual PredstavnikHyundai Predstavnik { get; set; }
        public virtual MehanicarHyundai Mehanicar { get; set; }

        public Testira()
        { }
    }
    
}
