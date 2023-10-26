using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("Persona");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
        .HasMaxLength(20);

        builder.Property(x => x.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(x => x.Apellido)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(x => x.Generos)
        .WithMany(x => x.Personas)
        .HasForeignKey(x => x.IdGeneroFk);

        builder.HasOne(x => x.Ciudades)
        .WithMany(x => x.Personas)
        .HasForeignKey(x => x.IdCiudadFk);

        builder.HasOne(x => x.TipoPersonas)
        .WithMany(x => x.Personas)
        .HasForeignKey(x => x.IdTipoPersonaFk);

        builder.HasOne(x => x.Direcciones).WithOne(x => x.Personas).HasForeignKey<Persona>(x => x.IdDireccionFk);
    }
}
