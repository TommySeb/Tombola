﻿using System;
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
        public static List<ClsPartita> _partite = new List<ClsPartita>(0);
        public static List<ClsCartella> _cartelle = new List<ClsCartella>(0);
        #endregion
    }
}
