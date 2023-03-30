using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GenteFitApp.Modelo
{
    [XmlRoot("PersonaLst")]
    public class PersonaLst
    {
        [XmlElement("PersonaView")]
        public List<PersonaView> Personas { get; set; }
    }

    [Serializable]
    public class PersonaView
    {
        public int id_Persona { get; set; }
        public string email { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string direccion { get; set; }
        public int? codigoPostal { get; set; }
        public string provincia { get; set; }
        public string dniNifNie { get; set; }
        public string password { get; set; }
    }
}
