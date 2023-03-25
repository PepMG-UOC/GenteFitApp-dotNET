using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFitApp
{
    public partial class UserControlDias : UserControl
    {
        public static string static_dia;

        public UserControlDias()
        {
            InitializeComponent();
        }

        private void UserControlDias_Load(object sender, EventArgs e)
        {

        }
        public void dias(int numdia)
        {
            lbdias.Text = numdia + "";
        }

        private void UserControlDias_Click(object sender, EventArgs e)
        {
            static_dia = lbdias.Text;
            frmEventos _frmEvento = new frmEventos();
            _frmEvento.Show();
        }

        //Metodo para mostrar Evento



    }
}
