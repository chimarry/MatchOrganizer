using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.EntityConfigurations
{
    class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.Property(x => x.StartTime).IsRequired();
            builder.Property(x => x.Place).IsRequired();
            builder.Property(x => x.NotActive).HasDefaultValue(false);
            builder.Property(x => x.HostTeamId).IsRequired();
            builder.Property(x => x.GuestTeamId).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(1).IsRequired();
        }
    }
}
