using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    class ClsPartitaDB
    {
        #region Attributi
        long _id;
        string _nome;
        decimal _prezzo = 0;
        decimal _valoreAmbo = 0;
        decimal _valoreTerna = 0;
        decimal _valoreQuaterna = 0;
        decimal _valoreCinquina = 0;
        decimal _valoreTombola = 0;
        #endregion

        #region Proprietà
        public long Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value >= 0)
                    _id = value;
                else
                    throw new Exception("L'ID di una partita non può essere negativo.");
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                // Elaborazione stringa
                string _tmp = value.Trim();

                // Controllo che la stringa non sia vuota
                if (!String.IsNullOrEmpty(_tmp))
                    _nome = _tmp;
            }
        }

        public decimal Prezzo
        {
            get
            {
                return _prezzo;
            }
            set
            {
                if (value >= 0)
                    _prezzo = value;
                else
                    throw new Exception("Il prezzo della partita non può essere negativo.");
            }
        }

        public decimal ValoreAmbo
        {
            get
            {
                return _valoreAmbo;
            }
            set
            {
                if (value >= 0)
                    _valoreAmbo = value;
                else
                    throw new Exception("Il valore dell'ambo non può essere negativo.");
            }
        }

        public decimal ValoreTerna
        {
            get
            {
                return _valoreTerna;
            }
            set
            {
                if (value >= 0)
                    _valoreTerna = value;
                else
                    throw new Exception("Il valore della terna non può essere negativo.");
            }
        }

        public decimal ValoreQuaterna
        {
            get
            {
                return _valoreQuaterna;
            }
            set
            {
                if (value >= 0)
                    _valoreQuaterna = value;
                else
                    throw new Exception("Il valore della quaterna non può essere negativo.");
            }
        }

        public decimal ValoreCinquina
        {
            get
            {
                return _valoreCinquina;
            }
            set
            {
                if (value >= 0)
                    _valoreCinquina = value;
                else
                    throw new Exception("Il valore della cinquina non può essere negativo.");
            }
        }

        public decimal ValoreTombola
        {
            get
            {
                return _valoreTombola;
            }
            set
            {
                if (value >= 0)
                    _valoreTombola = value;
                else
                    throw new Exception("Il valore della tombola non può essere negativo.");
            }
        }
        #endregion

        #region Costruttore
        public ClsPartitaDB()
        {

        }
        #endregion
    }
}
