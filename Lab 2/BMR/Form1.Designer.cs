namespace BMR
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
            this.labelMasaInputBox = new System.Windows.Forms.Label();
            this.textBoxMasaInput = new System.Windows.Forms.TextBox();
            this.labelWzrostInputBox = new System.Windows.Forms.Label();
            this.textBoxWzrostInput = new System.Windows.Forms.TextBox();
            this.labelRadioButton = new System.Windows.Forms.Label();
            this.radioButtonKobieta = new System.Windows.Forms.RadioButton();
            this.radioButtonMezczyzna = new System.Windows.Forms.RadioButton();
            this.labelWynik = new System.Windows.Forms.Label();
            this.labelWynikOutput = new System.Windows.Forms.Label();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.labelInputBoxWiek = new System.Windows.Forms.Label();
            this.textBoxWiekInput = new System.Windows.Forms.TextBox();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMasaInputBox
            // 
            this.labelMasaInputBox.AutoSize = true;
            this.labelMasaInputBox.Location = new System.Drawing.Point(50, 93);
            this.labelMasaInputBox.Name = "labelMasaInputBox";
            this.labelMasaInputBox.Size = new System.Drawing.Size(84, 13);
            this.labelMasaInputBox.TabIndex = 0;
            this.labelMasaInputBox.Text = "Masa ciała [kg]:";
            this.labelMasaInputBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxMasaInput
            // 
            this.textBoxMasaInput.Location = new System.Drawing.Point(53, 109);
            this.textBoxMasaInput.Name = "textBoxMasaInput";
            this.textBoxMasaInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxMasaInput.TabIndex = 1;
            this.textBoxMasaInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelWzrostInputBox
            // 
            this.labelWzrostInputBox.AutoSize = true;
            this.labelWzrostInputBox.Location = new System.Drawing.Point(53, 161);
            this.labelWzrostInputBox.Name = "labelWzrostInputBox";
            this.labelWzrostInputBox.Size = new System.Drawing.Size(66, 13);
            this.labelWzrostInputBox.TabIndex = 2;
            this.labelWzrostInputBox.Text = "Wzrost [cm]:";
            this.labelWzrostInputBox.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxWzrostInput
            // 
            this.textBoxWzrostInput.Location = new System.Drawing.Point(53, 177);
            this.textBoxWzrostInput.Name = "textBoxWzrostInput";
            this.textBoxWzrostInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxWzrostInput.TabIndex = 3;
            // 
            // labelRadioButton
            // 
            this.labelRadioButton.AutoSize = true;
            this.labelRadioButton.Location = new System.Drawing.Point(262, 115);
            this.labelRadioButton.Name = "labelRadioButton";
            this.labelRadioButton.Size = new System.Drawing.Size(86, 13);
            this.labelRadioButton.TabIndex = 4;
            this.labelRadioButton.Text = "Oblicz wynik dla:";
            this.labelRadioButton.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioButtonKobieta
            // 
            this.radioButtonKobieta.AutoSize = true;
            this.radioButtonKobieta.Location = new System.Drawing.Point(265, 141);
            this.radioButtonKobieta.Name = "radioButtonKobieta";
            this.radioButtonKobieta.Size = new System.Drawing.Size(60, 17);
            this.radioButtonKobieta.TabIndex = 5;
            this.radioButtonKobieta.Text = "Kobiety";
            this.radioButtonKobieta.UseVisualStyleBackColor = true;
            this.radioButtonKobieta.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonMezczyzna
            // 
            this.radioButtonMezczyzna.AutoSize = true;
            this.radioButtonMezczyzna.Location = new System.Drawing.Point(265, 165);
            this.radioButtonMezczyzna.Name = "radioButtonMezczyzna";
            this.radioButtonMezczyzna.Size = new System.Drawing.Size(77, 17);
            this.radioButtonMezczyzna.TabIndex = 6;
            this.radioButtonMezczyzna.Text = "Mężczyzny";
            this.radioButtonMezczyzna.UseVisualStyleBackColor = true;
            this.radioButtonMezczyzna.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Location = new System.Drawing.Point(265, 205);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(40, 13);
            this.labelWynik.TabIndex = 7;
            this.labelWynik.Text = "Wynik:";
            this.labelWynik.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelWynikOutput
            // 
            this.labelWynikOutput.AutoSize = true;
            this.labelWynikOutput.Location = new System.Drawing.Point(307, 205);
            this.labelWynikOutput.Name = "labelWynikOutput";
            this.labelWynikOutput.Size = new System.Drawing.Size(0, 13);
            this.labelWynikOutput.TabIndex = 8;
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOblicz.Location = new System.Drawing.Point(12, 367);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(220, 71);
            this.buttonOblicz.TabIndex = 9;
            this.buttonOblicz.Text = "OBLICZ!";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            this.buttonOblicz.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInputBoxWiek
            // 
            this.labelInputBoxWiek.AutoSize = true;
            this.labelInputBoxWiek.Location = new System.Drawing.Point(53, 220);
            this.labelInputBoxWiek.Name = "labelInputBoxWiek";
            this.labelInputBoxWiek.Size = new System.Drawing.Size(35, 13);
            this.labelInputBoxWiek.TabIndex = 10;
            this.labelInputBoxWiek.Text = "Wiek:";
            // 
            // textBoxWiekInput
            // 
            this.textBoxWiekInput.Location = new System.Drawing.Point(53, 237);
            this.textBoxWiekInput.Name = "textBoxWiekInput";
            this.textBoxWiekInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxWiekInput.TabIndex = 11;
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyczysc.Location = new System.Drawing.Point(238, 367);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(220, 71);
            this.buttonWyczysc.TabIndex = 12;
            this.buttonWyczysc.Text = "WYCZYŚĆ POLA";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 451);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.textBoxWiekInput);
            this.Controls.Add(this.labelInputBoxWiek);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.labelWynikOutput);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.radioButtonMezczyzna);
            this.Controls.Add(this.radioButtonKobieta);
            this.Controls.Add(this.labelRadioButton);
            this.Controls.Add(this.textBoxWzrostInput);
            this.Controls.Add(this.labelWzrostInputBox);
            this.Controls.Add(this.textBoxMasaInput);
            this.Controls.Add(this.labelMasaInputBox);
            this.Name = "Form1";
            this.Text = "BMR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMasaInputBox;
        private System.Windows.Forms.TextBox textBoxMasaInput;
        private System.Windows.Forms.Label labelWzrostInputBox;
        private System.Windows.Forms.TextBox textBoxWzrostInput;
        private System.Windows.Forms.Label labelRadioButton;
        private System.Windows.Forms.RadioButton radioButtonKobieta;
        private System.Windows.Forms.RadioButton radioButtonMezczyzna;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.Label labelWynikOutput;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.Label labelInputBoxWiek;
        private System.Windows.Forms.TextBox textBoxWiekInput;
        private System.Windows.Forms.Button buttonWyczysc;
    }
}

