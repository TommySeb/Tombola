namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    partial class FrmAccesso
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
            this.pnlAccesso = new System.Windows.Forms.Panel();
            this.llRegistrati = new System.Windows.Forms.LinkLabel();
            this.btAccedi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAccesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccesso
            // 
            this.pnlAccesso.Controls.Add(this.llRegistrati);
            this.pnlAccesso.Controls.Add(this.btAccedi);
            this.pnlAccesso.Controls.Add(this.label3);
            this.pnlAccesso.Controls.Add(this.label2);
            this.pnlAccesso.Controls.Add(this.tbPassword);
            this.pnlAccesso.Controls.Add(this.tbEmail);
            this.pnlAccesso.Controls.Add(this.label1);
            this.pnlAccesso.Location = new System.Drawing.Point(367, 146);
            this.pnlAccesso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAccesso.Name = "pnlAccesso";
            this.pnlAccesso.Size = new System.Drawing.Size(335, 262);
            this.pnlAccesso.TabIndex = 0;
            // 
            // llRegistrati
            // 
            this.llRegistrati.AutoSize = true;
            this.llRegistrati.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.llRegistrati.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            this.llRegistrati.Location = new System.Drawing.Point(72, 228);
            this.llRegistrati.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llRegistrati.Name = "llRegistrati";
            this.llRegistrati.Size = new System.Drawing.Size(229, 19);
            this.llRegistrati.TabIndex = 6;
            this.llRegistrati.TabStop = true;
            this.llRegistrati.Text = "Non hai mai giocato? Registrati!";
            this.llRegistrati.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            this.llRegistrati.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRegistrati_LinkClicked);
            // 
            // btAccedi
            // 
            this.btAccedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            this.btAccedi.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btAccedi.ForeColor = System.Drawing.Color.White;
            this.btAccedi.Location = new System.Drawing.Point(33, 183);
            this.btAccedi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAccedi.Name = "btAccedi";
            this.btAccedi.Size = new System.Drawing.Size(277, 41);
            this.btAccedi.TabIndex = 5;
            this.btAccedi.Text = "Accedi";
            this.btAccedi.UseVisualStyleBackColor = false;
            this.btAccedi.Click += new System.EventHandler(this.btAccedi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(29, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tbPassword.Location = new System.Drawing.Point(33, 151);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(276, 24);
            this.tbPassword.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tbEmail.Location = new System.Drawing.Point(33, 103);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(276, 24);
            this.tbEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accesso";
            // 
            // FrmAccesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EsLab0._1_Tombola_Sebastianelli_Tomas.Properties.Resources.Sfondo;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlAccesso);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAccesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accesso - Tombola";
            this.pnlAccesso.ResumeLayout(false);
            this.pnlAccesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccesso;
        private System.Windows.Forms.Button btAccedi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llRegistrati;
    }
}

