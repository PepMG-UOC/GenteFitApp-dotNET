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








    }
}
