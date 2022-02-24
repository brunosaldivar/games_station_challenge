using Microsoft.EntityFrameworkCore;
using SuperExampleGame.API.Models;

namespace SuperExampleGame.API.Infrastructure
{
    public class SuperExampleGameContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SuperGameDB.db;");
        }


        public DbSet<Warrior> Warrior { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Warrior>().ToTable("Warriors");
        }

     
    }
}