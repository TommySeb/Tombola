namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    partial class FrmHomepage
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
            this.lblUtente = new System.Windows.Forms.Label();
            this.lvPartite = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CostoCartella = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btCerca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUtente
            // 
            this.lblUtente.AutoSize = true;
            this.lblUtente.BackColor = System.Drawing.Color.Transparent;
            this.lblUtente.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtente.ForeColor = System.Drawing.Color.White;
            this.lblUtente.Location = new System.Drawing.Point(12, 9);
            this.lblUtente.Name = "lblUtente";
            this.lblUtente.Size = new System.Drawing.Size(166, 23);
            this.lblUtente.TabIndex = 0;
            this.lblUtente.Text = "Benvenuto, user";
            // 
            // lvPartite
            // 
            this.lvPartite.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.CostoCartella});
            this.lvPartite.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lvPartite.FullRowSelect = true;
            this.lvPartite.HideSelection = false;
            this.lvPartite.Location = new System.Drawing.Point(17, 83);
            this.lvPartite.MultiSelect = false;
            this.lvPartite.Name = "lvPartite";
            this.lvPartite.Size = new System.Drawing.Size(316, 355);
            this.lvPartite.TabIndex = 1;
            this.lvPartite.UseCompatibleStateImageBehavior = false;
            this.lvPartite.View = System.Windows.Forms.View.Details;
            this.lvPartite.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvPartite_ColumnWidthChanging);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 150;
            // 
            // CostoCartella
            // 
            this.CostoCartella.Text = "Costo cartella";
            this.CostoCartella.Width = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Partite disponibili:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(339, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gioca";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(173)))), ((int)(((byte)(240)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(339, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Crea nuova partita";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btCerca
            // 
            this.btCerca.Location = new System.Drawing.Point(239, 57);
            this.btCerca.Name = "btCerca";
            this.btCerca.Size = new System.Drawing.Size(94, 20);
            this.btCerca.TabIndex = 6;
            this.btCerca.Text = "Cerca per nome";
            this.btCerca.UseVisualStyleBackColor = true;
            // 
            // FrmHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EsLab0._1_Tombola_Sebastianelli_Tomas.Properties.Resources.Sfondo;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.btCerca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvPartite);
            this.Controls.Add(this.lblUtente);
            this.Name = "FrmHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage - Tombola";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHomepage_FormClosing);
            this.Load += new System.EventHandler(this.FrmHomepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUtente;
        private System.Windows.Forms.ListView lvPartite;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader CostoCartella;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btCerca;
    }
}