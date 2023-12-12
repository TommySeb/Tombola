namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    partial class FrmBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanco));
            this.lblNomePartita = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btEstrai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomePartita
            // 
            this.lblNomePartita.AutoSize = true;
            this.lblNomePartita.BackColor = System.Drawing.Color.Transparent;
            this.lblNomePartita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartita.ForeColor = System.Drawing.Color.White;
            this.lblNomePartita.Location = new System.Drawing.Point(12, 9);
            this.lblNomePartita.Name = "lblNomePartita";
            this.lblNomePartita.Size = new System.Drawing.Size(128, 25);
            this.lblNomePartita.TabIndex = 0;
            this.lblNomePartita.Text = "Nome partita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Numeri estratti:";
            // 
            // btEstrai
            // 
            this.btEstrai.Location = new System.Drawing.Point(564, 39);
            this.btEstrai.Name = "btEstrai";
            this.btEstrai.Size = new System.Drawing.Size(75, 23);
            this.btEstrai.TabIndex = 57;
            this.btEstrai.Text = "Estrai...";
            this.btEstrai.UseVisualStyleBackColor = true;
            this.btEstrai.Click += new System.EventHandler(this.btEstrai_Click);
            // 
            // FrmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EsLab0._1_Tombola_Sebastianelli_Tomas.Properties.Resources.Sfondo_744x798;
            this.ClientSize = new System.Drawing.Size(653, 703);
            this.Controls.Add(this.btEstrai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomePartita);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBanco";
            this.Text = "Banco - Tombola";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBanco_FormClosing);
            this.Load += new System.EventHandler(this.FrmBanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePartita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEstrai;
    }
}