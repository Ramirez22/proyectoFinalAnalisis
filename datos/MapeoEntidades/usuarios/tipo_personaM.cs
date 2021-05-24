using entidades.usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos.MapeoEntidades.usuarios
{
    public class Tipo_PersonaM : IEntityTypeConfiguration<Tipo_Persona>
    {
        public void Configure(EntityTypeBuilder<Tipo_Persona> builder)
        {
            builder.ToTable("tbl_Tipo_Persona")
                  .HasKey(tper => tper.idpersona);
            builder.Property(tper => tper.descripcion)
                .HasMaxLength(50);
           
    }
}
