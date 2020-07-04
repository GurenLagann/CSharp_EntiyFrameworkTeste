using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using Dev01.Json;

namespace Dev01
{
    public partial class LftmtesteContext : DbContext
    {
        public DbSet <RD> Leads {get; set;}
        public LftmtesteContext()
        {
        }

        public LftmtesteContext(DbContextOptions<LftmtesteContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=Lftmteste;Username=postgres;Password=docker");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
            modelBuilder.Entity<RD>()
                .HasNoKey();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
