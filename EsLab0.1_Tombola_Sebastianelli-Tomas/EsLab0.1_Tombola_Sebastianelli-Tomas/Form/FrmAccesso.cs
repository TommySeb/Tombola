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
            // Memorizzo le credenziali inserite dall'utente
            MySqlParameter[] parametriLogin = new MySqlParameter[2];
            parametriLogin[0] = new MySqlParameter("@EMAIL", tbEmail.Text);
            parametriLogin[1] = new MySqlParameter("@PASSWORD", tbPassword.Text);

            // Effettuo la query al DB
            MySqlConnection _connessione = new MySqlConnection("server=localhost;user=root;database=tombola;port=3306;password=root");
            string _query = "SELECT * FROM giocatori WHERE email = @EMAIL AND password = @PASSWORD";
            _connessione.Open();

            DataSet _utente = new DataSet();
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_query, _connessione);
            _dataAdapter.Fill(_utente, "giocatori");

            _connessione.Close();

            DataSet tmp = _utente;

            

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
