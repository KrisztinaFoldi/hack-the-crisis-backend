using System;
using HTCCovidBE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HTCCovidBE
{
    public class ApplicationContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Donation> Donations { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category {CategoryId = 1, Name = "Bolti bevásárlás"},
                new Category {CategoryId = 2, Name = "Gyógyszertári bevásárlás"},
                new Category { CategoryId = 3, Name = "Kutyasétáltatás" },
                new Category { CategoryId = 4, Name = "Kisállat ideiglenes gondozása" },
                new Category { CategoryId = 5, Name = "Egyéb" }
                );
        }
    }
}
