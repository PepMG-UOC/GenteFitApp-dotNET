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

        public static List<Actividad> listarActividades()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                //return dBGfit.Sala.ToList();
                return dBGfit.Actividad.ToList();
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

        public static List<Sala> listarSalas()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Sala.Select(s => new Sala
                {
                    id_Sala = s.id_Sala,
                    numPlazas = s.numPlazas,
                    dimensionM2 = s.dimensionM2
                }).ToList();
            }
        }

        public static List<Clase> listarClases()
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                return dBGfit.Clase.ToList();
            }
        }




    }
}
