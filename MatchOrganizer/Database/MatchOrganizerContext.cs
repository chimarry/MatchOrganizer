using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class MatchOrganizerContext:DbContext
    {
        public MatchOrganizerContext(DbContextOptions<MatchOrganizerContext> dbContextOptions):base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<Entity>(new EntityConfiguration());

        }
    }
}
