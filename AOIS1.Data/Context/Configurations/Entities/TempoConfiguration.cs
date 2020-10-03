using AOIS1.Core.Domain.Models.Characteristics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOIS1.Data.Context.Configurations.Entities
{
    public class TempoConfiguration : IEntityTypeConfiguration<Tempo>
    {
        public void Configure(EntityTypeBuilder<Tempo> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.ImageURL)
                .HasMaxLength(3000)
                .IsRequired();
        }
    }
}
