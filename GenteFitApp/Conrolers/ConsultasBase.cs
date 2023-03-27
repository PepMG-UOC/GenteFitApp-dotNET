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
        public List<Clase> listarClases()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Clase.ToList();
            }  
        }

        public List<Actividad> listarActividades() 
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Actividad.ToList();
            }
        }

        public List<Reserva> listaReservasCliente(int IDCliente)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Reserva.Where(r => r.clienteID== IDCliente).ToList();
            }
        }

        public List<Reserva> listaReservasClase(int IDClase)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {  
                return dBGfit.Reserva.Where(r => r.claseID == IDClase).ToList();
            }
        }

        public int getPlazasClase(int IDClase) 
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Clase estaClase = dBGfit.Clase.Find(IDClase);
                Sala enSala = dBGfit.Sala.Find(estaClase.salaID);
                return enSala.numPlazas;
            }
        }

        public List<DateTime> listarFechasActividad(int IDActividad)
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
