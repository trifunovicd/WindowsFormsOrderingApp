using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.Entities;
using DataAccessLayer.ViewModels;

namespace PresentationLayer
{
    public partial class FormArtikli : Form
    {
        private ProductRepository _productRepository = new ProductRepository();
        private BindingSource _productBindingSource = new BindingSource();
        private GroupRepository _groupRepository = new GroupRepository();
        private BindingSource _groupBindingSource = new BindingSource();
        private DocumentRepository _documentRepository = new DocumentRepository();
        private BindingSource _documentBindingSource = new BindingSource();
        public FormArtikli()
        {
            InitializeComponent();
            _productBindingSource.DataSource = _productRepository.GetProducts();
            _groupBindingSource.DataSource = _groupRepository.GetGroupNames();
        }

        private void FormArtikli_Load(object sender, EventArgs e)
        {
            dataGridViewArtikli.DataSource = _productBindingSource;
            comboBoxGrupa.DataSource = _groupBindingSource;

            DataGridViewImageColumn oViewButton = new DataGridViewImageColumn();
            oViewButton.Image = Image.FromFile("Image/view.png");
            oViewButton.Width = 20;
            oViewButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            oViewButton.HeaderText = "Izvjesce artikla";
            dataGridViewArtikli.Columns.Add(oViewButton);
            dataGridViewArtikli.AutoGenerateColumns = false;
        }

        private void dataGridViewArtikli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewArtikli.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                //var id = Convert.ToInt32(dataGridViewArtikli.Rows[e.RowIndex].Cells[0].Value);
                var id = Convert.ToInt32(dataGridViewArtikli.Rows[e.RowIndex].Cells[0].Value);
                var naziv = Convert.ToString(dataGridViewArtikli.Rows[e.RowIndex].Cells[1].Value);
                var jmj = Convert.ToString(dataGridViewArtikli.Rows[e.RowIndex].Cells[2].Value);
                var cijena = Convert.ToDecimal(dataGridViewArtikli.Rows[e.RowIndex].Cells[3].Value);
                var grupaid = Convert.ToString(dataGridViewArtikli.Rows[e.RowIndex].Cells[4].Value);

                var product = new ProductVM
                {
                    Id = id,
                    Naziv = naziv,
                    JMJ = jmj,
                    Cijena = cijena,
                    Grupa = grupaid

                };
                FormIzvjesceArtikla formIzvjesceArtikla = new FormIzvjesceArtikla(product, this);
                formIzvjesceArtikla.Show();
            }
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            if(textBoxNaziv.Text!="" && textBoxJMJ.Text!="" && numericUpDownCijena.Value!=0 && comboBoxGrupa.SelectedIndex!=0)
            {
                Product _product = new Product();
                _product.Naziv = textBoxNaziv.Text;
                _product.JMJ = textBoxJMJ.Text;
                _product.Cijena = Convert.ToDecimal(numericUpDownCijena.Text);
                _product.GrupaId = _groupRepository.GetGroupId(comboBoxGrupa.Text);
                _productRepository.AddProduct(_product);

                var _product_Repository = new ProductRepository();

                Document _document = new Document();
                _document.TipDokumenta = 1;
                _document.Datum = DateTime.Now;
                _document.SifraArtikla = _product_Repository.GetProductId(textBoxNaziv.Text);
                _document.Kolicina = Convert.ToInt32(numericUpDownKolicina.Text);
                _documentRepository.AddDocument(_document);

                _productBindingSource.DataSource = _product_Repository.GetProducts();
                MessageBox.Show("Spremili ste novi proizvod!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Popunite sva polja!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            _productBindingSource.DataSource = _productRepository.SearchProduct(textBoxArtikl.Text);
        }
    }
}
