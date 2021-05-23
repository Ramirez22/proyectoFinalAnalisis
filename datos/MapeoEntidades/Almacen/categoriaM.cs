using entidades.almacen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos.MapeoEntidades.Almacen
{
    public class categoriaM : IEntityTypeConfiguration<categoria>
    {
        public void Configure(EntityTypeBuilder<categoria> builder)
        {
            builder.ToTable("tbl_categoria")
                .HasKey(ca => ca.idcategoria);
            builder.Property(ca => ca.nombre)
                .HasMaxLength(50);
            builder.Property(ca => ca.descripcion)
                .HasMaxLength(250);
        }
    }
}
