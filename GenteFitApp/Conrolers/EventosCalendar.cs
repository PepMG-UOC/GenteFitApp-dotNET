using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public static UserControlDias rellenaDia (DateTime fecha, string origen)
        {            
            UserControlDias ucdias = new UserControlDias(); 
            ucdias.Origen = origen;
            ucdias.setMyDia(fecha);
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

        public static void eliminaReservasDeCliente(int idCliente)
        {
            using (var dBGfit = new GenteFitDBEntities()) 
            {
                var reservasAEliminar = dBGfit.Reserva.Where(r => r.clienteID == idCliente);

                foreach (var reserva in reservasAEliminar)
                {
                    dBGfit.Reserva.Remove(reserva);
                }
                dBGfit.SaveChanges();
            }
        }        

        public static Color colorLinea(int idClase)
        {
            Clase miClase = GestionCentro.getClaseByID(idClase);
            int numReservas = ConsultasBase.reservasDeClase(miClase);
            if (miClase.Sala.numPlazas > numReservas)
            {
                return Color.YellowGreen;
            }
            return Color.Yellow;
        }

        public static void borraReservasDeClase(Clase clase)
        {
            // Eliminar todas las Reservas que pertenecen a la Clase
            using (var dBGfit = new GenteFitDBEntities())
            {                
                Clase claseeliminar = dBGfit.Clase.FirstOrDefault(c => c.id_Clase == clase.id_Clase);
                foreach (var reserva in claseeliminar.Reserva.ToList())
                {
                    dBGfit.Reserva.Remove(reserva);
                }
                dBGfit.SaveChanges();
            }
        }


    }

   

}
