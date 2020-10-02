using AccessInsideBuildingSystem.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace AccessInsideBuildingSystem.Infrastructure
{
    public class AccessInsideBuidldingContext : DbContext
    {
        public AccessInsideBuidldingContext(DbContextOptions<AccessInsideBuidldingContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }
}
