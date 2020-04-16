using System;
using HTCCovidBE.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HTCCovidBE
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Kennel> Kennels { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Favourite> Favourites { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Favourite>()
                .HasKey(a => new { a.UserId, a.KennelId });
            modelBuilder.Entity<Favourite>()
                .HasOne(a => a.User)
                .WithMany(a => a.Favourites)
                .HasForeignKey(a => a.UserId);
            modelBuilder.Entity<Favourite>()
                .HasOne(a => a.Kennel)
                .WithMany(a => a.Favourites)
                .HasForeignKey(a => a.KennelId);
            base.OnModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "Admin".ToUpper() }
            );
        }
    }
}
