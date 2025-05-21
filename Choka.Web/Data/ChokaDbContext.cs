using Microsoft.EntityFrameworkCore;
using Choka.Web.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Choka.Web.Data
{
    public class ChokaDbContext : DbContext
    {
        public ChokaDbContext(DbContextOptions<ChokaDbContext> options)
            : base(options) { }

        public DbSet<JobOffer> JobOffers { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Unique constraint for RowId
            modelBuilder.Entity<JobOffer>()
                .HasIndex(x => x.RowId)
                .IsUnique();

            modelBuilder.Entity<JobApplication>()
                .HasIndex(x => x.RowId)
                .IsUnique();

            // Optional UpdatedAt, UpdatedBy
            modelBuilder.Entity<JobOffer>()
                .Property(x => x.UpdatedAt)
                .IsRequired(false);

            modelBuilder.Entity<JobOffer>()
                .Property(x => x.UpdatedBy)
                .IsRequired(false);

            modelBuilder.Entity<JobApplication>()
                .Property(x => x.UpdatedAt)
                .IsRequired(false);

            modelBuilder.Entity<JobApplication>()
                .Property(x => x.UpdatedBy)
                .IsRequired(false);
        }
    }
}

