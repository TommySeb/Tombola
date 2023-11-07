using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    public partial class UcCasellaNumero : UserControl
    {
        #region Costruttore
        public UcCasellaNumero(int numero)
        {
            InitializeComponent();

            // Valuto se la casella ha un numero o è coperta
            if (numero >= 1 && numero <= 99)
                lblNumero.Text = numero.ToString();
            else
                CopriCasella();
        }
        #endregion

        #region Metodi
        public void CopriCasella()
        {
            lblNumero.Visible = false;
            this.BackColor = Color.DarkGray;
        }
        #endregion
    }
}
