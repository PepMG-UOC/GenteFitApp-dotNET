using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFitApp
{
    public partial class frmCalendario : Form
    {
        int mes, año;
        public static int static_mes, static_año;
        public frmCalendario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            muestraDias();
        }
        private void muestraDias()
        {
            DateTime ahora = DateTime.Now;
            mes = ahora.Month;
            año = ahora.Year;

            string mesNombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToUpper();
            lbMesAnyo.Text = mesNombre + " " + año;

            static_mes = mes;
            static_año = año;
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
                ucdias.dias(i);
                diasContenedor.Controls.Add(ucdias);
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
            static_mes = mes;
            static_año = año;
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
                ucdias.dias(i);
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
            
            static_mes = mes;
            static_año = año;
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
                ucdias.dias(i);
                diasContenedor.Controls.Add(ucdias);
            }
        }
    }
}
