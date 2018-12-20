using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Document
    {
        public int Id { get; set; }
        public int TipDokumenta { get; set; }
        public DateTime Datum { get; set; }
        public int SifraArtikla { get; set; }
        public decimal Kolicina { get; set; }
    }
}
