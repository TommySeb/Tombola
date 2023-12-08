﻿using System;
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

            // Creo i vari oggetti di classe partita e li inserisco nella lista se non si sono verificati errori
            if (String.IsNullOrEmpty(_errore))
            {
                for(int i = 0; i < _partite.Rows.Count; i++)
                {
                    ClsPartitaDB _partita = new ClsPartitaDB();
                    _partita.Id = Convert.ToInt64(_partite.Rows[i]["id"]);
                    _partita.Nome = (string)_partite.Rows[i]["nome"];
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
        /// Ritorna la posizione di una partita nella lista di partite (-1 se non trovata)
        /// </summary>
        /// <param name="id">ID della partita da cercare</param>
        /// <returns></returns>
        public int CercaPartitaDaID(long id)
        {
            // Ricerca della posizione della partita nella lista di partite
            int i = 0;

            while (i < Program._partite.Count && Program._partite[i].Id != id)
                i++;

            // Ritorno l'indice della partita
            if (i != Program._partite.Count)
                return i;
            else
                return -1;
        }

        /// <summary>
        /// Ottiene le partite dal DB ed effettua una ricerca per nome
        /// </summary>
        /// <param name="nome">Nome della partita da cercare</param>
        /// <returns></returns>
        public List<ClsPartitaDB> CercaPerNome(string nome)
        {
            // Dichiarazione variabili necessarie
            List<ClsPartitaDB> _partiteTrovate = new List<ClsPartitaDB>(0);
            string _errore = String.Empty;

            // Aggiorno le partite in RAM
            OttieniPartiteDaDB();

            // Effettuo la ricerca
            foreach(ClsPartitaDB partita in Program._partite)
            {
                if (partita.Nome.Contains(nome))
                    _partiteTrovate.Add(partita);
            }

            // Ritorno i risultati di ricerca
            return _partiteTrovate;
        }
        #endregion
    }
}
