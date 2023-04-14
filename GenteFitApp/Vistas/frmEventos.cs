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
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            txtbxFecha.Text = UserControlDias.dia + "/" + frmCalendario.mes + "/" +  frmCalendario.año;

        }
    }
}
