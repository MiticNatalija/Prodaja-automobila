using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entiteti
{
    public class Vlasnik
    {
        public virtual int Id { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Adresa { get; set; }
        public virtual Vozilo Vozilo { get; set; }
        //Nata: ili da se napravi mapiranje ili da se ovi atributi stave u Vozilo

        // Maruska: 
        // Bogdanovic jeste rekao da za slabe tipove treba kompozitni kljuc
        // ali mozda se zeznuo ako je pogledao na brzinu, 
        // jer je izmedju Vlasnika i Vozila veza 1:1 pa mislim da tu moze da radi ovo sto pisem u nastavku
        // Eventualno, posto je izmedju Vozila i Knjizice veza 1:N, tu bi mozda kompozitni kljuc Knjizice bili
        // idKnjizice(evidencije) i idVozila, posto Vozilo moze da ima vise evidencija (sto se kod nas zove knjizica)


        // Ovo u konstruktoru mozda nije skroz ispravno pa moze da pravi problem za dalje faze, a za sad moze da prodje

        // Ipak je mozda najzgodnije za nas slucaj da stavimo atribute Vlasnika kod Vozila, 
        // posto ih ima samo 2. 
        // Jes da je pametnije da postoji i klasa Vlasnik ali mozda da gledamo da prodjemo laganije ?

        public Vlasnik()
        { }

        public Vlasnik(Vozilo Vozilo)
        {
            Id = Vozilo.Id;
            this.Vozilo = Vozilo;
        }
    }
}
