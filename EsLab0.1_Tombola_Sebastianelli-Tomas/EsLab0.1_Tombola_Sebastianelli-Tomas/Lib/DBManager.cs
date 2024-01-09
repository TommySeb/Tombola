using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySqlConnector;
using System.Data;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    public class DBManager
    {
        #region ATTRIBUTI
        private static MySqlConnection conn= null;
        private static string _stringaConnessione = null;
        #endregion

        #region PROPRIETA'
        // Per rendere la classe più generica si potrebbe creare un costruttore che riceve la stringa di connessione
        // soprattutto se questa classe non fa parte dello stesso progetto
        public static string StringaConnessione 
        {
            get
            {
                if (String.IsNullOrWhiteSpace(_stringaConnessione))
                    return ConfigurationManager.ConnectionStrings[Program._nomeConnectionString].ConnectionString;
                else return _stringaConnessione;
            }
        }

        public static  MySqlConnection Connessione
        {
            get
            {
                // if (conn == null)
                conn = new MySqlConnection(StringaConnessione);
                return conn;
            }
        }
        #endregion

        #region COSTRUTTORI
        public DBManager() {
        }
        public DBManager(string database, string server, string username, string password, string port)
        {
            if (String.IsNullOrWhiteSpace(database) ||
                String.IsNullOrWhiteSpace(server) ||
                String.IsNullOrWhiteSpace(username) ||
                String.IsNullOrWhiteSpace(password) ||
                String.IsNullOrWhiteSpace(port))
                throw new ArgumentException("Argomento mancante");

            _stringaConnessione = $"server={server};port={port};user={username};password={password};database={database};";

            // Barbatrucco
            conn = new MySqlConnection("server=localhost;user=root;database=tombola;port=3306;password=root");
        }

        #endregion

        #region METODI
        /// <summary>
        /// SELECT: il metodo estrae i dati e restituisce un DataTable
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parametri"></param>
        /// <param name="errore"></param>
        /// <returns></returns>
        public DataTable GetDataTableByQuery(string query, MySqlParameter[] parametri, ref string errore)
        {
            DataTable dt = null;
            
            try
            {
                //Apertura connessione
                Connessione.Open();

                //Creo l'oggetto dataadapter
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

                if (parametri != null)
                    da.SelectCommand.Parameters.AddRange(parametri);
                
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
            finally
            {
                //Chiusura connessione
                if (Connessione.State == ConnectionState.Open)
                    Connessione.Close();
            }

            return dt;

        }

        /// <summary>
        /// SELECT: il metodo estrae i dati e restituisce un DataSet
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parametri"></param>
        /// <param name="tabella"></param>
        /// <param name="errore"></param>
        /// <returns></returns>
        public DataSet GetDataSetByQuery(string query, MySqlParameter[] parametri, string tabella, ref string errore)
        {
            DataSet ds = null;
            try
            {
                //Apertura connessione
                Connessione.Open();

                //Creo l'oggetto dataadapter
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

                if (parametri!= null) 
                    da.SelectCommand.Parameters.AddRange(parametri);
                
                ds = new DataSet();
                da.Fill(ds, tabella);
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
            finally
            {
                //Chiusura connessione
                if (Connessione.State == ConnectionState.Open)
                    Connessione.Close();
            }

            return ds;

        }

        /// <summary>
        /// Il metodo esegue un MySQLCommand.ExecuteScalar
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parametri"></param>
        /// <param name="errore"></param>
        /// <returns></returns>
        public object GetScalarByQuery(string query, MySqlParameter[] parametri, ref string errore)
        {
            object risultato = null;
            try
            {
                //Apertura connessione
                Connessione.Open();

                //Creo l'oggetto command
                MySqlCommand cmd = new MySqlCommand(query, Connessione);
                
                if(parametri!=null)
                    cmd.Parameters.AddRange(parametri);

                //Eseguo il comando
                risultato = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
            finally
            {
                //Chiusura connessione
                if (Connessione.State == ConnectionState.Open)
                    Connessione.Close();
            }

            return risultato;

        }

        /// <summary>
        /// Il metodo restituisce il numero di righe processate o l'esito dell'operazione richiesta. Si ricorda che 
        /// INSERT, UPDATE, DELETE risultato = numero delle righe
        /// CREATE, DROP, ALTER se operazione eseguita risultato = 1
        /// Il metodo esegue un MySQLCommand.ExecuteNonQuery
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parametri"></param>
        /// <param name="errore"></param>
        /// <returns></returns>
        public int GetAffectedRows(string query, MySqlParameter[] parametri, ref string errore)
        {
            int righeInserite=0;
            try
            {
                //Apertura connessione
                Connessione.Open();

                //Creo l'oggetto command
                MySqlCommand cmd = new MySqlCommand(query, Connessione);

                if (parametri != null)
                    cmd.Parameters.AddRange(parametri);

                //Eseguo il comando
                righeInserite = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
            finally
            {
                //Chiusura connessione
                if (Connessione.State == ConnectionState.Open)
                    Connessione.Close();
            }

            return righeInserite;

        }
        
        /// <summary>
        /// INSERT - UPDATE - DELETE parametrici che restituiscono numero di righe interessate
        /// </summary>
        /// <param name="query">INSERT - UPDATE - DELETE</param>
        /// <param name="parametri"></param>
        /// <param name="lastId">-1 in caso di errore, 0 negli altri casi</param>
        /// <param name="errore">Messaggio di errore</param>
        /// <returns>righeInteressate</returns>
        public int GetAffectedRowsByNonQuery(string query, MySqlParameter[] parametri, ref long lastId, ref string errore)
        {
            int righeInteressate = 0;
            errore = string.Empty;
            lastId = -1;

            try
            {
                // Apertura connessione
                Connessione.Open();

                string tmp = Connessione.State.ToString();

                // Creo l'oggetto command
                MySqlCommand cmd = new MySqlCommand(query, Connessione);

                if (parametri != null)
                    cmd.Parameters.AddRange(parametri);

                // Eseguo il comando
                righeInteressate = cmd.ExecuteNonQuery();

                lastId = cmd.LastInsertedId; // Restituisce zero su UPDATE e DELETE
            }
            catch(Exception ex)
            {
                errore = ex.Message;
            }
            finally
            {
                // Chiusura connessione
                if (Connessione.State == ConnectionState.Open)
                    Connessione.Close();
            }

            return righeInteressate;
        }
        #endregion

    }
}
