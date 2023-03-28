using System;
using System.Collections.Generic;
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

        public static List<Reserva> listarReservas()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Reserva.ToList();
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
