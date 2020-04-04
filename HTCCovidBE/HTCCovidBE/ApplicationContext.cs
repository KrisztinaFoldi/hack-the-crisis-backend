using System;
using HTCCovidBE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HTCCovidBE
{
    public class ApplicationContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}
