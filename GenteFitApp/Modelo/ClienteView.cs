using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GenteFitApp.Modelo
{
    [Serializable]
    [XmlRoot("Cliente")]
    public class ClienteView
    {
        public int id_Cliente { get; set; }
        public int personaID { get; set; }
        public DateTime? fechaAlta { get; set; }
    }
}
