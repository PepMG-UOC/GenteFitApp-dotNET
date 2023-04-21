using GenteFitApp.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace GenteFitApp.Conrolers
{
    public class GestionCentro
    {
        public static void altaActividad(string nombre, string descripcion, int monitorID)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Actividad nuevaActividad = new Actividad
                {
                    nombre = nombre,
                    descripcion = descripcion,
                    monitorID = monitorID
                };

                dBGfit.Actividad.Add(nuevaActividad);
                dBGfit.SaveChanges();
            }
        }

        public static Actividad getActividadById(int IDActividad)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Actividad.Include(a => a.Monitor)
                    .Include(a => a.Clase)
                    .FirstOrDefault(a => a.id_Actividad == IDActividad);
            }
        }

        public static void bajaActividad(int IDActividad)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Actividad borrarActividad = dBGfit.Actividad.Find(IDActividad);

                if (borrarActividad != null)
                {
                    dBGfit.Actividad.Remove(borrarActividad);
                    dBGfit.SaveChanges();
                }
            }
        }



        // ---
        public static List<int> getIDsSalas()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var idSalas = dBGfit.Sala.Select(s => s.id_Sala).ToList();
                return idSalas;
            }
        }
        public static void altaSala(int numPlazas, int dimensionM2)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Sala nuevaSala = new Sala
                {
                    numPlazas = numPlazas,
                    dimensionM2 = dimensionM2
                };
                dBGfit.Sala.Add(nuevaSala);
                dBGfit.SaveChanges();
            }
        }

        public static Sala getSalaById(int IdSala)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Sala.Include(s => s.Clase)
                    .FirstOrDefault(s => s.id_Sala== IdSala);                                 
            }
        }


        public static void bajaSalaById(int IDSala)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Sala sala = getSalaById(IDSala);                
                if (sala != null)                
                {                    
                    foreach (Clase clase in sala.Clase)
                    {
                        List<Reserva> reservas = dBGfit.Reserva.Where(r => r.claseID == clase.id_Clase).ToList();
                        foreach (Reserva reserva in clase.Reserva)
                        {
                            dBGfit.Reserva.Remove(reserva);
                        }
                        dBGfit.Clase.Remove(clase);
                    }
                    dBGfit.Sala.Remove(sala);
                    dBGfit.SaveChanges();
                }
            }
        }

        public static void altaClase()
        {

        }

        public static Clase getClaseByID(int id)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Clase.Include(c => c.Actividad)
                    .Include(c => c.Sala)
                    .Include(c => c.Reserva)
                    .FirstOrDefault(c => c.id_Clase == id);
            }
        }

        public static List<ActividadView> listarActividades()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var actividades = dBGfit.Actividad.Select(s=> new ActividadView
                {
                    id_Actividad = s.id_Actividad,
                    nombre = s.nombre,
                    descripcion= s.descripcion,
                    monitorID=s.monitorID
                }).ToList();                
                return actividades;
            }
        }

        public static List<SalaView> listarSalas()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {               
                var salas = dBGfit.Sala.Select(s => new SalaView
                {
                    id_Sala = s.id_Sala,
                    numPlazas = s.numPlazas,
                    dimensionM2 = s.dimensionM2
                }).ToList();
                return salas;
            } 
              
        }

        public static List<ClaseView> listarClases()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var clases = dBGfit.Clase.Select(c => new ClaseView
                {
                    id_Clase = c.id_Clase,
                    actividadID = c.actividadID,
                    salaID = c.salaID,
                    fechaHora = c.fechaHora
                }).ToList();

                return clases;
            }
        } 



    }
}
