using entidades.usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos.MapeoEntidades.usuarios
{
  public class rolM: IEntityTypeConfiguration<rol>
    {
        public void Configure(EntityTypeBuilder<rol> builder)
        {
            builder.ToTable("tbl_Rol")
                 .HasKey(rol => rol.idrol);
            builder.Property(rol => rol.nombre)
                .HasMaxLength(30);
            builder.Property(rol => rol.descripcion)
              .HasMaxLength(50);
        }

       
  }
}