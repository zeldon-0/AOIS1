using AOIS1.Core.Domain.Models.Artists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOIS1.Data.Context.Configurations.Entities
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
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
