namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    partial class FrmRegistrazione
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tbConfermaPassword = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbGenere = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataDiNascita = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.btRegistrati = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbConfermaPassword);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.cbGenere);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpDataDiNascita);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbNickname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbCognome);
            this.panel1.Controls.Add(this.btRegistrati);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(275, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 437);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Conferma password:";
            // 
            // tbConfermaPassword
            // 
            this.tbConfermaPassword.Location = new System.Drawing.Point(19, 360);
            this.tbConfermaPassword.Name = "tbConfermaPassword";
            this.tbConfermaPassword.PasswordChar = '•';
            this.tbConfermaPassword.Size = new System.Drawing.Size(208, 20);
            this.tbConfermaPassword.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "E-mail:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(19, 283);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(208, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // cbGenere
            // 
            this.cbGenere.FormattingEnabled = true;
            this.cbGenere.Items.AddRange(new object[] {
            "Maschio",
            "Femmina",
            "Altro"});
            this.cbGenere.Location = new System.Drawing.Point(19, 243);
            this.cbGenere.Name = "cbGenere";
            this.cbGenere.Size = new System.Drawing.Size(208, 21);
            this.cbGenere.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Genere:";
            // 
            // dtpDataDiNascita
            // 
            this.dtpDataDiNascita.Location = new System.Drawing.Point(19, 204);
            this.dtpDataDiNascita.Name = "dtpDataDiNascita";
            this.dtpDataDiNascita.Size = new System.Drawing.Size(208, 20);
            this.dtpDataDiNascita.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data di nascita:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nickname:";
            // 
            // tbNickname
            // 
            this.tbNickname.Location = new System.Drawing.Point(19, 165);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(208, 20);
            this.tbNickname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cognome:";
            // 
            // tbCognome
            // 
            this.tbCognome.Location = new System.Drawing.Point(19, 126);
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(208, 20);
            this.tbCognome.TabIndex = 2;
            // 
            // btRegistrati
            // 
            this.btRegistrati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            this.btRegistrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrati.ForeColor = System.Drawing.Color.White;
            this.btRegistrati.Location = new System.Drawing.Point(19, 386);
            this.btRegistrati.Name = "btRegistrati";
            this.btRegistrati.Size = new System.Drawing.Size(208, 33);
            this.btRegistrati.TabIndex = 9;
            this.btRegistrati.Text = "Registrati";
            this.btRegistrati.UseVisualStyleBackColor = false;
            this.btRegistrati.Click += new System.EventHandler(this.btRegistrati_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(19, 322);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(208, 20);
            this.tbPassword.TabIndex = 7;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(19, 87);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(208, 20);
            this.tbNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrazione";
            // 
            // FrmRegistrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EsLab0._1_Tombola_Sebastianelli_Tomas.Properties.Resources.Sfondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRegistrazione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrazione - Tombola";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btRegistrati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbPassword;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCognome;
        private System.Windows.Forms.DateTimePicker dtpDataDiNascita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox tbConfermaPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbGenere;
        private System.Windows.Forms.Label label7;
    }
}

