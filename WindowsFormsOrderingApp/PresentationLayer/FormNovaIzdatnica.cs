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
    public partial class FormNovaIzdatnica : Form
    {
        private DocumentRepository _documentRepository = new DocumentRepository();
        private ProductRepository _productRepository = new ProductRepository();
        private BindingSource _productBindingSource = new BindingSource();
        public FormNovaIzdatnica()
        {
            InitializeComponent();
            _productBindingSource.DataSource = _productRepository.GetProductNames();
        }

        private void FormNovaIzdatnica_Load(object sender, EventArgs e)
        {
            comboBoxArtikli.DataSource = _productBindingSource;
        }
        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            Document _document = new Document();
            _document.TipDokumenta = 3;
            _document.Datum = DateTime.Now;
            _document.SifraArtikla = _productRepository.GetProductId(comboBoxArtikli.Text);
            _document.Kolicina = Convert.ToDecimal(numericUpDownKolicina.Text);
            if(Convert.ToDecimal(numericUpDownKolicina.Text)>_documentRepository.DohvatiTrenutnoStanje(_productRepository.GetProductId(comboBoxArtikli.Text)))
            {
                MessageBox.Show("Nije moguće izvesti traženu akciju!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _documentRepository.AddDocument(_document);
                this.Hide();
            }
            
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
