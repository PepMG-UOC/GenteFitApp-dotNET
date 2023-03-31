using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GenteFitApp.Modelo
{
    [XmlRoot("ActividadLst")]
    public class ActividadLst
    {
        [XmlElement("ActividadView")]
        public List<ActividadView> Actividades { get; set; }
    }


    [Serializable]   
    public class ActividadView
    {
        public int id_Actividad { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int monitorID { get; set; }
    }
}
