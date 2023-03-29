using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GenteFitApp.Modelo
{
    [Serializable]
    [XmlRoot("Administrador")]
    public class AdministradorView
    {
        public int id_Admin { get; set; }
        public int personaID { get; set; }
    }
}
