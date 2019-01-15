namespace PresentationLayer
{
    partial class FormNovaIzdatnica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxArtikli = new System.Windows.Forms.ComboBox();
            this.numericUpDownKolicina = new System.Windows.Forms.NumericUpDown();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artikl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kolicina:";
            // 
            // comboBoxArtikli
            // 
            this.comboBoxArtikli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArtikli.FormattingEnabled = true;
            this.comboBoxArtikli.Location = new System.Drawing.Point(68, 22);
            this.comboBoxArtikli.Name = "comboBoxArtikli";
            this.comboBoxArtikli.Size = new System.Drawing.Size(181, 21);
            this.comboBoxArtikli.TabIndex = 6;
            // 
            // numericUpDownKolicina
            // 
            this.numericUpDownKolicina.Location = new System.Drawing.Point(69, 57);
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
            this.numericUpDownKolicina.Size = new System.Drawing.Size(180, 20);
            this.numericUpDownKolicina.TabIndex = 7;
            this.numericUpDownKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(68, 108);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(75, 23);
            this.buttonSpremi.TabIndex = 8;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(174, 108);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(75, 23);
            this.buttonOdustani.TabIndex = 9;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // FormNovaIzdatnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 146);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.numericUpDownKolicina);
            this.Controls.Add(this.comboBoxArtikli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNovaIzdatnica";
            this.Text = "Nova izdatnica";
            this.Load += new System.EventHandler(this.FormNovaIzdatnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxArtikli;
        private System.Windows.Forms.NumericUpDown numericUpDownKolicina;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.Button buttonOdustani;
    }
}