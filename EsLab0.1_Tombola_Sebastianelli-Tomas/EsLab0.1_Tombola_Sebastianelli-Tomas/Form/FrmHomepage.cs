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
        #region Variabili

        #endregion

        #region Costruttore
        public FrmHomepage()
        {
            InitializeComponent();
        }
        #endregion
        ClsPartitaBL _metodiPartita = new ClsPartitaBL(Program._dbManager);
        #region Eventi
        private void FrmHomepage_Load(object sender, EventArgs e)
        {
            // Nascondi la Form di accesso
            this.Owner.Hide();

            // Carica il nome utente
            lblUtente.Text = "Bentornato, " + Program._giocatoreLoggato.Nome;

            // Caricamento ListView
            // TODO
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

        private void btCerca_Click(object sender, EventArgs e)
        {
            // Dichiarazione variabili
            List<int> _idPartiteTrovate;

            // Svuoto la ListView delle partite
            lvPartite.Items.Clear();

            // Cerco le partite per nome ed ottengo gli indici di quelle trovate
            _idPartiteTrovate = _metodiPartita.CercaPerNome(tbCerca.Text.Trim());

            // Mostro le partite con l'ID 
            for(int i = 0; i < _idPartiteTrovate.Count; i++)
            {
                // Ottengo la posizione della partita nella lista di partite
                int _indicePartita = _metodiPartita.CercaPartitaDaID(_idPartiteTrovate[i]);

                // Creo e carico la riga sulla ListView
                ListViewItem lvi = new ListViewItem(Program._partite[_indicePartita].Id.ToString());
                lvi.SubItems.Add(Program._partite[_indicePartita].Nome);
                lvi.SubItems.Add(Program._partite[_indicePartita].Prezzo.ToString());

                lvPartite.Items.Add(lvi);
            }
        }
    }
}
