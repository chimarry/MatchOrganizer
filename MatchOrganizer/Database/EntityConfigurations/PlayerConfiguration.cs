using Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.EntityConfigurations
{
    class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Player> builder)
        {

            builder.Property(x => x.FullName).IsRequired();
            builder.Property(x => x.NotActive).HasDefaultValue(false);

        }
    }
}