using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace ConsoleAppTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var documentRepo = new DocumentRepository();
            var documents = documentRepo.GetAllDocuments();
            var productRepo = new ProductRepository();
            var products = productRepo.GetAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Naziv);
                Console.WriteLine(product.JMJ);
                Console.WriteLine(product.Cijena);
                Console.WriteLine(product.GrupaId);
            }
            foreach (var document in documents)
            {
                Console.WriteLine(document.TipDokumenta);
                Console.WriteLine(document.Datum);
                Console.WriteLine(document.SifraArtikla);
                Console.WriteLine(document.Kolicina);
            }
            Console.ReadKey();
        }
    }
}
