using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenteFitApp.Conrolers
{
    public static class Session
    {
        public static int idPersona { get; set; }
        public static string Usermail { get; set; }
        public static string Password { get; set; }
        private static string tipo;
        public static string Tipo
        {
            get
            {
                if (tipo == null)
                {
                    if (Usuarios.getClienteDePersona(idPersona) != null) tipo = "Cliente";
                    else if (Usuarios.getMonitorDePersona(idPersona) != null) tipo = "Monitor";
                    else if (Usuarios.getAdminDePersona(idPersona) != null) tipo = "Admin";
                }
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

        public static void ResetSession()
        {
            idPersona= 0;
            Usermail= string.Empty;
            Password = string.Empty;
            Tipo = string.Empty;
        }


    }
}
