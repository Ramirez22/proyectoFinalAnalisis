using entidades.ventas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos.MapeoEntidades.Ventas
{
    public class DetalleVentaM : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("tbl_DetalleVenta")
             .HasKey(Dventa => Dventa.idDetalleVenta);
            builder.Property(Dventa => Dventa.Cantidad)
                  .IsRequired();
            builder.Property(Dventa => Dventa.PrecioDetalleVenta)
                .IsRequired();
            builder.Property(Dventa => Dventa.descuento)
              .IsRequired();
        }
    }
}
