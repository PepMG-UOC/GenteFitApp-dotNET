using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenteFitApp.Modelo;
using System.Xml.Serialization;
using System.IO;
using System.Data.Entity;
using System.Xml;

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
                XmlSerializer serializer = new XmlSerializer(typeof(List<SalaView>), new XmlRootAttribute("SalaLst"));
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
                XmlSerializer serializer = new XmlSerializer(typeof(List<ActividadView>), new XmlRootAttribute("ActividadLst"));
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, listaActividades);
                }
            }
        }



        public static void updateBDDesdeXmlSala(string filePath)
        {
            SalaLst salasXmlLst = new SalaLst();
            XmlSerializer serializer = new XmlSerializer(typeof(SalaLst));
            using (StreamReader reader = new StreamReader(filePath))
            {
                salasXmlLst = (SalaLst)serializer.Deserialize(reader);
                // hacer algo con la lista de salas...
            }

            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                // Recuperar todas las salas de la BD
                var salasBD = dBGfit.Sala.ToList();
                foreach (var salaXml in salasXmlLst.Salas)
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
                    var salaXml = salasXmlLst.Salas.FirstOrDefault(s => s.id_Sala == salaBD.id_Sala);
                    if (salaXml == null)
                    {
                        dBGfit.Sala.Remove(salaBD);
                    }
                }
                // Guardar los cambios en la BD
                dBGfit.SaveChanges();
            }
        }

        public static void updateBDDesdeXmlActividad(string filePath)
        {
            ActividadLst ActividadXmlLst = new ActividadLst();
            XmlSerializer serializer = new XmlSerializer(typeof(ActividadLst));
            using (StreamReader reader = new StreamReader(filePath))
            {
                ActividadXmlLst = (ActividadLst)serializer.Deserialize(reader);
                // hacer algo con la lista de Actividad...
            }

            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                // Recuperar todas las Actividad de la BD
                var ActividadesBD = dBGfit.Actividad.ToList();
                foreach (var ActividadXml in ActividadXmlLst.Actividades)
                {
                    // Buscar si la Actividad ya existe en la BD
                    var ActividadBD = ActividadesBD.FirstOrDefault(s => s.id_Actividad == ActividadXml.id_Actividad);
                    if (ActividadBD != null)
                    {
                        ActividadBD.nombre = ActividadXml.nombre;
                        ActividadBD.descripcion = ActividadXml.descripcion;
                        ActividadBD.monitorID = ActividadXml.monitorID;                        
                        dBGfit.Entry(ActividadBD).State = EntityState.Modified;
                    }
                    else
                    {
                        // La Actividad no existe en la BD, crear un nuevo objeto Actividad y agregarlo
                        var ActividadNueva = new Actividad
                        {
                            id_Actividad = ActividadXml.id_Actividad,
                            nombre = ActividadXml.nombre,
                            descripcion = ActividadXml.descripcion,
                            monitorID = ActividadXml.monitorID
                        };
                        dBGfit.Actividad.Add(ActividadNueva);
                    }
                }
                // Eliminar las Actividades de la BD que no aparecen en el archivo XML
                foreach (var ActividadBD in ActividadesBD)
                {
                    var ActividadXml = ActividadXmlLst.Actividades.FirstOrDefault(s => s.id_Actividad == ActividadBD.id_Actividad);
                    if (ActividadXml == null)
                    {
                        dBGfit.Actividad.Remove(ActividadBD);
                    }
                }
                // Guardar los cambios en la BD
                dBGfit.SaveChanges();
            }
        }





    }
}
