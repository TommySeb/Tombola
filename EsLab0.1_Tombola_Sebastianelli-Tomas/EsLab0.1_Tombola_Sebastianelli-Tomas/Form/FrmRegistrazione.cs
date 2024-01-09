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
    public partial class FrmRegistrazione : Form
    {
        public FrmRegistrazione()
        {
            InitializeComponent();
        }

        #region Eventi
        private void btRegistrati_Click(object sender, EventArgs e)
        {
            try
            {
                // Memorizza le informazioni del nuovo giocatore
                ClsGiocatoreDB _giocatore = new ClsGiocatoreDB();
                _giocatore.Nome = tbNome.Text;
                _giocatore.Cognome = tbCognome.Text;
                _giocatore.Nickname = tbNickname.Text;
                _giocatore.DataDiNascita = dtpDataDiNascita.Value;
                _giocatore.Genere = cbGenere.SelectedItem.ToString()[0];
                _giocatore.Email = tbEmail.Text;
                if (tbPassword.Text == tbConfermaPassword.Text)
                    _giocatore.Password = tbPassword.Text;
                else
                    throw new Exception("Le due password devono essere uguali.");

                // Registra il giocatore
                ClsGiocatoreBL _clsGiocatoreBL = new ClsGiocatoreBL(Program._dbManager);
                string _errore = String.Empty;

                _clsGiocatoreBL.Registra(_giocatore, ref _errore);

                // In caso si siano presentati errori riportali
                if (!String.IsNullOrEmpty(_errore))
                    MessageBox.Show(_errore, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Altrimenti conferma la registrazione
                else
                {
                    MessageBox.Show("Utente registrato con successo.", "Conferma di registrazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion
    }
}
