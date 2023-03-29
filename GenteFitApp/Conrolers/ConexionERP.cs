using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenteFitApp.Modelo;
using System.Xml.Serialization;
using System.IO;
using System.Data.Entity;

namespace GenteFitApp.Conrolers
{
    public class ConexionERP
    {
        public static void XMLdeSala(string filePath)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {                
                List<SalaView> listaSalas = GestionCentro.listarSalas();
                // Serializar el objeto en formato XML
                XmlSerializer serializer = new XmlSerializer(typeof(List<SalaView>), new XmlRootAttribute("Salas"));
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, listaSalas);
                }
            }
        }

        public static void  XMLdeActividad(string filePath)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                List<ActividadView> listaActividades = GestionCentro.listarActividades();
                XmlSerializer serializer = new XmlSerializer(typeof(List<ActividadView>), new XmlRootAttribute("Actividad"));
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, listaActividades);
                }
            }
        }



        public static void updateBDDesdeXmlSala(string filePath)
        {
            // Leer el archivo XML y deserializarlo en una lista de objetos SalaView
            List<SalaView> salasXml;
            XmlSerializer serializer = new XmlSerializer(typeof(List<SalaView>));
            using (TextReader reader = new StreamReader(filePath))
            {
                salasXml = (List<SalaView>)serializer.Deserialize(reader);
            }

            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                // Recuperar todas las salas de la BD
                var salasBD = dBGfit.Sala.ToList();
                foreach (var salaXml in salasXml)
                {
                    // Buscar si la sala ya existe en la BD
                    var salaBD = salasBD.FirstOrDefault(s => s.id_Sala == salaXml.id_Sala);
                    if (salaBD != null)
                    {
                        // Actualizar los datos de la sala en la BD
                        salaBD.numPlazas = salaXml.numPlazas;
                        salaBD.dimensionM2 = salaXml.dimensionM2;
                        dBGfit.Entry(salaBD).State = EntityState.Modified;
                    }
                    else
                    {
                        // La sala no existe en la BD, crear un nuevo objeto Sala y agregarlo
                        var salaNueva = new Sala
                        {
                            id_Sala = salaXml.id_Sala,
                            numPlazas = salaXml.numPlazas,
                            dimensionM2 = salaXml.dimensionM2
                        };
                        dBGfit.Sala.Add(salaNueva);
                    }
                }
                // Eliminar las salas de la BD que no aparecen en el archivo XML
                foreach (var salaBD in salasBD)
                {
                    var salaXml = salasXml.FirstOrDefault(s => s.id_Sala == salaBD.id_Sala);
                    if (salaXml == null)
                    {
                        dBGfit.Sala.Remove(salaBD);
                    }
                }
                // Guardar los cambios en la BD
                dBGfit.SaveChanges();
            }
        }




    }
}
