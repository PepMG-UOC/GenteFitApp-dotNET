using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GenteFitApp.Modelo
{
    [Serializable]
    [XmlRoot("Clase")]
    public class ClaseView
    {
        public int id_Clase { get; set; }
        public int actividadID { get; set; }
        public int salaID { get; set; }
        public DateTime fechaHora { get; set; }
    }
}
