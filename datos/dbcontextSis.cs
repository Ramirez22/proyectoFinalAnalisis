using datos.MapeoEntidades.Almacen;
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
            modelBuilder.ApplyConfiguration(new detalleingreso());



        }

    }
}
