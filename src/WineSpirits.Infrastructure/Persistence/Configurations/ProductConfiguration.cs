using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineSpirits.Domain.Entities;

namespace WineSpirits.Infrastructure.Persistence.Configurations;

internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(product => product.Id);

        builder.Property(product => product.Name)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(product => product.Slug)
            .HasMaxLength(220)
            .IsRequired();

        builder.Property(product => product.Brand)
            .HasMaxLength(160)
            .IsRequired();

        builder.Property(product => product.Description)
            .HasMaxLength(2000);

        builder.Property(product => product.Price)
            .HasPrecision(10, 2);

        builder.Property(product => product.Size)
            .HasMaxLength(80)
            .IsRequired();

        builder.Property(product => product.Abv)
            .HasPrecision(5, 2);

        builder.Property(product => product.ImageUrl)
            .HasMaxLength(1000);

        builder.HasIndex(product => product.Slug)
            .IsUnique();
    }
}
