using entidades.usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos.MapeoEntidades.usuarios
{
   public class personaM: IEntityTypeConfiguration<persona>
    {
        public void Configure(EntityTypeBuilder<persona> builder)
        {
            builder.ToTable("tbl_Persona")
                 .HasKey(person => person.idpersona);
            builder.Property(person => person.nombre)
                .HasMaxLength(100);
            builder.Property(person => person.apellido)
                 .HasMaxLength(100);
            builder.Property(person => person.tipoDocumento)
                .HasMaxLength(20);
            builder.Property(person => person.numDocumento)
                .HasMaxLength(20);
            builder.Property(person => person.aldea)
                .HasMaxLength(50);
            builder.Property(person => person.lote)
                .HasMaxLength(50);
            builder.Property(person => person.manzana)
                .HasMaxLength(50);
            builder.Property(person => person.telefono)
                .HasMaxLength(50);
            builder.Property(person => person.email)
                .HasMaxLength(50);
        }
    }
}