using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenteFitApp.Modelo;
using GenteFitApp.Vistas;

namespace GenteFitApp.Conrolers
{
    public static class EventosCalendar
    {
        // ucdias = rellenaDia(i, mes, año);
        

        public static UserControlDias rellenaDia (DateTime fecha)
        {
            TextoSeleccionable evento;
            DateTime ahora = DateTime.Now;
            
            UserControlDias ucdias = new UserControlDias();
            ConsultasBase.ObtenerClasesPorFecha(fecha);
            ucdias.dias(fecha.Day);
            ucdias.CargaClasesDelDia(fecha);
            //if (fecha.Date == ahora.Date)
            //{
            //    evento = new TextoSeleccionable { Texto = "Speening", BackColor = Color.Green };
            //    var labelEvento = new Label { Text = evento.Texto, BackColor = evento.BackColor };
            //    ucdias.insertaEvento(labelEvento);
            //    ucdias.dias(fecha.Day);
            //}
            //else ucdias.dias(fecha.Day);


            return ucdias;
        }

    }



    public class TextoSeleccionable
    {
        public string Texto { get; set; }
        public Color BackColor { get; set; }
    }
}
