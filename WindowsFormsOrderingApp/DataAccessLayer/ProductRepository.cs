using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductRepository
    {
        string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
        public List<Product> _products = new List<Product>();
        public ProductRepository()
        {
            _products = GetAllProducts();
        }
        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Ordering_Products";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product()
                        {
                            Id = (int)reader["Id"],
                            Naziv = (string)reader["Naziv"],
                            JMJ = (string)reader["JMJ"],
                            Cijena = (decimal)reader["Cijena"],
                            GrupaId = (int)reader["GrupaId"]
                        });
                    }
                }
            }
            return products;
        }

        public void AddProduct(Product product)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Ordering_Products (Id, Naziv, JMJ, Cijena, GrupaId) VALUES ('" + product.Id + "', '" + product.Naziv + "', '" + product.JMJ + "', '" + product.Cijena + "', '" + product.GrupaId + "') ";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
    }
}
