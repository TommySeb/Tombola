using System;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    class ClsCartellaDB
    {
        #region Costruttore
        public ClsCartellaDB()
        {

        }
        #endregion

        #region Attributi
        long _id;

        long _idGiocatore;
        long _idPartita;
        int _primoNumero;
        int _secondoNumero;
        int _terzoNumero;
        int _quartoNumero;
        int _quintoNumero;
        int _sestoNumero;
        int _settimoNumero;
        int _ottavoNumero;
        int _nonoNumero;
        int _decimoNumero;
        int _undicesimoNumero;
        int _dodicesimoNumero;
        int _tredicesimoNumero;
        int _quattordicesimoNumero;
        int _quindicesimoNumero;

        bool _primoNumeroEstratto;
        bool _secondoNumeroEstratto;
        bool _terzoNumeroEstratto;
        bool _quartoNumeroEstratto;
        bool _quintoNumeroEstratto;
        bool _sestoNumeroEstratto;
        bool _settimoNumeroEstratto;
        bool _ottavoNumeroEstratto;
        bool _nonoNumeroEstratto;
        bool _decimoNumeroEstratto;
        bool _undicesimoNumeroEstratto;
        bool _dodicesimoNumeroEstratto;
        bool _tredicesimoNumeroEstratto;
        bool _quattordicesimoNumeroEstratto;
        bool _quindicesimoNumeroEstratto;
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
                    throw new Exception("L'ID della cartella non può assumere un valore negativo.");
            }
        }

        public int PrimoNumero
        {
            get
            {
                return _primoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _primoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int SecondoNumero
        {
            get
            {
                return _secondoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _secondoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int TerzoNumero
        {
            get
            {
                return _terzoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _terzoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int QuartoNumero
        {
            get
            {
                return _quartoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _quartoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int QuintoNumero
        {
            get
            {
                return _quintoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _quintoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int SestoNumero
        {
            get
            {
                return _sestoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _sestoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int SettimoNumero
        {
            get
            {
                return _settimoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _settimoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int OttavoNumero
        {
            get
            {
                return _ottavoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _ottavoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int NonoNumero
        {
            get
            {
                return _nonoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _nonoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int DecimoNumero
        {
            get
            {
                return _decimoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _decimoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int UndicesimoNumero
        {
            get
            {
                return _undicesimoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _undicesimoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int DodicesimoNumero
        {
            get
            {
                return _dodicesimoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _dodicesimoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int TredicesimoNumero
        {
            get
            {
                return _tredicesimoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _tredicesimoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int QuattordicesimoNumero
        {
            get
            {
                return _quattordicesimoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _quattordicesimoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public int QuindicesimoNumero
        {
            get
            {
                return _quindicesimoNumero;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _quindicesimoNumero = value;
                else
                    throw new Exception("Un numero di una cartella della tombola deve essere comrpeso tra 1 e 99");
            }
        }

        public bool PrimoNumeroEstratto { get => _primoNumeroEstratto; set => _primoNumeroEstratto = value; }
        public bool SecondoNumeroEstratto { get => _secondoNumeroEstratto; set => _secondoNumeroEstratto = value; }
        public bool TerzoNumeroEstratto { get => _terzoNumeroEstratto; set => _terzoNumeroEstratto = value; }
        public bool QuartoNumeroEstratto { get => _quartoNumeroEstratto; set => _quartoNumeroEstratto = value; }
        public bool QuintoNumeroEstratto { get => _quintoNumeroEstratto; set => _quintoNumeroEstratto = value; }
        public bool SestoNumeroEstratto { get => _sestoNumeroEstratto; set => _sestoNumeroEstratto = value; }
        public bool SettimoNumeroEstratto { get => _settimoNumeroEstratto; set => _settimoNumeroEstratto = value; }
        public bool OttavoNumeroEstratto { get => _ottavoNumeroEstratto; set => _ottavoNumeroEstratto = value; }
        public bool NonoNumeroEstratto { get => _nonoNumeroEstratto; set => _nonoNumeroEstratto = value; }
        public bool DecimoNumeroEstratto { get => _decimoNumeroEstratto; set => _decimoNumeroEstratto = value; }
        public bool UndicesimoNumeroEstratto { get => _undicesimoNumeroEstratto; set => _undicesimoNumeroEstratto = value; }
        public bool DodicesimoNumeroEstratto { get => _dodicesimoNumeroEstratto; set => _dodicesimoNumeroEstratto = value; }
        public bool TredicesimoNumeroEstratto { get => _tredicesimoNumeroEstratto; set => _tredicesimoNumeroEstratto = value; }
        public bool QuattordicesimoNumeroEstratto { get => _quattordicesimoNumeroEstratto; set => _quattordicesimoNumeroEstratto = value; }
        public bool QuindicesimoNumeroEstratto { get => _quindicesimoNumeroEstratto; set => _quindicesimoNumeroEstratto = value; }
        #endregion
    }
}
