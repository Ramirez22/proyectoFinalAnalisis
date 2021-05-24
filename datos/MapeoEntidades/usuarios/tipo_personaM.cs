using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace datos.MapeoEntidades.usuarios
{
    public class tipo_personaM : IEntityTypeConfiguration<tipo_persona>
    {
        public void Configure(EntityTypeBuilder<tipo_persona> builder)
        {
            builder.ToTable("tbl_Tipo_Persona")
                  .HasKey(tper => tper.idPersona);
            builder.Property(tper => tper.descripcion)
                .HasMaxLength(50);
           
        }
    }
}
