using entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos.MapeoEntidades.Almacen
{
    public class articuloM : IEntityTypeConfiguration<articulo>
    {
        public void Configure(EntityTypeBuilder<articulo> builder)
        {
            builder.ToTable("tbl_articulo")
                .HasKey(ar => ar.idarticulo);
            builder.Property(ar => ar.codigo )
                .HasMaxLength(50);
            builder.Property(ar => ar.nombre)
                .HasMaxLength(250);
            builder.Property(ar => ar.PrecioVenta)
               .IsRequired();
            builder.Property(ar => ar.stock)
               .IsRequired();
            builder.Property(ar => ar.descripcion)
               .HasMaxLength(256);


        }
    }
}
