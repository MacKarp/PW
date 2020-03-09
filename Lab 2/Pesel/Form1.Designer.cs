namespace Pesel
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
            this.labelInputbox = new System.Windows.Forms.Label();
            this.textBoxPeselInput = new System.Windows.Forms.TextBox();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.labelWynikSprawdzania = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInputbox
            // 
            this.labelInputbox.AutoSize = true;
            this.labelInputbox.Location = new System.Drawing.Point(95, 88);
            this.labelInputbox.Name = "labelInputbox";
            this.labelInputbox.Size = new System.Drawing.Size(97, 13);
            this.labelInputbox.TabIndex = 0;
            this.labelInputbox.Text = "Podaj numer pesel:";
            // 
            // textBoxPeselInput
            // 
            this.textBoxPeselInput.Location = new System.Drawing.Point(98, 104);
            this.textBoxPeselInput.Name = "textBoxPeselInput";
            this.textBoxPeselInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxPeselInput.TabIndex = 1;
            this.textBoxPeselInput.TextChanged += new System.EventHandler(this.textBoxPeselInput_TextChanged);
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSprawdz.Location = new System.Drawing.Point(98, 239);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(291, 92);
            this.buttonSprawdz.TabIndex = 2;
            this.buttonSprawdz.Text = "SPRAWDŹ POPRAWNOŚĆ";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            // 
            // labelWynikSprawdzania
            // 
            this.labelWynikSprawdzania.AutoSize = true;
            this.labelWynikSprawdzania.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynikSprawdzania.Location = new System.Drawing.Point(237, 88);
            this.labelWynikSprawdzania.Name = "labelWynikSprawdzania";
            this.labelWynikSprawdzania.Size = new System.Drawing.Size(0, 39);
            this.labelWynikSprawdzania.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWynikSprawdzania);
            this.Controls.Add(this.buttonSprawdz);
            this.Controls.Add(this.textBoxPeselInput);
            this.Controls.Add(this.labelInputbox);
            this.Name = "Form1";
            this.Text = "Pesel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputbox;
        private System.Windows.Forms.TextBox textBoxPeselInput;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Label labelWynikSprawdzania;
    }
}

