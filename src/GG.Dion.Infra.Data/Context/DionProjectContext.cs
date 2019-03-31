using GG.Dion.Domain.Entities;
using GG.Dion.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace GG.Dion.Infra.Data.Context
{
    public class DionProjectContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfig());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DionProject;Trusted_Connection=True;");
        }
    }
}
