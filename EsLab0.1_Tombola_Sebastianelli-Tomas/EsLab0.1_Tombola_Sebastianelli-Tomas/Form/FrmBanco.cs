using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    public partial class FrmBanco : Form
    {
        #region Costruttore
        public FrmBanco()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventi
        private void FrmBanco_Load(object sender, EventArgs e)
        {
            // Crea le caselle con i 99 numeri della tombola
            int x = 17;
            int y = 65;
            int offset = 10;

            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    UcCasellaNumero ucCasellaNumero = new UcCasellaNumero(Convert.ToInt32(String.Concat(i, k)));
                    ucCasellaNumero.Location = new Point(x, y);
                    x += ucCasellaNumero.Size.Width + offset;
                    this.Controls.Add(ucCasellaNumero);
                }

                x = 17;
                y += /*UcCasellaNumero.Size.Height*/ 60 + offset;
            }
        }
        #endregion
    }
}
