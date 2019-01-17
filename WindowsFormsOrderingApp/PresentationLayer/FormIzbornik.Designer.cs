namespace PresentationLayer
{
    partial class FormIzbornik
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
            this.buttonArtikli = new System.Windows.Forms.Button();
            this.buttonDokumenti = new System.Windows.Forms.Button();
            this.buttonPrimka = new System.Windows.Forms.Button();
            this.buttonIzdatnica = new System.Windows.Forms.Button();
            this.buttonStanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArtikli
            // 
            this.buttonArtikli.Location = new System.Drawing.Point(43, 12);
            this.buttonArtikli.Name = "buttonArtikli";
            this.buttonArtikli.Size = new System.Drawing.Size(120, 32);
            this.buttonArtikli.TabIndex = 0;
            this.buttonArtikli.Text = "Artikli";
            this.buttonArtikli.UseVisualStyleBackColor = true;
            this.buttonArtikli.Click += new System.EventHandler(this.buttonArtikli_Click);
            // 
            // buttonDokumenti
            // 
            this.buttonDokumenti.Location = new System.Drawing.Point(43, 50);
            this.buttonDokumenti.Name = "buttonDokumenti";
            this.buttonDokumenti.Size = new System.Drawing.Size(120, 32);
            this.buttonDokumenti.TabIndex = 4;
            this.buttonDokumenti.Text = "Dokumenti";
            this.buttonDokumenti.UseVisualStyleBackColor = true;
            this.buttonDokumenti.Click += new System.EventHandler(this.buttonDokumenti_Click);
            // 
            // buttonPrimka
            // 
            this.buttonPrimka.Location = new System.Drawing.Point(43, 88);
            this.buttonPrimka.Name = "buttonPrimka";
            this.buttonPrimka.Size = new System.Drawing.Size(120, 32);
            this.buttonPrimka.TabIndex = 5;
            this.buttonPrimka.Text = "Nova primka";
            this.buttonPrimka.UseVisualStyleBackColor = true;
            this.buttonPrimka.Click += new System.EventHandler(this.buttonPrimka_Click);
            // 
            // buttonIzdatnica
            // 
            this.buttonIzdatnica.Location = new System.Drawing.Point(43, 126);
            this.buttonIzdatnica.Name = "buttonIzdatnica";
            this.buttonIzdatnica.Size = new System.Drawing.Size(120, 32);
            this.buttonIzdatnica.TabIndex = 6;
            this.buttonIzdatnica.Text = "Nova izdatnica";
            this.buttonIzdatnica.UseVisualStyleBackColor = true;
            this.buttonIzdatnica.Click += new System.EventHandler(this.buttonIzdatnica_Click);
            // 
            // buttonStanje
            // 
            this.buttonStanje.Location = new System.Drawing.Point(43, 164);
            this.buttonStanje.Name = "buttonStanje";
            this.buttonStanje.Size = new System.Drawing.Size(120, 32);
            this.buttonStanje.TabIndex = 7;
            this.buttonStanje.Text = "Stanje";
            this.buttonStanje.UseVisualStyleBackColor = true;
            this.buttonStanje.Click += new System.EventHandler(this.buttonStanje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 215);
            this.Controls.Add(this.buttonStanje);
            this.Controls.Add(this.buttonIzdatnica);
            this.Controls.Add(this.buttonPrimka);
            this.Controls.Add(this.buttonDokumenti);
            this.Controls.Add(this.buttonArtikli);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonArtikli;
        private System.Windows.Forms.Button buttonDokumenti;
        private System.Windows.Forms.Button buttonPrimka;
        private System.Windows.Forms.Button buttonIzdatnica;
        private System.Windows.Forms.Button buttonStanje;
    }
}

