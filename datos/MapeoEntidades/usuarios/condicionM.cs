using entidades.usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos.MapeoEntidades.usuarios
{
    public class condicionM : IEntityTypeConfiguration<condicion>
    {
        public void Configure(EntityTypeBuilder<condicion> builder)
        {
            builder.ToTable("tbl_condicion")
           .HasKey(con => con.idCondicion);
            builder.Property(con => con.descripcion)
                .IsRequired();
        }
    }
}
