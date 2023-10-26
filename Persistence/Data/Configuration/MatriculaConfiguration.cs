using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.ToTable("Matricula");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.HasOne(x => x.Personas)
            .WithMany(x => x.Matriculas)
            .HasForeignKey(x => x.IdPersonaFk);

            builder.HasOne(x => x.Salones)
            .WithMany(x => x.Matriculas)
            .HasForeignKey(x => x.IdSalonFk);
        }
    }
}