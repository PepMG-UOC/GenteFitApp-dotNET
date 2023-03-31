using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GenteFitApp.Modelo
{
    [XmlRoot("ClienteLst")]
    public class ClienteLst
    {
        [XmlElement("ClienteView")]
        public List<ClienteView> Clientes { get; set; }
    }

    [Serializable]   
    public class ClienteView
    {
        public int id_Cliente { get; set; }
        public int personaID { get; set; }
        public DateTime? fechaAlta { get; set; }
    }
}
