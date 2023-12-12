using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    public partial class UcCartella : UserControl
    {
        #region Variabili
        long _idCartella;
        ClsCartellaBL _metodiCartella = new ClsCartellaBL(Program._dbManager);
        ClsPartitaBL _metodiPartita = new ClsPartitaBL(Program._dbManager);
        #endregion

        #region Costruttore
        public UcCartella(long idCartella)
        {
            InitializeComponent();

            // Memorizzo l'ID della cartella da visualizzare
            _idCartella = idCartella;
        }
        #endregion

        #region Eventi
        private void UcCartella_Load(object sender, EventArgs e)
        {
            // Dichiarazione variabili necessarie
            int _indiceCartella;
            int _indicePartita;
            int[] _numeriCartella;
            int _indiceNumeroDaPosizionare = 0;
            int x = 20;
            int y = 56;
            int _latoCasella = 60;
            int _offset = 10;

            // Ricerca degli indici della cartella e della partita
            _indiceCartella = _metodiCartella.CercaCartellaPerID(_idCartella);
            _indicePartita = _metodiPartita.CercaPartitaDaID(Program._cartelle[_indiceCartella].IdPartita);

            // Procedo solo se questi esistono
            if(_indiceCartella != -1 && _indicePartita != -1)
            {
                // Caricamento nome partita e ID cartella
                lblNomePartita.Text += " " + Program._partite[_indicePartita].Nome;
                lblID.Text += " " + _idCartella;

                // Ottengo i numeri della cartella come array
                _numeriCartella = _metodiCartella.OttieniNumeriCartella(_idCartella);

                /*
                    Soluzione 1:
                    1- Crea una matrice che rappresenta la struttura della cartella
                    2- Inserisco prima i numeri di un range che compaiono più volte
                    3- A mano a mano diminuisco
                    4- Inserisco i numeri della matrice nelle varie caselle, usando come indici i e k
                */

                // Genera le caselle dei numeri
                for (int i = 0; i < 10; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        // Dichiarazione casella
                        UcCasellaNumero ucCasellaNumero;

                        // Verifico se inserire dentro la casella un numero o lasciarla vuota
                        if (_indiceNumeroDaPosizionare < 15 && _numeriCartella[_indiceNumeroDaPosizionare] >= i * 10 && _numeriCartella[_indiceNumeroDaPosizionare] <= i * 10 + 9)
                        {
                            ucCasellaNumero = new UcCasellaNumero(_numeriCartella[_indiceNumeroDaPosizionare]);
                            _indiceNumeroDaPosizionare++;
                        }
                        else
                            ucCasellaNumero = new UcCasellaNumero(0);

                        // Indico la posizione della casella e la inserisco nella cartella
                        ucCasellaNumero.Location = new Point(x, y);

                        y += _latoCasella + _offset;

                        this.Controls.Add(ucCasellaNumero);
                    }

                    x += _latoCasella + _offset;
                    y = 56;
                }
            }
            else
            {
                // Come posso annullare il caricamento della cartella?
            }
            
        }
        #endregion
    }
}
