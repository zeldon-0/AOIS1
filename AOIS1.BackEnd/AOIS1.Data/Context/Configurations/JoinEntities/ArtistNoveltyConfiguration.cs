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
    public class ArtistNoveltyConfiguration : IEntityTypeConfiguration<ArtistNovelty>
    {
        public void Configure(EntityTypeBuilder<ArtistNovelty> builder)
        {
            builder.HasKey(ag => new {ag.ArtistId, ag.NoveltyId });

            builder.HasOne(ag => ag.Artist)
                .WithMany(a => a.ArtistNovelties)
                .HasForeignKey(ag => ag.ArtistId);

            builder.HasOne(ag => ag.Novelty)
                .WithMany(a => a.ArtistNovelties)
                .HasForeignKey(ag => ag.NoveltyId);

            builder.Property(a => a.Probability)
                .HasColumnType("decimal(3,2)");
        }
    }
}
