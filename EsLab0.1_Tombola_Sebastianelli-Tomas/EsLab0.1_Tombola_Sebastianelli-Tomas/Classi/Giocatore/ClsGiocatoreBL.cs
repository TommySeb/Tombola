using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySqlConnector;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    class ClsGiocatoreBL
    {
        #region Variabili
        DBManager _dbManager;
        string _connectionString;
        #endregion

        #region Costruttore
        public ClsGiocatoreBL(DBManager dBManager)
        {
            _dbManager = dBManager;
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Verifica che un giocatore esista dal DB a partire da username e password
        /// </summary>
        /// <param name="email">E-mail del giocatore</param>
        /// <param name="password">Password del giocatore</param>
        /// <returns></returns>
        public bool EsisteGiocatore(string email, string password)
        {
            // Ottengo gli utenti con le credenziali specificate dal DB
            string _query = "SELECT * FROM giocatori WHERE email = @EMAIL and password = @PASSWORD";

            MySqlParameter[] _parametriLogin = {
                new MySqlParameter("@EMAIL", email),
                new MySqlParameter("@PASSWORD", password),
            };

            string _errore = String.Empty;

            System.Data.DataTable _utenteOttenuto = _dbManager.GetDataTableByQuery(_query, _parametriLogin, ref _errore);

            // Continuo se non si sono verificati errori di connessione
            if (String.IsNullOrEmpty(_errore))
            {
                // Verifico di aver ottenuto un utente e ritorno il risultato dell'accesso
                if (_utenteOttenuto.Rows.Count == 1)
                {
                    // In caso positivo lo memorizzo
                    ClsGiocatoreDB _giocatore = new ClsGiocatoreDB();
                    _giocatore.Id = Convert.ToInt64(_utenteOttenuto.Rows[0]["id"]);
                    _giocatore.Nome = _utenteOttenuto.Rows[0]["nome"].ToString();
                    _giocatore.Cognome = _utenteOttenuto.Rows[0]["cognome"].ToString();
                    _giocatore.Nickname = _utenteOttenuto.Rows[0]["nickname"].ToString();
                    _giocatore.Email = _utenteOttenuto.Rows[0]["email"].ToString();
                    _giocatore.Password = _utenteOttenuto.Rows[0]["password"].ToString();
                    _giocatore.DataDiNascita = Convert.ToDateTime(_utenteOttenuto.Rows[0]["data_nascita"]);
                    _giocatore.Genere = Convert.ToChar(_utenteOttenuto.Rows[0]["genere"]);
                    _giocatore.Portafoglio = Convert.ToDecimal(_utenteOttenuto.Rows[0]["portafoglio"]);

                    Program._giocatoreLoggato = _giocatore;

                    return true;
                }
                else
                    return false;
            }
            else
                throw new Exception(_errore);
        }
        
        /// <summary>
        /// Registra un utente
        /// </summary>
        /// <param name="giocatore">Giocatore da registrare</param>
        /// <param name="errore">Variabile nella quale memorizzare eventuali errori</param>
        /// <returns>Esito della registrazione</returns>
        public int Registra(ClsGiocatoreDB giocatore, ref string errore)
        {
            // Esito dell'operazione
            int esito = 0;

            try
            {
                // Effettuo la query di inserimento sul DB
                // TODO: Implementare crittografia
                string sql = "INSERT INTO giocatori (nome, cognome, nickname, data_nascita, genere, email, password, portafoglio) VALUES (@nome, @cognome, @nickname, @data_nascita, @genere, @email, @password, 0)";

                MySqlParameter[] parametri =
                {
                    new MySqlParameter("@nome", giocatore.Nome),
                    new MySqlParameter("@cognome", giocatore.Cognome),
                    new MySqlParameter("@nickname", giocatore.Nickname),
                    new MySqlParameter("@data_nascita", giocatore.DataDiNascita),
                    new MySqlParameter("@genere", giocatore.Genere),
                    new MySqlParameter("@email", giocatore.Email),
                    new MySqlParameter("@password", giocatore.Password)
                };

                esito = _dbManager.GetAffectedRows(sql, parametri, ref errore);
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }

            return esito;
        }
        #endregion
    }
}
