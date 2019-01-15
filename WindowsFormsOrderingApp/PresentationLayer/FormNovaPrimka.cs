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

namespace PresentationLayer
{
    public partial class FormNovaPrimka : Form
    {
        private DocumentRepository _documentRepository = new DocumentRepository();
        private ProductRepository _productRepository = new ProductRepository();
        private BindingSource _productBindingSource = new BindingSource();
        public FormNovaPrimka()
        {
            InitializeComponent();
            _productBindingSource.DataSource = _productRepository.GetProductNames();
        }

        private void FormNovaPrimka_Load(object sender, EventArgs e)
        {
            comboBoxArtikli.DataSource = _productBindingSource;
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            if(comboBoxArtikli.SelectedIndex!=0)
            {
                Document _document = new Document();
                _document.TipDokumenta = 2;
                _document.Datum = DateTime.Now;
                _document.SifraArtikla = _productRepository.GetProductId(comboBoxArtikli.Text);
                _document.Kolicina = Convert.ToInt32(numericUpDownKolicina.Text);
                _documentRepository.AddDocument(_document);
                this.Hide();
                MessageBox.Show("Nova primka je kreirana!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Popunite sva polja!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
