﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Olimpia.Balanceador.Infraestructura.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Olimpia.Balanceador.Dominio.Entity;
    using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

  public partial class InfoClimaEntities : DbContext
    {
        public InfoClimaEntities()
            : base("name=InfoClimaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Climates> Climates { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}