using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using GenteFitApp.Modelo;

// El namespace indica en que bloque del programa o capa nos encontramos.
// En este caso se trata de la capa Controlers
namespace GenteFitApp.Conrolers
{
    // Esta es la clase contenedora de metodos para consultas a la BBDD
    public class ConsultasBase
    {
        // Esta función lista todas las clases que se llevarán a cabo en una fecha determinada.
        // Se utiliza el Entity Framework para acceder a la base de datos.
        // La función utiliza una expresión lambda para filtrar las clases que tienen una fechaHora igual a la fecha especificada.
        // Además, incluye la información de las propiedades Actividad y Sala de cada clase en la búsqueda.
        // Por último, se ordenan las clases por su fechaHora y se retornan como una lista.
        public static List<Clase> listarClasesPorFecha(DateTime fecha)
        {
            // Crea un objeto de la clase GenteFitDBEntities para acceder a la base de datos.
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                // Realiza una búsqueda de las clases que se llevarán a cabo en la fecha especificada.
                // La propiedad "Where" permite filtrar las clases que cumplen con una determinada condición.
                // En este caso, se utiliza la función "DbFunctions.TruncateTime" para comparar solo la parte de la fecha de la propiedad fechaHora de la clase.
                // La expresión lambda especifica que se desea buscar las clases que tengan una fechaHora igual a la fecha especificada.
                var clases = dBGfit.Clase.Where(c => DbFunctions.TruncateTime(c.fechaHora) == fecha.Date)
                    // La propiedad "Include" permite especificar las propiedades relacionadas que se desean incluir en la búsqueda.
                    // En este caso, se incluyen las propiedades "Actividad" y "Sala" de cada clase para evitar cargarlas de forma diferida (lazy loading).
                    .Include(c => c.Actividad)
                    .Include(c => c.Sala)
                    // La propiedad "OrderBy" permite especificar la propiedad por la cual se desea ordenar las clases.
                    // En este caso, se ordenan las clases por su fechaHora.
                    .OrderBy(c => c.fechaHora)
                    // La función "ToList" convierte el resultado de la búsqueda en una lista de objetos Clase.
                    .ToList();

                // Retorna la lista de clases encontradas.
                return clases;
            }
        }


        public static int numReservasClase(int idClase)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                // Con Count retornamos el numero de Reservas que tiene la Clase
                return dBGfit.Reserva.Count(r => r.claseID == idClase);
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

        public static List<Reserva> listarReservasClase(int IDClase)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {  
                return dBGfit.Reserva.Where(r => r.claseID == IDClase)
                    .OrderBy(r => r.id_Reserva)
                    .ToList();
            }
        }

        public static List<string> clientesConPlaza(int IDClase)
        {
            List<string> result = new List<string>();
            foreach(Reserva reserv in listarReservasClase(IDClase))
            {
                if(reserv.confirmada)
                {
                    var persona = Usuarios.getPersonaDeCliente(reserv.clienteID);
                    result.Add(persona.nombre + "\t" + persona.apellido1);
                }                
            }
            return result;
        }

        public static List<string> clientesEnEspera(int IDClase)
        {
            List<string> result = new List<string>();
            foreach (Reserva reserv in listarReservasClase(IDClase))
            {
                if (!reserv.confirmada)
                {
                    var persona = Usuarios.getPersonaDeCliente(reserv.clienteID);
                    result.Add(persona.nombre + "\t" + persona.apellido1);
                }
            }
            return result;
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
    }
}
