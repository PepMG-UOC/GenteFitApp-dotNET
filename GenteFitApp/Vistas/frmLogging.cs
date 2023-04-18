using GenteFitApp.Conrolers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GenteFitApp.Vistas
{
    public partial class frmLogging : Form
    {
        public frmLogging()
        {
            InitializeComponent();
        }

        private void frmLogging_Load(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "eMail")
            {
                tbEmail.Text = string.Empty;
            }
        }
        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Usuarios.formatoEmailCorrecto(tbEmail.Text))
                {
                    e.SuppressKeyPress = true; // Evita que se produzca un sonido de "ding" al pulsar Enter
                    tbPassw.Select(); // Selecciona el siguiente TextBox
                } else MessageBox.Show("Formato de eMail Incorrecto. Intente de nuevo.");
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {          
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
               tbEmail.Text = "eMail";
            }
           
        }

        private void tbPassw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAccede.PerformClick();
            }
        }


        private void btnAccede_Click(object sender, EventArgs e)
        {
            if (Usuarios.logging(tbEmail.Text, tbPassw.Text))
            {                    
                if (Usuarios.getAdminDePersona(Session.idPersona) != null)
                {
                    frmMenuAdmin menuAdmin = new frmMenuAdmin();
                    menuAdmin.Show();
                } 
                else
                {
                    frmMenuCliente menuCliente = new frmMenuCliente();
                    menuCliente.Show();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas. Intente de nuevo.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
