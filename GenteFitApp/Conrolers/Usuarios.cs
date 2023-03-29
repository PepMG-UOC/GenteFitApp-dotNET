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
        public static List<Monitor> listarMonitores()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Monitor.Include("Actividad").Include("Persona").ToList();
            }
        }

        public static List<Cliente> listarClientes()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Cliente.ToList();
            }
        }

        public static List<Administrador> listarAdministradores()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Administrador.ToList();
            }
        }



    }
}
