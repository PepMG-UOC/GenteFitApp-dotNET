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

namespace GenteFitApp.Vistas
{
    public partial class frmMenuCliente : Form
    {
        public frmMenuCliente()
        {
            InitializeComponent();
        }

        private void pbClases_Click(object sender, EventArgs e)
        {         
            if(Session.Tipo.Equals("Monitor"))
            {
                MessageBox.Show("Los monitores no pueden registrarse a las clases.");
            } else
            {
                frmCalendario clientCalendar = new frmCalendario();
                clientCalendar.Origen = "MenuCliente_Clases";
                clientCalendar.Show();
                this.Close();
            }            
        }

        private void pbMisClases_Click(object sender, EventArgs e)
        {            
            frmCalendario clientCalendar = new frmCalendario();
            clientCalendar.Origen = "MenuCliente_MisClases";
            clientCalendar.Show();
            this.Close();            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Session.ResetSession();
            frmLogging loggingForm = new frmLogging();
            loggingForm.Show();
            this.Close();
        }
    }
}
