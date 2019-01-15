using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Entities;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class FormObrisiDokument : Form
    {
        Document _document = new Document();
        private DocumentRepository _documentRepository = new DocumentRepository();
        FormDokumenti _formDokumenti = new FormDokumenti();
        public FormObrisiDokument(Document document, FormDokumenti formDokumenti)
        {
            InitializeComponent();
            _document = document;
            _formDokumenti = formDokumenti;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            _documentRepository.DeleteDocument(_document);
            this.Hide();
            var _document_Repository = new DocumentRepository();
            _formDokumenti._documentBindingSource.DataSource = _document_Repository.GetDocuments();
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
