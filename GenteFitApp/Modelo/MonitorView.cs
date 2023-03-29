using System;
using System.Xml.Serialization;

namespace GenteFitApp.Modelo
{
    [Serializable]
    [XmlRoot("Monitor")]
    public class MonitorView
    {
        public int id_Monitor { get; set; }
        public int personaID { get; set; }
        public decimal? precioHora { get; set; }
        public DateTime? fechaAlta { get; set; }
    }
}
