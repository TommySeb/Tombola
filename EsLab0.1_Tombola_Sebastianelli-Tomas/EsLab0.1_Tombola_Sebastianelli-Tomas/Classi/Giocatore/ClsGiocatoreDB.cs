using System;
using System.Linq;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    class ClsGiocatoreDB
    {
        #region Costruttore
        public ClsGiocatoreDB(MySql.Data.MySqlClient.dataset)
        {
            
        }
        #endregion

        #region Attributi
        string _email;
        string _password;
        string _nome;
        string _cognome;
        string _nickname;
        DateTime _dataDiNascita;
        Char _genere;
        Decimal _portafoglio;
        #endregion

        #region Proprietà
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                string _tmp = value.Trim();

                // Controllo sul formato dell'e-mail
                if (_tmp.IndexOf('@') != -1 || _tmp.Split('@')[1].IndexOf('.') != -1 || _tmp.Split('@')[1].Split('.').Count() == 2)
                {
                    _email = _tmp;
                }
                else
                    throw new Exception("Il formato dell'e-mail non è corretto.")
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (!String.IsNullOrEmpty(value.Trim()))
                    _nome = value.Trim();
                else
                    throw new Exception("Il nome del giocatore non può essere vuoto");
            }
        }

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
                    throw new Exception("L'ID del giocatore non può assumere un valore negativo.");
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
                if (!String.IsNullOrEmpty(value.Trim()))
                    _nome = value.Trim();
                else
                    throw new Exception("Il nome del giocatore non può essere vuoto");
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                if (!String.IsNullOrEmpty(value.Trim()))
                    _cognome = value.Trim();
                else
                    throw new Exception("Il cognome del giocatore non può essere vuoto");
            }
        }

        public string Nickname
        {
            get
            {
                return _nickname;
            }
            set
            {
                if (!String.IsNullOrEmpty(value.Trim()))
                    _nickname = value.Trim();
                else
                    throw new Exception("Il nickname del giocatore non può essere vuoto");
            }
        }
        #endregion
    }
}
