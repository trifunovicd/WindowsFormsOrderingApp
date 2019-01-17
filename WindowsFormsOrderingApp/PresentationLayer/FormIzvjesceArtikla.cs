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
using DataAccessLayer.ViewModels;

namespace PresentationLayer
{
    public partial class FormIzvjesceArtikla : Form
    {
        ProductVM _product = new ProductVM();
        private DocumentRepository _documentRepository = new DocumentRepository();
        private BindingSource _documentBindingSource = new BindingSource();
        public FormIzvjesceArtikla(ProductVM product, FormArtikli form)
        {
            InitializeComponent();
            _product = product;
            _documentBindingSource.DataSource = _documentRepository.GetDocumentsById(_product.Id);
            dateTimePickerDokumenti.Format = DateTimePickerFormat.Short;
        }

        private void FormIzvjesceArtikla_Load(object sender, EventArgs e)
        {
            dataGridViewIzvjesceArtikla.DataSource = _documentBindingSource;
        }

        private void buttonPrikaziSve_Click(object sender, EventArgs e)
        {
            _documentBindingSource.DataSource = _documentRepository.GetDocumentsById(_product.Id);
        }

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            _documentBindingSource.DataSource = _documentRepository.SearchDocumentByDate(dateTimePickerDokumenti.Text, _product.Naziv);
        }
    }
}
