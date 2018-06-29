using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Entiteti;

namespace Desktop.Web_DTOs
{
    public class VlasnikView
    {
        public int Id { get; protected set; }
        public virtual string Adresa { get; set; }
        public virtual string Telefon { get; set; }
        public VlasnikView() { }
        public VlasnikView(Vlasnik v)
        {
            Id = v.Id;
            Adresa = v.Adresa;
            Telefon = v.Telefon;
          
        }

}
}
