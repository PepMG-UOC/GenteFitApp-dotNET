using GenteFitApp.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GenteFitApp.Conrolers
{
    public class Usuarios
    {
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
                    direccion= m.direccion,
                    codigoPostal= m.codigoPostal,
                    provincia= m.provincia,
                    dniNifNie= m.dniNifNie,
                    password= m.password
                }).ToList();
                return Personas;
            }
        }

        public static int idClienteDePersona(int idPersona)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var cliente = dBGfit.Cliente.FirstOrDefault(c => c.personaID == idPersona);
                if (cliente != null) return cliente.id_Cliente;
                else return 0;                
            }
        }

      
        public static int idMonitorDePersona(int idPersona)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var monitor = dBGfit.Monitor.FirstOrDefault(m => m.personaID == idPersona);
                if (monitor != null) return monitor.id_Monitor;
                else return 0;
            }
        }

        public static int idAdminDePersona(int? idPersona)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var administrador = dBGfit.Administrador.FirstOrDefault(a => a.personaID == idPersona);
                if (administrador != null) return administrador.id_Admin;
                else return 0;
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
                Persona persona = dBGfit.Persona.FirstOrDefault(p => p.email == eMail);
                return persona;
            }

        }

    }
}
