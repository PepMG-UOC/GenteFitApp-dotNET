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

        private void tbEmail_Leave(object sender, EventArgs e)
        {          
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
               tbEmail.Text = "eMail";
            }
           
        }

        private void tbPassw_Enter(object sender, EventArgs e)
        {
            if (tbPassw.Text == "password")
            {
                tbPassw.Text = string.Empty;
            }
        }

        private void tbPassw_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassw.Text))               
            {
                tbPassw.Text = "password";
            }
        }

        private void btnAccede_Click(object sender, EventArgs e)
        {
            if(Usuarios.logging(tbEmail.Text,tbPassw.Text))
            {                
                if (Usuarios.idClienteDePersona(Session.idPersona)!=0 || Usuarios.idMonitorDePersona(Session.idPersona)!=0)                
                {
                    frmMenuCliente menuCliente = new frmMenuCliente();
                    menuCliente.Show();
                }
                else if (Usuarios.idAdminDePersona(Session.idPersona)!=0)                
                {
                    frmMenuAdmin menuAdmin = new frmMenuAdmin();
                    menuAdmin.Show();
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
