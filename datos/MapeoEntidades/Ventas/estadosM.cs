using entidades.ventas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos.MapeoEntidades.Ventas
{
    public class estadosM : IEntityTypeConfiguration<estados>
    {
    
        public void Configure(EntityTypeBuilder<estados> builder)
        {
            builder.ToTable("tbl_Estado")
                   .HasKey(status=> status.idestado);
            builder.Property(status => status.descripcion)
                .HasMaxLength(50);
            
    }
}
}