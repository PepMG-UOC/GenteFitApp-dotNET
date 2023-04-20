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
    public partial class frmGestionCentro : Form
    {
        public frmGestionCentro()
        {
            InitializeComponent();
        }

        private void pBClases_Click(object sender, EventArgs e)
        {

        }

        private void pBActividades_Click(object sender, EventArgs e)
        {

        }

        private void pBSalas_Click(object sender, EventArgs e)
        {
            frmSalas salasform= new frmSalas();
            salasform.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuAdmin menuAdmin = new frmMenuAdmin();
            menuAdmin.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmImportExportXML importaExportaXML = new frmImportExportXML();
            importaExportaXML.ShowDialog();
        }
    }
}
