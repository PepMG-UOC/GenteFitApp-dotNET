using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenteFitApp.Modelo;
using GenteFitApp.Vistas;

namespace GenteFitApp.Conrolers
{
    public class EventosCalendar
    {
        // ucdias = rellenaDia(i, mes, año);
        public static UserControlDias rellenaDia (int esteDia, int esteMes, int esteAño)
        {
            UserControlDias ucdias = new UserControlDias();

            return ucdias;
        }

    }
    public class TextoSeleccionable
    {
        public string Texto { get; set; }
        public Color BackColor { get; set; }
    }
}
