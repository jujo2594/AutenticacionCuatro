using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DireccionConfiguration : IEntityTypeConfiguration<Direccion>
    {
        public void Configure(EntityTypeBuilder<Direccion> builder)
        {
            builder.ToTable("Direccion");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.TipoVia)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(x => x.Numero)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(x => x.Letra)
            .IsRequired()
            .HasMaxLength(1);

            builder.Property(x => x.SufijoCardinal)
            .HasMaxLength(30);

            builder.Property(x => x.NumeroViaSec)
            .HasColumnType("int");

            builder.Property(x => x.LetraSec)
            .HasMaxLength(1);

            builder.Property(x => x.SufijoCardinalSec)
            .HasMaxLength(30);
        }
    }
}