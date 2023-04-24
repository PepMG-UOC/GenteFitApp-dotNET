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
            if(origen.Equals("Mis Clases"))
            {
                var usuario = Usuarios.getPersonaById(Session.idPersona);
                var userCliente = Usuarios.getClienteDePersona(usuario.id_Persona);
                ucdias.CargaMisClasesCliente(fecha, userCliente.id_Cliente);

            } else ucdias.CargaClasesDisponibles(fecha);  
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

        // Esta función reserva una clase para un cliente en la base de datos.
        // La función crea una nueva instancia de la clase Reserva y la agrega a la base de datos.
        // Además, verifica si hay plazas disponibles en la clase para confirmar la reserva.
        public static bool reservarClase(int IDclase, int IDcliente)
        {
            try
            {
                using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
                {
                    // Obtiene la información de la clase a partir de su Id utilizando la función getClaseByID de la clase GestionCentro.
                    Clase miClase = GestionCentro.getClaseByID(IDclase);
                    // Crea una nueva instancia de la clase Reserva y establece sus propiedades.
                    Reserva nuevaReserva = new Reserva();
                    int numReservas = ConsultasBase.numReservasClase(IDclase);  // Obtiene el número de reservas para la clase.                  
                    nuevaReserva.claseID = IDclase;
                    nuevaReserva.clienteID = IDcliente;
                    // Verifica si hay plazas disponibles para la clase.
                    if (numReservas + 1 <= miClase.Sala.numPlazas) nuevaReserva.confirmada = true;
                    else nuevaReserva.confirmada = false;
                    // Agrega la nueva reserva a la base de datos y guarda los cambios.
                    dBGfit.Reserva.Add(nuevaReserva);
                    dBGfit.SaveChanges();
                }
                return true; // Si todo ha ido bien, retorna true.
            }
            catch (Exception ex)
            {   // Si se produce una excepción, muestra un mensaje de error y retorna false.
                MessageBox.Show("La operacion no se ha realizado: " + ex.Message);
                return false;
            }
        }

        // Esta función elimina la reserva de un cliente en una clase específica,
        // y confirma la reserva del siguiente cliente en la lista de espera (si existe).
        public static bool desapuntarDeClase(int IDclase, int IDcliente)
        {
            try
            {
                using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
                {   // Obtiene la lista de reservas para la clase especificada
                    var reservasList = ConsultasBase.listarReservasClase(IDclase);
                    var miReserva = getReservaClaseCliente(IDclase, IDcliente);
                    // Busca la siguiente reserva en la lista de espera para confirmarla
                    bool siguienteReservaEncontrada = false;
                    foreach (Reserva reserva in reservasList)
                    {
                        if (siguienteReservaEncontrada && !reserva.confirmada)
                        {
                            reserva.confirmada = true;
                            // Modifica la reserva siguiente encontrada que no estava confirmada.
                            dBGfit.Entry(reserva).State = EntityState.Modified;
                            break;
                        }
                        if (reserva.id_Reserva == miReserva.id_Reserva)
                        {
                            siguienteReservaEncontrada = true;
                        }
                    }                   
                    Reserva eliminaReserva = dBGfit.Reserva.FirstOrDefault(r => r.id_Reserva == miReserva.id_Reserva);
                    dBGfit.Reserva.Remove(eliminaReserva);  // Elimina la reserva del cliente en esa clase.
                    dBGfit.SaveChanges();
                }
                return true; // Si todo ha ido bien, retorna true.
            }
            catch (Exception ex)
            {   // Si se produce una excepción, muestra un mensaje de error y retorna false.
                MessageBox.Show("La operacion no se ha realizado: " + ex.Message);
                return false;
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
            int numReservas = ConsultasBase.numReservasClase(idClase);
            if (miClase.Sala.numPlazas > numReservas)
            {
                return Color.YellowGreen;
            }
            return Color.Yellow;
        }
                
        // Esta función borra todas las reservas de una clase.
        // Primero, busca la clase en la base de datos y luego, utiliza un bucle foreach para recorrer todas las reservas asociadas.
        // Por cada reserva, se elimina de la base de datos y se guarda la transacción.
        public static void borraReservasDeClase(Clase clase)
        {
            using (var dBGfit = new GenteFitDBEntities())
            {
                // Busca la clase en la base de datos
                Clase claseeliminar = dBGfit.Clase.FirstOrDefault(c => c.id_Clase == clase.id_Clase);
                // Recorre todas las reservas asociadas a la clase y las borra
                foreach (var reserva in claseeliminar.Reserva.ToList())
                {
                    dBGfit.Reserva.Remove(reserva);
                }
                // Guarda la transacción
                dBGfit.SaveChanges();
            }
        }

    }

}
