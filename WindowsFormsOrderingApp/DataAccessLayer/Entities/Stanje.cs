using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Stanje
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string JMJ { get; set; }
        public decimal Cijena { get; set; }
        public int PSKolicina { get; set; }
        public decimal PSIznos { get; set; }
        public int UkupnaKolicinaUlaz { get; set; }
        public decimal UkupniIznosUlaz { get; set; }
        public int UkupnaKolicinaIzlaz { get; set; }
        public decimal UkupniIznosIzlaz { get; set; }
        public int TrenutnoStanjeKolicina { get; set; }
        public decimal TrenutnoStanjeIznos { get; set; }
    }
}
