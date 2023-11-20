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
        ClsPartitaBL(DBManager dBManager)
        {
            _dbManager = dBManager;
        }
        #endregion

        #region Metodi
        public void OttieniDalDB()
        {
            // Dichiarazione variabili necessarie
            System.Data.DataTable _partite;
            string _errore = String.Empty;

            // Query al DB
            _partite = _dbManager.GetDataTableByQuery("SELECT * FROM partite", null, ref _errore);

            // Creo i vari oggetti di classe partita se non si sono verificati errori
            if (String.IsNullOrEmpty(_errore))
            {
                for(int i = 0; i < _partite.Rows.Count; i++)
                {
                    ClsPartitaDB _partita = new ClsPartitaDB();
                    _partita.Id = (long)_partite.Rows[i]["id"];
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

        public List<ClsPartitaDB> CercaPerNome(string nome)
        {
            // Risultato di ricerca
            List<ClsPartitaDB> _partiteTrovate = new List<ClsPartitaDB>(0);

            // Query al DB
            _dbManager.GetDataTableByQuery("SELECT ID ")

            // Ritorno il risultato di ricerca
            return _partiteTrovate;
        }
        #endregion
    }
}
