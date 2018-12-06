using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string JMJ { get; set; }
        public decimal Cijena { get; set; }
        public int Kolicina { get; set; }
        public int GrupaId { get; set; }
    }
}
