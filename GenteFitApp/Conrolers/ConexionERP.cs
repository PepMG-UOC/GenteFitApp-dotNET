using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenteFitApp.Modelo;
using System.Xml.Serialization;
using System.IO;

namespace GenteFitApp.Conrolers
{
    public class ConexionERP
    {
        public void crearXmlSala(int IDSala, string filePath)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                
                Sala miSala = dBGfit.Sala.Find(IDSala);
                SerializarXmlSala(miSala, filePath);
            }
        }

        public static void SerializarXmlSala(Sala sala, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Sala));

            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, sala);
            }
        }
    }
}
