using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.ToTable("Departamento");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
        .HasMaxLength(3);

        builder.Property(x => x.NombreDepartamento)
        .IsRequired()
        .HasMaxLength(30);

        builder.HasOne(x => x.Paises)
        .WithMany(x => x.Departamentos)
        .HasForeignKey(x => x.IdPaisFk);
    }
}
