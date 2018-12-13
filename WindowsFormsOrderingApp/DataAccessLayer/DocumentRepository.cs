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
    public class DocumentRepository
    {
        string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
        public List<Document> _documents = new List<Document>();
        public DocumentRepository()
        {
            _documents = GetAllDocuments();
        }
        public List<Document> GetAllDocuments()
        {
            var documents = new List<Document>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Ordering_Documents";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        documents.Add(new Document()
                        {
                            TipDokumenta = (int)reader["TipDokumenta"],
                            Datum = (DateTime)reader["Datum"],
                            SifraArtikla = (int)reader["SifraArtikla"],
                            Kolicina = (decimal)reader["Kolicina"]
                        });
                    }
                }
            }
            return documents;
        }
    }
}
