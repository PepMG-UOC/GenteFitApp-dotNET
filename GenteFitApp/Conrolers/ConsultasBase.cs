using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using GenteFitApp.Modelo;


namespace GenteFitApp.Conrolers
{
    public class ConsultasBase
    {
        public static List<Clase> listarClases()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var clases = dBGfit.Clase
                    .Include(c => c.Actividad)
                    .Include(c => c.Sala)
                    .ToList();
                return clases;
            }  
        }
                
        public static List<Clase> listarClasesPorFecha(DateTime fecha)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var clases = dBGfit.Clase.Where(c => DbFunctions.TruncateTime(c.fechaHora) == fecha.Date)
                    .Include(c => c.Actividad)
                    .Include(c => c.Sala)
                    .OrderBy(c => c.fechaHora)
                    .ToList();
                return clases;
            }
        }
           
        public static int reservasDeClase(Clase estaClase)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Reserva.Count(r => r.claseID == estaClase.id_Clase);
            }
                
        }

        public static Clase getClasebyID(int IDClase)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Clase myClase = dBGfit.Clase
                    .Include(c => c.Actividad)
                    .Include(c => c.Sala)
                    .FirstOrDefault(c => c.id_Clase == IDClase);
                return myClase;
            }
        }

        public static List<Actividad> listarActividades() 
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var actividades = dBGfit.Actividad
                    .Include(a => a.Monitor)
                    .ToList();
                return actividades;                
            }
        }

        public static List<Reserva> listarReservasCliente(int IDCliente)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Reserva.Where(r => r.clienteID== IDCliente).ToList();
            }
        }

        public static List<Reserva> listarReservasClase(int IDClase)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {  
                return dBGfit.Reserva.Where(r => r.claseID == IDClase).ToList();
            }
        }

        public static List<ReservaView> listarReservas()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var reservas = dBGfit.Reserva.Select(r => new ReservaView
                {
                    id_Reserva = r.id_Reserva,
                    posicion = r.posicion,
                    claseID = r.claseID,
                    clienteID = r.clienteID,
                    confirmada = r.confirmada,
                }).ToList();

                return reservas;
            }
        }

        public static List<DateTime> listarFechasActividad(int IDActividad)
        {
            List<DateTime> listaHorarios = new List<DateTime>();
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                List<Clase> allClaseActv = dBGfit.Clase.Where(c => c.actividadID == IDActividad).ToList();
                foreach(Clase claseAct in allClaseActv)
                {
                    listaHorarios.Add(claseAct.fechaHora);
                }
                return listaHorarios;
            }
        }



    }
}
