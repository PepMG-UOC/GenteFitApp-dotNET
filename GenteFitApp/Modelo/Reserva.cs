//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenteFitApp.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserva
    {
        public int id_Reserva { get; set; }
        public Nullable<int> posicion { get; set; }
        public int claseID { get; set; }
        public int clienteID { get; set; }
        public bool confirmada { get; set; }
    
        public virtual Clase Clase { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
