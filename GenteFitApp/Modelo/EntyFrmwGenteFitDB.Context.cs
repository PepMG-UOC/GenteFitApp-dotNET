﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GenteFitDBEntities : DbContext
    {
        public GenteFitDBEntities()
            : base("name=GenteFitDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<Clase> Clase { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Monitor> Monitor { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<Sala> Sala { get; set; }
    }
}
