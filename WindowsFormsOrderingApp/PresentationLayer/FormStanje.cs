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

namespace PresentationLayer
{
    public partial class FormStanje : Form
    {
        private DocumentRepository _documentRepository = new DocumentRepository();
        private BindingSource _documentBindingSource = new BindingSource();
        public FormStanje()
        {
            InitializeComponent();
            _documentBindingSource.DataSource = _documentRepository.DohvatiStanje();
        }

        private void FormStanje_Load(object sender, EventArgs e)
        {
             dataGridViewStanje.DataSource = _documentBindingSource;
        }

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            _documentBindingSource.DataSource = _documentRepository.SearchStanje(textBoxArtikl.Text);
        }

        private void buttonOsvjezi_Click(object sender, EventArgs e)
        {
            var _document_Repository = new DocumentRepository();
            _documentBindingSource.DataSource = _document_Repository.DohvatiStanje();
        }
    }
}
