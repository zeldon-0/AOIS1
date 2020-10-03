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
    public class ArtistTempoConfiguration : IEntityTypeConfiguration<ArtistTempo>
    {
        public void Configure(EntityTypeBuilder<ArtistTempo> builder)
        {
            builder.HasKey(ag => new {ag.ArtistId, ag.TempoId });

            builder.HasOne(ag => ag.Artist)
                .WithMany(a => a.ArtistTempos)
                .HasForeignKey(ag => ag.ArtistId);

            builder.HasOne(ag => ag.Tempo)
                .WithMany(a => a.ArtistTempos)
                .HasForeignKey(ag => ag.TempoId);

            builder.Property(a => a.Probability)
                .HasColumnType("decimal(1,2)");
        }
    }
}
