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
        private DocumentRepository _documentRepository = new DocumentRepository();
        private BindingSource _documentBindingSource = new BindingSource();
        public FormIzvjesceArtikla(int id, FormArtikli form)
        {
            InitializeComponent();
            var productId = id;
            _documentBindingSource.DataSource = _documentRepository.GetDocumentsById(productId);
        }

        private void FormIzvjesceArtikla_Load(object sender, EventArgs e)
        {
            dataGridViewIzvjesceArtikla.DataSource = _documentBindingSource;
        }
    }
}
