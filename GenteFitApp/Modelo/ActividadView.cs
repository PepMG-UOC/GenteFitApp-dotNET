using System;
using System.Xml.Serialization;

namespace GenteFitApp.Modelo
{
    [Serializable]
    [XmlRoot("Actividad")]
    public class ActividadView
    {
        public int id_Actividad { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int monitorID { get; set; }
    }
}
