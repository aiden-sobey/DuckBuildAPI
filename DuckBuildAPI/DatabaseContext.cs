using System;
using Microsoft.EntityFrameworkCore;

namespace DuckBuildAPI
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Quack> Quacks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=quacking.db");
    }
}
