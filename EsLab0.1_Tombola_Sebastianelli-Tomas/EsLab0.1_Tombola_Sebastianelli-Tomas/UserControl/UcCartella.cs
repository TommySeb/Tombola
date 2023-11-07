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
    public partial class UcCartella : UserControl
    {
        #region Costruttore
        public UcCartella()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventi
        private void UcCartella_Load(object sender, EventArgs e)
        {
            // TODO: Ottenimento numero dal DB

            // Crea le caselle con i 99 numeri della tombola
            int x = 20;
            int y = 56;
            int offset = 10;

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    UcCasellaNumero ucCasellaNumero = new UcCasellaNumero(/*Numero*/ 0);
                    ucCasellaNumero.Location = new Point(x, y);
                    x += ucCasellaNumero.Size.Width + offset;
                    this.Controls.Add(ucCasellaNumero);
                }

                x = 20;
                y += /*UcCasellaNumero.Size.Height*/ 60 + offset;
            }
        }
        #endregion
    }
}
