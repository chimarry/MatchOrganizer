using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.EntityConfigurations
{
    class MatchTeamPlayerConfiguration : IEntityTypeConfiguration<MatchTeamPlayer>
    {
        public void Configure(EntityTypeBuilder<MatchTeamPlayer> builder)
        {
            builder.HasKey("MatchId", "TeamId", "PlayerId");
            builder.Property(m => m.PlayerId).IsRequired();
            builder.Property(m => m.MatchId).IsRequired();
            builder.Property(m => m.TeamId).IsRequired();

        }
    }
}
