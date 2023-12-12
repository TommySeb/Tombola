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
    public partial class FrmBanco : Form
    {
        #region Variabili
        long _idPartita;
        ClsPartitaBL _metodiPartita = new ClsPartitaBL(Program._dbManager);
        ClsEstrazioneBL _metodiEstrazione = new ClsEstrazioneBL(Program._dbManager);
        #endregion

        #region Costruttore
        public FrmBanco(long idPartita)
        {
            InitializeComponent();

            // Memorizzo l'ID della partita
            _idPartita = idPartita;
        }
        #endregion

        #region Eventi
        private void FrmBanco_Load(object sender, EventArgs e)
        {
            // Dichiarazione variabili necessarie
            int _indicePartitaSuLista;
            int x = 17;
            int y = 65;
            int _latoCasella = 60;
            int offset = 10;

            // Cerco la partita nella lista di partite
            _indicePartitaSuLista = _metodiPartita.CercaPartitaDaID(_idPartita);

            // Se esiste procedi
            if(_indicePartitaSuLista != -1)
            {
                // Caricamento nome della partita
                this.Text = Program._partite[_indicePartitaSuLista].Nome + " (Banco) - Tombola";
                lblNomePartita.Text = Program._partite[_indicePartitaSuLista].Nome;

                // Crea le caselle con i 90 numeri della tombola
                for (int i = 0; i < 9; i++)      // Creazione caselle in verticale
                {
                    for (int k = 1; k <= 9; k++) // Creazione caselle in orizzontale
                    {
                        UcCasellaNumero ucCasellaNumero = new UcCasellaNumero(Convert.ToInt32(String.Concat(i, k)));
                        ucCasellaNumero.Location = new Point(x, y);
                        x += _latoCasella + offset;
                        this.Controls.Add(ucCasellaNumero);
                    }

                    x = 17;
                    y += _latoCasella + offset;
                }
            }
            else
            {
                MessageBox.Show("Errore: La partita specificata non esiste.");
                this.Close();
            }
        }

        private void btEstrai_Click(object sender, EventArgs e)
        {
            // Dichiarazione variabili necessarie
            int _numeroEstratto;

            // Effettua un'estrazione
            _numeroEstratto = _metodiEstrazione.EstraiNumero(_idPartita);

            // Mostra il numero estratto
            MessageBox.Show(_numeroEstratto.ToString(), "Numero estratto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmBanco_FormClosing(object sender, FormClosingEventArgs e)
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
