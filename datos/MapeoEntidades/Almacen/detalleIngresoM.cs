using entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos.MapeoEntidades
{
    public class detalleIngresoM : IEntityTypeConfiguration<detalleIngreso>
    {
        public void Configure(EntityTypeBuilder<detalleIngreso> builder)
        {
            builder.ToTable("tbl_DetalleIngreso")
                 .HasKey(dtalle => dtalle.iddetalle_ingreso);
            builder.Property(dtalle => dtalle.cantidad)
                .IsRequired();
            builder.Property(dtalle => dtalle.precio_detalle)
                .IsRequired();
            

        }
    }
}
