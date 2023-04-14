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
    public partial class UserControlDias : UserControl
    {
        public static string dia;

        public UserControlDias()
        {
            InitializeComponent();
        }

        private void UserControlDias_Load(object sender, EventArgs e)
        {

        }
        public void dias(int numdia)
        {
            lbdias.Text = numdia.ToString();            
        }

        public void insertaEvento(Label evento)
        {
            evento.Click += new EventHandler(abreEvento);
            fLPClase.Controls.Add(evento);
        }
        private void UserControlDias_Click(object sender, EventArgs e)
        {
           
        }

        private void abreEvento(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string activ = label.Text;

           // dia = lbdias.Text;
            frmEventos _frmEvento = new frmEventos();
            _frmEvento.Show();
        }



    }
}
