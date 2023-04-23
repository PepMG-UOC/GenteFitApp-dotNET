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

        public static bool reservarClase(int IDclase, int IDcliente)
        {
            try
            {
                using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
                {
                    Clase miClase = GestionCentro.getClaseByID(IDclase);
                    Reserva nuevaReserva = new Reserva();
                    int numReservas = ConsultasBase.numReservasClase(IDclase);
                    //nuevaReserva.posicion = numReservas + 1;
                    nuevaReserva.claseID = IDclase;
                    nuevaReserva.clienteID = IDcliente;
                    if (numReservas + 1 <= miClase.Sala.numPlazas) nuevaReserva.confirmada = true;
                    else nuevaReserva.confirmada = false;
                    dBGfit.Reserva.Add(nuevaReserva);
                    dBGfit.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La operacion no se ha realizado: " + ex.Message);
                return false;
            }
        }

        public static bool desapuntarDeClase(int IDclase, int IDcliente)
        {
            try
            {
                using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
                {
                    var reservasList = ConsultasBase.listarReservasClase(IDclase);
                    var miReserva = getReservaClaseCliente(IDclase, IDcliente);
                    bool siguienteReservaEncontrada = false;
                    foreach (Reserva reserva in reservasList)
                    {
                        if (siguienteReservaEncontrada && !reserva.confirmada)
                        {
                            reserva.confirmada = true;
                            dBGfit.Entry(reserva).State = EntityState.Modified;
                            break;
                        }
                        if (reserva.id_Reserva == miReserva.id_Reserva)
                        {
                            siguienteReservaEncontrada = true;
                        }
                    }                   
                    Reserva eliminaReserva = dBGfit.Reserva.FirstOrDefault(r => r.id_Reserva == miReserva.id_Reserva);
                    dBGfit.Reserva.Remove(eliminaReserva);
                    dBGfit.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
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
