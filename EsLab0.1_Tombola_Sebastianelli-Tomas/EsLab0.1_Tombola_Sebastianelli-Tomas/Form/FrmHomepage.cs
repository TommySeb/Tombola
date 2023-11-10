using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    public partial class FrmHomepage : Form
    {
        #region Costruttore
        public FrmHomepage()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventi
        private void FrmHomepage_Load(object sender, EventArgs e)
        {
            // Nascondi la Form di accesso
            this.Owner.Hide();

            // Carica il nome utente
            lblUtente.Text = Program._giocatoreLoggato.Nome;
        }

        private void lvPartite_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            Console.Write("Column Resizing");
            e.NewWidth = this.lvPartite.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void FrmHomepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Conferma di uscita dall'app
            DialogResult dr = MessageBox.Show("Sei sicuro di voler uscire?", "Conferma uscita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                Application.Exit();
            else
                e.Cancel = true;
        }
        #endregion
    }
}
