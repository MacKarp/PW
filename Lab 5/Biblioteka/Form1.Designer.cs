namespace Biblioteka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelNazwaKsiazki = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelGatunek = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelWydawnictwo = new System.Windows.Forms.Label();
            this.labelPolozenie = new System.Windows.Forms.Label();
            this.labelSektor = new System.Windows.Forms.Label();
            this.labelPozycja = new System.Windows.Forms.Label();
            this.labelRegal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(652, 412);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelNazwaKsiazki
            // 
            this.labelNazwaKsiazki.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwaKsiazki.Location = new System.Drawing.Point(670, 12);
            this.labelNazwaKsiazki.Name = "labelNazwaKsiazki";
            this.labelNazwaKsiazki.Size = new System.Drawing.Size(385, 58);
            this.labelNazwaKsiazki.TabIndex = 1;
            this.labelNazwaKsiazki.Text = "Nazwa książki";
            this.labelNazwaKsiazki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAutor.Location = new System.Drawing.Point(670, 70);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(69, 25);
            this.labelAutor.TabIndex = 2;
            this.labelAutor.Text = "Autor:";
            this.labelAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGatunek
            // 
            this.labelGatunek.AutoSize = true;
            this.labelGatunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGatunek.Location = new System.Drawing.Point(670, 95);
            this.labelGatunek.Name = "labelGatunek";
            this.labelGatunek.Size = new System.Drawing.Size(99, 25);
            this.labelGatunek.TabIndex = 3;
            this.labelGatunek.Text = "Gatunek:";
            this.labelGatunek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelISBN.Location = new System.Drawing.Point(670, 120);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(135, 25);
            this.labelISBN.TabIndex = 4;
            this.labelISBN.Text = "Numer ISBN:";
            this.labelISBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWydawnictwo
            // 
            this.labelWydawnictwo.AutoSize = true;
            this.labelWydawnictwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWydawnictwo.Location = new System.Drawing.Point(670, 145);
            this.labelWydawnictwo.Name = "labelWydawnictwo";
            this.labelWydawnictwo.Size = new System.Drawing.Size(149, 25);
            this.labelWydawnictwo.TabIndex = 5;
            this.labelWydawnictwo.Text = "Wydawnictwo:";
            this.labelWydawnictwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPolozenie
            // 
            this.labelPolozenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPolozenie.Location = new System.Drawing.Point(670, 170);
            this.labelPolozenie.Name = "labelPolozenie";
            this.labelPolozenie.Size = new System.Drawing.Size(385, 58);
            this.labelPolozenie.TabIndex = 6;
            this.labelPolozenie.Text = "Książka znajduje się w:";
            this.labelPolozenie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSektor
            // 
            this.labelSektor.AutoSize = true;
            this.labelSektor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSektor.Location = new System.Drawing.Point(671, 228);
            this.labelSektor.Name = "labelSektor";
            this.labelSektor.Size = new System.Drawing.Size(80, 25);
            this.labelSektor.TabIndex = 7;
            this.labelSektor.Text = "Sektor:";
            this.labelSektor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPozycja
            // 
            this.labelPozycja.AutoSize = true;
            this.labelPozycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPozycja.Location = new System.Drawing.Point(670, 278);
            this.labelPozycja.Name = "labelPozycja";
            this.labelPozycja.Size = new System.Drawing.Size(94, 25);
            this.labelPozycja.TabIndex = 8;
            this.labelPozycja.Text = "Pozycja:";
            this.labelPozycja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegal
            // 
            this.labelRegal.AutoSize = true;
            this.labelRegal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRegal.Location = new System.Drawing.Point(671, 253);
            this.labelRegal.Name = "labelRegal";
            this.labelRegal.Size = new System.Drawing.Size(74, 25);
            this.labelRegal.TabIndex = 9;
            this.labelRegal.Text = "Regał:";
            this.labelRegal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.labelRegal);
            this.Controls.Add(this.labelPozycja);
            this.Controls.Add(this.labelSektor);
            this.Controls.Add(this.labelPolozenie);
            this.Controls.Add(this.labelWydawnictwo);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelGatunek);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelNazwaKsiazki);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Katalog biblioteki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelNazwaKsiazki;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelGatunek;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelWydawnictwo;
        private System.Windows.Forms.Label labelPolozenie;
        private System.Windows.Forms.Label labelSektor;
        private System.Windows.Forms.Label labelPozycja;
        private System.Windows.Forms.Label labelRegal;
    }
}

