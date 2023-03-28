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
        public static void crearXMLdeSala(string filePath)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                // Seleccionar únicamente las propiedades de Sala que se quieren serializar
                var salas = dBGfit.Sala.Select(s => new
                {
                    s.id_Sala,
                    s.numPlazas,
                    s.dimensionM2
                }).ToList();
                // Serializar el objeto anónimo en formato XML
                XmlSerializer serializer = new XmlSerializer(typeof(List<object>), new XmlRootAttribute("Salas"));
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, salas.Cast<object>().ToList());
                }
            }
        }

        public static void updateBDDesdeXmlSala(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sala>), new XmlRootAttribute("Salas"));
            using (TextReader reader = new StreamReader(filePath))
            {
                List<Sala> salasXml = (List<Sala>)serializer.Deserialize(reader);
                using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
                {
                    foreach (Sala salaXml in salasXml)
                    {
                        Sala salaDb = dBGfit.Sala.Find(salaXml.id_Sala);
                        if (salaDb != null)
                        {
                            // Actualizar registro existente
                            salaDb.numPlazas = salaXml.numPlazas;
                            salaDb.dimensionM2 = salaXml.dimensionM2;
                        }
                        else
                        {
                            // Insertar nuevo registro
                            dBGfit.Sala.Add(salaXml);
                        }
                    }
                    dBGfit.SaveChanges();
                }
            }
        }




    }
}
