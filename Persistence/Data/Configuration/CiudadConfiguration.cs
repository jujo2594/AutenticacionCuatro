using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.ToTable("Ciudad");
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasMaxLength(3);

            builder.Property(x => x.NombreCiudad)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(x => x.Departamentos)
            .WithMany(x => x.Ciudades)
            .HasForeignKey(x => x.IdDepartamentoFk);
        }
    }
