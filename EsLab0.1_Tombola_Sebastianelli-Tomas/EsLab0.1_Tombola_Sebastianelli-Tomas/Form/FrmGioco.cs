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
    public partial class FrmGioco : Form
    {
        #region Variabili
        int _idPartita;
        ClsCartellaBL _metodiCartella = new ClsCartellaBL(Program._dbManager);
        List<int> _cartelleDaGiocare;
        #endregion

        #region Costruttore
        public FrmGioco(int idPartita)
        {
            InitializeComponent();

            // Memorizzo l'indice della partita
            _idPartita = idPartita;
        }
        #endregion

        #region Eventi
        private void FrmGioco_Load(object sender, EventArgs e)
        {
            // Dichiarazione variabili necessarie
            int _colonne = 0;
            int _righe = 0;

            int _distanzaBordoSinistro = 10;
            int _distanzaBordoAlto = 20;
            int _offsetCartelle = 10;

            // Nascondi la FrmHomepage
            this.Owner.Visible = false;

            // Ottengo le cartelle dal DB
            _metodiCartella.OttieniCartelleDaDB();

            // Cerco le cartelle appartenenti all'utente connesso
            _cartelleDaGiocare = _metodiCartella.CercaCartellaPerPartitaEUtente(_idPartita, Program._giocatoreLoggato.Id);

            // Calcola il numero di righe e colonne
            if(_cartelleDaGiocare.Count <= 0)
            {
                MessageBox.Show("Nessuna cartella acquistata per questa partita, acquistarne per continuare.");
                this.Close();
            }
            else if(_cartelleDaGiocare.Count == 1)
            {
                _colonne = 1;
                _righe = 1;
            }
            else
            {
                _colonne = 2;
                _righe = Convert.ToInt32(Math.Round((Double)_cartelleDaGiocare.Count / 2, 2));
            }
            
            // Mostro le cartelle sulla form
            for(int i = 1; i <= _righe; i++)                // Stampa verticale
            {
                for(int k = 1; k <= _colonne; k++)          // Stampa orizzontale
                {
                    if(i + k <= _cartelleDaGiocare.Count)   // Verifica se le cartelle sono terminate
                    {
                        UcCartella cartella = new UcCartella(Program._cartelle[i + k].Id);
                        cartella.Location = new Point(_distanzaBordoSinistro + (k - 1) * (cartella.Height + _offsetCartelle), _distanzaBordoAlto + (i - 1) * (cartella.Height + _offsetCartelle));
                        this.Controls.Add(cartella);
                    }
                }
            }
        }
        #endregion
    }
}
