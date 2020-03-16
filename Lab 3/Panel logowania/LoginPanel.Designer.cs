namespace Panel_logowania
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPasswordField = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelLoginEmpty = new System.Windows.Forms.Label();
            this.labelPasswordEmpty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserName.Location = new System.Drawing.Point(12, 9);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(208, 73);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Login:";
            // 
            // labelPasswordField
            // 
            this.labelPasswordField.AutoSize = true;
            this.labelPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordField.Location = new System.Drawing.Point(12, 148);
            this.labelPasswordField.Name = "labelPasswordField";
            this.labelPasswordField.Size = new System.Drawing.Size(214, 73);
            this.labelPasswordField.TabIndex = 1;
            this.labelPasswordField.Text = "Hasło:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUserName.Location = new System.Drawing.Point(226, 6);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(549, 80);
            this.textBoxUserName.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(226, 145);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(549, 80);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.Location = new System.Drawing.Point(263, 327);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(336, 111);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelLoginEmpty
            // 
            this.labelLoginEmpty.AutoSize = true;
            this.labelLoginEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginEmpty.ForeColor = System.Drawing.Color.Red;
            this.labelLoginEmpty.Location = new System.Drawing.Point(256, 89);
            this.labelLoginEmpty.Name = "labelLoginEmpty";
            this.labelLoginEmpty.Size = new System.Drawing.Size(486, 39);
            this.labelLoginEmpty.TabIndex = 5;
            this.labelLoginEmpty.Text = "Pole login nie może być puste!";
            this.labelLoginEmpty.Visible = false;
            // 
            // labelPasswordEmpty
            // 
            this.labelPasswordEmpty.AutoSize = true;
            this.labelPasswordEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordEmpty.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordEmpty.Location = new System.Drawing.Point(256, 228);
            this.labelPasswordEmpty.Name = "labelPasswordEmpty";
            this.labelPasswordEmpty.Size = new System.Drawing.Size(496, 39);
            this.labelPasswordEmpty.TabIndex = 6;
            this.labelPasswordEmpty.Text = "Pole hasło nie może być puste!";
            this.labelPasswordEmpty.Visible = false;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPasswordEmpty);
            this.Controls.Add(this.labelLoginEmpty);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPasswordField);
            this.Controls.Add(this.labelUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "LoginPanel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Panel logowania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPasswordField;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelLoginEmpty;
        private System.Windows.Forms.Label labelPasswordEmpty;
    }
}

