﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Database.Migrations
{
    [DbContext(typeof(MatchOrganizerContext))]
    partial class MatchOrganizerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Database.Entities.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GuestScore");

                    b.Property<int>("GuestTeamId");

                    b.Property<int>("HostScore");

                    b.Property<int>("HostTeamId");

                    b.Property<bool>("NotActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Place")
                        .IsRequired();

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(1);

                    b.HasKey("MatchId");

                    b.HasIndex("GuestTeamId");

                    b.HasIndex("HostTeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Database.Entities.MatchTeamPlayer", b =>
                {
                    b.Property<int>("MatchId");

                    b.Property<int>("TeamId");

                    b.Property<int>("PlayerId");

                    b.Property<int>("Score");

                    b.HasKey("MatchId", "TeamId", "PlayerId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("MatchTeamPlayers");
                });

            modelBuilder.Entity("Database.Entities.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<bool>("NotActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("TeamId");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Database.Entities.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc");

                    b.Property<string>("LogoRelativePath")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("/defualt_logo.jpeg");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("NoDraws");

                    b.Property<int>("NoLosses");

                    b.Property<int>("NoWins");

                    b.Property<bool>("NotActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.HasKey("TeamId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Database.Entities.Match", b =>
                {
                    b.HasOne("Database.Entities.Team", "GuestTeam")
                        .WithMany("GuestMatches")
                        .HasForeignKey("GuestTeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Database.Entities.Team", "HostTeam")
                        .WithMany("HostMatches")
                        .HasForeignKey("HostTeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Database.Entities.MatchTeamPlayer", b =>
                {
                    b.HasOne("Database.Entities.Match", "Match")
                        .WithMany("MatchTeamPlayers")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Database.Entities.Player", "Player")
                        .WithMany("MatchTeamPlayers")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Database.Entities.Team", "Team")
                        .WithMany("MatchTeamPlayers")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Database.Entities.Player", b =>
                {
                    b.HasOne("Database.Entities.Team", "CurrentTeam")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
