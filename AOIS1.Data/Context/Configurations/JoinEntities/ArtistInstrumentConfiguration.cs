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
    public class ArtistInstrumentConfiguration : IEntityTypeConfiguration<ArtistInstrument>
    {
        public void Configure(EntityTypeBuilder<ArtistInstrument> builder)
        {
            builder.HasKey(ag => new {ag.ArtistId, ag.InstrumentId });

            builder.HasOne(ag => ag.Artist)
                .WithMany(a => a.ArtistInstruments)
                .HasForeignKey(ag => ag.ArtistId);

            builder.HasOne(ag => ag.Instrument)
                .WithMany(a => a.ArtistInstruments)
                .HasForeignKey(ag => ag.InstrumentId);

            builder.Property(a => a.Probability)
                .HasColumnType("decimal(1,2)");
        }
    }
}
