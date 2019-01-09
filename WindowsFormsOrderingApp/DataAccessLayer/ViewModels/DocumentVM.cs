using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Enum;

namespace DataAccessLayer.ViewModels
{
    public class DocumentVM
    {
        public int Id { get; set; }
        public TipDokumenta TipDokumenta { get; set; }
        public DateTime Datum { get; set; }
        public string NazivArtikla { get; set; }
        public decimal Kolicina { get; set; }
    }
}
