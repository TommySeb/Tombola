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
            int[] _numeriCartella;
            int _indiceNumeroDaPosizionare = 0;
            int x = 20;
            int y = 56;
            int offset = 10;

            // Ottengo i numeri della cartella come array
            // TODO: Implementare controllo eccezione --> Errore _numeriCartella risulta non dichiarata e non so come annullare creazione cartella
            _numeriCartella = _metodiCartella.OttieniNumeriCartella(_idCartella);
            
            // Genera la casella con i relativi numeri
            // TODO: Rivedere implementazione
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    // Dichiarazione casella
                    UcCasellaNumero ucCasellaNumero;

                    // Verifico se inserire dentro la casella un numero o lasciarla vuota
                    if(_numeriCartella[_indiceNumeroDaPosizionare] > k * 10 && _numeriCartella[_indiceNumeroDaPosizionare] < k * 10 + 9)
                    {
                        ucCasellaNumero = new UcCasellaNumero(_numeriCartella[_indiceNumeroDaPosizionare]);
                        _indiceNumeroDaPosizionare++;
                    }
                    else
                        ucCasellaNumero = new UcCasellaNumero(0);

                    // Indico la posizione della casella e la inserisco nella cartella
                    ucCasellaNumero.Location = new Point(x, y);
                    x += ucCasellaNumero.Size.Width + offset;
                    this.Controls.Add(ucCasellaNumero);
                }

                x = 20;
                y += /*UcCasellaNumero.Size.Height*/ 60 + offset;
            }
        }
        #endregion
    }
}
