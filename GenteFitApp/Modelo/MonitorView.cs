using System;
using System.Collections.Generic;
using System.Globalization;
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
        [XmlIgnore]
        public DateTime? fechaAlta { get; set; }

        [XmlElement("fechaAlta")]
        public string FechaAltaXml
        {
            get => fechaAlta?.ToString("yyyy-MM-ddTHH:mm:ss");
            set => fechaAlta = DateTime.ParseExact(value, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
        }
    }
}
