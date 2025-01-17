﻿// <auto-generated />
using AOIS1.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AOIS1.Data.Migrations
{
    [DbContext(typeof(ExpertSystemContext))]
    [Migration("20201004155333_RemoveRequiredURLForTempo")]
    partial class RemoveRequiredURLForTempo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AOIS1.Core.Domain.Models.Artists.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("AOIS1.Core.Domain.Models.Characteristics.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("AOIS1.Core.Domain.Models.Characteristics.Instrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Instruments");
                });

            modelBuilder.Entity("AOIS1.Core.Domain.Models.Characteristics.Novelty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Novelties");
                });

            modelBuilder.Entity("AOIS1.Core.Domain.Models.Characteristics.Tempo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Tempos");
                });

            modelBuilder.Entity("AOIS1.Core.Domain.Models.JoinEntities.ArtistGenre", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<decimal>("Probability")
                        .HasColumnType("decimal(3,2)");

                    b.HasKey("ArtistId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("ArtistGenre");
                });

            modelBuilder.Entity("AOIS1.Core.Domain.Models.JoinEntities.ArtistInstrument", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("InstrumentId")
                        .HasColumnType("int");

                    b.Property<decimal>("Probability")
                        .HasColumnType("decimal(3,2)");

                    b.HasKey("ArtistId", "InstrumentId");

                    b.HasIndex("InstrumentId");

                    b.ToTable("ArtistInstrument");
                });

            modelBuilder.Entity("AOIS1.Core.Domain.Models.JoinEntities.ArtistNovelty", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("NoveltyId")
                        .HasColumnType("int");

                    b.Property<decimal>("Probability")
                        .HasColumnType("decimal(3,2)");

                    b.HasKey("ArtistId", "NoveltyId");

                    b.HasIndex("NoveltyId");

                    b.ToTable("ArtistNovelty");
                });

            modelBuilder.Entity("AOIS1.Core.Domain.Models.JoinEntities.ArtistTempo", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("TempoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Probability")
                        .HasColumnType("decimal(3,2)");

                    b.HasKey("ArtistId", "TempoId");

                    b.HasIndex("TempoId");

                    b.ToTable("ArtistTempo");
                });

            modelBuilder.Entity("AOIS1.Core.Domain.Models.JoinEntities.ArtistGenre", b =>
                {
                    b.HasOne("AOIS1.Core.Domain.Models.Artists.Artist", "Artist")
                        .WithMany("ArtistGenres")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AOIS1.Core.Domain.Models.Characteristics.Genre", "Genre")
                        .WithMany("ArtistGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AOIS1.Core.Domain.Models.JoinEntities.ArtistInstrument", b =>
                {
                    b.HasOne("AOIS1.Core.Domain.Models.Artists.Artist", "Artist")
                        .WithMany("ArtistInstruments")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AOIS1.Core.Domain.Models.Characteristics.Instrument", "Instrument")
                        .WithMany("ArtistInstruments")
                        .HasForeignKey("InstrumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AOIS1.Core.Domain.Models.JoinEntities.ArtistNovelty", b =>
                {
                    b.HasOne("AOIS1.Core.Domain.Models.Artists.Artist", "Artist")
                        .WithMany("ArtistNovelties")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AOIS1.Core.Domain.Models.Characteristics.Novelty", "Novelty")
                        .WithMany("ArtistNovelties")
                        .HasForeignKey("NoveltyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AOIS1.Core.Domain.Models.JoinEntities.ArtistTempo", b =>
                {
                    b.HasOne("AOIS1.Core.Domain.Models.Artists.Artist", "Artist")
                        .WithMany("ArtistTempos")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AOIS1.Core.Domain.Models.Characteristics.Tempo", "Tempo")
                        .WithMany("ArtistTempos")
                        .HasForeignKey("TempoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
