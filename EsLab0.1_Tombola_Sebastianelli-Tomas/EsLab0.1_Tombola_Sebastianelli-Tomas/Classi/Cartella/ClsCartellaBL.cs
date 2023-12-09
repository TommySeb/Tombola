using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    class ClsCartellaBL
    {
        #region Variabili
        DBManager _dbManager;
        #endregion

        #region Costruttore
        public ClsCartellaBL(DBManager dbManager)
        {
            _dbManager = dbManager;
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Ottiene tutte le cartelle dal DB
        /// </summary>
        public void OttieniCartelleDaDB()
        {
            // Dichiarazione variabili necessarie
            System.Data.DataTable _cartelleOttenute;
            string _errore = String.Empty;

            // Elimino tutte le cartelle presenti nella lista
            Program._cartelle.Clear();

            // Query al DB
            _cartelleOttenute = _dbManager.GetDataTableByQuery("SELECT * FROM cartelle", null, ref _errore);

            // Creo i vari oggetti di classe cartella e li inserisco nella lista se non si sono verificati errori
            if (String.IsNullOrEmpty(_errore))
            {
                for (int i = 0; i < _cartelleOttenute.Rows.Count; i++)
                {
                    ClsCartellaDB _cartella = new ClsCartellaDB();
                    _cartella.Id = Convert.ToInt64(_cartelleOttenute.Rows[i]["id"]);
                    _cartella.IdGiocatore = Convert.ToInt64(_cartelleOttenute.Rows[i]["id_giocatore"]);
                    _cartella.IdPartita = Convert.ToInt64(_cartelleOttenute.Rows[i]["id_partita"]);

                    _cartella.PrimoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["primo_numero"]);
                    _cartella.SecondoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["secondo_numero"]);
                    _cartella.TerzoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["terzo_numero"]);
                    _cartella.QuartoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["quarto_numero"]);
                    _cartella.QuintoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["quinto_numero"]);
                    _cartella.SestoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["sesto_numero"]);
                    _cartella.SettimoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["settimo_numero"]);
                    _cartella.OttavoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["ottavo_numero"]);
                    _cartella.NonoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["nono_numero"]);
                    _cartella.DecimoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["decimo_numero"]);
                    _cartella.UndicesimoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["undicesimo_numero"]);
                    _cartella.DodicesimoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["dodicesimo_numero"]);
                    _cartella.TredicesimoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["tredicesimo_numero"]);
                    _cartella.QuattordicesimoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["quattordicesimo_numero"]);
                    _cartella.QuindicesimoNumero = Convert.ToInt32(_cartelleOttenute.Rows[i]["quindicesimo_numero"]);

                    _cartella.PrimoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.SecondoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.TerzoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.QuartoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.QuintoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.SestoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.SettimoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.OttavoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.NonoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.DecimoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.UndicesimoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.DodicesimoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.TredicesimoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.QuattordicesimoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);
                    _cartella.QuindicesimoNumeroEstratto = Convert.ToBoolean(_cartelleOttenute.Rows[i]["primo_numero_estratto"]);

                    Program._cartelle.Add(_cartella);
                }
            }
            else
                throw new Exception(_errore);
        }

        /// <summary>
        /// Cerca una cartella per ID e ritorna il suo indice nella lista (O -1 se non trovata)
        /// </summary>
        /// <param name="idDaCercare"></param>
        /// <returns></returns>
        public int CercaCartellaPerID(long idDaCercare)
        {
            // Dichiarazione variabili necessarie
            int _indiceCartella = 0;

            // Ricerca della posizione della cartella nella lista di cartelle
            while(_indiceCartella < Program._cartelle.Count && Program._cartelle[_indiceCartella].Id != idDaCercare)
                _indiceCartella++;

            // Ritorno l'indice della cartella (O -1 se non ho trovato nulla)
            if (_indiceCartella != Program._cartelle.Count)
                return _indiceCartella;
            else
                return -1;
        }

        /// <summary>
        /// Effettua una ricerca delle cartelle appartenenti ad un giocatore per una partita
        /// </summary>
        /// <param name="idPartita">ID della partita</param>
        /// <param name="idGiocatore">ID del giocatore</param>
        /// <returns></returns>
        public List<int> CercaCartellaPerPartitaEUtente(long idPartita, long idGiocatore)
        {
            // Dichiarazione variabili
            List<int> _indiceCartelleTrovate = new List<int>(0);

            // Effettuo la ricerca
            for(int i = 0; i < Program._cartelle.Count; i++)
            {
                if (Program._cartelle[i].IdPartita == idPartita && Program._cartelle[i].IdGiocatore == idGiocatore)
                    _indiceCartelleTrovate.Add(i);
            }

            // Restituisci i risultati trovati
            return _indiceCartelleTrovate;
        }

        /// <summary>
        /// Inserisce i numeri di una cartella in un array
        /// </summary>
        /// <param name="id">ID della cartella</param>
        /// <returns>Array con i numeri della cartella specificata</returns>
        public int[] OttieniNumeriCartella(long id)
        {
            // Cerco la posizione della cartella sulla lista
            int _indiceCartellaSuLista = CercaCartellaPerID(id);

            // Verifico se la cartella esiste
            if (_indiceCartellaSuLista != -1)
            {
                // Inserisco i numeri della cartella su un array
                int[] _numeriCartella =
                {
                    Program._cartelle[_indiceCartellaSuLista].PrimoNumero,
                    Program._cartelle[_indiceCartellaSuLista].SecondoNumero,
                    Program._cartelle[_indiceCartellaSuLista].TerzoNumero,
                    Program._cartelle[_indiceCartellaSuLista].QuartoNumero,
                    Program._cartelle[_indiceCartellaSuLista].QuintoNumero,
                    Program._cartelle[_indiceCartellaSuLista].SestoNumero,
                    Program._cartelle[_indiceCartellaSuLista].SettimoNumero,
                    Program._cartelle[_indiceCartellaSuLista].OttavoNumero,
                    Program._cartelle[_indiceCartellaSuLista].NonoNumero,
                    Program._cartelle[_indiceCartellaSuLista].DecimoNumero,
                    Program._cartelle[_indiceCartellaSuLista].UndicesimoNumero,
                    Program._cartelle[_indiceCartellaSuLista].DodicesimoNumero,
                    Program._cartelle[_indiceCartellaSuLista].TredicesimoNumero,
                    Program._cartelle[_indiceCartellaSuLista].QuattordicesimoNumero,
                    Program._cartelle[_indiceCartellaSuLista].QuindicesimoNumero
                };

                // Ritorno l'array di numeri
                return _numeriCartella;
            }
            else
                throw new Exception("La cartella con id " + id + " non esiste.");
        }

        /// <summary>
        /// Genera una cartella e i suoi 15 numeri, per poi inserirla sul DB
        /// </summary>
        /// <param name="idGiocatore">ID del giocatore che ha richiesto la cartella</param>
        /// <param name="idPartita">ID della partita della cartella</param>
        public void GeneraCartella(int idGiocatore, int idPartita)
        {
            // Dichiarazione variabili necessarie
            List<int> _numeriGenerati = new List<int>();
            Random _random = new Random();
            string _erroreDB = String.Empty;

            // Generazione di 15 numeri casuali
            while (_numeriGenerati.Count < 15)
            {
                // Dichiarazione variabili necessarie
                int _numeroGenerato;
                int _primaCifraNumeroGenerato = 0;
                int _tmp = 0;

                // Genero un numero a caso compreso tra 1 e 90
                _numeroGenerato = _random.Next(1, 90);

                // Memorizzo la prima cifra del numero
                if (_numeroGenerato.ToString().Length == 1)
                    _primaCifraNumeroGenerato = 0;
                else if(_numeroGenerato.ToString().Length == 2)
                    _primaCifraNumeroGenerato = Convert.ToInt32(_numeroGenerato.ToString().Substring(0, 1));

                // Verifico quanti numeri iniziano con quella cifra
                foreach (int _numero in _numeriGenerati)
                    if (_numero >= _primaCifraNumeroGenerato * 10 && _numero <= _primaCifraNumeroGenerato * 10 + 9)
                        _tmp++;

                // Se i numeri che iniziano con quella cifra sono minori di tre e il numero non è stato già generato posso effettuare l'inserimento
                if (_tmp < 3 && !_numeriGenerati.Contains(_numeroGenerato))
                    _numeriGenerati.Add(_numeroGenerato);
            }

            // Ordinamento dei numeri generati in ordine crescente
            _numeriGenerati.Sort();

            // Creo la cartella sul DB
            MySqlConnector.MySqlParameter[] _parametriQuery =
            {
                new MySqlConnector.MySqlParameter("@ID_GIOCATORE", idGiocatore),
                new MySqlConnector.MySqlParameter("@ID_PARTITA", idPartita),
                new MySqlConnector.MySqlParameter("@PRIMO_NUMERO", _numeriGenerati[0]),
                new MySqlConnector.MySqlParameter("@SECONDO_NUMERO", _numeriGenerati[1]),
                new MySqlConnector.MySqlParameter("@TERZO_NUMERO", _numeriGenerati[2]),
                new MySqlConnector.MySqlParameter("@QUARTO_NUMERO", _numeriGenerati[3]),
                new MySqlConnector.MySqlParameter("@QUINTO_NUMERO", _numeriGenerati[4]),
                new MySqlConnector.MySqlParameter("@SESTO_NUMERO", _numeriGenerati[5]),
                new MySqlConnector.MySqlParameter("@SETTIMO_NUMERO", _numeriGenerati[6]),
                new MySqlConnector.MySqlParameter("@OTTAVO_NUMERO", _numeriGenerati[7]),
                new MySqlConnector.MySqlParameter("@NONO_NUMERO", _numeriGenerati[8]),
                new MySqlConnector.MySqlParameter("@DECIMO_NUMERO", _numeriGenerati[9]),
                new MySqlConnector.MySqlParameter("@UNDICESIMO_NUMERO", _numeriGenerati[10]),
                new MySqlConnector.MySqlParameter("@DODICESIMO_NUMERO", _numeriGenerati[11]),
                new MySqlConnector.MySqlParameter("@TREDICESIMO_NUMERO", _numeriGenerati[12]),
                new MySqlConnector.MySqlParameter("@QUATTORDICESIMO_NUMERO", _numeriGenerati[13]),
                new MySqlConnector.MySqlParameter("@QUINDICESIMO_NUMERO", _numeriGenerati[14])
            };

            _dbManager.GetAffectedRows("INSERT INTO cartelle(id_giocatore, id_partita, primo_numero, secondo_numero, terzo_numero, quarto_numero, quinto_numero, sesto_numero, settimo_numero, ottavo_numero, nono_numero, decimo_numero, undicesimo_numero, dodicesimo_numero, tredicesimo_numero, quattordicesimo_numero, quindicesimo_numero, primo_numero_estratto, secondo_numero_estratto, terzo_numero_estratto, quarto_numero_estratto, quinto_numero_estratto, sesto_numero_estratto, settimo_numero_estratto, ottavo_numero_estratto, nono_numero_estratto, decimo_numero_estratto, undicesimo_numero_estratto, dodicesimo_numero_estratto, tredicesimo_numero_estratto, quattordicesimo_numero_estratto, quindicesimo_numero_estratto) VALUES (@ID_GIOCATORE, @ID_PARTITA, @PRIMO_NUMERO, @SECONDO_NUMERO, @TERZO_NUMERO, @QUARTO_NUMERO, @QUINTO_NUMERO, @SESTO_NUMERO, @SETTIMO_NUMERO, @OTTAVO_NUMERO, @NONO_NUMERO, @DECIMO_NUMERO, @UNDICESIMO_NUMERO, @DODICESIMO_NUMERO, @TREDICESIMO_NUMERO, @QUATTORDICESIMO_NUMERO, @QUINDICESIMO_NUMERO, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false)", _parametriQuery, ref _erroreDB);

            // Aggiornamento lista delle cartelle
            if (String.IsNullOrEmpty(_erroreDB))
                OttieniCartelleDaDB();
            else
                throw new Exception("Errore nell'inserimento della cartella su DB:\r\n" + _erroreDB);
        }
        #endregion
    }
}
