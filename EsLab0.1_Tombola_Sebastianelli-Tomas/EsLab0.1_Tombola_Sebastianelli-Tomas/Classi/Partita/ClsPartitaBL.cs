using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    class ClsPartitaBL
    {
        #region Variabili
        DBManager _dbManager;
        string _connectionString;
        #endregion

        #region Costruttore
        public ClsPartitaBL(DBManager dBManager)
        {
            _dbManager = dBManager;
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Ottiene tutte le partite dal DB
        /// </summary>
        public void OttieniPartiteDaDB()
        {
            // Dichiarazione variabili necessarie
            System.Data.DataTable _partite;
            string _errore = String.Empty;

            // Elimino tutte le partite presenti nella lista
            Program._partite.Clear();

            // Query al DB
            _partite = _dbManager.GetDataTableByQuery("SELECT * FROM partite", null, ref _errore);

            // Creo i vari oggetti di classe partita se non si sono verificati errori
            if (String.IsNullOrEmpty(_errore))
            {
                for(int i = 0; i < _partite.Rows.Count; i++)
                {
                    ClsPartitaDB _partita = new ClsPartitaDB();
                    _partita.Id = Convert.ToInt32(_partite.Rows[i]["id"]);      // TODO: Usare long
                    _partita.Prezzo = (Decimal)_partite.Rows[i]["prezzo"];
                    _partita.ValoreAmbo = (Decimal)_partite.Rows[i]["valore_ambo"];
                    _partita.ValoreTerna = (Decimal)_partite.Rows[i]["valore_terna"];
                    _partita.ValoreQuaterna = (Decimal)_partite.Rows[i]["valore_quaterna"];
                    _partita.ValoreCinquina = (Decimal)_partite.Rows[i]["valore_cinquina"];
                    _partita.ValoreTombola = (Decimal)_partite.Rows[i]["valore_tombola"];

                    Program._partite.Add(_partita);
                }
            }
            else
                throw new Exception(_errore);
        }

        /// <summary>
        /// Ritorna la posizione di una partita nella lista di partite
        /// </summary>
        /// <param name="id">ID della partita da cercare</param>
        /// <returns></returns>
        public int CercaPartitaDaID(long id)
        {
            // Aggiorno la lista delle partite in RAM
            OttieniPartiteDaDB();

            // Ricerca della posizione della partita nella lista di partite
            int i = 0;

            do
            {
                i++;
            } while (Program._partite[i].Id != id && i < Program._partite.Count);

            // Ritorno l'indice della partita
            return i;
        }

        /// <summary>
        /// Ottiene le partite dal DB, effettua una ricerca per nome e restituisce gli indici delle partite trovate
        /// </summary>
        /// <param name="nome">Nome della partita da cercare</param>
        /// <returns></returns>
        public List<int> CercaPerNome(string nome)
        {
            // Dichiarazione variabili necessarie
            List<int> _idPartiteTrovate = new List<int>(0);
            string _errore = String.Empty;

            // Aggiorno le partite in RAM
            OttieniPartiteDaDB();

            // Effettuo la query al DB
            MySqlConnector.MySqlParameter[] _parametri =
            {
                new MySqlConnector.MySqlParameter("NOME", nome)
            };

            System.Data.DataTable _risultato = _dbManager.GetDataTableByQuery("SELECT ID FROM partite WHERE nome LIKE '%@NOME%'", _parametri, ref _errore);

            // Inserisco gli indici trovati in una lista
            for(int i = 0; i < _risultato.Rows.Count; i++)
                _idPartiteTrovate.Add(Convert.ToInt32(_risultato.Rows[i]["id"]));

            // Ritorno i risultati di ricerca
            return _idPartiteTrovate;
        }
        #endregion
    }
}
