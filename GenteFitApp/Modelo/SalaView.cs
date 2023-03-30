using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GenteFitApp.Modelo
{
    [XmlRoot("SalaLst")]
    public class SalaLst
    {
        [XmlElement("SalaView")]
        public List<SalaView> Salas { get; set; }
    }


    [Serializable]    
    public class SalaView
    {
        public int id_Sala { get; set; }
        public int numPlazas { get; set; }
        public int? dimensionM2 { get; set; }
    }


}
