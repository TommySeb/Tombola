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
        int _idPartita;
        #endregion

        #region Costruttore
        public FrmDetailsPartita(int idPartita)
        {
            InitializeComponent();

            // Memorizzo l'ID della partita
            _idPartita = idPartita;
        }
        #endregion

        #region Eventi
        private void FrmDetailsPartita_Load(object sender, EventArgs e)
        {
            // Modifica dei controlli in base alla modalità di lavoro
            if (_idPartita == -1)
            {
                this.Text = "Crea nuova partita - Tombola";
                lblTitolo.Text = "Crea nuova partita...";
                btConferma.Text = "Salva";
            }
            else
            {
                tbNome.ReadOnly = true;
                nudPrezzo.ReadOnly = true;
                nudValoreAmbo.ReadOnly = true;
                nudValoreTerna.ReadOnly = true;
                nudValoreQuaterna.ReadOnly = true;
                nudValoreCinquina.ReadOnly = true;
                nudValoreTombola.ReadOnly = true;
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
                        _metodiPartita.CreaPartita(tbNome.Text, nudPrezzo.Value, nudValoreAmbo.Value, nudValoreTerna.Value, nudValoreQuaterna.Value, nudValoreCinquina.Value, nudValoreTombola.Value);

                        MessageBox.Show("Inserimento della partita effettuato con successo", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // TODO: Apri il banco della partita
                        // Come posso far sì che, una volta aver inserito un record, mi viene ritornato indietro l'ID del record appena inserito?
                        this.Close();
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
                // TODO: Istruzioni per partecipare alla partita
            }
        }
        #endregion
    }
}
