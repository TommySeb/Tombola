using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    class ClsEstrazioneBL
    {
        #region Variabili
        DBManager _dbManager;
        #endregion

        #region Costruttore
        public ClsEstrazioneBL(DBManager dbManager)
        {
            // Memorizzo il DBManager
            _dbManager = dbManager;
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Ottiene tutte le estrazioni effettuate per una partita dal DB
        /// </summary>
        /// <param name="_idPartita">ID della partita</param>
        public void OttieniEstrazioniDaDB(long _idPartita)
        {
            // Dichiarazione variabili necessarie
            System.Data.DataTable _estrazioni;
            string _errore = String.Empty;

            // Elimino tutte le estrazioni presenti nella lista
            Program._estrazioni.Clear();

            // Query al DB
            MySqlConnector.MySqlParameter[] _parametriQuery =
            {
                new MySqlConnector.MySqlParameter("@ID_PARTITA", _idPartita)
            };

            if (Program._nomeConnectionString == "serverLocale")
                _estrazioni = _dbManager.GetDataTableByQuery("SELECT * FROM estrazioni", _parametriQuery, ref _errore);
            else
                _estrazioni = _dbManager.GetDataTableByQuery("SELECT * FROM st10453_estrazioni", _parametriQuery, ref _errore);

            // Creo i vari oggetti di classe partita e li inserisco nella lista se non si sono verificati errori
            if (String.IsNullOrEmpty(_errore))
            {
                for (int i = 0; i < _estrazioni.Rows.Count; i++)
                {
                    ClsEstrazioneDB _estrazione = new ClsEstrazioneDB();
                    _estrazione.Id = Convert.ToInt64(_estrazioni.Rows[i]["id"]);
                    _estrazione.IdPartita = Convert.ToInt64(_estrazioni.Rows[i]["id_partita"]);
                    _estrazione.NumeroEstratto = Convert.ToInt32(_estrazioni.Rows[i]["numero_estratto"]);

                    Program._estrazioni.Add(_estrazione);
                }
            }
            else
                throw new Exception(_errore);
        }

        /// <summary>
        /// Estrae un numero in una partita e registra l'estrazione sul DB
        /// </summary>
        /// <param name="idPartita">ID della partita</param>
        /// <returns>Numero estratto</returns>
        public int EstraiNumero(long idPartita)
        {
            // Dichiarazione variabili necessarie
            Random _random = new Random(); ;
            List<int> _numeriEstratti;
            int _numeroEstratto;

            // Ottieni i numeri estratti per la partita specificata
            _numeriEstratti = OttieniNumeriEstratti(idPartita);

            // Estrai un numero tra 1 e 90 che non sia stato già estratto
            do
            {
                _numeroEstratto = _random.Next(1, 90);
            } while (_numeriEstratti.Contains(_numeroEstratto));

            // Registra l'estrazione sul DB
            RegistraEstrazioneSuDB(idPartita, _numeroEstratto);

            // Aggiorna le estrazioni effettuate
            OttieniEstrazioniDaDB(idPartita);

            // Ritorna il numero estratto
            return _numeroEstratto;
        }

        /// <summary>
        /// Registra un estrazione sul DB
        /// </summary>
        /// <param name="idPartita">ID della partita</param>
        /// <param name="numeroEstratto">Numero estratto</param>
        private void RegistraEstrazioneSuDB(long idPartita, int numeroEstratto)
        {
            // Dichiarazione variabili necessarie
            string _errore = String.Empty;

            // Registro l'estrazione sul DB
            MySqlConnector.MySqlParameter[] _parametriQuery =
            {
                new MySqlConnector.MySqlParameter("@ID_PARTITA", idPartita),
                new MySqlConnector.MySqlParameter("@NUMERO_ESTRATTO", numeroEstratto)
            };

            if (Program._nomeConnectionString == "serverLocale")
                _dbManager.GetAffectedRows("INSERT INTO estrazioni (id_partita, numero_estratto) VALUES (@ID_PARTITA, @NUMERO_ESTRATTO)", _parametriQuery, ref _errore);
            else
                _dbManager.GetAffectedRows("INSERT INTO st10453_estrazioni (id_partita, numero_estratto) VALUES (@ID_PARTITA, @NUMERO_ESTRATTO)", _parametriQuery, ref _errore);

            // Aggiornamento lista delle cartelle
            if (String.IsNullOrEmpty(_errore))
                OttieniEstrazioniDaDB(idPartita);
            else
                throw new Exception("Errore nell'inserimento dell'estrazione sul DB:\r\n" + _errore);
        }

        /// <summary>
        /// Ottiene i numeri estratti durante una partita
        /// </summary>
        /// <param name="_idPartita">ID della partita</param>
        /// <returns>Lista dei numeri estratti durante la partita specificata</returns>
        public List<int> OttieniNumeriEstratti(long _idPartita)
        {
            // Dichiarazione variabili necessarie
            List<int> _numeriEstratti = new List<int>(0);

            // Ottenimento numeri estratti
            foreach(ClsEstrazioneDB estrazione in Program._estrazioni)
            {
                if (estrazione.IdPartita == _idPartita)
                    _numeriEstratti.Add(estrazione.NumeroEstratto);
            }

            // Ritorna i numeri estratti
            return _numeriEstratti;
        }
        #endregion
    }
}
