using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace r12
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=LibraryDb;Integrated Security=True;";

        public DbSet<User> Users { get; set; }
        public DbSet<Tovari> Tovari { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Tovaris)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.UserId);
        }
    }
}
