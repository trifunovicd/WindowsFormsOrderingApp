using DataAccessLayer.Entities;
using DataAccessLayer.Enum;
using DataAccessLayer.ViewModels;
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
        public List<Stanje> _stanje = new List<Stanje>();/////
        public ProductRepository _productRepository = new ProductRepository();
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
                            Id = (int)reader["Id"],
                            TipDokumenta = (int)reader["TipDokumenta"],
                            Datum = (DateTime)reader["Datum"],
                            SifraArtikla = (int)reader["SifraArtikla"],
                            Kolicina = (int)reader["Kolicina"]
                        });
                    }
                }
            }
            return documents;
        }

        public List<DocumentVM> GetDocuments()
        {
            var products = _productRepository.GetAllProducts();
            var documents = GetAllDocuments().Select(d => new DocumentVM
            {
                Id = d.Id,
                TipDokumenta = (TipDokumenta)d.TipDokumenta,
                Datum = d.Datum,
                NazivArtikla = products.Where(p => p.Id == d.SifraArtikla).Select(p => p.Naziv).FirstOrDefault(),
                Kolicina = d.Kolicina
            }).ToList();

            return documents;
        }

        public List<DocumentVM> SearchDocument(string datum)
        {
            var documents = GetDocuments().Where(d => true);
            
            documents = documents.Where(d => d.Datum.ToShortDateString() == datum);
            
            return documents.ToList();
        }
        public List<DocumentVM> SearchDocumentByDate(string datum, string naziv)
        {
            var documents = GetDocuments().Where(d => true);

            documents = documents.Where(d => d.Datum.ToShortDateString() == datum && d.NazivArtikla == naziv);

            return documents.ToList();
        }
        public List<DocumentVM> GetDocumentsById(int productId)
        {
            var products = _productRepository.GetAllProducts();
            var documents = _documents.Where(d => d.SifraArtikla == productId).Select(d => new DocumentVM
            {
                Id = d.Id,
                TipDokumenta = (TipDokumenta)d.TipDokumenta,
                Datum = d.Datum,
                NazivArtikla = products.Where(p => p.Id == d.SifraArtikla).Select(p => p.Naziv).FirstOrDefault(),
                Kolicina = d.Kolicina
            }).ToList();

            return documents;
        }

        public void AddDocument(Document document)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Ordering_Documents (TipDokumenta, Datum, SifraArtikla, Kolicina) VALUES (" + document.TipDokumenta + ", '" + document.Datum.ToString("yyyy-MM-dd") + "', " + document.SifraArtikla + ", " + document.Kolicina + ") ";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void DeleteDocument(Document document)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Ordering_Documents WHERE  Id =" + document.Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public List<Stanje> DohvatiStanje()
        {
            _stanje.Clear();
            var _products = _productRepository.GetAllProducts();
            for (int i = 0; i < _products.Count(); i++)
            {
                var PocetnaKolicinaUlaz = GetAllDocuments().Where(item => item.TipDokumenta == 1 && item.SifraArtikla == _products[i].Id).Sum(item => item.Kolicina);
                var PocetniIznosUlaz = GetAllDocuments().Where(item => item.TipDokumenta == 1 && item.SifraArtikla == _products[i].Id).Sum(item => item.Kolicina * _products[i].Cijena);
                var UkupnaKolicinaUlaz = GetAllDocuments().Where(item => item.TipDokumenta == 2 && item.SifraArtikla == _products[i].Id).Sum(item => item.Kolicina);
                var UkupniIznosUlaz = GetAllDocuments().Where(item => item.TipDokumenta == 2 && item.SifraArtikla == _products[i].Id).Sum(item => item.Kolicina * _products[i].Cijena);
                var UkupnaKolicinaIzlaz = GetAllDocuments().Where(item => item.TipDokumenta == 3 && item.SifraArtikla == _products[i].Id).Sum(item => item.Kolicina);
                var UkupniIznosIzlaz = GetAllDocuments().Where(item => item.TipDokumenta == 3 && item.SifraArtikla == _products[i].Id).Sum(item => item.Kolicina * _products[i].Cijena);
                
                var stanje = new Stanje
                {
                    Id = _products[i].Id,
                    Naziv = _products[i].Naziv,
                    JMJ = _products[i].JMJ,
                    Cijena = _products[i].Cijena,
                    PSKolicina = PocetnaKolicinaUlaz,
                    PSIznos = Decimal.Round(PocetniIznosUlaz, 2),
                    UkupnaKolicinaUlaz = UkupnaKolicinaUlaz,
                    UkupniIznosUlaz = Decimal.Round(UkupniIznosUlaz, 2),
                    UkupnaKolicinaIzlaz = UkupnaKolicinaIzlaz,
                    UkupniIznosIzlaz = Decimal.Round(UkupniIznosIzlaz, 2),
                    TrenutnoStanjeKolicina = ((PocetnaKolicinaUlaz + UkupnaKolicinaUlaz) - UkupnaKolicinaIzlaz),
                    TrenutnoStanjeIznos = Decimal.Round(((PocetniIznosUlaz + UkupniIznosUlaz) - UkupniIznosIzlaz), 2)
                };
                _stanje.Add(stanje);
            }
            
            return _stanje;
        }

        public List<Stanje> SearchStanje(string naziv)
        {
            var stanje = DohvatiStanje().Where(s => true);
            if (naziv != "")
            {
                stanje = stanje.Where(s => s.Naziv.ToUpper().Contains(naziv.ToUpper()) || s.Id.ToString().ToUpper().Contains(naziv.ToUpper()));
            }
            return stanje.ToList();
        }

        public int DohvatiTrenutnoStanje(int sifraArtikla)
        {
            int PocetnaKolicinaUlaz =0;
            int UkupnaKolicinaUlaz =0;
            int UkupnaKolicinaIzlaz =0;
            var _products = _productRepository.GetAllProducts();
            
            for (int i = 0; i < _products.Count(); i++)
            {
                for (int j = 0; j < _documents.Count(); j++)
                {
                    if (_documents[j].TipDokumenta == 1 && _products[i].Id == _documents[j].SifraArtikla && _products[i].Id == sifraArtikla)
                    {
                        PocetnaKolicinaUlaz = _documents[j].Kolicina;
                    }

                    if (_documents[j].TipDokumenta == 2 && _products[i].Id == _documents[j].SifraArtikla && _products[i].Id == sifraArtikla)
                    {
                        UkupnaKolicinaUlaz += _documents[j].Kolicina;
                    }

                    if (_documents[j].TipDokumenta == 3 && _products[i].Id == _documents[j].SifraArtikla && _products[i].Id == sifraArtikla)
                    {
                        UkupnaKolicinaIzlaz += _documents[j].Kolicina;
                    }
                }
            }

            int trenutnoStanje = ((PocetnaKolicinaUlaz + UkupnaKolicinaUlaz) - UkupnaKolicinaIzlaz);
            return trenutnoStanje;
        }
    }
}
