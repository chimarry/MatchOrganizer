using Database.Configuration;
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.EntityConfigurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Team> builder)
        {

            builder.Property(x => x.Name).IsRequired();
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.LogoRelativePath).HasDefaultValue(Properties.DefaultLogoPath);
            builder.Property(x => x.NotActive).HasDefaultValue(false);
            builder.HasMany(t => t.HostMatches)
             .WithOne(g => g.HostTeam)
             .HasForeignKey(g => g.HostTeamId);
            builder.HasMany(t => t.GuestMatches)
             .WithOne(g => g.GuestTeam)
             .HasForeignKey(g => g.GuestTeamId);
        }
    }
}
