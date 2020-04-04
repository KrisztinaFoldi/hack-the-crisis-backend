using System;
using HTCCovidBE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HTCCovidBE
{
    public class ApplicationContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Kennel> Kennels { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}
