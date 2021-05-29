using datos.MapeoEntidades;
using datos.MapeoEntidades.Almacen;
using datos.MapeoEntidades.usuarios;
using datos.MapeoEntidades.Ventas;
using entidades;
using entidades.almacen;
using entidades.usuarios;
using entidades.ventas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos
{
    public class dbcontextSis : DbContext
    {
        public DbSet<categoria> categorias { get; set; }
        public DbSet<articulo> articulos { get; set; }

        public DbSet<detalleIngreso> detalleIngreso { get; set; }

        public DbSet<ingreso> ingreso { get; set; }

        public DbSet<condicion> condiciones { get; set; }

        public DbSet<persona> personas { get; set; }

        public DbSet<rol> r0les{ get; set; }

        public DbSet<usuario> usuarios{ get; set; }

        public DbSet<Tipo_Persona> tipopersonas { get; set; }
          public DbSet<DetalleVenta> Detaventa { get; set; }

        public DbSet<estados> estados { get; set; } 

        public DbSet<venta> venta { get; set; }


        public dbcontextSis (DbContextOptions <dbcontextSis>options):base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new categoriaM());
            modelBuilder.ApplyConfiguration(new articuloM());
            modelBuilder.ApplyConfiguration(new IngresoM());
            modelBuilder.ApplyConfiguration(new detalleIngresoM());
            modelBuilder.ApplyConfiguration(new condicionM());
            modelBuilder.ApplyConfiguration(new personaM());
            modelBuilder.ApplyConfiguration(new rolM());
            modelBuilder.ApplyConfiguration(new Tipo_PersonaM());
            modelBuilder.ApplyConfiguration(new usuarioM());
            modelBuilder.ApplyConfiguration(new DetalleVentaM());
            modelBuilder.ApplyConfiguration(new estadosM());
            modelBuilder.ApplyConfiguration(new ventaM());
        }

    }
}
