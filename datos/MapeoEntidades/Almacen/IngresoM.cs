using entidades.almacen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos.MapeoEntidades.Almacen
{
    public class IngresoM : IEntityTypeConfiguration<ingreso>
    {
        public void Configure(EntityTypeBuilder<ingreso> builder)
        {
            builder.ToTable("tbl_Ingreso")
                 .HasKey(ing => ing.idingreso);
            builder.Property(ing => ing.tipoComprobante)
                .HasMaxLength(20);
            builder.Property(ing => ing.serieComprobante)
                .HasMaxLength(7);
            builder.Property(ing => ing.numComprobante)
                .HasMaxLength(10);
            builder.Property(ing => ing.fechaHora)
                .IsRequired();
            builder.Property(ing => ing.impuesto)
                .IsRequired();
            builder.Property(ing => ing.total)
               .IsRequired();
        }
}
}