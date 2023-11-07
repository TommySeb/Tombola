using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EsLab0._1_Tombola_Sebastianelli_Tomas
{
    public partial class FrmAccesso : Form
    {
        #region Costruttore
        public FrmAccesso()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventi
        private void btAccedi_Click(object sender, EventArgs e)
        {
            // Variabile usata in caso di errore
            string _errore = String.Empty;

            // Memorizzo le credenziali inserite dall'utente
            MySqlParameter[] parametriLogin = new MySqlParameter[2];
            parametriLogin[0] = new MySqlParameter("@EMAIL", tbEmail.Text);
            parametriLogin[1] = new MySqlParameter("@PASSWORD", tbPassword.Text);

            // Effettuo la query al DB
            DBManager dBManager = new DBManager("tombola", "localhost", "root", "root", "8081");
            DataSet _utente = dBManager.GetDataSetByQuery("SELECT * FROM giocatori WHERE email = @EMAIL AND password = @PASSWORD;", parametriLogin, "giocatori", ref _errore);
            

            FrmHomepage frmHomepage = new FrmHomepage();
            frmHomepage.Owner = this;
            frmHomepage.Show();
        }
        private void llRegistrati_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistrazione frmRegistrazione = new FrmRegistrazione();
            frmRegistrazione.ShowDialog();
        }
        #endregion
    }
}
