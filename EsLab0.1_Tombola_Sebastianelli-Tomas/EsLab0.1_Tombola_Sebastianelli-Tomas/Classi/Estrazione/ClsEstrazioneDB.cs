using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    class ClsEstrazioneDB
    {
        #region Costruttore
        public ClsEstrazioneDB()
        {

        }
        #endregion

        #region Attributi
        long _id;
        long _idPartita;
        int _numeroEstratto;
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
                    throw new Exception("L'ID dell'estrazione non può assumere un valore negativo.");
            }
        }

        public long IdPartita
        {
            get
            {
                return _idPartita;
            }
            set
            {
                if (value >= 0)
                    _idPartita = value;
                else
                    throw new Exception("L'ID della partita non può assumere un valore negativo.");
            }
        }

        public int NumeroEstratto
        {
            get
            {
                return _numeroEstratto;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    _numeroEstratto = value;
                else
                    throw new Exception("Un numero estratto deve essere comrpeso tra 1 e 99");
            }
        }
        #endregion
    }
}
