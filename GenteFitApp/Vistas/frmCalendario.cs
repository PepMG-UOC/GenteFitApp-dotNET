using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenteFitApp.Conrolers;

namespace GenteFitApp.Vistas
{
    public partial class frmCalendario : Form
    {
        public static int mes, año, dia;
        public int mesActual, añoActual, diaActual;
        private string origen;
        TextoSeleccionable evento;
        public DateTime ahora;

        public frmCalendario(string orig)
        {
            InitializeComponent();
            origen = orig;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ahora = DateTime.Now;
            mesActual = ahora.Month;
            añoActual = ahora.Year;
            diaActual = ahora.Day;
            muestraDias();
        }
        private void muestraDias()
        {
            
            mes = mesActual;
            año = añoActual;
            dia = diaActual;

            string mesNombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToUpper();
            lbMesAnyo.Text = mesNombre + " " + año;
            
            // Determinamos primer dia del mes.
            DateTime inicioDeMes = new DateTime(año, mes, 1);

            int dias = DateTime.DaysInMonth(año, mes);
            int diasDelaSemana = Convert.ToInt32(inicioDeMes.DayOfWeek.ToString("d"));
            if (diasDelaSemana == 0) diasDelaSemana = 7;
            // creamos un usercontrol en blanco para los dias sobrantes del mes
            for (int i=1; i< diasDelaSemana; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                diasContenedor.Controls.Add(ucblank);
            }

            // creamos un usercontrol para los dias existentes del mes
            for(int i= 1; i<=dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                // ucdias = rellenaDia(i, mes, año);
                if (i == diaActual && mes == mesActual && año == añoActual)
                {
                    ucdias.dias(i, Color.Blue);

                    evento = new TextoSeleccionable { Texto = "Speening", BackColor = Color.Green };
                    var labelEvento = new Label { Text = evento.Texto, BackColor = evento.BackColor };
                    ucdias.insertaEvento(labelEvento);
                }
                else ucdias.dias(i, Color.White);

                diasContenedor.Controls.Add(ucdias);
            }
        }

      

        private void btnSalir_Click(object sender, EventArgs e)
        {
            switch (origen)
            {
                case "cliente":
                    frmMenuCliente menuCliente = new frmMenuCliente();
                    menuCliente.Show();
                    this.Close();
                    break;
                case "admin":
                    frmMenuAdmin menuAdmin = new frmMenuAdmin();
                    menuAdmin.Show();
                    this.Close();
                    break;                    
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            // limpiamos el contenedor del mes
            diasContenedor.Controls.Clear();
            // decrementa un mes
            mes--;
            if (mes <= 0)
            {
                mes = 12;
                año--;
            }
            
            string mesNombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToUpper();
            lbMesAnyo.Text = mesNombre + " " + año;

            DateTime inicioDeMes = new DateTime(año, mes, 1);

            int dias = DateTime.DaysInMonth(año, mes);
            int diasDelaSemana = Convert.ToInt32(inicioDeMes.DayOfWeek.ToString("d"));
            if (diasDelaSemana == 0) diasDelaSemana = 7;
            // creamos un usercontrol en blanco para los dias sobrantes del mes
            for (int i = 1; i < diasDelaSemana; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                diasContenedor.Controls.Add(ucblank);
            }

            // creamos un usercontrol para los dias existentes del mes
            for (int i = 1; i <= dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                if (i == diaActual && mes == mesActual && año == añoActual)
                {
                    ucdias.dias(i, Color.Blue);
                    evento = new TextoSeleccionable { Texto = "Speening", BackColor = Color.Green };
                    var labelEvento = new Label { Text = evento.Texto, BackColor = evento.BackColor };
                    ucdias.insertaEvento(labelEvento);
                }
                else ucdias.dias(i, Color.White);
                diasContenedor.Controls.Add(ucdias);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // limpiamos el contenedor del mes
            diasContenedor.Controls.Clear();
            // incrementa un mes
            mes++;
            if (mes >= 12) 
            {
                mes = 1;
                año++;
            }            
           
            string mesNombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToUpper();
            lbMesAnyo.Text = mesNombre + " " + año;

            DateTime inicioDeMes = new DateTime(año, mes, 1);

            int dias = DateTime.DaysInMonth(año, mes);
            int diasDelaSemana = Convert.ToInt32(inicioDeMes.DayOfWeek.ToString("d"));
            if (diasDelaSemana == 0) diasDelaSemana = 7;
            // creamos un usercontrol en blanco para los dias sobrantes del mes
            for (int i = 1; i < diasDelaSemana; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                diasContenedor.Controls.Add(ucblank);
            }

            // creamos un usercontrol para los dias existentes del mes
            for (int i = 1; i <= dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                if (i == diaActual && mes == mesActual && año == añoActual)
                {
                    ucdias.dias(i, Color.Blue);
                    evento = new TextoSeleccionable { Texto = "Speening", BackColor = Color.Green };
                    var labelEvento = new Label { Text = evento.Texto, BackColor = evento.BackColor };
                    ucdias.insertaEvento(labelEvento);
                }
                else ucdias.dias(i, Color.White);
                diasContenedor.Controls.Add(ucdias);
            }
        }
    }
    
}
