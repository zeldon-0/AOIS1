using System;
using System.Collections.Generic;
using System.Text;
using AOIS1.Core.Domain.Models.Artists;
using AOIS1.Core.Domain.Models.Characteristics;
using Microsoft.EntityFrameworkCore;
using AOIS1.Data.Context.Configurations.Entities;
using AOIS1.Data.Context.Configurations.JoinEntities;

namespace AOIS1.Data.Context
{
    public class ExpertSystemContext : DbContext
    {
        public DbSet<Artist> Artists { get; private set; }
        public DbSet<Tempo> Tempos { get; private set; }
        public DbSet<Instrument> Instruments { get; private set; }
        public DbSet<Novelty> Novelties { get; private set; }
        public DbSet<Genre> Genres { get; private set; }

        public ExpertSystemContext(DbContextOptions<ExpertSystemContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        public ExpertSystemContext() : base()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ArtistConfiguration());

            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new NoveltyConfiguration());
            modelBuilder.ApplyConfiguration(new TempoConfiguration());
            modelBuilder.ApplyConfiguration(new InstrumentConfiguration());

            modelBuilder.ApplyConfiguration(new ArtistGenreConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistNoveltyConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistTempoConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistInstrumentConfiguration());

        }
    }
}
