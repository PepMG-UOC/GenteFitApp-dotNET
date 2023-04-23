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
        /// <summary>
        /// Origen de instancia del form:
        /// MenuCliente_Clases
        /// MenuCliente_MisClases
        /// MenuAdmin_Reservas
        /// Admin_Clases
        /// </summary>
        public string Origen { get; set; }
        public static int mes, año, dia;
        public int mesActual, añoActual, diaActual;               
        public DateTime ahora;

        public frmCalendario()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ahora = DateTime.Now;
            mes = mesActual = ahora.Month;
            año = añoActual = ahora.Year;
            dia = diaActual = ahora.Day;            
            muestraDias();
        }
        private void muestraDias()
        {        
            string mesNombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToUpper();
            lbMesAnyo.Text = mesNombre + " " + año;            
            // Determinamos primer dia del mes.
            DateTime inicioDeMes = new DateTime(año, mes, 1);

            int cantidadDiasMes = DateTime.DaysInMonth(año, mes);
            int diaSemanaInitMes = Convert.ToInt32(inicioDeMes.DayOfWeek.ToString("d"));
            if (diaSemanaInitMes == 0) diaSemanaInitMes = 7;
            // creamos un usercontrol en blanco para los cantidadDiasMes sobrantes del mes
            for (int i=1; i< diaSemanaInitMes; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                diasContenedor.Controls.Add(ucblank);
            }

            // creamos un usercontrol para los cantidadDiasMes existentes del mes
            for(int i= 1; i<=cantidadDiasMes; i++)
            {
                DateTime fecha = DateTime.Parse($"{año}-{mes}-{i}");
                diasContenedor.Controls.Add(EventosCalendar.rellenaDia(fecha, Origen));
            }

        }
            
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            // limpiamos el contenedor del mes
            diasContenedor.Controls.Clear();
            // decrementa un mes
            mes--;
            // decrementa un año
            if (mes <= 0)
            {
                mes = 12;
                año--;
            }
            muestraDias();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // limpiamos el contenedor del mes
            diasContenedor.Controls.Clear();
            // incrementa un mes
            mes++;
            // incrementa un año
            if (mes >= 12) 
            {
                mes = 1;
                año++;
            }
            muestraDias();            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(Session.Tipo.Equals("Cliente") || Session.Tipo.Equals("Monitor"))
            {
                frmMenuCliente menuCliente = new frmMenuCliente();
                menuCliente.Show();
                this.Close();                
            } else if(Origen.Equals("MenuAdmin_Reservas"))
            {
                frmMenuAdmin menuAdmin = new frmMenuAdmin();
                menuAdmin.Show();
                this.Close();
            } else if(Origen.Equals("Admin_Clases"))
            {
                frmGestionCentro gestionCentro = new frmGestionCentro();
                gestionCentro.Show();
                this.Close();
            }           
        }
    }
    
}
