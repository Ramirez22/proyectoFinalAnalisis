using entidades.ventas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos.MapeoEntidades.Ventas
{
    public class ventaM : IEntityTypeConfiguration<venta>
    {
        public void Configure(EntityTypeBuilder<venta> builder)
        {
            builder.ToTable("tbl_Venta")
                   .HasKey(vent => vent.idVenta);
            builder.Property(vent => vent.tipo_comprobante)
                .HasMaxLength(20);
            builder.Property(vent => vent.serieComprobante)
                .HasMaxLength(7);
            builder.Property(vent => vent.fechaHora)
                .HasMaxLength(10);
            builder.Property(vent=> vent.impuesto)
                .HasMaxLength(10);
            builder.Property(vent => vent.total)
                .HasMaxLength(10);
           

        }
    }
}
