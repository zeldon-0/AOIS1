using System;
using System.Collections.Generic;
using System.Text;
using AOIS1.Core.Domain.Models.Characteristics;
using AOIS1.Core.Domain.Models.Artists;
using AOIS1.Core.Domain.Models.JoinEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AOIS1.Data.Context.Configurations.JoinEntities
{
    public class ArtistGenreConfiguration : IEntityTypeConfiguration<ArtistGenre>
    {
        public void Configure(EntityTypeBuilder<ArtistGenre> builder)
        {
            builder.HasKey(ag => new {ag.ArtistId, ag.GenreId });

            builder.HasOne(ag => ag.Artist)
                .WithMany(a => a.ArtistGenres)
                .HasForeignKey(ag => ag.ArtistId);

            builder.HasOne(ag => ag.Genre)
                .WithMany(a => a.ArtistGenres)
                .HasForeignKey(ag => ag.GenreId);

            builder.Property(a => a.Probability)
                .HasColumnType("decimal(1,2)");
        }
    }
}
