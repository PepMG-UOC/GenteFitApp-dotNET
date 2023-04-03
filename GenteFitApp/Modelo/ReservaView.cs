using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GenteFitApp.Modelo
{
    [XmlRoot("ReservaLst")]
    public class ReservaLst
    {
        [XmlElement("ReservaView")]
        public List<ReservaView> Reservas { get; set; }
    }

    [Serializable]
    public class ReservaView
    {
        public int id_Reserva { get; set; }
        public int? posicion { get; set; }
        public int claseID { get; set; }
        public int clienteID { get; set; }
        public bool confirmada { get; set; }
    }


}

