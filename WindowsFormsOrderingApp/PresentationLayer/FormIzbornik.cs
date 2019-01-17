using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormIzbornik : Form
    {
        public FormIzbornik()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.CenterToScreen();
            //this.Location = new Point(0, 0);
        }

        private void buttonArtikli_Click(object sender, EventArgs e)
        {
            FormArtikli formArtikli = new FormArtikli();
            formArtikli.Show();
        }

        private void buttonDokumenti_Click(object sender, EventArgs e)
        {
            FormDokumenti formDokumenti = new FormDokumenti();
            formDokumenti.Show();
        }

        private void buttonPrimka_Click(object sender, EventArgs e)
        {
            FormNovaPrimka formNovaPrimka = new FormNovaPrimka();
            formNovaPrimka.Show();
        }

        private void buttonIzdatnica_Click(object sender, EventArgs e)
        {
            FormNovaIzdatnica formNovaIzdatnica = new FormNovaIzdatnica();
            formNovaIzdatnica.Show();
        }

        private void buttonStanje_Click(object sender, EventArgs e)
        {
            FormStanje formStanje = new FormStanje();
            formStanje.Show();
        }
    }
}
