using Microsoft.EntityFrameworkCore;
using Roomly.Models;

namespace Roomly.Data
{
    public class AppDbContext : DbContext
    {
        // These properties create the tables in your SQLite database
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // This creates the database file in your project's bin/Debug folder
            options.UseSqlite("Data Source=roomly.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "Receptionist" }
            );

            // A User has one Role, and a Role has many Users
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);
        }
    }
}