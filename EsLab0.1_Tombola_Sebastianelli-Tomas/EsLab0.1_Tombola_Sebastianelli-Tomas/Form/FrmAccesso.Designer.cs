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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccesso));
            this.pnlAccesso = new System.Windows.Forms.Panel();
            this.llRegistrati = new System.Windows.Forms.LinkLabel();
            this.btAccedi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbLocale = new System.Windows.Forms.RadioButton();
            this.rbRemoto = new System.Windows.Forms.RadioButton();
            this.pnlAccesso.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnlAccesso.Location = new System.Drawing.Point(275, 119);
            this.pnlAccesso.Name = "pnlAccesso";
            this.pnlAccesso.Size = new System.Drawing.Size(251, 213);
            this.pnlAccesso.TabIndex = 0;
            // 
            // llRegistrati
            // 
            this.llRegistrati.AutoSize = true;
            this.llRegistrati.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.llRegistrati.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            this.llRegistrati.Location = new System.Drawing.Point(54, 185);
            this.llRegistrati.Name = "llRegistrati";
            this.llRegistrati.Size = new System.Drawing.Size(179, 16);
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
            this.btAccedi.Location = new System.Drawing.Point(25, 149);
            this.btAccedi.Name = "btAccedi";
            this.btAccedi.Size = new System.Drawing.Size(208, 33);
            this.btAccedi.TabIndex = 5;
            this.btAccedi.Text = "Accedi";
            this.btAccedi.UseVisualStyleBackColor = false;
            this.btAccedi.Click += new System.EventHandler(this.btAccedi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tbPassword.Location = new System.Drawing.Point(25, 123);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(208, 21);
            this.tbPassword.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tbEmail.Location = new System.Drawing.Point(25, 84);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(208, 21);
            this.tbEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accesso";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbRemoto);
            this.panel1.Controls.Add(this.rbLocale);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 45);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gioca con server:";
            // 
            // rbLocale
            // 
            this.rbLocale.AutoSize = true;
            this.rbLocale.Checked = true;
            this.rbLocale.Location = new System.Drawing.Point(13, 21);
            this.rbLocale.Name = "rbLocale";
            this.rbLocale.Size = new System.Drawing.Size(57, 17);
            this.rbLocale.TabIndex = 2;
            this.rbLocale.TabStop = true;
            this.rbLocale.Text = "Locale";
            this.rbLocale.UseVisualStyleBackColor = true;
            this.rbLocale.CheckedChanged += new System.EventHandler(this.rbLocale_CheckedChanged);
            // 
            // rbRemoto
            // 
            this.rbRemoto.AutoSize = true;
            this.rbRemoto.Location = new System.Drawing.Point(76, 21);
            this.rbRemoto.Name = "rbRemoto";
            this.rbRemoto.Size = new System.Drawing.Size(62, 17);
            this.rbRemoto.TabIndex = 3;
            this.rbRemoto.Text = "Remoto";
            this.rbRemoto.UseVisualStyleBackColor = true;
            this.rbRemoto.CheckedChanged += new System.EventHandler(this.rbRemoto_CheckedChanged);
            // 
            // FrmAccesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EsLab0._1_Tombola_Sebastianelli_Tomas.Properties.Resources.Sfondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAccesso);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAccesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accesso - Tombola";
            this.pnlAccesso.ResumeLayout(false);
            this.pnlAccesso.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbRemoto;
        private System.Windows.Forms.RadioButton rbLocale;
        private System.Windows.Forms.Label label4;
    }
}

