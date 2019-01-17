namespace PresentationLayer
{
    partial class FormDokumenti
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
            this.dataGridViewDokumenti = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerDokumenti = new System.Windows.Forms.DateTimePicker();
            this.buttonPrikaziSve = new System.Windows.Forms.Button();
            this.buttonPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDokumenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDokumenti
            // 
            this.dataGridViewDokumenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDokumenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDokumenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewDokumenti.Location = new System.Drawing.Point(2, 37);
            this.dataGridViewDokumenti.Name = "dataGridViewDokumenti";
            this.dataGridViewDokumenti.Size = new System.Drawing.Size(696, 275);
            this.dataGridViewDokumenti.TabIndex = 0;
            this.dataGridViewDokumenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDokumenti_CellContentClick);
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
            this.dateTimePickerDokumenti.TabIndex = 1;
            // 
            // buttonPrikaziSve
            // 
            this.buttonPrikaziSve.Location = new System.Drawing.Point(12, 8);
            this.buttonPrikaziSve.Name = "buttonPrikaziSve";
            this.buttonPrikaziSve.Size = new System.Drawing.Size(75, 23);
            this.buttonPrikaziSve.TabIndex = 2;
            this.buttonPrikaziSve.Text = "Prikaži sve";
            this.buttonPrikaziSve.UseVisualStyleBackColor = true;
            this.buttonPrikaziSve.Click += new System.EventHandler(this.buttonPrikaziSve_Click);
            // 
            // buttonPretrazi
            // 
            this.buttonPretrazi.Location = new System.Drawing.Point(582, 6);
            this.buttonPretrazi.Name = "buttonPretrazi";
            this.buttonPretrazi.Size = new System.Drawing.Size(105, 22);
            this.buttonPretrazi.TabIndex = 4;
            this.buttonPretrazi.Text = "Pretraži po datumu";
            this.buttonPretrazi.UseVisualStyleBackColor = true;
            this.buttonPretrazi.Click += new System.EventHandler(this.buttonPretrazi_Click);
            // 
            // FormDokumenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 314);
            this.Controls.Add(this.buttonPretrazi);
            this.Controls.Add(this.buttonPrikaziSve);
            this.Controls.Add(this.dateTimePickerDokumenti);
            this.Controls.Add(this.dataGridViewDokumenti);
            this.Name = "FormDokumenti";
            this.Text = "Dokumenti";
            this.Load += new System.EventHandler(this.FormDokumenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDokumenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDokumenti;
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