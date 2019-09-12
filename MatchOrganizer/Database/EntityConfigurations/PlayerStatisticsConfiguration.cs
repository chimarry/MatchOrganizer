using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.EntityConfigurations
{
    public class PlayerStatisticsConfiguration : IEntityTypeConfiguration<PlayerStatistics>
    {
        public void Configure(EntityTypeBuilder<PlayerStatistics> builder)
        {
            builder.Property(x => x.PlayerId).IsRequired();
            builder.Property(x => x.TeamId).IsRequired();
            builder.Property(x => x.NotActive).HasDefaultValue(false);
        }
    }
}
