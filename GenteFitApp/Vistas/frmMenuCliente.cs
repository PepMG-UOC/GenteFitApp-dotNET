﻿using GenteFitApp.Conrolers;
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
            var monitor = Usuarios.getMonitorDePersona(Session.idPersona);
            if(monitor!=null)
            {
                MessageBox.Show("Los monitores no pueden registrarse a las clases.");
            } else
            {
                frmCalendario clientCalendar = new frmCalendario("cliente");
                clientCalendar.Show();
                this.Close();
            }            
        }

        private void pbMisClases_Click(object sender, EventArgs e)
        {

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
