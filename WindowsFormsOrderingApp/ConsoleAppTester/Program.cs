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
            var productRepo = new ProductRepository();
            var products = productRepo.GetAll();
            foreach (var product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Naziv);
                Console.WriteLine(product.JMJ);
                Console.WriteLine(product.Cijena);
                Console.WriteLine(product.Kolicina);
                Console.WriteLine(product.GrupaId);
            }
            Console.ReadKey();
        }
    }
}
