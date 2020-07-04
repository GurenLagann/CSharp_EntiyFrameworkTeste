using Microsoft.EntityFrameworkCore;

using Dev01.Json;

namespace Dev01 {
    public class EFconnect : DbContext {
        public DbSet <RD> leads {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseNpgsql("Host=localhost;Database=Lftmteste;Username=my_user;Password=docker");
    }
}