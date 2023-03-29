using System;
using System.Xml.Serialization;

namespace GenteFitApp.Modelo
{
    [Serializable]
    [XmlRoot("Sala")]
    public class SalaView
    {
        public int id_Sala { get; set; }
        public int numPlazas { get; set; }
        public int? dimensionM2 { get; set; }
    }
}
