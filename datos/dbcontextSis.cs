using datos.MapeoEntidades;
using datos.MapeoEntidades.Almacen;
using datos.MapeoEntidades.usuarios;
using datos.MapeoEntidades.Ventas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos
{
   public class dbcontextSis:DbContext
    {
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
            modelBuilder.ApplyConfiguration(new tipo_personaM());
            modelBuilder.ApplyConfiguration(new usuarioM());
            modelBuilder.ApplyConfiguration(new DetalleVentaM());
            modelBuilder.ApplyConfiguration(new estadosM());
            modelBuilder.ApplyConfiguration(new ventaM());
        }

    }
}
