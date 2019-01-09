using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.Entities;
using DataAccessLayer.Enum;
using DataAccessLayer.ViewModels;

namespace PresentationLayer
{
    public partial class FormDokumenti : Form
    {
        private ProductRepository _productRepository = new ProductRepository();
        public DocumentRepository _documentRepository = new DocumentRepository();
        public BindingSource _documentBindingSource = new BindingSource();
        public FormDokumenti()
        {
            InitializeComponent();
            _documentBindingSource.DataSource = _documentRepository.GetDocuments();
        }

        private void FormDokumenti_Load(object sender, EventArgs e)
        {
            dataGridViewDokumenti.DataSource = _documentBindingSource;

            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("Image/delete.png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDokumenti.Columns.Add(oDeleteButton);

            dataGridViewDokumenti.AutoGenerateColumns = false;
        }

        private void dataGridViewDokumenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDokumenti.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                var id = Convert.ToInt32(dataGridViewDokumenti.Rows[e.RowIndex].Cells[0].Value);
                var tipDokumenta = Convert.ToInt32(dataGridViewDokumenti.Rows[e.RowIndex].Cells[1].Value);
                var datum = Convert.ToDateTime(dataGridViewDokumenti.Rows[e.RowIndex].Cells[2].Value);
                var sifraArtikla = Convert.ToString(dataGridViewDokumenti.Rows[e.RowIndex].Cells[3].Value);
                var kolicina = Convert.ToDecimal(dataGridViewDokumenti.Rows[e.RowIndex].Cells[4].Value);

                var document = new Document
                {
                    Id = id,
                    TipDokumenta = tipDokumenta,
                    Datum = datum,
                    SifraArtikla = _productRepository.GetProductId(sifraArtikla),
                    Kolicina = kolicina

                };
                FormObrisiDokument formObrisiDokument = new FormObrisiDokument(document, this);
                formObrisiDokument.Show();
            }
        }
    }
}
