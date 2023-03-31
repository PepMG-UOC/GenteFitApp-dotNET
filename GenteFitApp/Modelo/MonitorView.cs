using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GenteFitApp.Modelo
{
    [XmlRoot("MonitorLst")]
    public class MonitorLst
    {
        [XmlElement("MonitorView")]
        public List<MonitorView> Monitores { get; set; }
    }

    [Serializable]    
    public class MonitorView
    {
        public int id_Monitor { get; set; }
        public int personaID { get; set; }
        public decimal? precioHora { get; set; }
        public DateTime? fechaAlta { get; set; }
    }
}
