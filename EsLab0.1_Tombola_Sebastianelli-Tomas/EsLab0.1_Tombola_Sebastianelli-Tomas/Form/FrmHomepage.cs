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
    public partial class FrmHomepage : Form
    {
        #region Costruttore
        public FrmHomepage()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventi
        private void FrmHomepage_Load(object sender, EventArgs e)
        {
            // Nascondi la Form di accesso
            this.Owner.Hide();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            Console.Write("Column Resizing");
            e.NewWidth = this.listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        #endregion
    }
}
