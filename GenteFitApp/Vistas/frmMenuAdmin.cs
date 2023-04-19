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

        }

        private void pbCentro_Click(object sender, EventArgs e)
        {
            frmImportExportXML importaExportaXML= new frmImportExportXML();
            importaExportaXML.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Session.idPersona = 0;

            frmLogging loggingForm = new frmLogging();
            loggingForm.Show();
            this.Close();
        }
    }
}
