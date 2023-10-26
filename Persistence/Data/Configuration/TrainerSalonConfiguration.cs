using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TrainerSalonConfiguration : IEntityTypeConfiguration<TrainerSalon>
    {
        public void Configure(EntityTypeBuilder<TrainerSalon> builder)
        {
            builder.ToTable("TrainerSalon");

            builder.HasKey(x => new {x.IdPersonaFk, x.IdSalonFk});

            builder.HasOne(x => x.Personas).WithMany(x => x.TrainerSalones).HasForeignKey(x => x.IdPersonaFk);

            builder.HasOne(x => x.Salones).WithMany(x => x.TrainerSalones).HasForeignKey(x => x.IdSalonFk);
        }
    }
}