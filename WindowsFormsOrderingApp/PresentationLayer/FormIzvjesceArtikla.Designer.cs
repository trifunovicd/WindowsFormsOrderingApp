namespace PresentationLayer
{
    partial class FormIzvjesceArtikla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewIzvjesceArtikla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerDokumenti = new System.Windows.Forms.DateTimePicker();
            this.buttonPrikaziSve = new System.Windows.Forms.Button();
            this.buttonPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIzvjesceArtikla)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIzvjesceArtikla
            // 
            this.dataGridViewIzvjesceArtikla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIzvjesceArtikla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIzvjesceArtikla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewIzvjesceArtikla.Location = new System.Drawing.Point(2, 37);
            this.dataGridViewIzvjesceArtikla.Name = "dataGridViewIzvjesceArtikla";
            this.dataGridViewIzvjesceArtikla.Size = new System.Drawing.Size(696, 275);
            this.dataGridViewIzvjesceArtikla.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TipDokumenta";
            this.Column2.HeaderText = "Tip Dokumenta";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Datum";
            this.Column3.HeaderText = "Datum";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NazivArtikla";
            this.Column4.HeaderText = "Naziv Artikla";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Kolicina";
            this.Column5.HeaderText = "Kolicina";
            this.Column5.Name = "Column5";
            // 
            // dateTimePickerDokumenti
            // 
            this.dateTimePickerDokumenti.Location = new System.Drawing.Point(376, 8);
            this.dateTimePickerDokumenti.Name = "dateTimePickerDokumenti";
            this.dateTimePickerDokumenti.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDokumenti.TabIndex = 2;
            this.dateTimePickerDokumenti.ValueChanged += new System.EventHandler(this.dateTimePickerDokumenti_ValueChanged);
            // 
            // buttonPrikaziSve
            // 
            this.buttonPrikaziSve.Location = new System.Drawing.Point(12, 8);
            this.buttonPrikaziSve.Name = "buttonPrikaziSve";
            this.buttonPrikaziSve.Size = new System.Drawing.Size(75, 23);
            this.buttonPrikaziSve.TabIndex = 3;
            this.buttonPrikaziSve.Text = "Prikaži sve";
            this.buttonPrikaziSve.UseVisualStyleBackColor = true;
            this.buttonPrikaziSve.Click += new System.EventHandler(this.buttonPrikaziSve_Click);
            // 
            // buttonPretrazi
            // 
            this.buttonPretrazi.Location = new System.Drawing.Point(582, 6);
            this.buttonPretrazi.Name = "buttonPretrazi";
            this.buttonPretrazi.Size = new System.Drawing.Size(105, 22);
            this.buttonPretrazi.TabIndex = 5;
            this.buttonPretrazi.Text = "Pretraži po datumu";
            this.buttonPretrazi.UseVisualStyleBackColor = true;
            this.buttonPretrazi.Click += new System.EventHandler(this.buttonPretrazi_Click);
            // 
            // FormIzvjesceArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 314);
            this.Controls.Add(this.buttonPretrazi);
            this.Controls.Add(this.buttonPrikaziSve);
            this.Controls.Add(this.dateTimePickerDokumenti);
            this.Controls.Add(this.dataGridViewIzvjesceArtikla);
            this.Name = "FormIzvjesceArtikla";
            this.Text = "Izvjesce Artikla";
            this.Load += new System.EventHandler(this.FormIzvjesceArtikla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIzvjesceArtikla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIzvjesceArtikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDokumenti;
        private System.Windows.Forms.Button buttonPrikaziSve;
        private System.Windows.Forms.Button buttonPretrazi;
    }
}