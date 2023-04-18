using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenteFitApp.Modelo;
using GenteFitApp.Vistas;

namespace GenteFitApp.Conrolers
{
    public static class EventosCalendar
    {
        // ucdias = rellenaDia(i, mes, año);
        

        public static UserControlDias rellenaDia (DateTime fecha)
        {            
            DateTime ahora = DateTime.Now;
            
            UserControlDias ucdias = new UserControlDias();
            //ConsultasBase.ObtenerClasesPorFecha(fecha);
            ucdias.dias(fecha.Day);
            ucdias.CargaClasesDelDia(fecha);  
            return ucdias;
        }

        public static Reserva getReservaClaseCliente(int IDclase, int IDCiente)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var reservaEncontrada = dBGfit.Reserva
                    .Include("Clase")
                    .Include("Cliente")
                   .FirstOrDefault(r => r.claseID == IDclase && r.clienteID == IDCiente);
                return reservaEncontrada;
            }
        }

        public static Color colorLinea(Clase miClase)
        {
            int numReservas = ConsultasBase.reservasDeClase(miClase);
            if (miClase.Sala.numPlazas >= numReservas)
            {
                return Color.YellowGreen;
            }
            return Color.Yellow;
        }


    }

   

}
