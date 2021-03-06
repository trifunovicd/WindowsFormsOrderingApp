﻿using DataAccessLayer.Entities;
using DataAccessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductRepository
    {
        string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
        public GroupRepository _groupRepository = new GroupRepository();
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

        public List<ProductVM> SearchProduct(string naziv)
        {
            var products = GetProducts().Where(p => true);
            if (naziv != "")
            {
                products = products.Where(p => p.Naziv.ToUpper().Contains(naziv.ToUpper()) || p.Id.ToString().ToUpper().Contains(naziv.ToUpper()));
            }
            return products.ToList();
        }
        public List<ProductVM> GetProducts()
        {
            var groups = _groupRepository.GetGroups();
            var products = GetAllProducts().Select(p => new ProductVM
            {
                Id = p.Id,
                Naziv = p.Naziv,
                JMJ = p.JMJ,
                Cijena = p.Cijena,
                Grupa = groups.Where(g => g.Id == p.GrupaId).Select(g => g.Naziv).FirstOrDefault()
            }).ToList();

            return products;
        }
        public List<string> GetProductNames()
        {
            var products = GetAllProducts().Select(p => p.Naziv).OrderBy(p => p).ToList();
            products.Insert(0, "-- Odaberite artikl --");
            return products;
        }
        public int GetProductId(string productName)
        {
            int productId = GetAllProducts().Where(p => p.Naziv == productName).Select(p => p.Id).FirstOrDefault();
            
            return productId;
        }
        public int AddProduct(Product product)
        {
            int sifraArtikla = 0;
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                var query = "INSERT INTO Ordering_Products (Naziv, JMJ, Cijena, GrupaId) OUTPUT INSERTED.Id  VALUES ('" + product.Naziv + "', '" + product.JMJ + "', " + product.Cijena.ToString().Replace(",", ".") + ", " + product.GrupaId + ") ";
                //Log(query);
                oCommand.CommandText = query;
                oConnection.Open();
                sifraArtikla = (Int32)oCommand.ExecuteScalar();
            }
            return sifraArtikla;
        }
        /*
        public void Log(string query)
        {
            File.WriteAllText("D:\\log.txt", query);
        }*/
        
    }
}
