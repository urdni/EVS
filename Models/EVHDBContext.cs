using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EVH.Models
{
    public class EVHDBContext : DbContext
    {
        public EVHDBContext(DbContextOptions<EVHDBContext> options) : base(options) { }

        public DbSet<HealthRecords> HealthRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HealthRecords>();
        }
    }
}
