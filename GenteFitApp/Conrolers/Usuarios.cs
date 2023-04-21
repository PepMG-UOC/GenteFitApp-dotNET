using GenteFitApp.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.Remoting.Contexts;



namespace GenteFitApp.Conrolers
{
    public class Usuarios
    {
        public static bool formatoEmailCorrecto(string eMailCheck)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(eMailCheck, sFormato))
            {
                if (Regex.Replace(eMailCheck, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else return false;                
            } else return false;
        }

        public static List<AdministradorView> listarAdministradores()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var administradores = dBGfit.Administrador.Select(a => new AdministradorView
                {
                    id_Admin = a.id_Admin,
                    personaID = a.personaID
                }).ToList();

                return administradores;
            }
        }

        public static List<MonitorView> listarMonitores()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var monitores = dBGfit.Monitor.Select(m => new MonitorView
                {
                    id_Monitor = m.id_Monitor,
                    personaID = m.personaID,
                    precioHora = m.precioHora,
                    fechaAlta = m.fechaAlta
                }).ToList();

                return monitores;
            }
        }
        public static List<ClienteView> listarClientes()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var clientes = dBGfit.Cliente.Select(cl => new ClienteView
                {
                    id_Cliente = cl.id_Cliente,
                    personaID = cl.personaID,
                    fechaAlta = cl.fechaAlta
                }).ToList();

                return clientes;
            }
        }

        public static List<PersonaView> listarPersonas()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var Personas = dBGfit.Persona.Select(m => new PersonaView
                {
                    id_Persona= m.id_Persona,
                    email= m.email,
                    nombre= m.nombre,
                    apellido1= m.apellido1,
                    apellido2= m.apellido2,
                    direccion= m.direccion,
                    codigoPostal= m.codigoPostal,
                    provincia= m.provincia,
                    dniNifNie= m.dniNifNie,
                    password= m.password
                }).ToList();
                return Personas;
            }
        }

        //public static Persona getPersonadeMonitor(int idMonitor)
        //{
        //    using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
        //    {

        //        dBGfit.Persona.Where(p => p.id_Persona == idMonitor)
        //    }
        //}
        //public static Monitor getMonitor(int idMonitor)
        //{
        //    using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
        //    {

        //        var monitor = dBGfit.Monitor.Where(m => m.id_Monitor == idMonitor);
        //        return monitor;
        //    }

        //}
        public static Monitor getMonitorById(int id)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Monitor.Include(m => m.Actividad)
                                     .Include(m => m.Persona)
                                     .FirstOrDefault(m => m.id_Monitor == id);
            }
                
        }


        public static Cliente getClienteDePersona(int idPersona)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var cliente = dBGfit.Cliente.FirstOrDefault(c => c.personaID == idPersona);
                return cliente;                                
            }
        }

      
        public static Monitor getMonitorDePersona(int idPersona)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var monitor = dBGfit.Monitor.FirstOrDefault(m => m.personaID == idPersona);                    
                return monitor;                
            }
        }

        public static Administrador getAdminDePersona(int idPersona)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var administrador = dBGfit.Administrador.FirstOrDefault(a => a.personaID == idPersona);
                return administrador;                
            }
        }

        public static bool logging(string eMail, string password)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                if (dBGfit.Persona.Where(p => p.email == eMail && p.password == password).Any())
                {
                    Persona persona = dBGfit.Persona.Single(p => p.email == eMail && p.password == password);
                    Session.idPersona = persona.id_Persona;
                    return true;                   
                }
            }
            return false;            
        }

        public static Persona personaByMail(string eMail)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Persona persona = dBGfit.Persona
                    .Include(p => p.Administrador)
                    .Include(p => p.Cliente)
                    .Include(p => p.Monitor)
                    .FirstOrDefault(p => p.email == eMail);
                return persona;
            }
        }

        public static Persona getPersonaById(int id)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Persona persona = dBGfit.Persona
                    .Include(p => p.Administrador)
                    .Include(p => p.Cliente)
                    .Include(p => p.Monitor)
                    .FirstOrDefault(p => p.id_Persona == id);
                return persona;
            }
        }

        public static bool altaUsuario(bool esCliente, bool esMonitor, bool esAdmin, TextBox tbSueldo, Persona usuario)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                dBGfit.Persona.Add(usuario);
                dBGfit.SaveChanges();
                if (esCliente)
                {
                    Cliente nuevoCliente = new Cliente();
                    nuevoCliente.personaID = usuario.id_Persona;
                    nuevoCliente.fechaAlta = DateTime.Now;
                    dBGfit.Cliente.Add(nuevoCliente);
                    dBGfit.SaveChanges();
                    return true;
                }
                else if (esMonitor)//
                {
                    Monitor nuevoMonitor = new Monitor();
                    nuevoMonitor.personaID = usuario.id_Persona;
                    nuevoMonitor.precioHora = decimal.Parse(tbSueldo.Text);
                    nuevoMonitor.fechaAlta = DateTime.Now;
                    dBGfit.Monitor.Add(nuevoMonitor);
                    dBGfit.SaveChanges();
                    return true; ;
                }
                else if (esAdmin)//
                {
                    Administrador nuevoAdmin = new Administrador();
                    nuevoAdmin.personaID = usuario.id_Persona;
                    dBGfit.Administrador.Add(nuevoAdmin);
                    dBGfit.SaveChanges();
                    return true;
                }
                else return false;
            }
        }

        public static bool modificarUsuario(bool esMonitor, TextBox tbSueldo,Persona usuario)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                dBGfit.Entry(usuario).State = EntityState.Modified;
                dBGfit.SaveChanges();
                if (esMonitor)
                {
                    Monitor nuevoMonitor = new Monitor();
                    nuevoMonitor.personaID = usuario.id_Persona;
                    nuevoMonitor.precioHora = decimal.Parse(tbSueldo.Text);
                    dBGfit.Entry(nuevoMonitor).State = EntityState.Modified;
                    dBGfit.SaveChanges();
                }
                return true;                
            }
        }
        private static void bajaCliente(int idCliente)
        {

            EventosCalendar.eliminaReservasDeCliente(idCliente);
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var cliente = dBGfit.Cliente.Find(idCliente);
                dBGfit.Cliente.Remove(cliente);
                dBGfit.SaveChanges();
            }
        }
        private static void bajaMonitorCascada(int idMonitor)
        {
            using (var dBGfit = new GenteFitDBEntities())
            {
                var monitor = dBGfit.Monitor.Find(idMonitor);
                foreach (var actividad in monitor.Actividad.ToList())
                {
                    // Eliminar todas las Clases que pertenecen a la Actividad
                    foreach (var clase in actividad.Clase.ToList())
                    {
                        // Eliminar todas las Reservas que pertenecen a la Clase
                        foreach (var reserva in clase.Reserva.ToList())
                        {
                            dBGfit.Reserva.Remove(reserva);
                        }
                        dBGfit.Clase.Remove(clase);
                    }
                    dBGfit.Actividad.Remove(actividad);
                }
                dBGfit.Monitor.Remove(monitor);
                dBGfit.SaveChanges();
            }
        }

        public static void bajaUsuario(int idPersona)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var person = dBGfit.Persona.Find(idPersona);
                int ctrl = 0;
                Cliente esCliente = getClienteDePersona(idPersona);
                Monitor esMonitor = getMonitorDePersona(idPersona);
                Administrador esAdmin = getAdminDePersona(idPersona);
                if (esCliente != null)
                {
                    bajaCliente(esCliente.id_Cliente); 
                    ctrl = 1;
                }
                if (esMonitor != null)
                {                   
                        bajaMonitorCascada(esMonitor.id_Monitor);
                        ctrl = 1;
                }
                if (esAdmin != null)
                {
                    int cantAdmin = dBGfit.Administrador.Count();
                    if (cantAdmin <= 1)
                    {
                        MessageBox.Show("no puede borrarse el unico administrador");                       
                    }
                    else
                    {
                        dBGfit.Administrador.Remove(esAdmin);
                        ctrl = 1;
                    }
                }
                if(ctrl == 1)
                {                    
                    dBGfit.Persona.Remove(person);
                    dBGfit.SaveChanges();
                    MessageBox.Show("El usuario se eliminó correctamente");
                } else
                {
                    MessageBox.Show("El usuario no pudo borrarse");
                }
                
            }            
        }




    }
}
