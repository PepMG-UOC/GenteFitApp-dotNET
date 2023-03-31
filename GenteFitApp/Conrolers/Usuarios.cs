using GenteFitApp.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    }
}
