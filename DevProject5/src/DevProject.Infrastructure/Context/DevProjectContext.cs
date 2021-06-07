using DevProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace DevProject.Infrastructure.Context
{
    public class DevProjectContext : DbContext
    {
        public DevProjectContext(DbContextOptions<DevProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
               .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                                                       .SelectMany(e => e.GetProperties()
                                                       .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("nvarchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DevProjectContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
