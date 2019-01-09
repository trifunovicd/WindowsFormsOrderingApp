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
        public decimal PSKolicina { get; set; }
        public decimal PSIznos { get; set; }
        public decimal UkupnaKolicinaUlaz { get; set; }
        public decimal UkupniIznosUlaz { get; set; }
        public decimal UkupnaKolicinaIzlaz { get; set; }
        public decimal UkupniIznosIzlaz { get; set; }
        public decimal TrenutnoStanjeKolicina { get; set; }
        public decimal TrenutnoStanjeIznos { get; set; }
    }
}
