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
        #region Costanti
        const string SUGGERIMENTO_TB_RICERCA = "Cerca per nome...";
        #endregion

        #region Variabili
        ClsPartitaBL _metodiPartite = new ClsPartitaBL(Program._dbManager);
        bool _suggerimentoTBRimosso;    // Indica se il suggerimento dalla TextBox di ricerca è stato rimosso
        #endregion

        #region Costruttore
        public FrmHomepage()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Ottiene le partite dal DB ed aggiorna la relativa ListView
        /// </summary>
        private void AggiornaLvPartite()
        {
            // Ottengo le partite dal DB
            _metodiPartite.OttieniPartiteDaDB();

            // Aggiorno la ListView
            lvPartite.Items.Clear();

            foreach (ClsPartitaDB partita in Program._partite)
            {
                ListViewItem lvi = new ListViewItem(partita.Id.ToString());
                lvi.SubItems.Add(partita.Nome);
                lvi.SubItems.Add(partita.Prezzo.ToString());

                lvPartite.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Svuota la ListView delle partite e carica quelle passate
        /// </summary>
        /// <param name="partiteDaCaricare">Lista di partite da caricare</param>
        private void CaricaSuListView(List<ClsPartitaDB> partiteDaCaricare)
        {
            lvPartite.Items.Clear();

            foreach (ClsPartitaDB partita in partiteDaCaricare)
            {
                ListViewItem lvi = new ListViewItem(partita.Id.ToString());
                lvi.SubItems.Add(partita.Nome);
                lvi.SubItems.Add(partita.Prezzo.ToString());

                lvPartite.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Ottiene tutte le partite dal DB e le cerca per nome
        /// </summary>
        /// <param name="nome"></param>
        private void CercaPartitaPerNome(string nome)
        {
            // Effettuo la ricerca
            List<ClsPartitaDB> _partiteTrovate = _metodiPartite.CercaPerNome(nome);

            // Mostro il risultato sulla ListView
            CaricaSuListView(_partiteTrovate);
        }
        #endregion

        #region Eventi
        private void FrmHomepage_Load(object sender, EventArgs e)
        {
            // Nascondi la Form di accesso
            this.Owner.Hide();

            // Carica il nome utente
            lblUtente.Text = "Bentornato, " + Program._giocatoreLoggato.Nome;

            // Ottenimento partite ed inserimento su ListView
            AggiornaLvPartite();
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

        private void btCerca_Click(object sender, EventArgs e)
        {
            CercaPartitaPerNome(tbCerca.Text);
        }

        private void tbCerca_Enter(object sender, EventArgs e)
        {
            if (tbCerca.Text == SUGGERIMENTO_TB_RICERCA)
            {
                _suggerimentoTBRimosso = true;
                tbCerca.Text = String.Empty;
            }
        }

        private void tbCerca_TextChanged(object sender, EventArgs e)
        {
            if (!_suggerimentoTBRimosso)
            {
                if (tbCerca.Text == String.Empty)
                    tbCerca.Text = SUGGERIMENTO_TB_RICERCA;
            }
            else
                _suggerimentoTBRimosso = false;
        }

        private void btAggiorna_Click(object sender, EventArgs e)
        {
            // Ottenimento partite ed inserimento su ListView
            AggiornaLvPartite();
        }

        private void btResetRicerca_Click(object sender, EventArgs e)
        {
            // Resetto i risultati di ricerca
            AggiornaLvPartite();

            // Resetto il testo della casella di ricerca
            tbCerca.Text = SUGGERIMENTO_TB_RICERCA;
        }

        private void btCrea_Click(object sender, EventArgs e)
        {
            // Apri la form di creazione della partita
            
        }
        #endregion
    }
}