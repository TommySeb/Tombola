using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAccesso());
        }

        #region Variabili pubbliche
        public static DBManager _dbManager = new DBManager();

        public static string _nomeConnectionString = "serverLocale";    // Nome connection string da prendere dall'App.Config

        public static ClsGiocatoreDB _giocatoreLoggato;
        public static List<ClsPartitaDB> _partite = new List<ClsPartitaDB>(0);
        public static List<ClsCartellaDB> _cartelle = new List<ClsCartellaDB>(0);
        public static List<ClsEstrazioneDB> _estrazioni = new List<ClsEstrazioneDB>(0);
        #endregion
    }
}
