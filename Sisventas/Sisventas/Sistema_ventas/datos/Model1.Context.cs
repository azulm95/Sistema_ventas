﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_ventas.datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class postEntities : DbContext
    {
        public postEntities()
            : base("name=postEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tbl_cliente> tbl_cliente { get; set; }
        public DbSet<tbl_compras> tbl_compras { get; set; }
        public DbSet<tbl_factura> tbl_factura { get; set; }
        public DbSet<tbl_inventario> tbl_inventario { get; set; }
        public DbSet<tbl_producto> tbl_producto { get; set; }
        public DbSet<tbl_proveedor> tbl_proveedor { get; set; }
        public DbSet<tbl_usuarios> tbl_usuarios { get; set; }
        public DbSet<tbl_ventas> tbl_ventas { get; set; }
    }
}