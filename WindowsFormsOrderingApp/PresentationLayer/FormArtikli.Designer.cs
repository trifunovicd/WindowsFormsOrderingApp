namespace PresentationLayer
{
    partial class FormArtikli
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
            this.dataGridViewArtikli = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnArtikli = new System.Windows.Forms.TabControl();
            this.tabPageArtikli = new System.Windows.Forms.TabPage();
            this.buttonPretrazi = new System.Windows.Forms.Button();
            this.textBoxArtikl = new System.Windows.Forms.TextBox();
            this.tabPageNoviArtikl = new System.Windows.Forms.TabPage();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.comboBoxGrupa = new System.Windows.Forms.ComboBox();
            this.numericUpDownKolicina = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCijena = new System.Windows.Forms.NumericUpDown();
            this.textBoxJMJ = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).BeginInit();
            this.btnArtikli.SuspendLayout();
            this.tabPageArtikli.SuspendLayout();
            this.tabPageNoviArtikl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArtikli
            // 
            this.dataGridViewArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewArtikli.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewArtikli.Name = "dataGridViewArtikli";
            this.dataGridViewArtikli.Size = new System.Drawing.Size(691, 254);
            this.dataGridViewArtikli.TabIndex = 0;
            this.dataGridViewArtikli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArtikli_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Šifra artikla";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Naziv";
            this.Column2.HeaderText = "Naziv";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "JMJ";
            this.Column3.HeaderText = "JMJ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Cijena";
            this.Column4.HeaderText = "Cijena";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Grupa";
            this.Column5.HeaderText = "Grupa";
            this.Column5.Name = "Column5";
            // 
            // btnArtikli
            // 
            this.btnArtikli.Controls.Add(this.tabPageArtikli);
            this.btnArtikli.Controls.Add(this.tabPageNoviArtikl);
            this.btnArtikli.Location = new System.Drawing.Point(1, 1);
            this.btnArtikli.Name = "btnArtikli";
            this.btnArtikli.SelectedIndex = 0;
            this.btnArtikli.Size = new System.Drawing.Size(699, 312);
            this.btnArtikli.TabIndex = 1;
            // 
            // tabPageArtikli
            // 
            this.tabPageArtikli.Controls.Add(this.buttonPretrazi);
            this.tabPageArtikli.Controls.Add(this.dataGridViewArtikli);
            this.tabPageArtikli.Controls.Add(this.textBoxArtikl);
            this.tabPageArtikli.Location = new System.Drawing.Point(4, 22);
            this.tabPageArtikli.Name = "tabPageArtikli";
            this.tabPageArtikli.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArtikli.Size = new System.Drawing.Size(691, 286);
            this.tabPageArtikli.TabIndex = 0;
            this.tabPageArtikli.Text = "Artikli";
            this.tabPageArtikli.UseVisualStyleBackColor = true;
            // 
            // buttonPretrazi
            // 
            this.buttonPretrazi.Location = new System.Drawing.Point(608, 4);
            this.buttonPretrazi.Name = "buttonPretrazi";
            this.buttonPretrazi.Size = new System.Drawing.Size(75, 23);
            this.buttonPretrazi.TabIndex = 3;
            this.buttonPretrazi.Text = "Pretraži";
            this.buttonPretrazi.UseVisualStyleBackColor = true;
            this.buttonPretrazi.Click += new System.EventHandler(this.buttonPretrazi_Click);
            // 
            // textBoxArtikl
            // 
            this.textBoxArtikl.Location = new System.Drawing.Point(433, 6);
            this.textBoxArtikl.Name = "textBoxArtikl";
            this.textBoxArtikl.Size = new System.Drawing.Size(169, 20);
            this.textBoxArtikl.TabIndex = 2;
            // 
            // tabPageNoviArtikl
            // 
            this.tabPageNoviArtikl.Controls.Add(this.buttonSpremi);
            this.tabPageNoviArtikl.Controls.Add(this.comboBoxGrupa);
            this.tabPageNoviArtikl.Controls.Add(this.numericUpDownKolicina);
            this.tabPageNoviArtikl.Controls.Add(this.numericUpDownCijena);
            this.tabPageNoviArtikl.Controls.Add(this.textBoxJMJ);
            this.tabPageNoviArtikl.Controls.Add(this.textBoxNaziv);
            this.tabPageNoviArtikl.Controls.Add(this.label5);
            this.tabPageNoviArtikl.Controls.Add(this.label4);
            this.tabPageNoviArtikl.Controls.Add(this.label3);
            this.tabPageNoviArtikl.Controls.Add(this.label2);
            this.tabPageNoviArtikl.Controls.Add(this.label1);
            this.tabPageNoviArtikl.Location = new System.Drawing.Point(4, 22);
            this.tabPageNoviArtikl.Name = "tabPageNoviArtikl";
            this.tabPageNoviArtikl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNoviArtikl.Size = new System.Drawing.Size(691, 286);
            this.tabPageNoviArtikl.TabIndex = 1;
            this.tabPageNoviArtikl.Text = "Novi artikl";
            this.tabPageNoviArtikl.UseVisualStyleBackColor = true;
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(19, 197);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(241, 31);
            this.buttonSpremi.TabIndex = 22;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // comboBoxGrupa
            // 
            this.comboBoxGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrupa.FormattingEnabled = true;
            this.comboBoxGrupa.Location = new System.Drawing.Point(81, 110);
            this.comboBoxGrupa.Name = "comboBoxGrupa";
            this.comboBoxGrupa.Size = new System.Drawing.Size(179, 21);
            this.comboBoxGrupa.TabIndex = 21;
            // 
            // numericUpDownKolicina
            // 
            this.numericUpDownKolicina.Location = new System.Drawing.Point(121, 150);
            this.numericUpDownKolicina.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKolicina.Name = "numericUpDownKolicina";
            this.numericUpDownKolicina.Size = new System.Drawing.Size(139, 20);
            this.numericUpDownKolicina.TabIndex = 20;
            this.numericUpDownKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownCijena
            // 
            this.numericUpDownCijena.DecimalPlaces = 2;
            this.numericUpDownCijena.Location = new System.Drawing.Point(81, 80);
            this.numericUpDownCijena.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCijena.Name = "numericUpDownCijena";
            this.numericUpDownCijena.Size = new System.Drawing.Size(179, 20);
            this.numericUpDownCijena.TabIndex = 19;
            // 
            // textBoxJMJ
            // 
            this.textBoxJMJ.Location = new System.Drawing.Point(81, 46);
            this.textBoxJMJ.Name = "textBoxJMJ";
            this.textBoxJMJ.Size = new System.Drawing.Size(179, 20);
            this.textBoxJMJ.TabIndex = 18;
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(81, 11);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(179, 20);
            this.textBoxNaziv.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Početna količina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Grupa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cijena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "JMJ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naziv:";
            // 
            // FormArtikli
            // 
            this.AcceptButton = this.buttonPretrazi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 314);
            this.Controls.Add(this.btnArtikli);
            this.Name = "FormArtikli";
            this.Text = "Artikli";
            this.Load += new System.EventHandler(this.FormArtikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).EndInit();
            this.btnArtikli.ResumeLayout(false);
            this.tabPageArtikli.ResumeLayout(false);
            this.tabPageArtikli.PerformLayout();
            this.tabPageNoviArtikl.ResumeLayout(false);
            this.tabPageNoviArtikl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArtikli;
        private System.Windows.Forms.TabControl btnArtikli;
        private System.Windows.Forms.TabPage tabPageArtikli;
        private System.Windows.Forms.TabPage tabPageNoviArtikl;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.ComboBox comboBoxGrupa;
        private System.Windows.Forms.NumericUpDown numericUpDownKolicina;
        private System.Windows.Forms.NumericUpDown numericUpDownCijena;
        private System.Windows.Forms.TextBox textBoxJMJ;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArtikl;
        private System.Windows.Forms.Button buttonPretrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}