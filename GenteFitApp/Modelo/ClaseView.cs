using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GenteFitApp.Modelo
{
    [XmlRoot("ClaseLst")]
    public class ClaseLst
    {
        [XmlElement("ClaseView")]
        public List<ClaseView> Clases { get; set; }
    }


    [Serializable]
    public class ClaseView
    {
        public int id_Clase { get; set; }
        public int actividadID { get; set; }
        public int salaID { get; set; }
        public DateTime fechaHora { get; set; }
    }
}
