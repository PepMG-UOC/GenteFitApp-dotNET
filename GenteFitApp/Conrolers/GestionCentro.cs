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

        public static Actividad getActividadByNombre(string nombre)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Actividad.Include(a => a.Monitor)
                    .Include(a => a.Clase)
                    .FirstOrDefault(a => a.nombre == nombre);
            }
        }
        public static List<string> getNombresActividades()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                List<string> list = new List<string>();
                var actividadesList = dBGfit.Actividad.ToList();
                foreach(Actividad activ in actividadesList)
                {
                    list.Add(activ.nombre);
                }
                return list;
            }
        }

        public static void bajaActividad(Actividad actividad)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Actividad actividadAEliminar = dBGfit.Actividad.FirstOrDefault(a => a.id_Actividad == actividad.id_Actividad);
                borrarClasesDeActividad(actividadAEliminar);
                dBGfit.Actividad.Remove(actividadAEliminar);
                dBGfit.SaveChanges();
            }               
        }


        // Esta función crea una nueva instancia de la clase Clase y la agrega a la base de datos.
        // Se utiliza el Entity Framework para acceder a la base de datos.
        // La función utiliza los parámetros actvID, salaID y fechaH para crear una nueva instancia de la clase Clase.
        // Posteriormente, la nueva instancia se agrega a la base de datos y se guardan los cambios.
        public static void altaClase(int actvID, int salaID, DateTime fechaH)
        {
            // Crea un objeto de la clase GenteFitDBEntities para acceder a la base de datos
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                // Crea una nueva instancia de la clase Clase con los parámetros recibidos
                Clase nuevaClase = new Clase
                {
                    actividadID = actvID,
                    salaID = salaID,
                    fechaHora = fechaH
                };
                // Agrega la nueva instancia de la clase Clase a la base de datos
                dBGfit.Clase.Add(nuevaClase);

                // Guarda los cambios realizados en la base de datos
                dBGfit.SaveChanges();
            }
        }

        public static void bajaClase(Clase clase)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Clase claseAEliminar = dBGfit.Clase.FirstOrDefault(c => c.id_Clase== clase.id_Clase);
                EventosCalendar.borraReservasDeClase(claseAEliminar);                
                dBGfit.Clase.Remove(claseAEliminar);
                dBGfit.SaveChanges();
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


        // Esta función obtiene una instancia de la clase Sala a partir de su Id.
        // Se utiliza el Entity Framework para acceder a la base de datos.
        // La función utiliza una expresión lambda para filtrar la búsqueda de la sala con el Id especificado.
        // Además, incluye la información de la propiedad Clase de la sala en la búsqueda.
        public static Sala getSalaById(int IdSala)
        {
            // Crea un objeto de la clase GenteFitDBEntities para acceder a la base de datos
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                // Retorna la primera sala que cumpla con el filtro de búsqueda.
                // La propiedad "Include" permite especificar las propiedades relacionadas que se desean incluir en la búsqueda.
                // En este caso, se incluye la propiedad "Clase" de la sala para evitar cargar la propiedad de forma diferida (lazy loading).
                // La expresión lambda especifica que se desea buscar la sala con el Id especificado.
                return dBGfit.Sala.Include(s => s.Clase)
                    .FirstOrDefault(s => s.id_Sala == IdSala);
            }
        }


        public static List<int> getSalasIds()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                List<int> list = new List<int>();
                var salasLst = dBGfit.Sala.ToList();
                foreach (Sala unasala in salasLst)
                {
                    list.Add(unasala.id_Sala);
                }
                return list;
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

        
        // Esta función borra todas las clases de una actividad y sus respectivas reservas en cascada.
        // Primero, busca la actividad en la base de datos y luego, utiliza un bucle foreach para recorrer todas las clases asociadas.
        // Por cada clase, se llama a la función "borraReservasDeClase" para borrar sus reservas de la base de datos.
        // Finalmente, se elimina la clase de la base de datos y se guarda la transacción.
        public static void borrarClasesDeActividad(Actividad actividad)
        {
            using (var dBGfit = new GenteFitDBEntities())
            {
                // Busca la actividad en la base de datos
                Actividad actividadAEliminar = dBGfit.Actividad.FirstOrDefault(a => a.id_Actividad == actividad.id_Actividad);
                // Recorre todas las clases asociadas a la actividad y borra sus reservas
                foreach (var clase in actividadAEliminar.Clase.ToList())
                {
                    EventosCalendar.borraReservasDeClase(clase);
                    // Elimina la clase de la base de datos
                    dBGfit.Clase.Remove(clase);
                }
                // Guarda la transacción
                dBGfit.SaveChanges();
            }
        }


    }
}
