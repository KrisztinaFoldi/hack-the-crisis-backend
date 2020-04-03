using System;
using HTCCovidBE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HTCCovidBE
{
    public class ApplicationContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Donation> Donations { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

    }
}
