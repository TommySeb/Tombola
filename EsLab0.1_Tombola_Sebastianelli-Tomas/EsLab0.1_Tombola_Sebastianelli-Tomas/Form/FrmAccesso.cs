using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

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
            // Imposto il cursore di caricamento
            this.Cursor = Cursors.WaitCursor;

            // Verifico se l'utente esiste nel DB e, in caso positivo, lo memorizzo
            string _email = tbEmail.Text;
            string _password = tbPassword.Text;

            ClsGiocatoreBL clsGiocatoreBL = new ClsGiocatoreBL(Program._dbManager);

            try
            {
                if (clsGiocatoreBL.EsisteGiocatore(_email, _password))
                {
                    // Ripristino il cursore base
                    this.Cursor = Cursors.Arrow;

                    FrmHomepage frmHomepage = new FrmHomepage();
                    frmHomepage.Owner = this;
                    frmHomepage.Show();
                }
                else
                {
                    // Ripristino il cursore base
                    this.Cursor = Cursors.Arrow;

                    throw new Exception("Credenziali di accesso non valide.");
                }  
            }
            catch(Exception ex)
            {
                // Ripristino il cursore base
                this.Cursor = Cursors.Arrow;

                MessageBox.Show("Si è verificato un errore: \r\n" + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llRegistrati_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistrazione frmRegistrazione = new FrmRegistrazione();
            frmRegistrazione.ShowDialog();
        }
        #endregion

        private void FrmAccesso_Load(object sender, EventArgs e)
        {
            // Tmp
            ClsCartellaBL metodi = new ClsCartellaBL(Program._dbManager);
            metodi.OttieniCartelleDaDB();
            UcCartella ucCartella = new UcCartella(1);
            this.Controls.Add(ucCartella);
        }
    }
}
