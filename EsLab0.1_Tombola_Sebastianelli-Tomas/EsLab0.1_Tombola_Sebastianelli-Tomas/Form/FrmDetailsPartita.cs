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
    public partial class FrmDetailsPartita : Form
    {
        #region Variabili
        ClsPartitaBL _metodiPartita = new ClsPartitaBL(Program._dbManager);
        long _idPartita;
        #endregion

        #region Costruttore
        public FrmDetailsPartita(long idPartita)
        {
            InitializeComponent();

            // Memorizzo l'ID della partita
            _idPartita = idPartita;
        }
        #endregion

        #region Eventi
        private void FrmDetailsPartita_Load(object sender, EventArgs e)
        {
            // Nascondi la homepage
            this.Owner.Hide();

            // Modifica dei controlli in base alla modalità di lavoro
            if (_idPartita == -1)
            {
                this.Text = "Crea nuova partita - Tombola";
                lblTitolo.Text = "Crea nuova partita...";
                btConferma.Text = "Salva";
            }
            else
            {
                // Dichiarazione variabili necessarie
                int _posizionePartitaSuLista;

                // Rendo tutti i controlli grafici ReadOnly
                tbNome.ReadOnly = true;
                nudPrezzo.ReadOnly = true;
                nudValoreAmbo.ReadOnly = true;
                nudValoreTerna.ReadOnly = true;
                nudValoreQuaterna.ReadOnly = true;
                nudValoreCinquina.ReadOnly = true;
                nudValoreTombola.ReadOnly = true;

                // Ottengo la posizione della partita sulla lista
                _posizionePartitaSuLista = _metodiPartita.CercaPartitaDaID(_idPartita);

                // Carico le informazioni della partita sui vari controlli grafici
                tbNome.Text = Program._partite[_posizionePartitaSuLista].Nome;
                nudPrezzo.Value = Program._partite[_posizionePartitaSuLista].Prezzo;
                nudValoreAmbo.Value = Program._partite[_posizionePartitaSuLista].ValoreAmbo;
                nudValoreTerna.Value = Program._partite[_posizionePartitaSuLista].ValoreTerna;
                nudValoreQuaterna.Value = Program._partite[_posizionePartitaSuLista].ValoreQuaterna;
                nudValoreCinquina.Value = Program._partite[_posizionePartitaSuLista].ValoreCinquina;
                nudValoreTombola.Value = Program._partite[_posizionePartitaSuLista].ValoreTombola;
            }
        }

        private void btAnnulla_Click(object sender, EventArgs e)
        {
            // Richiedi conferma per uscire
            DialogResult dr = MessageBox.Show("Sei sicuro di voler uscire?", "Conferma", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
                this.Close();
        }

        private void btConferma_Click(object sender, EventArgs e)
        {
            // Verifico se sono in inserimento o modifica
            if (_idPartita == -1)
            {
                // Verifico che sia stato inserito un nome per la partita da creare
                if (!String.IsNullOrEmpty(tbNome.Text.Trim()))
                {
                    // Effettuo l'inserimento sul DB
                    try
                    {
                        long _idPartitaGenerato = _metodiPartita.CreaPartita(tbNome.Text, nudPrezzo.Value, nudValoreAmbo.Value, nudValoreTerna.Value, nudValoreQuaterna.Value, nudValoreCinquina.Value, nudValoreTombola.Value);

                        if(_idPartitaGenerato != -1)
                        {
                            MessageBox.Show("Inserimento della partita effettuato con successo", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Nascondi la Form details della partita
                            this.Owner.Hide();

                            // Apri il banco della partita
                            FrmBanco frmBanco = new FrmBanco(_idPartitaGenerato);
                            frmBanco.Owner = this;
                            frmBanco.ShowDialog();
                        }
                        else
                            MessageBox.Show("Si è verificato un errore nel tentativo di inserire la partita.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Errore: Non è stato inserito un nome per la partita, inserirlo per continuare.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Apri la Form di gioco
                FrmGioco frmGioco = new FrmGioco(_idPartita);
                frmGioco.Owner = this;
                frmGioco.ShowDialog();
            }
        }

        private void FrmDetailsPartita_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            Scopo: Aprire la FrmHomepage se si chiude la FrmDetails
            Errore ottenuto: System.StackOverflowException

            if(this.Owner != null)
                this.Owner.Show();
            */

            this.Close();
        }
        #endregion
    }
}
