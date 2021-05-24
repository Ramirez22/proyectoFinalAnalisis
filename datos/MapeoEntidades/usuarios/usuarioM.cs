using entidades.usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos.MapeoEntidades.usuarios
{
    public class usuarioM : IEntityTypeConfiguration<usuario>
    {
        public void Configure(EntityTypeBuilder<usuario> builder)
        {
          
                builder.ToTable("tbl_Usuario")
                     .HasKey(user => user.idUsuario);
                builder.Property(user => user.nombre)
                    .HasMaxLength(100);
                builder.Property(user => user.apellido)
                     .HasMaxLength(100);
                builder.Property(user => user.tipoDocumento)
                    .HasMaxLength(20);
                builder.Property(user => user.numDocumento)
                    .HasMaxLength(20);
                builder.Property(user => user.aldea)
                    .HasMaxLength(10);
                builder.Property(user => user.lote)
                    .HasMaxLength(10);
                builder.Property(user => user.manzana)
                    .HasMaxLength(10);
                builder.Property(user => user.telefono)
                    .HasMaxLength(20);
                builder.Property(user => user.email)
                    .HasMaxLength(50);
            builder.Property(user => user.password_hash)
                     .IsRequired();
            builder.Property(user => user.password_sal)
                     .IsRequired();builder.Property(user => user.password_hash)
                     .IsRequired();

        }
        }
}
