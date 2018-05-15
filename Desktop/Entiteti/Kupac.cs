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

        //public virtual String Ime { get; set; }
        //public virtual String Prezime { get; set; }
        //public virtual String Telefon { get; set; }

        // Maruska: 
        // Mislim da je kategorija entitet koji preuzima osobine vise entiteta,
        // slicno kao deljiva klasa, samo sto kategorija nasledjuje PRESEK osobina tih entiteta koje "nasledjuje"
        // (zato sam dodala ova 3 atributa iznad, zakomentarisana)
        // a ukoliko su ID-evi tih entiteta razliciti, kao ovde, PIB i JMBG, onda se kategoriji dodaje ID kao surogat kljuc
        // (sto vec imamo = Id)

        

        public virtual Vozilo Vozilo { get; set; }

        //123
        //imace ili jedno ili drugo
        public virtual FizickoLice FLice { get; set; }
        public virtual PravnoLice PLice { get; set; }
    }
}
