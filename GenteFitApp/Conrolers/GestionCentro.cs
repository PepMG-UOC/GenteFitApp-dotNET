using GenteFitApp.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenteFitApp.Conrolers
{
    public class GestionCentro
    {
        public void altaActividad(string nombre, string descripcion, int monitorID)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Actividad nuevaActividad = new Actividad
                {
                    nombre = nombre,
                    descripcion = descripcion,
                    monitorID = monitorID
                };

                dBGfit.Actividad.Add(nuevaActividad);
                dBGfit.SaveChanges();
            }
        }

        public void bajaActividad(int IDActividad)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Actividad borrarActividad = dBGfit.Actividad.Find(IDActividad);

                if (borrarActividad != null)
                {
                    dBGfit.Actividad.Remove(borrarActividad);
                    dBGfit.SaveChanges();
                }
            }
        }

       

        // ---

        public static void altaSala(int numPlazas, int dimensionM2)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Sala nuevaSala = new Sala
                {
                    numPlazas = numPlazas,
                    dimensionM2 = dimensionM2
                };
                dBGfit.Sala.Add(nuevaSala);
                dBGfit.SaveChanges();
            }
        }

        public static Sala getSala(int IdSala)
        {
             using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Sala.Find(IdSala);                
            }
        }


        public void bajaSala(int IDSala)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                Sala borrarSala = dBGfit.Sala.Find(IDSala);

                if (borrarSala != null)
                {
                    dBGfit.Sala.Remove(borrarSala);
                    dBGfit.SaveChanges();
                }
            }
        }

        public static List<ActividadView> listarActividades()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var actividades = dBGfit.Actividad.Select(s=> new ActividadView
                {
                    id_Actividad = s.id_Actividad,
                    nombre = s.nombre,
                    descripcion= s.descripcion,
                    monitorID=s.monitorID
                }).ToList();                
                return actividades;
            }
        }

        public static List<SalaView> listarSalas()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {               
                var salas = dBGfit.Sala.Select(s => new SalaView
                {
                    id_Sala = s.id_Sala,
                    numPlazas = s.numPlazas,
                    dimensionM2 = s.dimensionM2
                }).ToList();
                return salas;
            } 
              
        }

        public static List<ClaseView> listarClases()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var clases = dBGfit.Clase.Select(c => new ClaseView
                {
                    id_Clase = c.id_Clase,
                    actividadID = c.actividadID,
                    salaID = c.salaID,
                    fechaHora = c.fechaHora
                }).ToList();

                return clases;
            }
        } 



    }
}
