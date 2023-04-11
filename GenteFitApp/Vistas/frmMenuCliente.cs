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
        private void pbClases_Click(object sender, EventArgs e)
        {

        }

        private void pbMisClases_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Usermail = null;
            Session.Password = null;

            frmLogging loggingForm = new frmLogging();
            loggingForm.Show();
            this.Close();
        }
    }
}
