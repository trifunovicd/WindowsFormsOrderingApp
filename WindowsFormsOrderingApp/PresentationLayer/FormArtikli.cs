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
    public partial class FormArtikli : Form
    {
        private ProductRepository _productRepository = new ProductRepository();
        private BindingSource _productBindingSource = new BindingSource();
        public FormArtikli()
        {
            InitializeComponent();
            _productBindingSource.DataSource = _productRepository.GetAllProducts();
        }

        private void FormArtikli_Load(object sender, EventArgs e)
        {
            dataGridViewArtikli.DataSource = _productBindingSource;

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
                var id = Convert.ToInt32(dataGridViewArtikli.Rows[e.RowIndex].Cells[0].Value);
                FormIzvjesceArtikla formIzvjesceArtikla = new FormIzvjesceArtikla(id, this);
                formIzvjesceArtikla.Show();
            }
        }
    }
}
