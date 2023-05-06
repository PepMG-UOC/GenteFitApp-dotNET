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
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void pbUsuarios_Click(object sender, EventArgs e)
        {
            frmGestionUsers gestionUsers = new frmGestionUsers();
            gestionUsers.Show();
            this.Close();
        }

        private void pbReservas_Click(object sender, EventArgs e)
        {
            frmCalendario adminCalendar = new frmCalendario();
            adminCalendar.Origen = "Info. Reservas de Clase Administrador";
            adminCalendar.Show();
            this.Close();
        }

        private void pbCentro_Click(object sender, EventArgs e)
        {
            frmGestionCentro gestionCentro = new frmGestionCentro();
            gestionCentro.Show();            
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Session.ResetSession();
            frmLogging loggingForm = new frmLogging();
            loggingForm.Show();
            this.Close();
        }

        private void pbOdoo_Click(object sender, EventArgs e)
        {
            frmImportExportXML importExportOdoo= new frmImportExportXML();
            importExportOdoo.Show();
            this.Close();
        }
    }
}
