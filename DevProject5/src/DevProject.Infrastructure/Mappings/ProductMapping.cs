using DevProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevProject.Infrastructure.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("nvarchar(200)");

            builder.Property(p => p.Description)
               .HasColumnType("nvarchar(500)");

            builder.Property(p => p.Quantity)
               .IsRequired()
               .HasColumnType("int");

            builder.Property(p => p.Value)
                .IsRequired()
                .HasColumnType("decimal(15,2)");

            builder.Property(p => p.Active)
                .IsRequired()
                .HasColumnType("bit");

            builder.ToTable("Products");
        }
    }
}
