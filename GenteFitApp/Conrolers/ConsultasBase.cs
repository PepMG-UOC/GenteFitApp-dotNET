using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
                return dBGfit.Clase.ToList();
            }  
        }

        //public List<Clase> ObtenerClasesPorFecha(int esteDia, int esteMes, int esteAño)
        //{
        //    using (var db = new GenteFitDBEntities())
        //    {
        //        var fechaBusqueda = new DateTime(esteAño, esteMes, esteDia);
        //        var clases = from c in db.Clase
        //                     where c.fechaHora.Date == fechaBusqueda.Date
        //                     select c;
        //        return clases.ToList();
        //    }
        //}

        public static List<ClaseEvento> ObtenerClasesPorFecha(DateTime fecha)
        {
            using (var dbContext = new GenteFitDBEntities())
            {
                var clases = dbContext.Clase.Where(c => DbFunctions.TruncateTime(c.fechaHora) == fecha.Date)
                                    .Include(c => c.Actividad)
                                    .Include(c => c.Sala)
                                    .ToList();

                var clasesEventos = clases.Select(c => new ClaseEvento
                {
                    id_Clase = c.id_Clase,
                    fechaHora = c.fechaHora,
                    nombreActividad = c.Actividad.nombre,
                    descripcionActividad = c.Actividad.descripcion,
                    numPlazasSala = c.Sala.numPlazas,
                    numReservas = dbContext.Reserva.Count(r => r.claseID == c.id_Clase)
                }).ToList();
                return clasesEventos;
            }
        }

        public static List<Actividad> listarActividades() 
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Actividad.ToList();
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

        public static int getPlazasClase(int IDClase) 
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Clase estaClase = dBGfit.Clase.Find(IDClase);
                Sala enSala = dBGfit.Sala.Find(estaClase.salaID);
                return enSala.numPlazas;
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
