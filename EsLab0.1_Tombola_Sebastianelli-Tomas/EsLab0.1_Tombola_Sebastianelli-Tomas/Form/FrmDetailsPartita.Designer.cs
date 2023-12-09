namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    partial class FrmDetailsPartita
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
            this.lblTitolo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPrezzo = new System.Windows.Forms.NumericUpDown();
            this.nudValoreAmbo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudValoreTerna = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudValoreQuaterna = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudValoreCinquina = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudValoreTombola = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btConferma = new System.Windows.Forms.Button();
            this.btAnnulla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValoreAmbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValoreTerna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValoreQuaterna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValoreCinquina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValoreTombola)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitolo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.ForeColor = System.Drawing.Color.White;
            this.lblTitolo.Location = new System.Drawing.Point(13, 13);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(153, 23);
            this.lblTitolo.TabIndex = 1;
            this.lblTitolo.Text = "Dettagli partita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(17, 62);
            this.tbNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(275, 21);
            this.tbNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezzo";
            // 
            // nudPrezzo
            // 
            this.nudPrezzo.Location = new System.Drawing.Point(17, 110);
            this.nudPrezzo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudPrezzo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nudPrezzo.Name = "nudPrezzo";
            this.nudPrezzo.Size = new System.Drawing.Size(275, 21);
            this.nudPrezzo.TabIndex = 6;
            // 
            // nudValoreAmbo
            // 
            this.nudValoreAmbo.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nudValoreAmbo.Location = new System.Drawing.Point(17, 158);
            this.nudValoreAmbo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudValoreAmbo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nudValoreAmbo.Name = "nudValoreAmbo";
            this.nudValoreAmbo.Size = new System.Drawing.Size(275, 21);
            this.nudValoreAmbo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valore ambo";
            // 
            // nudValoreTerna
            // 
            this.nudValoreTerna.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nudValoreTerna.Location = new System.Drawing.Point(17, 206);
            this.nudValoreTerna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudValoreTerna.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nudValoreTerna.Name = "nudValoreTerna";
            this.nudValoreTerna.Size = new System.Drawing.Size(275, 21);
            this.nudValoreTerna.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valore terna";
            // 
            // nudValoreQuaterna
            // 
            this.nudValoreQuaterna.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nudValoreQuaterna.Location = new System.Drawing.Point(17, 254);
            this.nudValoreQuaterna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudValoreQuaterna.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nudValoreQuaterna.Name = "nudValoreQuaterna";
            this.nudValoreQuaterna.Size = new System.Drawing.Size(275, 21);
            this.nudValoreQuaterna.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valore quaterna";
            // 
            // nudValoreCinquina
            // 
            this.nudValoreCinquina.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nudValoreCinquina.Location = new System.Drawing.Point(17, 302);
            this.nudValoreCinquina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudValoreCinquina.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nudValoreCinquina.Name = "nudValoreCinquina";
            this.nudValoreCinquina.Size = new System.Drawing.Size(275, 21);
            this.nudValoreCinquina.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valore cinquina";
            // 
            // nudValoreTombola
            // 
            this.nudValoreTombola.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nudValoreTombola.Location = new System.Drawing.Point(17, 350);
            this.nudValoreTombola.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudValoreTombola.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nudValoreTombola.Name = "nudValoreTombola";
            this.nudValoreTombola.Size = new System.Drawing.Size(275, 21);
            this.nudValoreTombola.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Valore tombola";
            // 
            // btConferma
            // 
            this.btConferma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            this.btConferma.ForeColor = System.Drawing.Color.White;
            this.btConferma.Location = new System.Drawing.Point(17, 379);
            this.btConferma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btConferma.Name = "btConferma";
            this.btConferma.Size = new System.Drawing.Size(114, 37);
            this.btConferma.TabIndex = 17;
            this.btConferma.Text = "Partecipa";
            this.btConferma.UseVisualStyleBackColor = false;
            this.btConferma.Click += new System.EventHandler(this.btConferma_Click);
            // 
            // btAnnulla
            // 
            this.btAnnulla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(173)))), ((int)(((byte)(240)))));
            this.btAnnulla.ForeColor = System.Drawing.Color.White;
            this.btAnnulla.Location = new System.Drawing.Point(178, 379);
            this.btAnnulla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAnnulla.Name = "btAnnulla";
            this.btAnnulla.Size = new System.Drawing.Size(114, 37);
            this.btAnnulla.TabIndex = 18;
            this.btAnnulla.Text = "Annulla";
            this.btAnnulla.UseVisualStyleBackColor = false;
            this.btAnnulla.Click += new System.EventHandler(this.btAnnulla_Click);
            // 
            // FrmDetailsPartita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EsLab0._1_Tombola_Sebastianelli_Tomas.Properties.Resources.Sfondo;
            this.ClientSize = new System.Drawing.Size(305, 429);
            this.Controls.Add(this.btAnnulla);
            this.Controls.Add(this.btConferma);
            this.Controls.Add(this.nudValoreTombola);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudValoreCinquina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudValoreQuaterna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudValoreTerna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudValoreAmbo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudPrezzo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitolo);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDetailsPartita";
            this.Text = "Dettagli partita - Tombola";
            this.Load += new System.EventHandler(this.FrmDetailsPartita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValoreAmbo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValoreTerna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValoreQuaterna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValoreCinquina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValoreTombola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPrezzo;
        private System.Windows.Forms.NumericUpDown nudValoreAmbo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudValoreTerna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudValoreQuaterna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudValoreCinquina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudValoreTombola;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btConferma;
        private System.Windows.Forms.Button btAnnulla;
    }
}